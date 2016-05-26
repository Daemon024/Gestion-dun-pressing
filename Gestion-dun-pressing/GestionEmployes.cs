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
        }

        private void GestionEmployes_Load(object sender, EventArgs e)
        {
            DataTable lesEmployes = Employe.employes();
            for (int i = 0; i < lesEmployes.Rows.Count; i++)
            {
                DataRow dr = lesEmployes.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["nomEmploye"].ToString());
                listitem.SubItems.Add(dr["prenomEmploye"].ToString());
                listitem.SubItems.Add(dr["password"].ToString());
                listitem.SubItems.Add(dr["dateArrivee"].ToString());
                listitem.SubItems.Add(dr["typeContrat"].ToString());
                listitem.SubItems.Add(dr["salaire"].ToString());
                listeEmployesListView.Items.Add(listitem);
            }
        }
    }
}
