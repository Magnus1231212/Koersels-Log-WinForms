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
        public CreateLog()
        {
            InitializeComponent();
        }

        private void CreateLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.Exit();
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
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@LogID", LogID);
                    command.Parameters.AddWithValue("@UserID", Globals.UserID);
                    command.Parameters.AddWithValue("@WhereFrom", from_textBox.Text);
                    command.Parameters.AddWithValue("@WhereTo", to_textBox.Text);

                    try { 
                        command.ExecuteNonQuery();
                        MessageBox.Show("Log Added Successfully");
                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    } catch (Exception ex)
                    {
                        if(Globals.Debug)
                        {
                            MessageBox.Show("Error: " + ex);
                        } else
                        {
                            MessageBox.Show("Failed to add Log");
                        }
                    }
                }
            }
        }
    }
}
