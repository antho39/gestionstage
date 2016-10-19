using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL
using MySql.Data.MySqlClient;

// Classes du projets
using gestionstage.Classes;
using System.Data;

namespace gestionstage.Dao
{
    class DaoContrat : Dao
    {
        public static void create(Contrat uneContrat)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `table`(`attribut`) VALUES (@valeur)"; // TODO change table, attribut et valeur

                cmd.Prepare();

                //cmd.Parameters.AddWithValue("@valeur", uneContrat.attribut); // TODO change attribut et valeur


                cmd.ExecuteNonQuery();

                uneContrat.Id = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static Contrat readOne(int idContrat)
        {
            Contrat leContrat = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM `table` WHERE `id`=" + idContrat; // TODO change table

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                leContrat = new Contrat((bool)res["leTypeContrat"], (string)res["leNomStagiaire"], (string)res["lePrenomStagiaire"], (string)res["laPromotion"], DaoEntreprise.readOne(Convert.ToInt16(res["idEntreprise"])), (string)res["lePosteOccupe"], (DateTime)res["laDateDebut"], (DateTime)res["laDateFin"], (DateTime)res["laDateModification"], Convert.ToInt16(res["laSatisfaction"])); //Changé par les noms des attributs de la table                                                                                                                                                                                                                                                          

                close();

                return leContrat;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return leContrat;
            }
        }

        public static List<Contrat> readAll()
        {
            List<Contrat> lesContrats = new List<Contrat>();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM `table`"; // TODO changer le nom de la table

                MySqlDataReader res = cmd.ExecuteReader();

                while (res.Read())
                {
                    lesContrats.Add(new Contrat((bool)res["leTypeContrat"], (string)res["leNomStagiaire"], (string)res["lePrenomStagiaire"], (string)res["laPromotion"], DaoEntreprise.readOne(Convert.ToInt16(res["idEntreprise"])), (string)res["lePosteOccupe"], (DateTime)res["laDateDebut"], (DateTime)res["laDateFin"], (DateTime)res["laDateModification"], Convert.ToInt16(res["laSatisfaction"]))); //Changé par les noms des attributs de la table
                }
                close();

                return lesContrats;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return lesContrats;
            }
        }

        public static DataTable dtReadAll()
        {
            DataTable dtContrat = new DataTable();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT contrats.id, bool_apprentissage, s_nom, s_prenom, t_nom, t_prenom, t_mail, t_telephone, date_debut, date_fin, commentaire, bool_envoye, appreciation, entreprise_id, formations.nom AS c_nom FROM contrats INNER JOIN formations ON contrats.formation_id = formations.id";

                MySqlDataReader res = cmd.ExecuteReader();

                dtContrat.Load(res);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return dtContrat;
            }

            return dtContrat;
        }
    }
}