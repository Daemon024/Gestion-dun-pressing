﻿using System;
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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            GestionBDD.connexion();
            Dashboard dashboardWindow = new Dashboard();
            dashboardWindow.ShowDialog();
            this.Close();
        }
    }
}
