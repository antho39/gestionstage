using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionstage.Classes
{
    public class Formation
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string nomComplet;
        public string NomComplet
        {
            get { return nomComplet; }
            set { nomComplet = value; }
        }

        /// <summary>
        /// Création d'une Formation objet chargement depuis BDD
        /// </summary>
        public Formation(int unId, string unNom, string unNomComplet)
        {
            this.id = unId;
            this.nom = unNom;
            this.nomComplet = unNomComplet;
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}
