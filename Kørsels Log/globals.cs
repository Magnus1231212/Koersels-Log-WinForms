using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Kørsels_Log
{
    class Globals
    {
        public static bool Debug = false;
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static int IsAdmin { get; set; }



        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString;
            }
        }

        public static SqlConnection GetOpenConnection()
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            return sqlConn;
        }
    }
}
