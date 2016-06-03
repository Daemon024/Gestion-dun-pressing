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
    public partial class GestionTarifs : Form
    {
        public GestionTarifs()
        {
            InitializeComponent();
            // On active la selection d'une ligne complète de la list view
            listeTarifsListView.FullRowSelect = true;
            listeTarifsListView.GridLines = true;

            // On désactive les boutons
            desactiver_TextBox();

            // On alimente les comboBox
            DataTable lesPrestations = Prestation.prestations();
            prestationComboBox.DataSource = lesPrestations;
            prestationComboBox.ValueMember = "id";
            prestationComboBox.DisplayMember = "nom";
            DataTable lesProduits = Produit.produits();
            produitComboBox.DataSource = lesProduits;
            produitComboBox.ValueMember = "id";
            produitComboBox.DisplayMember = "nom";
        }

        private void GestionTarifs_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listeTarifsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            validerBtn.Text = "Ajouter"; // Si on sélectionne une ligne de la list view, on modifie le bouton d'ajout
            activer_modification_suppresion(); // On active les modif/suppr
            if (listeTarifsListView.SelectedItems.Count > 0) // Si une donnée existe, on pré-remplie les text box
            {
                ListViewItem item = listeTarifsListView.SelectedItems[0];
                prestationComboBox.Text = item.SubItems[0].Text;
                produitComboBox.Text = item.SubItems[1].Text;
                tarifLbl.Text = item.SubItems[2].Text;

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
                if (tarifTxtBox.Text != string.Empty && prestationComboBox.Text != string.Empty && produitComboBox.Text != string.Empty)
                {
                    // On lance la requête d'ajout
                    Tarif.ajouter(Convert.ToInt32(tarifTxtBox.Text), Convert.ToInt32(produitComboBox.SelectedValue), Convert.ToInt32(prestationComboBox.SelectedValue));

                    rafraichir_ListView(); // On actualise les données de la Liste View
                    rafraichir_TextBox(); // On vide les text box
                    desactiver_TextBox(); // On désactive les text box

                    // On change le bouton d'ajout et on réactive la modif et la suppr
                    validerBtn.Text = "Ajouter";
                    activer_modification_suppresion();
                }
                else // Si certains champs sont vides, on affiche un message d'erreur
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
            }
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            if (tarifTxtBox.Text != string.Empty && prestationComboBox.Text != string.Empty && produitComboBox.Text != string.Empty)
            {
                // On éffectue la modification si tous les champs sont remplis
                Tarif.modifier(Convert.ToInt32(tarifTxtBox.Text), Convert.ToInt32(produitComboBox.SelectedValue), Convert.ToInt32(prestationComboBox.SelectedValue));

                // On actualise les données, on vide les text box et on les désactive
                rafraichir_ListView();
                rafraichir_TextBox();
                desactiver_TextBox();
            }
            else // Si certains champs sont vides, on affiche un message d'erreur
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            desactiver_TextBox();
            if (tarifTxtBox.Text != string.Empty && produitComboBox.Text != string.Empty && prestationComboBox.Text != string.Empty)
            {
                Tarif.supprimer(Convert.ToInt32(produitComboBox.Text), Convert.ToInt32(prestationComboBox.Text));
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
            listeTarifsListView.Clear();
            listeTarifsListView.Columns.Add("Tarif");
            listeTarifsListView.Columns.Add("Produit");
            listeTarifsListView.Columns.Add("Prestation");

            DataTable lesTarifs = Tarif.tarifs();
            for (int i = 0; i < lesTarifs.Rows.Count; i++)
            {
                DataRow dr = lesTarifs.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["tarif"].ToString()+"€");
                listitem.SubItems.Add(dr["Produit"].ToString());
                listitem.SubItems.Add(dr["Prestation"].ToString());
                listeTarifsListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            tarifTxtBox.Text = string.Empty;
            produitComboBox.Text = string.Empty;
            prestationComboBox.Text = string.Empty;
        }

        private void activer_TextBox()
        {
            tarifTxtBox.Enabled = true;
            produitComboBox.Enabled = true;
            prestationComboBox.Enabled = true;
        }

        private void desactiver_TextBox()
        {
            tarifTxtBox.Enabled = false;
            produitComboBox.Enabled = false;
            prestationComboBox.Enabled = false;
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
