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
    public partial class GestionCommandes : Form
    {
        // On crée une variable pour stocké le booléen de récupération
        private bool pretRecuperation = false;

        public GestionCommandes()
        {
            InitializeComponent();
            // On active la selection d'une ligne complète de la list view
            listeCommandesListView.FullRowSelect = true;
            listeCommandesListView.GridLines = true;

            // On désactive les boutons
            desactiver_TextBox();

            // On alimente les comboBox
            DataTable lesPrestations = Prestation.prestations();
            prestationComboBox.DataSource = lesPrestations;
            prestationComboBox.ValueMember = "id";
            prestationComboBox.DisplayMember = "nom";
            DataTable lesClients = Client.clients();
            lesClients.Columns.Add("concatNomPrenom", typeof(string), "nom + ' ' +prenom");
            clientComboBox.DataSource = lesClients;
            clientComboBox.ValueMember = "id";
            clientComboBox.DisplayMember = "concatNomPrenom";
            DataTable lesEmployes = Employe.employes();
            lesEmployes.Columns.Add("concatNomPrenom", typeof(string), "nom + ' ' +prenom");
            employeComboBox.DataSource = lesEmployes;
            employeComboBox.ValueMember = "id";
            employeComboBox.DisplayMember = "concatNomPrenom";
            pretRecuperationComboBox.Items.Add("Non");
            pretRecuperationComboBox.Items.Add("Oui");
        }

        private void GestionCommandes_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listeCommandesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            validerBtn.Text = "Ajouter"; // Si on sélectionne une ligne de la list view, on modifie le bouton d'ajout
            activer_modification_suppresion(); // On active les modif/suppr
            if (listeCommandesListView.SelectedItems.Count > 0) // Si une donnée existe, on pré-remplie les text box
            {
                ListViewItem item = listeCommandesListView.SelectedItems[0];
                idTxtBox.Text = item.SubItems[0].Text;
                commentaireTxtBox.Text = item.SubItems[1].Text;
                dateCreationPicker.Text = item.SubItems[2].Text;
                dateDepotPicker.Text = item.SubItems[3].Text;
                if (item.SubItems[4].Tag != null || item.SubItems[4].ToString() == "0000-00-00")
                {
                    dateRecuperationPicker.Text = item.SubItems[4].Text;
                }
                pretRecuperationComboBox.Text = item.SubItems[5].Text;

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
                dateRecuperationPicker.Enabled = false;
                rafraichir_TextBox();
                desactiver_modification_suppression();
            }
            else
            {
                if (dateCreationPicker.Text != string.Empty && dateDepotPicker.Text != string.Empty && pretRecuperationComboBox.Text != string.Empty)
                {
                    // Si il n'y a aucun commentaire, on précise qu'il n'y en a pas dans la valeur du champ
                    if(commentaireTxtBox.Text == string.Empty)
                    {
                        commentaireTxtBox.Text = "Pas de commentaire particulié";
                    }

                    // On traduit le booléen de Français en Anglais
                    if(pretRecuperationComboBox.Text == "Oui")
                    {
                        this.pretRecuperation = true;
                    }
                    else
                    {
                        this.pretRecuperation = false;
                    }

                    // On lance la requête d'ajout
                    Commande.ajouter(commentaireTxtBox.Text, dateCreationPicker.Value.ToString("yyyy-MM-dd"), dateDepotPicker.Value.ToString("yyyy-MM-dd"), "", this.pretRecuperation, Convert.ToInt32(prestationComboBox.SelectedValue), Convert.ToInt32(clientComboBox.SelectedValue), Convert.ToInt32(employeComboBox.SelectedValue));

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
            if (dateCreationPicker.Text != string.Empty && dateDepotPicker.Text != string.Empty && pretRecuperationComboBox.Text != string.Empty)
            {
                // Si il n'y a aucun commentaire, on précise qu'il n'y en a pas dans la valeur du champ
                if (commentaireTxtBox.Text == string.Empty)
                {
                    commentaireTxtBox.Text = "Pas de commentaire particulié";
                }

                // On traduit le booléen de Français en Anglais
                if (pretRecuperationComboBox.Text == "Oui")
                {
                    this.pretRecuperation = true;
                }
                else
                {
                    this.pretRecuperation = false;
                }

                // On éffectue la modification si tous les champs sont remplis
                Commande.modifier(Convert.ToInt32(idTxtBox.Text), commentaireTxtBox.Text, dateCreationPicker.Value.ToShortDateString(), dateDepotPicker.Value.ToShortDateString(), dateRecuperationPicker.Value.ToShortDateString(), this.pretRecuperation);

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
            if (idTxtBox.Text != string.Empty)
            {
                Commande.supprimer(Convert.ToInt32(idTxtBox.Text));
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
            listeCommandesListView.Clear();
            listeCommandesListView.Columns.Add("ID");
            listeCommandesListView.Columns.Add("Commentaire");
            listeCommandesListView.Columns.Add("Date de création");
            listeCommandesListView.Columns.Add("Date de dépôt");
            listeCommandesListView.Columns.Add("Date de récupération");
            listeCommandesListView.Columns.Add("Prêt pour la récupération ?");
            listeCommandesListView.Columns.Add("Prestation");
            listeCommandesListView.Columns.Add("Client");
            listeCommandesListView.Columns.Add("Employe");

            DataTable lesCommandes = Commande.commandes();
            for (int i = 0; i < lesCommandes.Rows.Count; i++)
            {
                DataRow dr = lesCommandes.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["commentaire"].ToString());
                listitem.SubItems.Add(Convert.ToDateTime(dr["dateCreation"]).ToShortDateString());
                listitem.SubItems.Add(Convert.ToDateTime(dr["dateDepot"]).ToShortDateString());
                if (dr["dateRecuperation"].ToString() == string.Empty)
                {
                    listitem.SubItems.Add("Non récupéré");
                }
                else
                {
                    ListViewItem.ListViewSubItem lvsi = listitem.SubItems.Add(Convert.ToDateTime(dr["dateRecuperation"]).ToShortDateString());
                    lvsi.Tag = Convert.ToDateTime(dr["dateRecuperation"]);
                }
                listitem.SubItems.Add(dr["pretPourRecuperation"].ToString());
                listitem.SubItems.Add(dr["Prestation"].ToString());
                listitem.SubItems.Add(dr["Client"].ToString());
                listitem.SubItems.Add(dr["Employe"].ToString());
                listeCommandesListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            idTxtBox.Text = string.Empty;
            commentaireTxtBox.Text = string.Empty;
            dateCreationPicker.Text = string.Empty;
            dateDepotPicker.Text = string.Empty;
            dateRecuperationPicker.Text = string.Empty;
        }

        private void activer_TextBox()
        {
            commentaireTxtBox.Enabled = true;
            dateCreationPicker.Enabled = true;
            dateDepotPicker.Enabled = true;
            dateRecuperationPicker.Enabled = true;
            pretRecuperationComboBox.Enabled = true;
            prestationComboBox.Enabled = true;
            employeComboBox.Enabled = true;
            clientComboBox.Enabled = true;

        }

        private void desactiver_TextBox()
        {
            commentaireTxtBox.Enabled = false;
            dateCreationPicker.Enabled = false;
            dateDepotPicker.Enabled = false;
            dateRecuperationPicker.Enabled = false;
            pretRecuperationComboBox.Enabled = false;
            prestationComboBox.Enabled = false;
            employeComboBox.Enabled = false;
            clientComboBox.Enabled = false;
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
