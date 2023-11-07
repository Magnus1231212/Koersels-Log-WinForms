using System.Data;
using System.Data.SqlClient;
using System.IO;

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
            string dataPath = Path.Combine(Application.UserAppDataPath, "data.txt");

            if(File.Exists(dataPath)) {
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
                    Hide();
                    Home home = new Home();
                    home.Show();
                }
                else if (SadminTabel.Rows.Count > 0)
                {
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

            string path = Application.UserAppDataPath;

            if (RememberMe.Checked)
            {
                string data = Path.Combine(path, "data.txt");
                var file = File.Create(data);
                file.Close();
                string[] saveData = new string[] { Username_textBox.Text + " " + Password_textBox.Text };
                File.AppendAllLines(data, saveData);
            }

            DataTable userTabel = new DataTable();
            DataTable adminTabel = new DataTable();

            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(UserQuery, con))
                {
                    command.Parameters.AddWithValue("@UserName", Username_textBox.Text);
                    command.Parameters.AddWithValue("@Password", Password_textBox.Text);

                    SqlDataAdapter userAdapter = new SqlDataAdapter(command);
                    userAdapter.Fill(userTabel);

                }

                using (SqlCommand command = new SqlCommand(AdminQuery, con))
                {
                    command.Parameters.AddWithValue("@UserName", Username_textBox.Text);
                    command.Parameters.AddWithValue("@Password", Password_textBox.Text);

                    SqlDataAdapter adminAdapter = new SqlDataAdapter(command);
                    adminAdapter.Fill(adminTabel);
                }
            }

            MessageBox.Show(userTabel.Rows.Count.ToString());

            if (userTabel.Rows.Count > 0)
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else if (adminTabel.Rows.Count > 0)
            {
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
    }
}