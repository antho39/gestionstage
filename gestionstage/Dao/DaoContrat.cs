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
                cmd.CommandText = "SELECT contrats.id, bool_apprentissage, s_nom, s_prenom, t_nom, t_prenom, t_mail, t_telephone, date_debut, date_fin, commentaire, bool_envoye, appreciation, entreprise_id, formations.nom AS c_nom FROM contrats INNER JOIN formations ON contrats.formation_id = formations.id WHERE entreprise_id =" + unId;

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