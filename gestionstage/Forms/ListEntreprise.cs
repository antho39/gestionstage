using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using perso
using gestionstage.Properties;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using gestionstage.Classes;
using gestionstage.Dao;
using System.Net;
using Newtonsoft.Json.Linq;

namespace gestionstage.Forms
{
    public partial class ListEntreprise : MetroFramework.Forms.MetroForm
    {
        DataTable dtListeEntreprise = DaoEntreprise.dtReadAll();

        public ListEntreprise()
        {         
            InitializeComponent();
            this.StyleManager = mSMListEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
            
        }

        private void ListEntreprise_Load(object sender, EventArgs e)
        {
            refreshDTListeEntreprise();
            refreshGrid(dtListeEntreprise);      //Affichage des entreprises dans le tableau
            refreshColor();                     //Affichage des tuiles de couleurs, pour la selection du thème
        }

        // --------------------------------------------------------------------
        // Button et Clics :
        // --------------------------------------------------------------------
        private void mButtonAddEntreprise_Click(object sender, EventArgs e)
        {
            AddEntreprise formAddEntreprise = new AddEntreprise();
            formAddEntreprise.Show();
            this.Close();
        }

        void _tile_Click(object sender, EventArgs e)
        {
            StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        private void mButtonConfirmPush_Click(object sender, EventArgs e)
        {
            DaoSynchronisation.SynchronisationPush();
            DialogResult result = MetroMessageBox.Show(this, "Les modifications ont été envoyé à la base du WebService", "Confirmation d'envoie", MessageBoxButtons.OK);
        }

        private void mButtonConfirmPull_Click(object sender, EventArgs e)
        {
            try
            {
                String url = "http://arcwebservice.aeg2.fr/"; //TODO Changer par le JSON des temps pleins
                var res = new WebClient();
                var json = res.DownloadString(url);
                JArray listEntreprisesContrats = JArray.Parse(json);
                foreach (var entreprise in listEntreprisesContrats)
                {
                    if (!(DaoEntreprise.isExistSiret(entreprise["siret"].ToString()))) // Si l'entreprise (siret) n'éxiste pas BDD C#
                    {
                        Entreprise nouvelleEntreprise = new Entreprise(
                            entreprise["siret"].ToString(),
                            entreprise["nom"].ToString(),
                            entreprise["adresse"].ToString(),
                            entreprise["cp"].ToString(),
                            entreprise["ville"].ToString(),
                            entreprise["telephone"].ToString(),
                            entreprise["email"].ToString(),
                            entreprise["commentaireEntreprise"].ToString(),
                            true); // Bool Envoyé à true, pas besoin de leur renvoyé leurs modifications

                        DaoEntreprise.create(nouvelleEntreprise);
                    }
                    else
                    {
                        //L'entreprise éxist déjà - Afficher une erreur si besoin ici.
                    }
                    foreach (var contrat in entreprise["contrats"])
                    {
                        Entreprise entrepriseDuContrat = DaoEntreprise.readOneBySiret(entreprise["siret"].ToString());

                        //Traduction des Cléfs étrangère
                        //Type Contrat
                        int typeContrat;
                        switch (contrat["typecontrat"].ToString())
                        {
                            case "apprentissage":
                                typeContrat = 1;
                                break;
                            case "Stage":
                                typeContrat = 2;
                                break;
                            case "Contrat Pro":
                                typeContrat = 3;
                                break;

                            default:
                                typeContrat = 0;
                                break;
                        }

                        //ID Formation
                        int idFormation;
                        switch (contrat["nom_formation"].ToString())
                        {
                            case "BTS SIO":
                                idFormation = 1;
                                break;

                            default:
                                idFormation = 0;
                                break;
                        }

                        //Traduction en DateTime
                        DateTime dateDebut = jsonToDateTime(contrat["date_debut"].ToString());
                        DateTime dateFin = jsonToDateTime(contrat["date_fin"].ToString());

                        Contrat nouveauContrat = new Contrat(
                            typeContrat,
                            idFormation,
                            contrat["nom_eleve"].ToString(),
                            contrat["prenom_eleve"].ToString(),
                            contrat["nom_tuteur"].ToString(),
                            contrat["prenom_tuteur"].ToString(),
                            contrat["mail_tuteur"].ToString(),
                            contrat["telephone_tuteur"].ToString(),
                            dateDebut,
                            dateFin,
                            contrat["commentaireContrat"].ToString(),
                            true,
                            Convert.ToInt32(contrat["appreciation"].ToString()),
                            entrepriseDuContrat.Id);

                        DaoContrat.create(nouveauContrat);

                    }
                }

                MessageBox.Show("Ok");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mButtonConfirmColor_Click(object sender, EventArgs e)
        {
            Settings.Default.Style = StyleManager.Style;
            Settings.Default.Save();
        }

        private void mGridEntreprises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(mGridEntreprises.Rows[e.RowIndex].Cells[1].Value.ToString() == "Aucun Résultat")) // Si le nom est = à Aucun Résultat (ligne de recherche)
            {
                // Si clique sur la column dataGridViewTextBoxColumn3 (Afficher) et Pas sur le header
                if (e.ColumnIndex == mGridEntreprises.Columns["dataGridViewTextBoxColumn3"].Index && e.RowIndex >= 0)
                {
                    ViewEntreprise formViewEntreprise = new ViewEntreprise(mGridEntreprises.Rows[e.RowIndex].Cells[0].Value.ToString());
                    formViewEntreprise.Show();
                    this.Close();
                }
                // Si clique sur la column dataGridViewTextBoxColumn4 (Modifier) et Pas sur le header
                else if (e.ColumnIndex == mGridEntreprises.Columns["dataGridViewTextBoxColumn4"].Index && e.RowIndex >= 0)
                {
                    ModifyEntreprise formModifyEntreprise = new ModifyEntreprise(mGridEntreprises.Rows[e.RowIndex].Cells[0].Value.ToString());
                    formModifyEntreprise.Show();
                    this.Close();
                }
                // Si clique sur la column dataGridViewTextBoxColumn5 (Supprimer) et Pas sur le header
                else if (e.ColumnIndex == mGridEntreprises.Columns["dataGridViewTextBoxColumn5"].Index && e.RowIndex >= 0)
                {
                    DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer l'entreprise ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        DaoEntreprise.delete(mGridEntreprises.Rows[e.RowIndex].Cells[0].Value.ToString());
                        refreshDTListeEntreprise();
                        refreshGrid(dtListeEntreprise);
                    }
                    else if (result == DialogResult.No)
                    {
                        // Ne rien faire
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void mTBSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                refreshGrid(dtListeEntreprise.Select("nom LIKE '%" + mTBSearch.Text + "%'").CopyToDataTable());
            }
            catch
            {
                // Création d'une DataTable avec une seul ligne "Aucun Résultat"
                DataTable dtVide = new DataTable();
                dtVide.Columns.Add("nom", typeof(string));
                dtVide.Rows.Add("Aucun Résultat");

                refreshGrid(dtVide);
            }
        }

        private void mTBSearch_Enter(object sender, EventArgs e)
        {
            mTBSearch.Text = "";
        }

        private void mTBSearch_Leave(object sender, EventArgs e)
        {
            if (mTBSearch.Text == "")
            {
                mTBSearch.Text = "Rechercher . . .";
            }
        }

        // --------------------------------------------------------------------
        // Fonctions de refresh :
        // --------------------------------------------------------------------
        private void refreshGrid(DataTable DataTableForFill)
        {
            //Chargement de la liste des entreprises
            mGridEntreprises.RowTemplate.MinimumHeight = 35;
            mGridEntreprises.AutoGenerateColumns = false;
            mGridEntreprises.Columns[0].DataPropertyName = "siret";
            mGridEntreprises.Columns[1].DataPropertyName = "nom";
            mGridEntreprises.DataSource = DataTableForFill;
        }

        private void refreshColor()
        {
            //Chargement des tuiles de couleurs, pour le changement de thème
            for (int i = 3; i < 13; i++) // i = 3 pour cacher Blanc et Noir.
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(185, 100);
                _tile.Tag = i; //Valeur de la couleur
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                ConteneurCouleurs.Controls.Add(_tile);
            }
        }

        private void refreshDTListeEntreprise()
        {
            dtListeEntreprise = DaoEntreprise.dtReadAll();
        }

        // --------------------------------------------------------------------
        // Fonctions utile
        // --------------------------------------------------------------------
        private DateTime jsonToDateTime(string JsonDate)
        {
            string anneeString = JsonDate[6].ToString() + JsonDate[7].ToString() + JsonDate[8].ToString() + JsonDate[9].ToString();
            string moisString = JsonDate[3].ToString() + JsonDate[4].ToString();
            string jourString = JsonDate[0].ToString() + JsonDate[1].ToString();
            string heureString = JsonDate[11].ToString() + JsonDate[12].ToString();
            string minuteString = JsonDate[14].ToString() + JsonDate[15].ToString();
            string secondeString = JsonDate[17].ToString() + JsonDate[18].ToString();

            int annee = Convert.ToInt32(anneeString);
            int mois = Convert.ToInt32(moisString);
            int jour = Convert.ToInt32(jourString);
            int heure = Convert.ToInt32(heureString);
            int minute = Convert.ToInt32(minuteString);
            int seconde = Convert.ToInt32(secondeString);

            DateTime laDateTime = new DateTime(annee, mois, jour, heure, minute, seconde);

            return laDateTime;
        }
    }
}
