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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.questionLbl = new System.Windows.Forms.Label();
            this.statLbl = new System.Windows.Forms.Label();
            this.gererClientBtn = new System.Windows.Forms.Button();
            this.gererProduitBtn = new System.Windows.Forms.Button();
            this.gererEmployeBtn = new System.Windows.Forms.Button();
            this.gererPrestationBtn = new System.Windows.Forms.Button();
            this.CAChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.typesProduitsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // 
            // CAChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CAChart.ChartAreas.Add(chartArea1);
            this.CAChart.Location = new System.Drawing.Point(27, 505);
            this.CAChart.Name = "CAChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "ChiffreAffaire";
            this.CAChart.Series.Add(series1);
            this.CAChart.Size = new System.Drawing.Size(1021, 531);
            this.CAChart.TabIndex = 6;
            this.CAChart.Text = "Chiffre d\'affaire";
            title1.Name = "Vide pour le titre en label";
            this.CAChart.Titles.Add(title1);
            // 
            // typesProduitsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.typesProduitsChart.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            this.typesProduitsChart.Legends.Add(legend1);
            this.typesProduitsChart.Location = new System.Drawing.Point(1083, 505);
            this.typesProduitsChart.Name = "typesProduitsChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "TypesProduits";
            series2.YValuesPerPoint = 2;
            this.typesProduitsChart.Series.Add(series2);
            this.typesProduitsChart.Size = new System.Drawing.Size(511, 531);
            this.typesProduitsChart.TabIndex = 7;
            this.typesProduitsChart.Text = "Types de produits";
            title2.Name = "Title1";
            title2.Text = "Types de produits";
            this.typesProduitsChart.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chiffre d\'affaire |";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(556, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sur une année";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}