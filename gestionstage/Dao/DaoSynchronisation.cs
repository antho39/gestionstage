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
    class DaoSynchronisation : Dao
    {
        public static void createEntreprise(Entreprise uneEntreprise)
        {
            try
            {
                //Ouverture de la connexion sur la BDD Web Service (true)
                open(true);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO entreprises(siret, nom, adresse, cp, ville, telephone, email, commentaire, bool_envoye) VALUES (@siret, @nom, @adresse, @cp, @ville, @telephone, @email, @commentaire, @bool_envoye)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@siret", uneEntreprise.Siret);
                cmd.Parameters.AddWithValue("@nom", uneEntreprise.Nom);
                cmd.Parameters.AddWithValue("@adresse", uneEntreprise.Adresse);
                cmd.Parameters.AddWithValue("@cp", uneEntreprise.Cp);
                cmd.Parameters.AddWithValue("@ville", uneEntreprise.Ville);
                cmd.Parameters.AddWithValue("@telephone", uneEntreprise.Telephone);
                cmd.Parameters.AddWithValue("@email", uneEntreprise.Email);
                cmd.Parameters.AddWithValue("@commentaire", uneEntreprise.Commentaire);
                cmd.Parameters.AddWithValue("@bool_envoye", uneEntreprise.Bool_envoye);

                cmd.ExecuteNonQuery();

                uneEntreprise.Id = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static void createContrat(Contrat unContrat)
        {
            try
            {
                //Ouverture de la connexion sur la BDD Web Service (true)
                open(true);

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

        public static Entreprise readEtrepriseeBySiret(string nSiret)
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

        public static DataTable dtReadAllEntreprises()
        {
            DataTable dtEntrepriseWS = new DataTable();

            try
            {
                open(true);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprises WHERE 1";

                MySqlDataReader res = cmd.ExecuteReader();

                dtEntrepriseWS.Load(res);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return dtEntrepriseWS;
            }

            return dtEntrepriseWS;
        }

        public static DataTable dtReadAllContrats()
        {
            DataTable dtContratWS = new DataTable();

            try
            {
                open(true);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM contrats WHERE 1";

                MySqlDataReader res = cmd.ExecuteReader();

                dtContratWS.Load(res);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return dtContratWS;
            }

            return dtContratWS;
        }

        public static void SynchronisationPush()
        {
            DataTable dtEntreprise = DaoEntreprise.dtReadAllByBoolEnvoye();
            DataTable dtEntrepriseWS = DaoSynchronisation.dtReadAllEntreprises();

            DataTable dtContrat = DaoContrat.dtReadAllByBoolEnvoye();
            DataTable dtContratWS = DaoSynchronisation.dtReadAllEntreprises();

            foreach (DataRow entreprise in dtEntreprise.Rows)
            {
                if (existSiret(entreprise["siret"].ToString()))
                {
                    // Erreur, entreprise déjà présente, TODO message erreur
                }
                else
                {
                    //Création de l'objet Entreprise, avec Bool_envoyé en True
                    Entreprise lEntreprise = new Entreprise(entreprise["siret"].ToString(), entreprise["nom"].ToString(), entreprise["adresse"].ToString(), entreprise["cp"].ToString(), entreprise["ville"].ToString(), entreprise["telephone"].ToString(), entreprise["email"].ToString(), entreprise["commentaire"].ToString(), true);
                    //Envois au Web Service, l'entreprise avec le Bool_Envoyé en True
                    DaoSynchronisation.createEntreprise(lEntreprise);
                    //Modifie l'entreprise sur la BDD C#, avec le Bool_Envoyé en True
                    DaoEntreprise.update(lEntreprise);

                    foreach (DataRow contrat in dtContrat.Rows)
                    {
                        //Envois au Web Service, le Contrat avec le bon Id_Entreprise et le Bool_Envoye à true
                        Entreprise EntrepriseLocal = DaoEntreprise.readOneBySiret(lEntreprise.Siret);
                        DaoSynchronisation.createContrat(new Contrat(Convert.ToInt16(contrat["typecontrat_id"].ToString()), Convert.ToInt16(contrat["formation_id"].ToString()), contrat["s_nom"].ToString(), contrat["s_prenom"].ToString(), contrat["t_nom"].ToString(), contrat["t_prenom"].ToString(), contrat["t_mail"].ToString(), contrat["t_telephone"].ToString(), Convert.ToDateTime(contrat["date_debut"].ToString()), Convert.ToDateTime(contrat["date_fin"].ToString()), contrat["commentaire"].ToString(), true, Convert.ToInt16(contrat["appreciation"].ToString()), EntrepriseLocal.Id));
                        //Modifie le Contrat sur la BDD C#, avec le bon Id_Entreprise et le Bool_Envoye à true
                        Entreprise EntrepriseWs = DaoSynchronisation.readEtrepriseeBySiret(lEntreprise.Siret);
                        DaoContrat.update(new Contrat(Convert.ToInt16(contrat["typecontrat_id"].ToString()), Convert.ToInt16(contrat["formation_id"].ToString()), contrat["s_nom"].ToString(), contrat["s_prenom"].ToString(), contrat["t_nom"].ToString(), contrat["t_prenom"].ToString(), contrat["t_mail"].ToString(), contrat["t_telephone"].ToString(), Convert.ToDateTime(contrat["date_debut"].ToString()), Convert.ToDateTime(contrat["date_fin"].ToString()), contrat["commentaire"].ToString(), true, Convert.ToInt16(contrat["appreciation"].ToString()), EntrepriseWs.Id));
                    }
                }
            }
        }

        public static Boolean existSiret(string unSiret)
        {
            try
            {
                open(true);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprises WHERE siret=" + unSiret;

                MySqlDataReader res = cmd.ExecuteReader();

                return res.Read();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return false;
            }
        }
    }
}