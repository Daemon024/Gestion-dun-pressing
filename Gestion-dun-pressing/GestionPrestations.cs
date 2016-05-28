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
            listePrestationsListView.FullRowSelect = true;
            listePrestationsListView.GridLines = true;
        }

        private void GestionPrestations_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void validerBtn_Click_1(object sender, EventArgs e)
        {
            Prestation.ajouter(Convert.ToInt32(identifiantTxtBox.Text), commentaireTxtBox.Text, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), string.Empty);
            rafraichir_ListView();
            rafraichir_TextBox();
        }

        private void modifierBtn_Click_1(object sender, EventArgs e)
        {
            Prestation.modifier(Convert.ToInt32(identifiantTxtBox.Text), commentaireTxtBox.Text, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), string.Empty);
            rafraichir_ListView();
            rafraichir_TextBox();
        }

        private void supprimerBtn_Click_1(object sender, EventArgs e)
        {
            Produit.supprimer(Convert.ToInt32(identifiantTxtBox.Text));
            rafraichir_ListView();
            rafraichir_TextBox();
        }

        private void rafraichir_ListView()
        {
            listePrestationsListView.Clear();
            listePrestationsListView.Columns.Add("ID");
            listePrestationsListView.Columns.Add("Commentaire");
            listePrestationsListView.Columns.Add("Date de dépôt");
            listePrestationsListView.Columns.Add("Date de récupération");

            DataTable lesPrestations = Prestation.prestations();
            for (int i = 0; i < lesPrestations.Rows.Count; i++)
            {
                DataRow dr = lesPrestations.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["commentaire"].ToString());
                listitem.SubItems.Add(dr["dateDepot"].ToString());
                listitem.SubItems.Add(dr["dateRecuperation"].ToString());
                listePrestationsListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            identifiantTxtBox.Text = string.Empty;
            commentaireTxtBox.Text = string.Empty;
        }
    }
}
