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
        private int selectedLogID = 0;
        private int selectedUserID = 0;

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                selectedUserID = Convert.ToInt32(listBox1.SelectedValue.ToString());
            } else
            {
                selectedUserID = 0;
            }
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
                listBox2.ClearSelected();
            }
            else
            {
                data.Clear();
                listBox2.DataSource = data;
                listBox2.ClearSelected();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                selectedLogID = Convert.ToInt32(listBox2.SelectedValue.ToString());
                showLogActions();
            }
            else
            {
                showUserActions();
            }
        }

        private void showUserActions()
        {
            add_log.Show();
            edit_user.Show();
            delete_user.Show();

            delete_log.Hide();
            edit_log.Hide();
        }

        private void showLogActions()
        {
            delete_log.Show();
            edit_log.Show();

            add_log.Hide();
            delete_user.Hide();
            edit_user.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Functions.LogOut();
        }

        private void delete_log_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show($"Are you sure that you want to delete\n{listBox1.GetItemText(listBox1.SelectedItem)}", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = Globals.GetOpenConnection())
                {
                    using (SqlCommand command = new SqlCommand("DELETE FROM logs WHERE LogID = @LogID", con))
                    {
                        command.Parameters.AddWithValue("@LogID", selectedLogID);
                        command.ExecuteNonQuery();
                    }
                }
                listBox1.ClearSelected();
            }
        }

        private void edit_log_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM logs WHERE LogID = @LogID";

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@LogID", selectedLogID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string? from = reader["WhereFrom"].ToString(); // Replace "FromColumn" with the actual column name
                            string? to = reader["WhereTo"].ToString();     // Replace "ToColumn" with the actual column name

                            // Hide the current form
                            this.Hide();

                            // Show the EditLog form and pass the retrieved data
                            EditLog editLogForm = new EditLog(selectedLogID, from, to);
                            editLogForm.Show();
                        }
                    }
                }
            }
        }

        private void add_log_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(listBox1.SelectedValue.ToString());
            this.Hide();
            CreateLog createlog = new CreateLog(UserID);
            createlog.Show();
        }

        private void edit_user_Click(object sender, EventArgs e)
        {

        }

        private void delete_user_Click(object sender, EventArgs e)
        {

        }

        private void create_user_Click(object sender, EventArgs e)
        {

        }
    }
}
