using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_dun_pressing
{
    public partial class GestionPrestations : Form
    {
        public GestionPrestations()
        {
            InitializeComponent();
            // On active la selection d'une ligne complète de la list view
            listePrestationsListView.FullRowSelect = true;
            listePrestationsListView.GridLines = true;

            // On désactive les boutons
            desactiver_TextBox();

            // On alimente les comboBox
            DataTable lesProduits = Produit.produits();
            produitIdComboBox.DataSource = lesProduits;
            produitIdComboBox.ValueMember = "id";
            produitIdComboBox.DisplayMember = "nom";
        }

        private void GestionPrestations_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listePrestationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            validerBtn.Text = "Ajouter"; // Si on sélectionne une ligne de la list view, on modifie le bouton d'ajout
            activer_modification_suppresion(); // On active les modif/suppr
            if (listePrestationsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = listePrestationsListView.SelectedItems[0];
                identifiantTxtBox.Text = item.SubItems[0].Text;
                nomTxtBox.Text = item.SubItems[1].Text;

                // On active pour la modification
                activer_TextBox();
            }
            else // Si aucune donnée n'est sélectionnée, on vide les text box
            {
                rafraichir_TextBox();
                desactiver_TextBox();
            }
        }

        private void validerBtn_Click_1(object sender, EventArgs e)
        {
            if (validerBtn.Text == "Ajouter") // Si l'ajout est sélectionner, on active les text box, on les vide et on désactive la suppression et la modification
            {
                validerBtn.Text = "Valider";
                activer_TextBox();
                rafraichir_TextBox();
                desactiver_modification_suppression();
            }
            else
            {
                if (nomTxtBox.Text != string.Empty && produitIdComboBox.Text != string.Empty)
                {
                    // On lance la requête d'ajout
                    Prestation.ajouter(nomTxtBox.Text, Convert.ToInt32(produitIdComboBox.SelectedValue));

                    rafraichir_ListView(); // On actualise les données de la Liste View
                    rafraichir_TextBox(); // On vide les text box
                    desactiver_TextBox(); // On désactive les text box

                    // On change le bouton d'ajout et on réactive la modif et la suppr
                    validerBtn.Text = "Ajouter";
                    activer_modification_suppresion();
                }
                else // Si certains champs sont vides, on affiche un message d'erreur
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
            }
        }

        private void modifierBtn_Click_1(object sender, EventArgs e)
        {
            if (identifiantTxtBox.Text != string.Empty && nomTxtBox.Text != string.Empty && produitIdComboBox.Text != string.Empty)
            {
                // On éffectue la modification si tous les champs sont remplis
                Prestation.modifier(Convert.ToInt32(identifiantTxtBox.Text), nomTxtBox.Text, Convert.ToInt32(produitIdComboBox.SelectedValue));

                // On actualise les données, on vide les text box et on les désactive
                rafraichir_ListView();
                rafraichir_TextBox();
                desactiver_TextBox();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }

        private void supprimerBtn_Click_1(object sender, EventArgs e)
        {
            desactiver_TextBox();
            if (identifiantTxtBox.Text != string.Empty && nomTxtBox.Text != string.Empty && produitIdComboBox.Text != string.Empty)
            {
                Produit.supprimer(Convert.ToInt32(identifiantTxtBox.Text));
                rafraichir_ListView();
                rafraichir_TextBox();
            }
            else
            {
                MessageBox.Show("Veuillez saisir un client à supprimer");
            }
        }

        private void rafraichir_ListView()
        {
            listePrestationsListView.Clear();
            listePrestationsListView.Columns.Add("ID");
            listePrestationsListView.Columns.Add("Nom");
            listePrestationsListView.Columns.Add("Produit");

            DataTable lesPrestations = Prestation.prestations();
            for (int i = 0; i < lesPrestations.Rows.Count; i++)
            {
                DataRow dr = lesPrestations.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["nom"].ToString());
                listitem.SubItems.Add(dr["produit_nom"].ToString());
                listePrestationsListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            identifiantTxtBox.Text = string.Empty;
            nomTxtBox.Text = string.Empty;
            produitIdComboBox.Text = string.Empty;
        }

        private void activer_TextBox()
        {
            nomTxtBox.Enabled = true;
            produitIdComboBox.Enabled = true;
        }

        private void desactiver_TextBox()
        {
            nomTxtBox.Enabled = false;
            produitIdComboBox.Enabled = false;
        }

        private void activer_modification_suppresion()
        {
            modifierBtn.Enabled = true;
            supprimerBtn.Enabled = true;
        }

        private void desactiver_modification_suppression()
        {
            modifierBtn.Enabled = false;
            supprimerBtn.Enabled = false;
        }
    }
}
