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
            this.commentaireTxtBox = new System.Windows.Forms.TextBox();
            this.commentaireLbl = new System.Windows.Forms.Label();
            this.clientLbl = new System.Windows.Forms.Label();
            this.employeLbl = new System.Windows.Forms.Label();
            this.typeServiceLbl = new System.Windows.Forms.Label();
            this.employeComboBox = new System.Windows.Forms.ComboBox();
            this.typeServiceComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // identifiantTxtBox
            // 
            this.identifiantTxtBox.Location = new System.Drawing.Point(480, 135);
            this.identifiantTxtBox.Name = "identifiantTxtBox";
            this.identifiantTxtBox.Size = new System.Drawing.Size(164, 31);
            this.identifiantTxtBox.TabIndex = 63;
            // 
            // identifiantLbl
            // 
            this.identifiantLbl.AutoSize = true;
            this.identifiantLbl.Location = new System.Drawing.Point(357, 138);
            this.identifiantLbl.Name = "identifiantLbl";
            this.identifiantLbl.Size = new System.Drawing.Size(117, 25);
            this.identifiantLbl.TabIndex = 62;
            this.identifiantLbl.Text = "Identifiant :";
            // 
            // listePrestationsListView
            // 
            this.listePrestationsListView.Location = new System.Drawing.Point(36, 390);
            this.listePrestationsListView.Name = "listePrestationsListView";
            this.listePrestationsListView.Size = new System.Drawing.Size(1554, 651);
            this.listePrestationsListView.TabIndex = 61;
            this.listePrestationsListView.UseCompatibleStateImageBehavior = false;
            this.listePrestationsListView.View = System.Windows.Forms.View.Details;
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.Location = new System.Drawing.Point(943, 299);
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
            this.modifierBtn.Location = new System.Drawing.Point(724, 299);
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
            this.validerBtn.Location = new System.Drawing.Point(493, 299);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(162, 46);
            this.validerBtn.TabIndex = 58;
            this.validerBtn.Text = "Valider";
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
            // commentaireTxtBox
            // 
            this.commentaireTxtBox.Location = new System.Drawing.Point(480, 198);
            this.commentaireTxtBox.Name = "commentaireTxtBox";
            this.commentaireTxtBox.Size = new System.Drawing.Size(164, 31);
            this.commentaireTxtBox.TabIndex = 67;
            // 
            // commentaireLbl
            // 
            this.commentaireLbl.AutoSize = true;
            this.commentaireLbl.Location = new System.Drawing.Point(323, 201);
            this.commentaireLbl.Name = "commentaireLbl";
            this.commentaireLbl.Size = new System.Drawing.Size(151, 25);
            this.commentaireLbl.TabIndex = 66;
            this.commentaireLbl.Text = "Commentaire :";
            // 
            // clientLbl
            // 
            this.clientLbl.AutoSize = true;
            this.clientLbl.Location = new System.Drawing.Point(783, 138);
            this.clientLbl.Name = "clientLbl";
            this.clientLbl.Size = new System.Drawing.Size(79, 25);
            this.clientLbl.TabIndex = 68;
            this.clientLbl.Text = "Client :";
            // 
            // employeLbl
            // 
            this.employeLbl.AutoSize = true;
            this.employeLbl.Location = new System.Drawing.Point(755, 199);
            this.employeLbl.Name = "employeLbl";
            this.employeLbl.Size = new System.Drawing.Size(107, 25);
            this.employeLbl.TabIndex = 69;
            this.employeLbl.Text = "Employé :";
            // 
            // typeServiceLbl
            // 
            this.typeServiceLbl.AutoSize = true;
            this.typeServiceLbl.Location = new System.Drawing.Point(1111, 170);
            this.typeServiceLbl.Name = "typeServiceLbl";
            this.typeServiceLbl.Size = new System.Drawing.Size(177, 25);
            this.typeServiceLbl.TabIndex = 70;
            this.typeServiceLbl.Text = "Type de service :";
            // 
            // employeComboBox
            // 
            this.employeComboBox.FormattingEnabled = true;
            this.employeComboBox.Location = new System.Drawing.Point(868, 196);
            this.employeComboBox.Name = "employeComboBox";
            this.employeComboBox.Size = new System.Drawing.Size(164, 33);
            this.employeComboBox.TabIndex = 71;
            // 
            // typeServiceComboBox
            // 
            this.typeServiceComboBox.FormattingEnabled = true;
            this.typeServiceComboBox.Location = new System.Drawing.Point(1294, 162);
            this.typeServiceComboBox.Name = "typeServiceComboBox";
            this.typeServiceComboBox.Size = new System.Drawing.Size(164, 33);
            this.typeServiceComboBox.TabIndex = 72;
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(868, 133);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(164, 33);
            this.clientComboBox.TabIndex = 73;
            // 
            // GestionPrestations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.typeServiceComboBox);
            this.Controls.Add(this.employeComboBox);
            this.Controls.Add(this.typeServiceLbl);
            this.Controls.Add(this.employeLbl);
            this.Controls.Add(this.clientLbl);
            this.Controls.Add(this.commentaireTxtBox);
            this.Controls.Add(this.commentaireLbl);
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
        private System.Windows.Forms.TextBox commentaireTxtBox;
        private System.Windows.Forms.Label commentaireLbl;
        private System.Windows.Forms.Label clientLbl;
        private System.Windows.Forms.Label employeLbl;
        private System.Windows.Forms.Label typeServiceLbl;
        private System.Windows.Forms.ComboBox employeComboBox;
        private System.Windows.Forms.ComboBox typeServiceComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
    }
}