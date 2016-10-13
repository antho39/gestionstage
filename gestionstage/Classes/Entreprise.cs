using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionstage.Classes
{
    class Entreprise
    {
        protected int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string denomination;
        public string Denomination
        {
            get { return denomination; }
            set { denomination = value; }
        }

        private int siret;
        public int Siret
        {
            get { return siret; }
            set { siret = value; }
        }


        private string rue;
        public string Rue
        {
            get { return rue; }
            set { rue = value; }
        }

        private int codePostale;
        public int CodePostale
        {
            get { return codePostale; }
            set { codePostale = value; }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private int telephone;
        public int Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private List<Contrat> lesContrats;
        public List<Contrat> LesContrats
        {
            get { return lesContrats; }
            set { lesContrats = value; }
        }

        /// <summary>
        /// Création d'une Entreprise
        /// </summary>
        public Entreprise(string laDenomination, int unSiret, string laRue, int leCodePostale, string laVille, string leMail, int leTelephone)
        {
            id = 0;
            denomination = laDenomination;
            siret = unSiret;
            rue = laRue;
            codePostale = leCodePostale;
            ville = laVille;
            mail = leMail;
            telephone = leTelephone;
            lesContrats = new List<Contrat>();
        }
    }
}
