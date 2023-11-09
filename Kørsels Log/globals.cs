using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Kørsels_Log
{
    class Globals
    {
        public static bool Debug = false;
        public static int UserID { get; set; }
        public static string? UserName { get; set; }
        public static bool IsLoggedIn { get; set; }
        public static bool IsAdmin { get; set; }

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString;
            }
        }

        public static SqlConnection GetOpenConnection()
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                if (Debug)
                    MessageBox.Show("Error: " + e.Message);
            }
            return sqlConn;
        }

        public static bool TestCon()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Globals.ConnectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public static void CheckIfOpen()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly()?.Location)).Length > 1) 
                System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
