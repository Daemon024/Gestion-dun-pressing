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
    public partial class GestionEmployes : Form
    {
        public GestionEmployes()
        {
            InitializeComponent();
            // On active la selection d'une ligne complète de la list view
            listeEmployesListView.FullRowSelect = true;
            listeEmployesListView.GridLines = true;

            // On désactive les boutons
            desactiver_TextBox();
        }

        private void GestionEmployes_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listeEmployesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            validerBtn.Text = "Ajouter"; // Si on sélectionne une ligne de la list view, on modifie le bouton d'ajout
            activer_modification_suppresion(); // On active les modif/suppr
            if (listeEmployesListView.SelectedItems.Count > 0) // Si une donnée existe, on pré-remplie les text box
            {
                ListViewItem item = listeEmployesListView.SelectedItems[0];
                identifiantTxtBox.Text = item.SubItems[0].Text;
                nomTxtBox.Text = item.SubItems[1].Text;
                prenomTxtBox.Text = item.SubItems[2].Text;
                mdpTxtBox.Text = item.SubItems[3].Text;
                typeContratComboBox.Text = item.SubItems[5].Text;
                salaireTxtBox.Text = item.SubItems[6].Text;

                // On active pour la modification (sauf le DatePicker)
                activer_TextBox();
                dateArriveePicker.Enabled = false;
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
                if (nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty && mdpTxtBox.Text != string.Empty && dateArriveePicker.Text != string.Empty && typeContratComboBox.Text != string.Empty && salaireTxtBox.Text != string.Empty)
                {
                    // On lance la requête d'ajout
                    Employe.ajouter(nomTxtBox.Text.ToUpper(), prenomTxtBox.Text, mdpTxtBox.Text, dateArriveePicker.Value.ToString("yyyy-MM-dd"), typeContratComboBox.Text, Convert.ToInt32(salaireTxtBox.Text));

                    rafraichir_ListView(); // On actualise les données de la Liste View
                    rafraichir_TextBox(); // On vide les text box
                    desactiver_TextBox(); // On désactive les text box

                    // On change le bouton d'ajout et on désactive le date picker et on réactive la modif et la suppr
                    validerBtn.Text = "Ajouter";
                    dateArriveePicker.Enabled = false;
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
            if (nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty && mdpTxtBox.Text != string.Empty && dateArriveePicker.Text != string.Empty && typeContratComboBox.Text != string.Empty && salaireTxtBox.Text != string.Empty)
            {
                // On éffectue la modification si tous les champs sont remplis
                Employe.modifier(Convert.ToInt32(identifiantTxtBox.Text), nomTxtBox.Text.ToUpper(), prenomTxtBox.Text, mdpTxtBox.Text, typeContratComboBox.Text, Convert.ToInt32(salaireTxtBox.Text));

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
            if (identifiantTxtBox.Text != string.Empty && nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty)
            {
                Employe.supprimer(Convert.ToInt32(identifiantTxtBox.Text));
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
            listeEmployesListView.Clear();
            listeEmployesListView.Columns.Add("ID");
            listeEmployesListView.Columns.Add("Nom");
            listeEmployesListView.Columns.Add("Prénom");
            listeEmployesListView.Columns.Add("Mot de passe");
            listeEmployesListView.Columns.Add("Date d'arrivée");
            listeEmployesListView.Columns.Add("Type de contrat");
            listeEmployesListView.Columns.Add("Salaire");

            DataTable lesEmployes = Employe.employes();
            for (int i = 0; i < lesEmployes.Rows.Count; i++)
            {
                DataRow dr = lesEmployes.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["nom"].ToString());
                listitem.SubItems.Add(dr["prenom"].ToString());
                listitem.SubItems.Add(dr["password"].ToString());
                listitem.SubItems.Add(dr["dateArrivee"].ToString());
                listitem.SubItems.Add(dr["typeContrat"].ToString());
                listitem.SubItems.Add(dr["salaire"].ToString());
                listeEmployesListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            identifiantTxtBox.Text = string.Empty;
            nomTxtBox.Text = string.Empty;
            prenomTxtBox.Text = string.Empty;
            mdpTxtBox.Text = string.Empty;
            dateArriveePicker.Text = string.Empty;
            typeContratComboBox.Text = string.Empty;
            salaireTxtBox.Text = string.Empty;
        }

        private void activer_TextBox()
        {
            nomTxtBox.Enabled = true;
            prenomTxtBox.Enabled = true;
            mdpTxtBox.Enabled = true;
            dateArriveePicker.Enabled = true;
            typeContratComboBox.Enabled = true;
            salaireTxtBox.Enabled = true;
        }

        private void desactiver_TextBox()
        {
            nomTxtBox.Enabled = false;
            prenomTxtBox.Enabled = false;
            mdpTxtBox.Enabled = false;
            dateArriveePicker.Enabled = false;
            typeContratComboBox.Enabled = false;
            salaireTxtBox.Enabled = false;
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
