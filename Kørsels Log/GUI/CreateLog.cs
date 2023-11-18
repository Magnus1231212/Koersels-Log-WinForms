using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kørsels_Log.src;

namespace Kørsels_Log
{

    public partial class CreateLog : Form
    {
        private int LogUserID;

        public CreateLog(int logUserID)
        {
            InitializeComponent();
            LogUserID = logUserID;
        }

        private void CreateLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.IsAdmin)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
        }

        private void CreateLog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_log_Click(object sender, EventArgs e)
        {
            int LogID = Functions.GetNewLogID();
            string query = "INSERT INTO logs (LogID, UserID, WhereFrom, WhereTo) VALUES (@LogID ,@UserID, @WhereFrom, @WhereTo)";
            if (from_textBox.Text == "" || to_textBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@LogID", LogID);
                    command.Parameters.AddWithValue("@UserID", LogUserID);
                    command.Parameters.AddWithValue("@WhereFrom", from_textBox.Text);
                    command.Parameters.AddWithValue("@WhereTo", to_textBox.Text);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Log Added Successfully");
                        if (Globals.IsAdmin)
                        {
                            this.Hide();
                            Admin admin = new Admin();
                            admin.Show();
                        }
                        else
                        {
                            this.Hide();
                            Home home = new Home();
                            home.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (Globals.Debug)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Log");
                        }
                    }
                }
            }
        }
    }
}
