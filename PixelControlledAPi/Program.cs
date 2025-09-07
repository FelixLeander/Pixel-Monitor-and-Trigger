using PixelControlledApi.Business;
using Microsoft.VisualBasic.ApplicationServices;

namespace PixelControlledApi;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        /* //Single application & system tray missing
        try
        {
            if (!SingleApplication.IsUnique())
            {
                //ToDo: Focus instance window or create it's window. 
                return;
            }
        }
        catch
        {
            var reponse = MessageBox.Show($"Could not find out if the program is already running.{Environment.NewLine}Do you want to start a new instance?", "Minor Error", MessageBoxButtons.YesNo);
            if (reponse != DialogResult.Yes)
                return;
        }
        */

        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hmmm... something unexpected crashed the program, sorry about that :){Environment.NewLine}If you could provide me with the following error that would be much appreciated <3.{Environment.NewLine}{Environment.NewLine}{ex.Message}", "Critical Error");
        }
    }
}