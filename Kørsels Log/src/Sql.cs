using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kørsels_Log.src
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

            INSERT INTO users (UserID, UserName, Password) VALUES (1, 'Nolfi', 'CD8C29B8DEED323FE1538CFBDB46FC2A2EA61CFD67807F0629708EA2A6E13A2919DEF3C837C4E7F2C8E0067568E3236827DEFB05C9346E476B6E954440A908A7') -- 123
            INSERT INTO admins (AdminID, UserName, Password) VALUES (1, 'Nolfi', '0A47151A074E633AB7B6BED6AAB724ABBDDCD3250F80A06BC612A233A907805101F2441B5B2926E54CE8AC8CFBC074BB7A56748830487DF09591DBE167E800F6') -- 123456

            INSERT INTO logs (LogID, UserID, WhereFrom, WhereTo) VALUES (1, 1, 'Amstadam', 'Hamborg')
        ";
    }
}
