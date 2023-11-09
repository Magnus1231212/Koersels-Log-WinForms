using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using Kørsels_Log.src;

namespace Kørsels_Log
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Globals.CheckIfOpen();
            ApplicationConfiguration.Initialize();
            if (Globals.Debug) { Sql.Load(); MessageBox.Show("Debug mode is enabled"); } else
            {
                if(!Globals.TestCon())
                {
                    DialogResult result = MessageBox.Show("Server is offline or unreachable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(1);
                }
            }
            Application.Run(new Login());
        }
    }
}