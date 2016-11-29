using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL
using MySql.Data.MySqlClient;

namespace gestionstage.Dao
{
    class Dao
    {
        //Attributs
        protected static MySqlConnection conn = null;
        
        //Méthodes
        protected static void open(Boolean synchro = false)
        {
            string cs = @"server=localhost;userid=root;password=;database=gestionstage";
            if (synchro == true)
            {   cs = @"server=localhost;userid=root;password=;database=arcwebservice";   }

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }
        protected static void close()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}