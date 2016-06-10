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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GestionBDD.connexion();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataTable chartCA = GestionBDD.selectPerso("CALL recuperer_statsCA");
            for (var j = 0; j < chartCA.Rows.Count; j++)
            {
                DataRow dr = chartCA.Rows[j];
                CAChart.Series["ChiffreAffaire"].Points.AddXY(dr["Mois"].ToString(), dr["CA"].ToString());
            }

            DataTable statsProduits = GestionBDD.selectPerso("CALL recuperer_statsProduits");
            for (var j = 0; j < statsProduits.Rows.Count; j++)
            {
                DataRow dr = statsProduits.Rows[j];
                typesProduitsChart.Series["TypesProduits"].Points.Add(Convert.ToInt32(dr["Total"].ToString()));
                typesProduitsChart.Series["TypesProduits"].Points[j].Label = dr["Total"].ToString();
                typesProduitsChart.Series["TypesProduits"].Points[j].LegendText = dr["Produit"].ToString();
            }
        }

        private void gererClientBtn_Click(object sender, EventArgs e)
        {
            GestionClients gestionClientsForm = new GestionClients();
            gestionClientsForm.ShowDialog();
        }

        private void gererEmployeBtn_Click(object sender, EventArgs e)
        {
            GestionEmployes gestionEmployesForm = new GestionEmployes();
            gestionEmployesForm.ShowDialog();
        }

        private void gererProduitBtn_Click(object sender, EventArgs e)
        {
            GestionProduits gestionProduitsForm = new GestionProduits();
            gestionProduitsForm.ShowDialog();
        }

        private void gererPrestationBtn_Click(object sender, EventArgs e)
        {
            GestionPrestations gestionPrestationsForm = new GestionPrestations();
            gestionPrestationsForm.ShowDialog();
        }

        private void gererCommandeBtn_Click(object sender, EventArgs e)
        {
            GestionCommandes gestionCommandesForm = new GestionCommandes();
            gestionCommandesForm.ShowDialog();
        }

        private void gererTarifBtn_Click(object sender, EventArgs e)
        {
            GestionTarifs gestionTarifsForm = new GestionTarifs();
            gestionTarifsForm.ShowDialog();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestionBDD.deconnexion();
        }
    }
}
