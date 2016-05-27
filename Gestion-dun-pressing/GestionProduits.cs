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
            listeProduitsListView.FullRowSelect = true;
            listeProduitsListView.GridLines = true;
        }

        private void GestionProduits_Load(object sender, EventArgs e)
        {
            rafraichir_ListView();
        }

        private void listeProduitsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeProduitsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = listeProduitsListView.SelectedItems[0];
                identifiantTxtBox.Text = item.SubItems[0].Text;
                typeTxtBox.Text = item.SubItems[1].Text;
            }
            else
            {
                rafraichir_TextBox();
            }
        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GestionBDD.executeRequestById("INSERT INTO produits VALUES(" + Convert.ToInt32(identifiantTxtBox.Text) + ", \"" + typeTxtBox.Text + "\", \"" + DateTime.Now.ToString("YYYY-MM-DD HH:MM:SS ") + "\", 12);");
                rafraichir_ListView();
                rafraichir_TextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur, plus d'infos: "+ ex.ToString());
            }
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GestionBDD.executeRequestById("UPDATE produits SET id=" + Convert.ToInt32(identifiantTxtBox.Text) + ", type=\"" + typeTxtBox.Text + "\", created_at=\"" + DateTime.Now.ToString("YYYY-MM-DD HH:MM:SS ") + "\", prix=12 WHERE id="+ Convert.ToInt32(identifiantTxtBox.Text) +";");
                rafraichir_ListView();
                rafraichir_TextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur, plus d'infos: " + ex.ToString());
            }
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            Produit.supprimer(Convert.ToInt32(identifiantTxtBox.Text));
            rafraichir_ListView();

        }

        private void rafraichir_ListView()
        {
            listeProduitsListView.Clear();
            listeProduitsListView.Columns.Add("ID");
            listeProduitsListView.Columns.Add("Type");
            listeProduitsListView.Columns.Add("Date de création");
            listeProduitsListView.Columns.Add("Prix");

            DataTable lesProduits = Produit.produits();
            for (int i = 0; i < lesProduits.Rows.Count; i++)
            {
                DataRow dr = lesProduits.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["type"].ToString());
                listitem.SubItems.Add(dr["created_at"].ToString());
                listitem.SubItems.Add(dr["prix"].ToString());
                listeProduitsListView.Items.Add(listitem);
            }
        }

        private void rafraichir_TextBox()
        {
            identifiantTxtBox.Text = string.Empty;
            typeTxtBox.Text = string.Empty;
        }
    }
}
