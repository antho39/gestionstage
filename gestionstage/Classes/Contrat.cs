using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionstage.Classes
{
    public class Contrat
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int typecontrat_id;
        public int Typecontrat_id
        {
            get { return typecontrat_id; }
            set { typecontrat_id = value; }
        }

        private int formation_id;
        public int Formation_id
        {
            get { return formation_id; }
            set { formation_id = value; }
        }

        private string s_nom;
        public string S_nom
        {
            get { return s_nom; }
            set { s_nom = value; }
        }

        private string s_prenom;
        public string S_prenom
        {
            get { return s_prenom; }
            set { s_prenom = value; }
        }

        private string t_nom;
        public string T_nom
        {
            get { return t_nom; }
            set { t_nom = value; }
        }

        private string t_prenom;
        public string T_prenom
        {
            get { return t_prenom; }
            set { t_prenom = value; }
        }

        private string t_mail;
        public string T_mail
        {
            get { return t_mail; }
            set { t_mail = value; }
        }

        private string t_telephone;
        public string T_telephone
        {
            get { return t_telephone; }
            set { t_telephone = value; }
        }

        private DateTime date_debut;
        public DateTime Date_debut
        {
            get { return date_debut; }
            set { date_debut = value; }
        }

        private DateTime date_fin;
        public DateTime Date_fin
        {
            get { return date_fin; }
            set { date_fin = value; }
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

        private int appreciation;
        public int Appreciation
        {
            get { return appreciation; }
            set { appreciation = value; }
        }

        private int entreprise_id;
        public int Entreprise_id
        {
            get { return entreprise_id; }
            set { entreprise_id = value; }
        }

        /// <summary>
        /// Création d'un contrat avant chargement BDD (sans l'ID)
        /// </summary>
        public Contrat(int unIdTypeContrat, int unIdFormation, string unNomStagiaire, string unPrenomStagiaire, string unNomTuteur, string unPrenomTuteur, string unEmailTuteur, string unTelephoneTuteur, DateTime uneDateDebut, DateTime uneDateFin, string unCommentaire, Boolean unBool_envoye, int uneAppreciation, int unIdEntreprise)
        {
            this.id = 0;
            this.typecontrat_id = unIdTypeContrat;
            this.formation_id = unIdFormation;
            this.s_nom = unNomStagiaire;
            this.s_prenom = unPrenomStagiaire;
            this.t_nom = unNomTuteur;
            this.t_prenom = unPrenomTuteur;
            this.t_mail = unEmailTuteur;
            this.t_telephone = unTelephoneTuteur;
            this.date_debut = uneDateDebut;
            this.date_fin = uneDateFin;
            this.commentaire = unCommentaire;
            this.bool_envoye = unBool_envoye;
            this.appreciation = uneAppreciation;
            this.entreprise_id = unIdEntreprise;
        }

        /// <summary>
        /// Création d'un contrat objet chargement depuis BDD
        /// </summary>
        public Contrat(int unId, int unIdTypeContrat, int unIdFormation, string unNomStagiaire, string unPrenomStagiaire, string unNomTuteur, string unPrenomTuteur, string unEmailTuteur, string unTelephoneTuteur, DateTime uneDateDebut, DateTime uneDateFin, string unCommentaire, Boolean unBool_envoye, int uneAppreciation, int unIdEntreprise)
        {
            this.id = unId;
            this.typecontrat_id = unIdTypeContrat;
            this.formation_id = unIdFormation;
            this.s_nom = unNomStagiaire;
            this.s_prenom = unPrenomStagiaire;
            this.t_nom = unNomTuteur;
            this.t_prenom = unPrenomTuteur;
            this.t_mail = unEmailTuteur;
            this.t_telephone = unTelephoneTuteur;
            this.date_debut = uneDateDebut;
            this.date_fin = uneDateFin;
            this.commentaire = unCommentaire;
            this.bool_envoye = unBool_envoye;
            this.appreciation = uneAppreciation;
            this.entreprise_id = unIdEntreprise;
        }
    }
}