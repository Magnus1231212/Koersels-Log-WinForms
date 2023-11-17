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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome Back {Globals.UserName}!";
            List<ListBoxItem> data = new List<ListBoxItem>();
            listBox1.DisplayMember = "Text";
            listBox1.ValueMember = "Value";

            string LogsQuery = "SELECT * FROM users";

            DataTable Userdata = new DataTable();

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(LogsQuery, con))
                {
                    SqlDataAdapter userAdapter = new SqlDataAdapter(command);
                    userAdapter.Fill(Userdata);
                }
            }

            if (Userdata.Rows.Count > 0)
            {
                foreach (DataRow row in Userdata.Rows)
                {
                    data.Add(new ListBoxItem() { Text = $"ID: {row["UserID"].ToString()} | UserName: {row["UserName"].ToString()}", Value = Convert.ToInt32(row["UserID"].ToString()) });
                }
                listBox1.DataSource = data;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Hide();
            List<ListBoxItem> data = new List<ListBoxItem>();
            listBox2.DisplayMember = "Text";
            listBox2.ValueMember = "Value";

            string LogsQuery = "SELECT * FROM logs WHERE UserID = @UserID";

            DataTable Logdata = new DataTable();

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(LogsQuery, con))
                {
                    command.Parameters.AddWithValue("@UserID", listBox1.SelectedValue.ToString());

                    SqlDataAdapter userAdapter = new SqlDataAdapter(command);
                    userAdapter.Fill(Logdata);
                }
            }

            if (Logdata.Rows.Count > 0)
            {
                foreach (DataRow row in Logdata.Rows)
                {
                    data.Add(new ListBoxItem() { Text = $"From: {row["WhereFrom"].ToString()} | To: {row["WhereTo"].ToString()}", Value = Convert.ToInt32(row["LogID"].ToString()) });
                }
                listBox2.DataSource = data;
            } else
            {
                data.Clear();
                listBox2.DataSource = data;
            }
        }

        private void showUserActions()
        {

        }

        private void showLogActions()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Functions.LogOut();
        }
    }
}
