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
        }

        private void GestionProduits_Load(object sender, EventArgs e)
        {
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
    }
}
