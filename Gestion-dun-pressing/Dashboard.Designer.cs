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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.questionLbl = new System.Windows.Forms.Label();
            this.statLbl = new System.Windows.Forms.Label();
            this.gererClientBtn = new System.Windows.Forms.Button();
            this.gererProduitBtn = new System.Windows.Forms.Button();
            this.gererEmployeBtn = new System.Windows.Forms.Button();
            this.gererPrestationBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(453, 35);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(360, 37);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Que voulez-vous faire ? ";
            // 
            // statLbl
            // 
            this.statLbl.AutoSize = true;
            this.statLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLbl.Location = new System.Drawing.Point(528, 427);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(182, 37);
            this.statLbl.TabIndex = 1;
            this.statLbl.Text = "Statistiques";
            // 
            // gererClientBtn
            // 
            this.gererClientBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererClientBtn.Location = new System.Drawing.Point(391, 133);
            this.gererClientBtn.Name = "gererClientBtn";
            this.gererClientBtn.Size = new System.Drawing.Size(225, 54);
            this.gererClientBtn.TabIndex = 2;
            this.gererClientBtn.Text = "Gérer les clients";
            this.gererClientBtn.UseVisualStyleBackColor = false;
            // 
            // gererProduitBtn
            // 
            this.gererProduitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererProduitBtn.Location = new System.Drawing.Point(650, 133);
            this.gererProduitBtn.Name = "gererProduitBtn";
            this.gererProduitBtn.Size = new System.Drawing.Size(225, 54);
            this.gererProduitBtn.TabIndex = 3;
            this.gererProduitBtn.Text = "Gérer les produits";
            this.gererProduitBtn.UseVisualStyleBackColor = false;
            // 
            // gererEmployeBtn
            // 
            this.gererEmployeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererEmployeBtn.Location = new System.Drawing.Point(391, 215);
            this.gererEmployeBtn.Name = "gererEmployeBtn";
            this.gererEmployeBtn.Size = new System.Drawing.Size(225, 54);
            this.gererEmployeBtn.TabIndex = 4;
            this.gererEmployeBtn.Text = "Gérer les employés";
            this.gererEmployeBtn.UseVisualStyleBackColor = false;
            // 
            // gererPrestationBtn
            // 
            this.gererPrestationBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gererPrestationBtn.Location = new System.Drawing.Point(650, 215);
            this.gererPrestationBtn.Name = "gererPrestationBtn";
            this.gererPrestationBtn.Size = new System.Drawing.Size(225, 54);
            this.gererPrestationBtn.TabIndex = 5;
            this.gererPrestationBtn.Text = "Gérer les prestations";
            this.gererPrestationBtn.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(44, 545);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(741, 369);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(814, 545);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(410, 369);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 992);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gererPrestationBtn);
            this.Controls.Add(this.gererEmployeBtn);
            this.Controls.Add(this.gererProduitBtn);
            this.Controls.Add(this.gererClientBtn);
            this.Controls.Add(this.statLbl);
            this.Controls.Add(this.questionLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}