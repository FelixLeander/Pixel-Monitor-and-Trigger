using ProjectMerlin.Ui;

namespace ProjectMerlin;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static int Main()
    {
        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            return 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hmmm... something unexpected crashed the program, sorry about that :){Environment.NewLine}If you could provide me with the following error that would be much appreciated <3.{Environment.NewLine}{Environment.NewLine}{ex.Message}", "Critical Error");
            return 1;
        }
    }
}