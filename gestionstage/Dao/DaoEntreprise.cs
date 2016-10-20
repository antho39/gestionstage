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
    class DaoEntreprise : Dao
    {
        public static Entreprise readOneBySiret(string nSiret)
        {
            Entreprise lEntreprise = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprises WHERE siret=" + nSiret;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                lEntreprise = new Entreprise(Convert.ToInt16(res["id"]), (string)res["siret"], (string)res["nom"], (string)res["adresse"], (string)res["cp"], (string)res["ville"], Convert.ToString(res["telephone"]), Convert.ToString(res["email"]), Convert.ToString(res["commentaire"]), (Boolean)res["bool_envoye"]);
                close();

                return lEntreprise;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return lEntreprise;
            }
        }

        public static DataTable dtReadAll()
        {
            DataTable dtEntreprise = new DataTable();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprises";

                MySqlDataReader res = cmd.ExecuteReader();

                dtEntreprise.Load(res);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return dtEntreprise;
            }

            return dtEntreprise;
        }

        public static void delete(string unSiret)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM entreprises WHERE siret=" + unSiret;

                cmd.ExecuteNonQuery();

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
    }
}