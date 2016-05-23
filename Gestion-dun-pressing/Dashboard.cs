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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Jan", "10 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Fév", "5 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Mars", "3 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Avr", "23 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Mai", "1 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Juin", "15 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Juil", "13 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Août", "12 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Sept", "10 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Oct", "13 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Nov", "1 000");
            CAChart.Series["ChiffreAffaire"].Points.AddXY("Déc", "20 000");

            typesProduitsChart.Series["TypesProduits"].Points.Add(25);
            typesProduitsChart.Series["TypesProduits"].Points.Add(38);
            typesProduitsChart.Series["TypesProduits"].Points[0].LegendText = "Chemises";
            typesProduitsChart.Series["TypesProduits"].Points[0].AxisLabel = "25%";
            typesProduitsChart.Series["TypesProduits"].Points[1].LegendText = "Pantalons";
            typesProduitsChart.Series["TypesProduits"].Points[1].AxisLabel = "38%";
        }

        private void gererClientBtn_Click(object sender, EventArgs e)
        {
            GestionClients gestionClientsForm = new GestionClients();
            gestionClientsForm.Show();
        }

        private void gererEmployeBtn_Click(object sender, EventArgs e)
        {
            GestionEmployes gestionEmployesForm = new GestionEmployes();
            gestionEmployesForm.Show();
        }
    }
}
