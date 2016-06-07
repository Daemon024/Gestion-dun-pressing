namespace Gestion_dun_pressing
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.questionLbl = new System.Windows.Forms.Label();
            this.statLbl = new System.Windows.Forms.Label();
            this.gererClientBtn = new System.Windows.Forms.Button();
            this.gererProduitBtn = new System.Windows.Forms.Button();
            this.gererEmployeBtn = new System.Windows.Forms.Button();
            this.gererPrestationBtn = new System.Windows.Forms.Button();
            this.CAChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.typesProduitsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.caLbl = new System.Windows.Forms.Label();
            this.caLbl2 = new System.Windows.Forms.Label();
            this.typeProduitLbl2 = new System.Windows.Forms.Label();
            this.typeProduitLbl = new System.Windows.Forms.Label();
            this.gererTarifBtn = new System.Windows.Forms.Button();
            this.gererCommandeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CAChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesProduitsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(658, 26);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(360, 37);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Que voulez-vous faire ? ";
            // 
            // statLbl
            // 
            this.statLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLbl.Location = new System.Drawing.Point(746, 440);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(195, 37);
            this.statLbl.TabIndex = 1;
            this.statLbl.Text = "Statistiques";
            // 
            // gererClientBtn
            // 
            this.gererClientBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererClientBtn.Location = new System.Drawing.Point(596, 105);
            this.gererClientBtn.Name = "gererClientBtn";
            this.gererClientBtn.Size = new System.Drawing.Size(225, 54);
            this.gererClientBtn.TabIndex = 2;
            this.gererClientBtn.Text = "Gérer les clients";
            this.gererClientBtn.UseVisualStyleBackColor = false;
            this.gererClientBtn.Click += new System.EventHandler(this.gererClientBtn_Click);
            // 
            // gererProduitBtn
            // 
            this.gererProduitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererProduitBtn.Location = new System.Drawing.Point(855, 105);
            this.gererProduitBtn.Name = "gererProduitBtn";
            this.gererProduitBtn.Size = new System.Drawing.Size(225, 54);
            this.gererProduitBtn.TabIndex = 3;
            this.gererProduitBtn.Text = "Gérer les produits";
            this.gererProduitBtn.UseVisualStyleBackColor = false;
            this.gererProduitBtn.Click += new System.EventHandler(this.gererProduitBtn_Click);
            // 
            // gererEmployeBtn
            // 
            this.gererEmployeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererEmployeBtn.Location = new System.Drawing.Point(596, 187);
            this.gererEmployeBtn.Name = "gererEmployeBtn";
            this.gererEmployeBtn.Size = new System.Drawing.Size(225, 54);
            this.gererEmployeBtn.TabIndex = 4;
            this.gererEmployeBtn.Text = "Gérer les employés";
            this.gererEmployeBtn.UseVisualStyleBackColor = false;
            this.gererEmployeBtn.Click += new System.EventHandler(this.gererEmployeBtn_Click);
            // 
            // gererPrestationBtn
            // 
            this.gererPrestationBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererPrestationBtn.Location = new System.Drawing.Point(855, 187);
            this.gererPrestationBtn.Name = "gererPrestationBtn";
            this.gererPrestationBtn.Size = new System.Drawing.Size(225, 54);
            this.gererPrestationBtn.TabIndex = 5;
            this.gererPrestationBtn.Text = "Gérer les prestations";
            this.gererPrestationBtn.UseVisualStyleBackColor = false;
            this.gererPrestationBtn.Click += new System.EventHandler(this.gererPrestationBtn_Click);
            // 
            // CAChart
            // 
            chartArea9.Name = "ChartArea1";
            this.CAChart.ChartAreas.Add(chartArea9);
            this.CAChart.Location = new System.Drawing.Point(27, 505);
            this.CAChart.Name = "CAChart";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series9.Name = "ChiffreAffaire";
            this.CAChart.Series.Add(series9);
            this.CAChart.Size = new System.Drawing.Size(1021, 531);
            this.CAChart.TabIndex = 6;
            this.CAChart.Text = "Chiffre d\'affaire";
            title5.Name = "Vide pour le titre en label";
            this.CAChart.Titles.Add(title5);
            // 
            // typesProduitsChart
            // 
            chartArea10.Name = "ChartArea1";
            this.typesProduitsChart.ChartAreas.Add(chartArea10);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            legend5.Name = "Legend1";
            this.typesProduitsChart.Legends.Add(legend5);
            this.typesProduitsChart.Location = new System.Drawing.Point(1083, 505);
            this.typesProduitsChart.Name = "typesProduitsChart";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.LabelForeColor = System.Drawing.Color.White;
            series10.Legend = "Legend1";
            series10.Name = "TypesProduits";
            series10.YValuesPerPoint = 2;
            this.typesProduitsChart.Series.Add(series10);
            this.typesProduitsChart.Size = new System.Drawing.Size(511, 531);
            this.typesProduitsChart.TabIndex = 7;
            this.typesProduitsChart.Text = "Types de produits";
            // 
            // caLbl
            // 
            this.caLbl.AutoSize = true;
            this.caLbl.BackColor = System.Drawing.Color.White;
            this.caLbl.Location = new System.Drawing.Point(393, 521);
            this.caLbl.Name = "caLbl";
            this.caLbl.Size = new System.Drawing.Size(168, 25);
            this.caLbl.TabIndex = 8;
            this.caLbl.Text = "Chiffre d\'affaire |";
            // 
            // caLbl2
            // 
            this.caLbl2.AutoSize = true;
            this.caLbl2.BackColor = System.Drawing.Color.White;
            this.caLbl2.ForeColor = System.Drawing.Color.Silver;
            this.caLbl2.Location = new System.Drawing.Point(556, 521);
            this.caLbl2.Name = "caLbl2";
            this.caLbl2.Size = new System.Drawing.Size(153, 25);
            this.caLbl2.TabIndex = 9;
            this.caLbl2.Text = "Sur une année";
            // 
            // typeProduitLbl2
            // 
            this.typeProduitLbl2.AutoSize = true;
            this.typeProduitLbl2.BackColor = System.Drawing.Color.White;
            this.typeProduitLbl2.ForeColor = System.Drawing.Color.Silver;
            this.typeProduitLbl2.Location = new System.Drawing.Point(1365, 521);
            this.typeProduitLbl2.Name = "typeProduitLbl2";
            this.typeProduitLbl2.Size = new System.Drawing.Size(153, 25);
            this.typeProduitLbl2.TabIndex = 11;
            this.typeProduitLbl2.Text = "Sur une année";
            // 
            // typeProduitLbl
            // 
            this.typeProduitLbl.AutoSize = true;
            this.typeProduitLbl.BackColor = System.Drawing.Color.White;
            this.typeProduitLbl.Location = new System.Drawing.Point(1164, 521);
            this.typeProduitLbl.Name = "typeProduitLbl";
            this.typeProduitLbl.Size = new System.Drawing.Size(195, 25);
            this.typeProduitLbl.TabIndex = 10;
            this.typeProduitLbl.Text = "Types de produits |";
            // 
            // gererTarifBtn
            // 
            this.gererTarifBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererTarifBtn.Location = new System.Drawing.Point(855, 274);
            this.gererTarifBtn.Name = "gererTarifBtn";
            this.gererTarifBtn.Size = new System.Drawing.Size(225, 64);
            this.gererTarifBtn.TabIndex = 13;
            this.gererTarifBtn.Text = "Gérer les tarifs";
            this.gererTarifBtn.UseVisualStyleBackColor = false;
            this.gererTarifBtn.Click += new System.EventHandler(this.gererTarifBtn_Click);
            // 
            // gererCommandeBtn
            // 
            this.gererCommandeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererCommandeBtn.Location = new System.Drawing.Point(596, 271);
            this.gererCommandeBtn.Name = "gererCommandeBtn";
            this.gererCommandeBtn.Size = new System.Drawing.Size(225, 67);
            this.gererCommandeBtn.TabIndex = 12;
            this.gererCommandeBtn.Text = "Gérer les commandes";
            this.gererCommandeBtn.UseVisualStyleBackColor = false;
            this.gererCommandeBtn.Click += new System.EventHandler(this.gererCommandeBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.gererTarifBtn);
            this.Controls.Add(this.gererCommandeBtn);
            this.Controls.Add(this.typeProduitLbl2);
            this.Controls.Add(this.typeProduitLbl);
            this.Controls.Add(this.caLbl2);
            this.Controls.Add(this.caLbl);
            this.Controls.Add(this.typesProduitsChart);
            this.Controls.Add(this.CAChart);
            this.Controls.Add(this.gererPrestationBtn);
            this.Controls.Add(this.gererEmployeBtn);
            this.Controls.Add(this.gererProduitBtn);
            this.Controls.Add(this.gererClientBtn);
            this.Controls.Add(this.statLbl);
            this.Controls.Add(this.questionLbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1650, 1150);
            this.MinimumSize = new System.Drawing.Size(1650, 1150);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CAChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesProduitsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label statLbl;
        private System.Windows.Forms.Button gererClientBtn;
        private System.Windows.Forms.Button gererProduitBtn;
        private System.Windows.Forms.Button gererEmployeBtn;
        private System.Windows.Forms.Button gererPrestationBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart CAChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart typesProduitsChart;
        private System.Windows.Forms.Label caLbl;
        private System.Windows.Forms.Label caLbl2;
        private System.Windows.Forms.Label typeProduitLbl2;
        private System.Windows.Forms.Label typeProduitLbl;
        private System.Windows.Forms.Button gererTarifBtn;
        private System.Windows.Forms.Button gererCommandeBtn;
    }
}