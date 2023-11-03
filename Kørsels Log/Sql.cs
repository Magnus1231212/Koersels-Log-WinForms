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
        static void Load()
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
            -- Oprettelse af databasen
            use master;
            IF OBJECT_ID ('dbo.skole_data_main', 'U') IS NOT NULL
            DROP DATABASE skole_data_main;

            go

            CREATE DATABASE skole_data_main;
            go

            use skole_data_main;

            -- Oprettelse af tabel klasse
            CREATE TABLE klasse (
                klasse_id int NOT NULL,
                klasse varchar(255) NOT NULL,
                PRIMARY KEY (klasse_id)
            );

            -- Oprettelse af tabel post_nr_by
            CREATE TABLE post_nr_by (
                post_nr int NOT NULL,
                by_navn varchar(255) NOT NULL,
                PRIMARY KEY (post_nr)
            );

            -- Oprettelse af tabel elev
            CREATE TABLE elev (
                elev_id int NOT NULL,
                fornavn varchar(255) NOT NULL,
                efternavn varchar(255) NOT NULL,
                adresse varchar(255) NOT NULL,
                post_nr int NOT NULL,
                klasse_id int NOT NULL,
                PRIMARY KEY (elev_id),
                FOREIGN KEY (post_nr) REFERENCES post_nr_by (post_nr),
                FOREIGN KEY (klasse_id) REFERENCES klasse (klasse_id)
            );

            -- Oprettelse af tabel laerer
            CREATE TABLE laerer (
                laerer_id int NOT NULL,
                fornavn varchar(255) NOT NULL,
                efternavn varchar(255) NOT NULL,
                adresse varchar(255) NOT NULL,
                post_nr int NOT NULL,
                klasse_id int NOT NULL,
                PRIMARY KEY (laerer_id),
                FOREIGN KEY (post_nr) REFERENCES post_nr_by (post_nr),
                FOREIGN KEY (klasse_id) REFERENCES klasse (klasse_id)
            );
        ";
    }
}
