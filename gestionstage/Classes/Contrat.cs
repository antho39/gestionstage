using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionstage.Classes
{
    class Contrat
    {
        protected int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private bool typeContrat; // True = Apprentissage
        public bool TypeContrat
        {
            get { return typeContrat; }
            set { typeContrat = value; }
        }

        private string nomStagiaire;
        public string NomStagiaire
        {
            get { return nomStagiaire; }
            set { nomStagiaire = value; }
        }

        private string prenomStagiaire;
        public string PrenomStagiaire
        {
            get { return prenomStagiaire; }
            set { prenomStagiaire = value; }
        }

        private string promotion;
        public string Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }

        private Entreprise entreprise;
        public Entreprise Entreprise
        {
            get { return entreprise; }
            set { entreprise = value; }
        }

        private string posteOccupe;
        public string PosteOccupe
        {
            get { return posteOccupe; }
            set { posteOccupe = value; }
        }

        private DateTime dateDebut;
        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        private DateTime dateFin;
        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }

        private DateTime dateModification;
        public DateTime DateModification
        {
            get { return dateModification; }
            set { dateModification = value; }
        }

        private int satisfaction; // 0 = nul | 3 = bon | null = null
        public int Satisfaction
        {
            get { return satisfaction; }
            set { satisfaction = value; }
        }

        /// <summary>
        /// Création d'un contrat
        /// </summary>
        public Contrat(bool leTypeContrat, string leNomStagiaire, string lePrenomStagiaire, string laPromotion, Entreprise lEntreprise, string lePosteOccupe, DateTime laDateDebut, DateTime laDateFin, DateTime laDateModification, int laSatisfaction)
        {
            id = 0;
            typeContrat = leTypeContrat;
            nomStagiaire = leNomStagiaire;
            prenomStagiaire = lePrenomStagiaire;
            promotion = laPromotion;
            entreprise = lEntreprise;
            posteOccupe = lePosteOccupe;
            dateDebut = laDateDebut;
            dateFin = laDateFin;
            dateModification = laDateModification;
            satisfaction = laSatisfaction;
        }

    }
}