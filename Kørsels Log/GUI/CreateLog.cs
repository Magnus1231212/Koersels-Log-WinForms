using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
