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
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {
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
                listitem.SubItems.Add(dr["email"].ToString());
                listitem.SubItems.Add(dr["created_at"].ToString());
                listitem.SubItems.Add(dr["remember_token"].ToString());
                listitem.SubItems.Add(dr["updated_at"].ToString());
                listeClientsListView.Items.Add(listitem);
            }
        }
    }
}
