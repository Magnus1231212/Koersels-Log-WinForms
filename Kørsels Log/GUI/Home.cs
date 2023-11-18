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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kørsels_Log
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Functions.LogOut();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome Back {Globals.UserName}!";
            List<ListBoxItem> data = new List<ListBoxItem>();
            listBox1.DisplayMember = "Text";
            listBox1.ValueMember = "Value";

            string LogsQuery = "SELECT * FROM logs WHERE UserID = @UserID";

            DataTable Logdata = new DataTable();

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(LogsQuery, con))
                {
                    command.Parameters.AddWithValue("@UserID", Globals.UserID);

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
                listBox1.DataSource = data;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void create_log_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateLog createlog = new CreateLog(Globals.UserID);
            createlog.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int LogID = Convert.ToInt32(listBox1.SelectedValue);
            string query = "SELECT * FROM logs WHERE LogID = @LogID";

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@LogID", LogID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string? from = reader["WhereFrom"].ToString(); // Replace "FromColumn" with the actual column name
                            string? to = reader["WhereTo"].ToString();     // Replace "ToColumn" with the actual column name

                            // Hide the current form
                            this.Hide();

                            // Show the EditLog form and pass the retrieved data
                            EditLog editLogForm = new EditLog(LogID, from, to);
                            editLogForm.Show();
                        }
                    }
                }
            }
        }
    }
}
