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
        public static Boolean createEntreprise(Entreprise uneEntreprise)
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

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return false;
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
                open(true);
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

                close();

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

                close();
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
            Boolean idCourantStable ;

            DataTable dtEntreprisesContrats = DaoEntreprise.dtReadAllJoin();

            //Vide la table du Web Service, avant intégration des nouvelles données.
            truncateContrat();
            truncateEntreprise();

            int i = 0;
            while (i < dtEntreprisesContrats.Rows.Count)
            {
                int idActuel = Convert.ToInt16(dtEntreprisesContrats.Rows[i]["idEntreprises"].ToString());

                //Création de l'objet Entreprise, avec Bool_envoyé en True
                Entreprise lEntreprise = new Entreprise(
                    dtEntreprisesContrats.Rows[i]["siret"].ToString(),
                    dtEntreprisesContrats.Rows[i]["nom"].ToString(),
                    dtEntreprisesContrats.Rows[i]["adresse"].ToString(),
                    dtEntreprisesContrats.Rows[i]["cp"].ToString(),
                    dtEntreprisesContrats.Rows[i]["ville"].ToString(),
                    dtEntreprisesContrats.Rows[i]["telephone"].ToString(),
                    dtEntreprisesContrats.Rows[i]["email"].ToString(),
                    dtEntreprisesContrats.Rows[i]["commentaire"].ToString(), 
                    true);
                //Envois au Web Service, l'entreprise avec le Bool_Envoyé en True
                DaoSynchronisation.createEntreprise(lEntreprise);
                //Modifie l'entreprise sur la BDD C#, avec le Bool_Envoyé en True
                DaoEntreprise.update(lEntreprise);
                idCourantStable = true;
                while ((idCourantStable) && (i < dtEntreprisesContrats.Rows.Count ))
                {
                    //Création de l'objet Entrepriselocal (avec l'ID de la BDD C#)
                    Entreprise EntrepriseLocal = DaoEntreprise.readOneBySiret(lEntreprise.Siret);
                    //Création de l'objet EntrepriseWs (avec l'ID de la BDD WebService)
                    Entreprise EntrepriseWs = DaoSynchronisation.readEtrepriseeBySiret(lEntreprise.Siret);
                    //Création du contrat sur le WebService, avec Bool_Envoyé à True
                    DaoSynchronisation.createContrat(new Contrat(
                        Convert.ToInt16(dtEntreprisesContrats.Rows[i]["typecontrat_id"].ToString()), 
                        Convert.ToInt16(dtEntreprisesContrats.Rows[i]["formation_id"].ToString()),
                        dtEntreprisesContrats.Rows[i]["s_nom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["s_prenom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_nom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_prenom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_mail"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_telephone"].ToString(), 
                        Convert.ToDateTime(dtEntreprisesContrats.Rows[i]["date_debut"].ToString()), 
                        Convert.ToDateTime(dtEntreprisesContrats.Rows[i]["date_fin"].ToString()),
                        dtEntreprisesContrats.Rows[i]["commentaire"].ToString(), 
                        true, 
                        Convert.ToInt16(dtEntreprisesContrats.Rows[i]["appreciation"].ToString()), 
                        EntrepriseWs.Id));

                    //Mise à jours du contrat de la BDD C#, pour Booléan à true
                    DaoContrat.update(new Contrat(
                        Convert.ToInt16(dtEntreprisesContrats.Rows[i]["idContrats"].ToString()), 
                        Convert.ToInt16(dtEntreprisesContrats.Rows[i]["typecontrat_id"].ToString()), 
                        Convert.ToInt16(dtEntreprisesContrats.Rows[i]["formation_id"].ToString()),
                        dtEntreprisesContrats.Rows[i]["s_nom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["s_prenom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_nom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_prenom"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_mail"].ToString(),
                        dtEntreprisesContrats.Rows[i]["t_telephone"].ToString(), 
                        Convert.ToDateTime(dtEntreprisesContrats.Rows[i]["date_debut"].ToString()),
                        Convert.ToDateTime(dtEntreprisesContrats.Rows[i]["date_fin"].ToString()),
                        dtEntreprisesContrats.Rows[i]["commentaire"].ToString(), 
                        true, 
                        Convert.ToInt16(dtEntreprisesContrats.Rows[i]["appreciation"].ToString()), 
                        EntrepriseLocal.Id));
                    i++;
                    if (i < dtEntreprisesContrats.Rows.Count)
                    {
                        if (Convert.ToInt16(dtEntreprisesContrats.Rows[i]["idEntreprises"].ToString()) != idActuel)
                        { idCourantStable = false; }
                    }
                    else
                    {
                        idCourantStable = false;
                    }
                 
                }
            }
        }

        public static Boolean truncateEntreprise()
        {
            try
            {
                open(true);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from entreprises";

                MySqlDataReader res = cmd.ExecuteReader();

                close();

                //return res.Read();
                return true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return false;
            }
        }

        public static Boolean truncateContrat()
        {
            try
            {
                open(true);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from contrats";

                MySqlDataReader res = cmd.ExecuteReader();

                close();

                //return res.Read();
                return true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return false;
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

                close();

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