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
        public static DataTable dtReadById(int unId)
        {
            DataTable dtContrat = new DataTable();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT contrats.id, typecontrats.nom AS typecontrat_nom, formations.nom AS c_nom, s_nom, s_prenom, t_nom, t_prenom, t_mail, t_telephone, date_debut, date_fin, contrats.commentaire, contrats.bool_envoye, appreciation, entreprises.nom, entreprise_id FROM contrats INNER JOIN formations ON contrats.formation_id = formations.id INNER JOIN typecontrats ON contrats.typecontrat_id = typecontrats.id INNER JOIN entreprises ON contrats.entreprise_id = entreprises.id WHERE entreprise_id =" + unId;

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

        public static void create(Contrat unContrat)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO contrats(typecontrat_id, formation_id, s_nom, s_prenom, t_nom, t_prenom, t_mail, t_telephone, date_debut, date_fin, commentaire, bool_envoye, appreciation, entreprise_id) VALUES (@typecontrat_id, @formation_id, @s_nom, @s_prenom, @t_nom, @t_prenom, @t_mail, @t_telephone, @date_debut, @date_fin, @commentaire, @bool_envoye, @appreciation, @entreprise_id)";
                
                cmd.Prepare();
                
                cmd.Parameters.AddWithValue("@typecontrat_id", unContrat.Typecontrat_id);
                cmd.Parameters.AddWithValue("@formation_id", unContrat.Formation_id);
                cmd.Parameters.AddWithValue("@s_nom", unContrat.S_nom);
                cmd.Parameters.AddWithValue("@s_prenom", unContrat.S_prenom);
                cmd.Parameters.AddWithValue("@t_nom", unContrat.T_nom);
                cmd.Parameters.AddWithValue("@t_prenom", unContrat.T_prenom);
                cmd.Parameters.AddWithValue("@t_mail", unContrat.T_mail);
                cmd.Parameters.AddWithValue("@t_telephone", unContrat.T_telephone);
                cmd.Parameters.AddWithValue("@date_debut", unContrat.Date_debut);
                cmd.Parameters.AddWithValue("@date_fin", unContrat.Date_fin);
                cmd.Parameters.AddWithValue("@commentaire", unContrat.Commentaire);
                cmd.Parameters.AddWithValue("@bool_envoye", unContrat.Bool_envoye);
                cmd.Parameters.AddWithValue("@appreciation", unContrat.Appreciation);
                cmd.Parameters.AddWithValue("@entreprise_id", unContrat.Entreprise_id);

                cmd.ExecuteNonQuery();

                unContrat.Id = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static Contrat readOne(string id)
        {
            Contrat leContrat = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprises WHERE id=" + id;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                leContrat = new Contrat(Convert.ToInt16(res["id"]), Convert.ToInt16(res["typecontrat_id"]), Convert.ToInt16(res["formation_id"]), (string)res["s_nom"], (string)res["s_prenom"], (string)res["t_nom"], (string)res["t_prenom"], (string)res["t_mail"], (string)res["t_telephone"], (DateTime)res["date_debut"], (DateTime)res["date_fin"], (string)res["commentaire"], Convert.ToInt16(res["appreciation"]), Convert.ToInt16(res["entreprise_id"]));
                close();

                return leContrat;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return leContrat;
            }
        }
    }
}