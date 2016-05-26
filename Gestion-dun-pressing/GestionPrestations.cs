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
        }

        private void GestionPrestations_Load(object sender, EventArgs e)
        {
            DataTable lesPrestations = Prestation.prestations();
            for (int i = 0; i < lesPrestations.Rows.Count; i++)
            {
                DataRow dr = lesPrestations.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["dateDepot"].ToString());
                listitem.SubItems.Add(dr["dateRecuperation"].ToString());
                listitem.SubItems.Add(dr["pretPourRecuperation"].ToString());
                listitem.SubItems.Add(dr["libelle"].ToString());
                listePrestationsListView.Items.Add(listitem);
            }
        }
    }
}
