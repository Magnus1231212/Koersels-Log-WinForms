using System.Diagnostics;

namespace Kørsels_Log
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (Globals.Debug) Sql.Load(); MessageBox.Show("Debug mode is enabled");
            Application.Run(new Login());
        }
    }
}