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
            listeClientsListView.FullRowSelect = true;
            listeClientsListView.GridLines = true;
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listeClientsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                dateCreationTxtBox.Text = item.SubItems[7].Text;
                telTxtBox.Text = item.SubItems[8].Text;
                mdpTxtBox.Text = item.SubItems[9].Text;
                tokenTxtBox.Text = item.SubItems[10].Text;
                dateModificationTxtBox.Text = item.SubItems[11].Text;
            }
            else
            {
                rafraichir_TextBox();
            }
        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            if(nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty && adresseTxtBox.Text != string.Empty && codePostalTxtBox.Text != string.Empty && villeTxtBox.Text != string.Empty && emailTxtBox.Text != string.Empty && telTxtBox.Text != string.Empty && mdpTxtBox.Text != string.Empty && tokenTxtBox.Text != string.Empty){
                Client.ajouter(nomTxtBox.Text, prenomTxtBox.Text, adresseTxtBox.Text, codePostalTxtBox.Text, villeTxtBox.Text, emailTxtBox.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), telTxtBox.Text, mdpTxtBox.Text, tokenTxtBox.Text, "Pas de modification");
                rafraichir_ListView();
                rafraichir_TextBox();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            if (nomTxtBox.Text != string.Empty && prenomTxtBox.Text != string.Empty && adresseTxtBox.Text != string.Empty && codePostalTxtBox.Text != string.Empty && villeTxtBox.Text != string.Empty && emailTxtBox.Text != string.Empty && telTxtBox.Text != string.Empty && mdpTxtBox.Text != string.Empty && tokenTxtBox.Text != string.Empty)
            {
                Client.modifier(Convert.ToInt32(idTxtBox.Text), nomTxtBox.Text, prenomTxtBox.Text, adresseTxtBox.Text, codePostalTxtBox.Text, villeTxtBox.Text, emailTxtBox.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), telTxtBox.Text, mdpTxtBox.Text, tokenTxtBox.Text, DateTime.Now.ToString("yyyy-MM-dd hh: mm:ss"));
                rafraichir_ListView();
                rafraichir_TextBox();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
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
            listeClientsListView.Columns.Add("Token");
            listeClientsListView.Columns.Add("Date de modification");

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
                listitem.SubItems.Add(dr["remember_token"].ToString());
                listitem.SubItems.Add(dr["updated_at"].ToString());
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
            dateCreationTxtBox.Text = string.Empty;
            telTxtBox.Text = string.Empty;
            mdpTxtBox.Text = string.Empty;
            tokenTxtBox.Text = string.Empty;
            dateModificationTxtBox.Text = string.Empty;
        }
    }
}
