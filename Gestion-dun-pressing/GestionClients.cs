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
    public partial class GestionClients : Form
    {
        public GestionClients()
        {
            InitializeComponent();
            // On active la selection d'une ligne complète de la list view
            listeClientsListView.FullRowSelect = true;
            listeClientsListView.GridLines = true;

            // On désactive les boutons
            desactiver_TextBox();
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listeClientsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            validerBtn.Text = "Ajouter"; // Si on sélectionne une ligne de la list view, on modifie le bouton d'ajout
            activer_modification_suppresion(); // On active les modif/suppr
            if (listeClientsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = listeClientsListView.SelectedItems[0];
                idTxtBox.Text = item.SubItems[0].Text;
                nomTxtBox.Text = item.SubItems[1].Text;
                prenomTxtBox.Text = item.SubItems[2].Text;
                adresseTxtBox.Text = item.SubItems[3].Text;
                codePostalTxtBox.Text = item.SubItems[4].Text;
                villeTxtBox.Text = item.SubItems[5].Text;
                emailTxtBox.Text = item.SubItems[6].Text;
                telTxtBox.Text = item.SubItems[8].Text;
                mdpTxtBox.Text = item.SubItems[9].Text;

                // On active pour la modification
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

                if (nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty && adresseTxtBox.Text != string.Empty && codePostalTxtBox.Text != string.Empty && villeTxtBox.Text != string.Empty && emailTxtBox.Text != string.Empty && telTxtBox.Text != string.Empty && mdpTxtBox.Text != string.Empty)
                {
                    // On lance la requête d'ajout
                    Client.ajouter(nomTxtBox.Text, prenomTxtBox.Text, adresseTxtBox.Text, codePostalTxtBox.Text, villeTxtBox.Text, emailTxtBox.Text, DateTime.Now.ToString("yyyy-MM-dd"), telTxtBox.Text, mdpTxtBox.Text);

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

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            if (nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty && adresseTxtBox.Text != string.Empty && codePostalTxtBox.Text != string.Empty && villeTxtBox.Text != string.Empty && emailTxtBox.Text != string.Empty && telTxtBox.Text != string.Empty && mdpTxtBox.Text != string.Empty)
            {
                // On éffectue la modification si tous les champs sont remplis
                Client.modifier(Convert.ToInt32(idTxtBox.Text), nomTxtBox.Text, prenomTxtBox.Text, adresseTxtBox.Text, codePostalTxtBox.Text, villeTxtBox.Text, emailTxtBox.Text, telTxtBox.Text, mdpTxtBox.Text);

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
            if (idTxtBox.Text != string.Empty && nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty)
            {
                Client.supprimer(Convert.ToInt32(idTxtBox.Text));
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
            listeClientsListView.Clear();
            listeClientsListView.Columns.Add("ID");
            listeClientsListView.Columns.Add("Nom");
            listeClientsListView.Columns.Add("Prénom");
            listeClientsListView.Columns.Add("Adresse");
            listeClientsListView.Columns.Add("Code Postal");
            listeClientsListView.Columns.Add("Ville");
            listeClientsListView.Columns.Add("Email");
            listeClientsListView.Columns.Add("Date de création");
            listeClientsListView.Columns.Add("Tel");
            listeClientsListView.Columns.Add("Mot de passe");

            DataTable lesClients = Client.clients();
            for (int i = 0; i < lesClients.Rows.Count; i++)
            {
                DataRow dr = lesClients.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["nom"].ToString());
                listitem.SubItems.Add(dr["prenom"].ToString());
                listitem.SubItems.Add(dr["adresse"].ToString());
                listitem.SubItems.Add(dr["codepostal"].ToString());
                listitem.SubItems.Add(dr["ville"].ToString());
                listitem.SubItems.Add(dr["email"].ToString());
                listitem.SubItems.Add(dr["created_at"].ToString());
                listitem.SubItems.Add(dr["tel"].ToString());
                listitem.SubItems.Add(dr["password"].ToString());
                listeClientsListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            idTxtBox.Text = string.Empty;
            nomTxtBox.Text = string.Empty;
            prenomTxtBox.Text = string.Empty;
            adresseTxtBox.Text = string.Empty;
            codePostalTxtBox.Text = string.Empty;
            villeTxtBox.Text = string.Empty;
            emailTxtBox.Text = string.Empty;
            telTxtBox.Text = string.Empty;
            mdpTxtBox.Text = string.Empty;
        }

        private void activer_TextBox()
        {
            nomTxtBox.Enabled = true;
            prenomTxtBox.Enabled = true;
            adresseTxtBox.Enabled = true;
            codePostalTxtBox.Enabled = true;
            villeTxtBox.Enabled = true;
            emailTxtBox.Enabled = true;
            telTxtBox.Enabled = true;
            mdpTxtBox.Enabled = true;
        }

        private void desactiver_TextBox()
        {
            nomTxtBox.Enabled = false;
            prenomTxtBox.Enabled = false;
            adresseTxtBox.Enabled = false;
            codePostalTxtBox.Enabled = false;
            villeTxtBox.Enabled = false;
            emailTxtBox.Enabled = false;
            telTxtBox.Enabled = false;
            mdpTxtBox.Enabled = false;
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
