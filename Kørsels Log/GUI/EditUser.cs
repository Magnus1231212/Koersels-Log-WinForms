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
    public partial class EditUser : Form
    {
        private int UserID;
        private string Password = "";

        public EditUser(int ID)
        {
            InitializeComponent();

            UserID = ID;
        }

        private void EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.IsAdmin)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            label1.Text = "Edit User #" + UserID;
            string query = "SELECT * FROM users WHERE UserID = @UserID";

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                username_textBox.Text = reader["UserName"].ToString();
                                Password = reader["Password"].ToString();
                            }
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
                            MessageBox.Show("Failed to get User");
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_user_Click(object sender, EventArgs e)
        {
            string query = "UPDATE users SET UserName = @UserName, Password = @Password WHERE UserID = @UserID";
            string pass = password_textBox.Text;

            if(pass == "")
            {
                pass = Password;
            } else
            {
                pass = Functions.GetEncryptedPassword(password_textBox.Text);
            }

            if (username_textBox.Text == "")
            {
                MessageBox.Show("Please fill out Username field");
                return;
            }
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", username_textBox.Text);
                    command.Parameters.AddWithValue("@Password", pass);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("User Updated Successfully");
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
                            MessageBox.Show("Failed to Update User");
                        }
                    }
                }
            }
        }
    }
}
