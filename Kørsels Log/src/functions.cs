using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kørsels_Log.src
{
    class Functions
    {
        public static void HideAll()
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
        }

        public static void ForceHide(Form var)
        {
            var.BeginInvoke(new MethodInvoker(delegate
            {
                var.Hide();
            }));
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void LogOut()
        {
            HideAll();
            Login login = new Login();
            login.Show();
            string dataPath = Path.Combine(Application.UserAppDataPath, "data");
            File.Delete(dataPath);
        }
    }
}
