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
    public partial class EditLog : Form
    {
        private int LogID;
        private string? From;
        private string? To;

        public EditLog(int ID, string? from, string? to)
        {
            InitializeComponent();

            LogID = ID;
            From = from;
            To = to;
        }

        private void EditLog_FormClosing(object sender, FormClosingEventArgs e)
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

        private void EditLog_Load(object sender, EventArgs e)
        {
            label1.Text = "Edit Log #" + LogID;
            from_textBox.Text = From;
            to_textBox.Text = To;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_log_Click(object sender, EventArgs e)
        {
            string query = "UPDATE logs SET WhereFrom = @WhereFrom, WhereTo = @WhereTo WHERE LogID = @LogID";

            if (from_textBox.Text == "" || to_textBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            if (from_textBox.Text == From && to_textBox.Text == To)
            {
                MessageBox.Show("You have not changed anything");
                return;
            }
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@LogID", LogID);
                    command.Parameters.AddWithValue("@WhereFrom", from_textBox.Text);
                    command.Parameters.AddWithValue("@WhereTo", to_textBox.Text);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Log Updated Successfully");
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
                            MessageBox.Show("Failed to Update Log");
                        }
                    }
                }
            }
        }
    }
}
