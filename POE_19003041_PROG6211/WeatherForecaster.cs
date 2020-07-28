using System;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    internal static class WeatherForecaster
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileCheckAndRun();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        //Check files needed (Weather and Login Data) are available and runs the program if they are
        private static void FileCheckAndRun()
        {
            Weather.PopulateArrayLists();
            Application.Run(new Login());
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            Weather.AddToDatabase();
        }
    }
}