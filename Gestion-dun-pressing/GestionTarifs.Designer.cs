namespace Gestion_dun_pressing
{
    partial class GestionTarifs
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
            this.tarifTxtBox = new System.Windows.Forms.TextBox();
            this.tarifLbl = new System.Windows.Forms.Label();
            this.prestationLbl = new System.Windows.Forms.Label();
            this.listeTarifsListView = new System.Windows.Forms.ListView();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.validerBtn = new System.Windows.Forms.Button();
            this.titreLbl = new System.Windows.Forms.Label();
            this.prestationComboBox = new System.Windows.Forms.ComboBox();
            this.produitComboBox = new System.Windows.Forms.ComboBox();
            this.produitLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tarifTxtBox
            // 
            this.tarifTxtBox.Location = new System.Drawing.Point(765, 189);
            this.tarifTxtBox.Name = "tarifTxtBox";
            this.tarifTxtBox.Size = new System.Drawing.Size(164, 31);
            this.tarifTxtBox.TabIndex = 76;
            // 
            // tarifLbl
            // 
            this.tarifLbl.AutoSize = true;
            this.tarifLbl.Location = new System.Drawing.Point(692, 192);
            this.tarifLbl.Name = "tarifLbl";
            this.tarifLbl.Size = new System.Drawing.Size(67, 25);
            this.tarifLbl.TabIndex = 75;
            this.tarifLbl.Text = "Tarif :";
            // 
            // prestationLbl
            // 
            this.prestationLbl.AutoSize = true;
            this.prestationLbl.Location = new System.Drawing.Point(510, 122);
            this.prestationLbl.Name = "prestationLbl";
            this.prestationLbl.Size = new System.Drawing.Size(127, 25);
            this.prestationLbl.TabIndex = 73;
            this.prestationLbl.Text = "Prestation : ";
            // 
            // listeTarifsListView
            // 
            this.listeTarifsListView.Location = new System.Drawing.Point(35, 318);
            this.listeTarifsListView.Name = "listeTarifsListView";
            this.listeTarifsListView.Size = new System.Drawing.Size(1554, 727);
            this.listeTarifsListView.TabIndex = 72;
            this.listeTarifsListView.UseCompatibleStateImageBehavior = false;
            this.listeTarifsListView.View = System.Windows.Forms.View.Details;
            this.listeTarifsListView.SelectedIndexChanged += new System.EventHandler(this.listeTarifsListView_SelectedIndexChanged);
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.Location = new System.Drawing.Point(971, 253);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(162, 46);
            this.supprimerBtn.TabIndex = 71;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = false;
            this.supprimerBtn.Click += new System.EventHandler(this.supprimerBtn_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.modifierBtn.FlatAppearance.BorderSize = 0;
            this.modifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBtn.ForeColor = System.Drawing.Color.White;
            this.modifierBtn.Location = new System.Drawing.Point(752, 253);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(162, 46);
            this.modifierBtn.TabIndex = 70;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = false;
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click);
            // 
            // validerBtn
            // 
            this.validerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.validerBtn.FlatAppearance.BorderSize = 0;
            this.validerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerBtn.ForeColor = System.Drawing.Color.White;
            this.validerBtn.Location = new System.Drawing.Point(521, 253);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(162, 46);
            this.validerBtn.TabIndex = 69;
            this.validerBtn.Text = "Ajouter";
            this.validerBtn.UseVisualStyleBackColor = false;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // titreLbl
            // 
            this.titreLbl.AutoSize = true;
            this.titreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLbl.Location = new System.Drawing.Point(623, 21);
            this.titreLbl.Name = "titreLbl";
            this.titreLbl.Size = new System.Drawing.Size(420, 59);
            this.titreLbl.TabIndex = 68;
            this.titreLbl.Text = "Gestion des tarifs";
            // 
            // prestationComboBox
            // 
            this.prestationComboBox.FormattingEnabled = true;
            this.prestationComboBox.Location = new System.Drawing.Point(643, 119);
            this.prestationComboBox.Name = "prestationComboBox";
            this.prestationComboBox.Size = new System.Drawing.Size(164, 33);
            this.prestationComboBox.TabIndex = 77;
            // 
            // produitComboBox
            // 
            this.produitComboBox.FormattingEnabled = true;
            this.produitComboBox.Location = new System.Drawing.Point(944, 117);
            this.produitComboBox.Name = "produitComboBox";
            this.produitComboBox.Size = new System.Drawing.Size(164, 33);
            this.produitComboBox.TabIndex = 78;
            // 
            // produitLbl
            // 
            this.produitLbl.AutoSize = true;
            this.produitLbl.Location = new System.Drawing.Point(846, 122);
            this.produitLbl.Name = "produitLbl";
            this.produitLbl.Size = new System.Drawing.Size(92, 25);
            this.produitLbl.TabIndex = 79;
            this.produitLbl.Text = "Produit :";
            // 
            // GestionTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.produitLbl);
            this.Controls.Add(this.produitComboBox);
            this.Controls.Add(this.prestationComboBox);
            this.Controls.Add(this.tarifTxtBox);
            this.Controls.Add(this.tarifLbl);
            this.Controls.Add(this.prestationLbl);
            this.Controls.Add(this.listeTarifsListView);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.titreLbl);
            this.MaximumSize = new System.Drawing.Size(1650, 1150);
            this.MinimumSize = new System.Drawing.Size(1650, 1150);
            this.Name = "GestionTarifs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer les tarifs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionTarifs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tarifTxtBox;
        private System.Windows.Forms.Label tarifLbl;
        private System.Windows.Forms.Label prestationLbl;
        private System.Windows.Forms.ListView listeTarifsListView;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Label titreLbl;
        private System.Windows.Forms.ComboBox prestationComboBox;
        private System.Windows.Forms.ComboBox produitComboBox;
        private System.Windows.Forms.Label produitLbl;
    }
}