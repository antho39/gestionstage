using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using gestionstage.Forms;

namespace gestionstage
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ListEntreprise MainFormListEntreprise = new ListEntreprise();
            MainFormListEntreprise.Show();
            Application.Run();
        }
    }
}