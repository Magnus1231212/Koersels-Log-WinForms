using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kørsels_Log.src
{
    class Functions
    {
        public static void HideAll()
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
        }

        public static void ForceHide(Form var)
        {
            var.BeginInvoke(new MethodInvoker(delegate
            {
                var.Hide();
            }));
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void LogOut()
        {
            HideAll();
            Login login = new Login();
            login.Show();
            string dataPath = Path.Combine(Application.UserAppDataPath, "data");
            File.Delete(dataPath);
        }

        public static int GetNewLogID() 
        {
            string query = "SELECT TOP 1 LogID FROM logs ORDER BY LogID DESC";
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result) + 1;
                }
            }
        }

        public static int GetNewAdminID()
        {
            string query = "SELECT TOP 1 AdminID FROM admins ORDER BY AdminID DESC";
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result) + 1;
                }
            }
        }

        public static int GetNewUserID()
        {
            string query = "SELECT TOP 1 UserID FROM users ORDER BY UserID DESC";
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result) + 1;
                }
            }
        }

        public static string GetEncryptedPassword(string password)
        {
            string query = "SELECT HASHBYTES('SHA2_512', @password)";
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@password", password);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        byte[] hashBytes = (byte[])result;
                        Debug.WriteLine(BitConverter.ToString(hashBytes).Replace("-", ""));
                        return BitConverter.ToString(hashBytes).Replace("-", "");
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }
    }

    public class ListBoxItem
    {
        public int? Value { get; set; }
        public string? Text { get; set; }
    }
}
