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
    public partial class GestionProduits : Form
    {
        public GestionProduits()
        {
            InitializeComponent();
            // On active la selection d'une ligne complète de la list view
            listeProduitsListView.FullRowSelect = true;
            listeProduitsListView.GridLines = true;

            // On désactive les boutons
            desactiver_TextBox();
        }

        private void GestionProduits_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listeProduitsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            validerBtn.Text = "Ajouter"; // Si on sélectionne une ligne de la list view, on modifie le bouton d'ajout
            activer_modification_suppresion(); // On active les modif/suppr
            if (listeProduitsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = listeProduitsListView.SelectedItems[0];
                identifiantTxtBox.Text = item.SubItems[0].Text;
                nomTxtBox.Text = item.SubItems[1].Text;

                // On active pour la modification (sauf le DatePicker)
                activer_TextBox();
            }
            else // Si aucune donnée n'est sélectionnée, on vide les text box
            {
                rafraichir_TextBox();
                desactiver_TextBox();
            }
        }

        private void validerBtn_Click(object sender, EventArgs e)
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

                if (nomTxtBox.Text != string.Empty)
                {
                    // On lance la requête d'ajout
                    Produit.ajouter(nomTxtBox.Text);

                    rafraichir_ListView(); // On actualise les données de la Liste View
                    rafraichir_TextBox(); // On vide les text box
                    desactiver_TextBox(); // On désactive les text box

                    // On change le bouton d'ajout et on désactive le date picker et on réactive la modif et la suppr
                    validerBtn.Text = "Ajouter";
                    activer_modification_suppresion();
                }
                else // Si certains champs sont vides, on affiche un message d'erreur
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
            }
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            if (nomTxtBox.Text != string.Empty)
            {
                // On éffectue la modification si tous les champs sont remplis
                Produit.modifier(Convert.ToInt32(identifiantTxtBox.Text), nomTxtBox.Text);

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

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            desactiver_TextBox();
            if (identifiantTxtBox.Text != string.Empty && nomTxtBox.Text != string.Empty)
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
            listeProduitsListView.Clear();
            listeProduitsListView.Columns.Add("ID");
            listeProduitsListView.Columns.Add("Nom");

            DataTable lesProduits = Produit.produits();
            for (int i = 0; i < lesProduits.Rows.Count; i++)
            {
                DataRow dr = lesProduits.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["nom"].ToString());
                listeProduitsListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            identifiantTxtBox.Text = string.Empty;
            nomTxtBox.Text = string.Empty;
        }

        private void activer_TextBox()
        {
            nomTxtBox.Enabled = true;
        }

        private void desactiver_TextBox()
        {
            nomTxtBox.Enabled = false;
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
