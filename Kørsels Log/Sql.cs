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
                AdminID int NOT NULL primary key,
                UserName varchar(255),
                Password varchar(255)
            );

			IF OBJECT_ID(N'users', N'U') IS NULL
            CREATE TABLE users (
                UserID int NOT NULL primary key,
                UserName varchar(255),
                Password varchar(255)
            );

            IF OBJECT_ID(N'logs', N'U') IS NULL
            CREATE TABLE logs (
                LogID int NOT NULL primary key,
                UserID int NOT NULL,
                WhereFrom varchar(255),
                WhereTo varchar(255)
            );

            INSERT INTO users (UserID, UserName, Password) VALUES (1, 'Nolfi', '123')
            INSERT INTO admins (AdminID, UserName, Password) VALUES (1, 'Nolfi', '123456')
        ";
    }
}
