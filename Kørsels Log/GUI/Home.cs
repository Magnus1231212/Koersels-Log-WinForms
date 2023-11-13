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
                    listBox1.Items.Add(new ListBoxItem() { Text = $"From: {row["WhereFrom"].ToString()} | To: {row["WhereTo"].ToString()}", Value = Convert.ToInt32(row["LogID"].ToString()) });
                }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void create_log_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateLog createlog = new CreateLog();
            createlog.Show();
        }
    }
}
