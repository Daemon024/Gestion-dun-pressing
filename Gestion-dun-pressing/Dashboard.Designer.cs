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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.CAChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesProduitsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(658, 48);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(360, 37);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Que voulez-vous faire ? ";
            // 
            // statLbl
            // 
            this.statLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLbl.Location = new System.Drawing.Point(744, 406);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(195, 37);
            this.statLbl.TabIndex = 1;
            this.statLbl.Text = "Statistiques";
            // 
            // gererClientBtn
            // 
            this.gererClientBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererClientBtn.Location = new System.Drawing.Point(596, 127);
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
            this.gererProduitBtn.Location = new System.Drawing.Point(855, 127);
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
            this.gererEmployeBtn.Location = new System.Drawing.Point(596, 209);
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
            this.gererPrestationBtn.Location = new System.Drawing.Point(855, 209);
            this.gererPrestationBtn.Name = "gererPrestationBtn";
            this.gererPrestationBtn.Size = new System.Drawing.Size(225, 54);
            this.gererPrestationBtn.TabIndex = 5;
            this.gererPrestationBtn.Text = "Gérer les prestations";
            this.gererPrestationBtn.UseVisualStyleBackColor = false;
            this.gererPrestationBtn.Click += new System.EventHandler(this.gererPrestationBtn_Click);
            // 
            // CAChart
            // 
            chartArea11.Name = "ChartArea1";
            this.CAChart.ChartAreas.Add(chartArea11);
            this.CAChart.Location = new System.Drawing.Point(27, 505);
            this.CAChart.Name = "CAChart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Name = "ChiffreAffaire";
            this.CAChart.Series.Add(series11);
            this.CAChart.Size = new System.Drawing.Size(1021, 531);
            this.CAChart.TabIndex = 6;
            this.CAChart.Text = "Chiffre d\'affaire";
            title6.Name = "Vide pour le titre en label";
            this.CAChart.Titles.Add(title6);
            // 
            // typesProduitsChart
            // 
            chartArea12.Name = "ChartArea1";
            this.typesProduitsChart.ChartAreas.Add(chartArea12);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            legend6.Name = "Legend1";
            this.typesProduitsChart.Legends.Add(legend6);
            this.typesProduitsChart.Location = new System.Drawing.Point(1083, 505);
            this.typesProduitsChart.Name = "typesProduitsChart";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.LabelForeColor = System.Drawing.Color.White;
            series12.Legend = "Legend1";
            series12.Name = "TypesProduits";
            series12.YValuesPerPoint = 2;
            this.typesProduitsChart.Series.Add(series12);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
    }
}