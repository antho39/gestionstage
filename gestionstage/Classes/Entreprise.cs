using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionstage.Classes
{
    class Entreprise
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string siret;
        public string Siret
        {
            get { return siret; }
            set { siret = value; }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private string cp;
        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string commentaire;
        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        private Boolean bool_envoye;
        public Boolean Bool_envoye
        {
            get { return bool_envoye; }
            set { bool_envoye = value; }
        }

        private List<Contrat> lesContrats;
        public List<Contrat> LesContrats
        {
            get { return lesContrats; }
            set { lesContrats = value; }
        }

        /// <summary>
        /// Création d'une Entreprise avant chargement BDD (sans l'ID)
        /// </summary>
        public Entreprise(string unSiret, string unNom, string uneAdresse, string unCp, string uneVille, string unTelephone, string unMail, string unCommentaire, Boolean unBool_envoye)
        {
            this.id = 0;
            this.siret = unSiret;
            this.nom = unNom;
            this.adresse = uneAdresse;
            this.cp = unCp;
            this.ville = uneVille;
            this.telephone = unTelephone;
            this.email = unMail;
            this.commentaire = unCommentaire;
            this.bool_envoye = unBool_envoye;
            lesContrats = new List<Contrat>();
        }

        /// <summary>
        /// Création d'une Entreprise objet chargement depuis BDD
        /// </summary>
        public Entreprise(int unId, string unSiret, string unNom, string uneAdresse, string unCp, string uneVille, string unTelephone, string unMail, string unCommentaire, Boolean unBool_envoye)
        {
            this.id = unId;
            this.siret = unSiret;
            this.nom = unNom;
            this.adresse = uneAdresse;
            this.cp = unCp;
            this.ville = uneVille;
            this.telephone = unTelephone;
            this.email = unMail;
            this.commentaire = unCommentaire;
            this.bool_envoye = unBool_envoye;
            lesContrats = new List<Contrat>();
        }
    }
}
