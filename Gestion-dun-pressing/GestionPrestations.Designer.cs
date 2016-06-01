namespace Gestion_dun_pressing
{
    partial class GestionPrestations
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
            this.identifiantTxtBox = new System.Windows.Forms.TextBox();
            this.identifiantLbl = new System.Windows.Forms.Label();
            this.listePrestationsListView = new System.Windows.Forms.ListView();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.validerBtn = new System.Windows.Forms.Button();
            this.titreLbl = new System.Windows.Forms.Label();
            this.nomTxtBox = new System.Windows.Forms.TextBox();
            this.nomLbl = new System.Windows.Forms.Label();
            this.produitIdComboBox = new System.Windows.Forms.ComboBox();
            this.produitIdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // identifiantTxtBox
            // 
            this.identifiantTxtBox.Enabled = false;
            this.identifiantTxtBox.Location = new System.Drawing.Point(503, 132);
            this.identifiantTxtBox.Name = "identifiantTxtBox";
            this.identifiantTxtBox.Size = new System.Drawing.Size(164, 31);
            this.identifiantTxtBox.TabIndex = 63;
            // 
            // identifiantLbl
            // 
            this.identifiantLbl.AutoSize = true;
            this.identifiantLbl.Location = new System.Drawing.Point(380, 135);
            this.identifiantLbl.Name = "identifiantLbl";
            this.identifiantLbl.Size = new System.Drawing.Size(117, 25);
            this.identifiantLbl.TabIndex = 62;
            this.identifiantLbl.Text = "Identifiant :";
            // 
            // listePrestationsListView
            // 
            this.listePrestationsListView.Location = new System.Drawing.Point(36, 314);
            this.listePrestationsListView.Name = "listePrestationsListView";
            this.listePrestationsListView.Size = new System.Drawing.Size(1554, 727);
            this.listePrestationsListView.TabIndex = 61;
            this.listePrestationsListView.UseCompatibleStateImageBehavior = false;
            this.listePrestationsListView.View = System.Windows.Forms.View.Details;
            this.listePrestationsListView.SelectedIndexChanged += new System.EventHandler(this.listePrestationsListView_SelectedIndexChanged);
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.Location = new System.Drawing.Point(972, 218);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(162, 46);
            this.supprimerBtn.TabIndex = 60;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = false;
            this.supprimerBtn.Click += new System.EventHandler(this.supprimerBtn_Click_1);
            // 
            // modifierBtn
            // 
            this.modifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.modifierBtn.FlatAppearance.BorderSize = 0;
            this.modifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBtn.ForeColor = System.Drawing.Color.White;
            this.modifierBtn.Location = new System.Drawing.Point(753, 218);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(162, 46);
            this.modifierBtn.TabIndex = 59;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = false;
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click_1);
            // 
            // validerBtn
            // 
            this.validerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.validerBtn.FlatAppearance.BorderSize = 0;
            this.validerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerBtn.ForeColor = System.Drawing.Color.White;
            this.validerBtn.Location = new System.Drawing.Point(522, 218);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(162, 46);
            this.validerBtn.TabIndex = 58;
            this.validerBtn.Text = "Ajouter";
            this.validerBtn.UseVisualStyleBackColor = false;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click_1);
            // 
            // titreLbl
            // 
            this.titreLbl.AutoSize = true;
            this.titreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLbl.Location = new System.Drawing.Point(558, 30);
            this.titreLbl.Name = "titreLbl";
            this.titreLbl.Size = new System.Drawing.Size(558, 59);
            this.titreLbl.TabIndex = 56;
            this.titreLbl.Text = "Gestion des prestations";
            // 
            // nomTxtBox
            // 
            this.nomTxtBox.Location = new System.Drawing.Point(812, 132);
            this.nomTxtBox.Name = "nomTxtBox";
            this.nomTxtBox.Size = new System.Drawing.Size(164, 31);
            this.nomTxtBox.TabIndex = 67;
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(738, 135);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(68, 25);
            this.nomLbl.TabIndex = 66;
            this.nomLbl.Text = "Nom :";
            // 
            // produitIdComboBox
            // 
            this.produitIdComboBox.FormattingEnabled = true;
            this.produitIdComboBox.Location = new System.Drawing.Point(1124, 130);
            this.produitIdComboBox.Name = "produitIdComboBox";
            this.produitIdComboBox.Size = new System.Drawing.Size(164, 33);
            this.produitIdComboBox.TabIndex = 68;
            // 
            // produitIdLbl
            // 
            this.produitIdLbl.AutoSize = true;
            this.produitIdLbl.Location = new System.Drawing.Point(1026, 135);
            this.produitIdLbl.Name = "produitIdLbl";
            this.produitIdLbl.Size = new System.Drawing.Size(92, 25);
            this.produitIdLbl.TabIndex = 69;
            this.produitIdLbl.Text = "Produit :";
            // 
            // GestionPrestations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.produitIdLbl);
            this.Controls.Add(this.produitIdComboBox);
            this.Controls.Add(this.nomTxtBox);
            this.Controls.Add(this.nomLbl);
            this.Controls.Add(this.identifiantTxtBox);
            this.Controls.Add(this.identifiantLbl);
            this.Controls.Add(this.listePrestationsListView);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.titreLbl);
            this.MaximumSize = new System.Drawing.Size(1650, 1150);
            this.MinimumSize = new System.Drawing.Size(1650, 1150);
            this.Name = "GestionPrestations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer des prestations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionPrestations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox identifiantTxtBox;
        private System.Windows.Forms.Label identifiantLbl;
        private System.Windows.Forms.ListView listePrestationsListView;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Label titreLbl;
        private System.Windows.Forms.TextBox nomTxtBox;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.ComboBox produitIdComboBox;
        private System.Windows.Forms.Label produitIdLbl;
    }
}