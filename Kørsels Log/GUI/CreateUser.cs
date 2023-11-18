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

    public partial class CreateUser : Form
    {

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.IsAdmin)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_user_Click(object sender, EventArgs e)
        {
            int UserID = Functions.GetNewUserID();
            int AdminID = Functions.GetNewAdminID();
            string pass = Functions.GetEncryptedPassword(password_textBox.Text);
            string query = "INSERT INTO users (UserID, UserName, Password) VALUES (@UserID, @UserName, @Password)";
            if (admin_checkBox.Checked)
            {
                query = "INSERT INTO admins (AdminID, UserName, Password) VALUES (@UserID, @UserName, @Password)";
            }
            if (username_textBox.Text == "" || password_textBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    if (admin_checkBox.Checked)
                    {
                        command.Parameters.AddWithValue("@UserID", AdminID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                    }
                    command.Parameters.AddWithValue("@UserName", username_textBox.Text);
                    command.Parameters.AddWithValue("@Password", pass);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("User Added Successfully");
                        if (Globals.IsAdmin)
                        {
                            this.Hide();
                            Admin admin = new Admin();
                            admin.Show();
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
                            MessageBox.Show("Failed to add User");
                        }
                    }
                }
            }
        }
    }
}
