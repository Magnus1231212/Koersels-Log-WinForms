using System.Data;
using System.Data.SqlClient;
using System.IO;
using Kørsels_Log.src;

namespace Kørsels_Log
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string dataPath = Path.Combine(Application.UserAppDataPath, "data");

            if (File.Exists(dataPath))
            {
                string UserQuery = "SELECT * FROM users WHERE UserName = @UserName AND Password = @Password";
                string AdminQuery = "SELECT * FROM admins WHERE UserName = @UserName AND Password = @Password";

                string data = File.ReadAllText(dataPath);
                string[] Sdata = data.Split(' ');

                string SUserName = Sdata[0].ToString();
                string SPassword = Sdata[1].ToString().Trim();

                DataTable SuserTabel = new DataTable();
                DataTable SadminTabel = new DataTable();

                using (SqlConnection con = Globals.GetOpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(UserQuery, con))
                    {
                        command.Parameters.AddWithValue("@UserName", SUserName.ToString());
                        command.Parameters.AddWithValue("@Password", SPassword.ToString());

                        SqlDataAdapter userAdapter = new SqlDataAdapter(command);
                        userAdapter.Fill(SuserTabel);
                    }

                    using (SqlCommand command = new SqlCommand(AdminQuery, con))
                    {
                        command.Parameters.AddWithValue("@UserName", SUserName);
                        command.Parameters.AddWithValue("@Password", SPassword);

                        SqlDataAdapter adminAdapter = new SqlDataAdapter(command);
                        adminAdapter.Fill(SadminTabel);
                    }
                }

                if (SuserTabel.Rows.Count > 0)
                {
                    Globals.UserID = Convert.ToInt32(SuserTabel.Rows[0]["UserID"]);
                    Globals.UserName = SuserTabel.Rows[0]["UserName"].ToString();
                    Globals.IsLoggedIn = true;

                    Hide();
                    Home home = new Home();
                    home.Show();
                }
                else if (SadminTabel.Rows.Count > 0)
                {
                    Globals.UserID = Convert.ToInt32(SadminTabel.Rows[0]["AdminID"]);
                    Globals.UserName = SadminTabel.Rows[0]["UserName"].ToString();
                    Globals.IsLoggedIn = true;
                    Globals.IsAdmin = true;

                    Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string UserQuery = "SELECT * FROM users WHERE UserName = @UserName AND Password = @Password";
            string AdminQuery = "SELECT * FROM admins WHERE UserName = @UserName AND Password = @Password";

            string pass = Functions.GetEncryptedPassword(Password_textBox.Text);

            string path = Application.UserAppDataPath;

            if (RememberMe.Checked)
            {
                string data = Path.Combine(path, "data");
                var file = File.Create(data);
                file.Close();
                string[] saveData = new string[] { Username_textBox.Text + " " + pass };
                File.AppendAllLines(data, saveData);
            }

            DataTable userTabel = new DataTable();
            DataTable adminTabel = new DataTable();

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(UserQuery, con))
                {
                    command.Parameters.AddWithValue("@UserName", Username_textBox.Text);
                    command.Parameters.AddWithValue("@Password", pass);

                    SqlDataAdapter userAdapter = new SqlDataAdapter(command);
                    userAdapter.Fill(userTabel);

                }

                using (SqlCommand command = new SqlCommand(AdminQuery, con))
                {
                    command.Parameters.AddWithValue("@UserName", Username_textBox.Text);
                    command.Parameters.AddWithValue("@Password", pass);

                    SqlDataAdapter adminAdapter = new SqlDataAdapter(command);
                    adminAdapter.Fill(adminTabel);
                }
            }

            if (userTabel.Rows.Count > 0)
            {
                Globals.UserID = Convert.ToInt32(userTabel.Rows[0]["UserID"]);
                Globals.UserName = userTabel.Rows[0]["UserName"].ToString();
                Globals.IsLoggedIn = true;

                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else if (adminTabel.Rows.Count > 0)
            {
                Globals.UserID = Convert.ToInt32(adminTabel.Rows[0]["AdminID"]);
                Globals.UserName = adminTabel.Rows[0]["UserName"].ToString();
                Globals.IsLoggedIn = true;
                Globals.IsAdmin = true;

                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Ugyldigt Login", "Fejl");
                Username_textBox.Clear();
                Password_textBox.Clear();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.Exit();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}