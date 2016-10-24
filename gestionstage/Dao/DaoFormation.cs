using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL
using MySql.Data.MySqlClient;
using System.Data;

// Classes du projets
using gestionstage.Classes;

namespace gestionstage.Dao
{
    class DaoFormation : Dao
    {
        public static List<Formation> readAll()
        {
            List<Formation> lesFormation = new List<Formation>();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM formations WHERE 1";

                MySqlDataReader res = cmd.ExecuteReader();

                while (res.Read())
                {
                    lesFormation.Add(new Formation(Convert.ToInt16(res["id"]), (string)res["nom"], (string)res["nomComplet"]));
                }

                close();

                return lesFormation;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return lesFormation;
            }
        }
    }
}
