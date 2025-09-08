using PixelToyControl.Business;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System.IO.Pipes;

namespace PixelToyControl;

internal static class Program
{
    /// <summary>
    /// Unique value for named pipe.
    /// </summary>
    private const string NotifierPipeName = $"{nameof(PixelToyControl)}-NotifyExistingInstance";

    /// <summary>
    /// Mutex to ensure application keeps single instance.
    /// </summary>
    private static readonly Mutex SinlgeInstanceApplication = new(true, $"{nameof(PixelToyControl)}-01992267-b115-787b-b29e-cbce5483956e");

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static int Main()
    {
        TrayApp? trayApp = null;
        try
        {
            Log.Logger = CreateLogger();

            Log.Information("Program started. Logger initialized. Aquiring mutex...");
            if (!SinlgeInstanceApplication.WaitOne(100)) // If an isntance of the program already runs, then notify it and exit.
                return NotifyNamedPipe();

            Log.Information("Sucessfully aquired mutex. Initalizing background-worker on system tray.");
            
            ApplicationConfiguration.Initialize();
            trayApp ??= new();
            _ = trayApp.StartAsync();

            Application.Run(trayApp);

            Log.Information("Program ran to completion. Ending application.");
            return 0;
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Unexpected error. Promting user with error, ending application after ok.");
            
            var displayErrorText =
                $"""
                Sorry, an unexpected error occured.
                If this keeps happening, please contact me.
                {Environment.NewLine}
                {ex.Message}
                """;

            MessageBox.Show(displayErrorText, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 1;
        }
        finally
        {
            if (trayApp != null)
                trayApp.NotifyIcon.Visible = false;

            Log.CloseAndFlush();
        }
    }

    /// <summary>
    /// Creates a hardcoded predefined logger.
    /// </summary>
    /// <returns>The serilog logger.</returns>
    private static Logger CreateLogger() => new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("logs/log.log", LogEventLevel.Information, rollingInterval: RollingInterval.Day)
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Verbose)
                .CreateLogger();

    /// <summary>
    /// Notifes the pipe, that the instance already exists.
    /// </summary>
    /// <returns>The exit code which shall be used.</returns>
    private static int NotifyNamedPipe()
    {
        try
        {
            Log.Verbose("Mutex reserved. Notifying existing instance.");
            using var client = new NamedPipeClientStream(".", NotifierPipeName, PipeDirection.Out);
            client.Connect(100);
            using var writer = new StreamWriter(client);
            writer.WriteLine("ACTIVATE");
            writer.Flush();

            Log.Information("Sucessfully notified existing instance IPC.");
            return 0;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Failed to notify exisitng instance via named pipe IPC. Exiting application.");
            return 2;
        }
    }
}