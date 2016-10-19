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
        public static void create(Entreprise uneEntreprise)
        {
            try
            {
                open();
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `table`(`attribut`) VALUES (@valeur)"; // TODO change table, attribut et valeur

                cmd.Prepare();

                //cmd.Parameters.AddWithValue("@valeur", uneEntreprise.attribut); // TODO change attribut et valeur


                cmd.ExecuteNonQuery();

                uneEntreprise.Id = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static Entreprise readOne(int idEntreprise)
        {
            Entreprise lEntreprise = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM `table` WHERE `id`=" + idEntreprise; // TODO change table

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                lEntreprise = new Entreprise((string)res["laDenomination"], Convert.ToInt16(res["unSiret"]), (string)res["laRue"], Convert.ToInt16(res["leCodePostale"]), (string)res["laVille"], (string)res["leMail"], Convert.ToInt16(res["leTelephone"])); //Changé par les noms des attributs de la table

                close();

                return lEntreprise;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return lEntreprise;
            }
        }

        public static List<Entreprise> readAll()
        {
            List<Entreprise> lesEntreprises = new List<Entreprise>();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM `table`"; // TODO changer le nom de la table

                MySqlDataReader res = cmd.ExecuteReader();

                while (res.Read())
                {
                    lesEntreprises.Add(new Entreprise((string)res["laDenomination"], Convert.ToInt16(res["unSiret"]), (string)res["laRue"], Convert.ToInt16(res["leCodePostale"]), (string)res["laVille"], (string)res["leMail"], Convert.ToInt16(res["leTelephone"]))); //Changé par les noms des attributs de la table
                }
                close();

                return lesEntreprises;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return lesEntreprises;
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
       
    }
}