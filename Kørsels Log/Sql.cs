using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kørsels_Log
{
    internal class Sql
    {
        public static void Load()
        {
            using (SqlConnection con = Globals.GetOpenConnection())
            {
                using (SqlCommand command = new SqlCommand(Script, con))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        if (Globals.Debug)
                        MessageBox.Show("Error: " + e.Message);
                    }
                }
            }
        }

        static private string Script = @"
			IF OBJECT_ID(N'admins', N'U') IS NOT NULL
            TRUNCATE TABLE admins
            IF OBJECT_ID(N'users', N'U') IS NOT NULL
            TRUNCATE TABLE users;
			IF OBJECT_ID(N'logs', N'U') IS NOT NULL
            TRUNCATE TABLE logs;

            IF OBJECT_ID(N'admins', N'U') IS NULL
            CREATE TABLE admins (
                klasse_id int NOT NULL,
                klasse varchar(255) NOT NULL,
                PRIMARY KEY (klasse_id)
            );

			IF OBJECT_ID(N'users', N'U') IS NULL
            CREATE TABLE users (
                klasse_id int NOT NULL,
                klasse varchar(255) NOT NULL,
                PRIMARY KEY (klasse_id)
            );

            IF OBJECT_ID(N'logs', N'U') IS NULL
            CREATE TABLE logs (
                post_nr int NOT NULL,
                by_navn varchar(255) NOT NULL,
                PRIMARY KEY (post_nr)
            );
        ";
    }
}
