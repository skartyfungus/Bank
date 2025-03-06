using Npgsql;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static async Task MonitorForms()
        {
            while (true)
            {
                await Task.Delay(5000); // Check every 5 seconds

                // Ensure we only count forms that are visible
                if (Application.OpenForms.Cast<Form>().All(f => !f.Visible))
                {
                    Debug.WriteLine("No visible forms open. Exiting application...");
                    Application.Exit();
                    return;
                }
            }
        }


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            loginForm login = new loginForm();
            login.Show(); // Show the login form first

            Task.Run(() => MonitorForms()); // Start the form monitoring task

            Application.Run(); // Keeps the application running
        }
    }
}
