namespace Gestion_dun_pressing
{
    partial class GestionEmployes
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
            this.salaireTxtBox = new System.Windows.Forms.TextBox();
            this.prenomTxtBox = new System.Windows.Forms.TextBox();
            this.nomTxtBox = new System.Windows.Forms.TextBox();
            this.prenomLbl = new System.Windows.Forms.Label();
            this.nomLbl = new System.Windows.Forms.Label();
            this.listeEmployesListView = new System.Windows.Forms.ListView();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.validerBtn = new System.Windows.Forms.Button();
            this.telLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.villeLbl = new System.Windows.Forms.Label();
            this.titreLbl = new System.Windows.Forms.Label();
            this.dateArriveePicker = new System.Windows.Forms.DateTimePicker();
            this.typeContratComboBox = new System.Windows.Forms.ComboBox();
            this.identifiantTxtBox = new System.Windows.Forms.TextBox();
            this.identifiantLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salaireTxtBox
            // 
            this.salaireTxtBox.Location = new System.Drawing.Point(1010, 256);
            this.salaireTxtBox.Name = "salaireTxtBox";
            this.salaireTxtBox.Size = new System.Drawing.Size(164, 31);
            this.salaireTxtBox.TabIndex = 40;
            // 
            // prenomTxtBox
            // 
            this.prenomTxtBox.Location = new System.Drawing.Point(573, 253);
            this.prenomTxtBox.Name = "prenomTxtBox";
            this.prenomTxtBox.Size = new System.Drawing.Size(164, 31);
            this.prenomTxtBox.TabIndex = 36;
            // 
            // nomTxtBox
            // 
            this.nomTxtBox.Location = new System.Drawing.Point(573, 191);
            this.nomTxtBox.Name = "nomTxtBox";
            this.nomTxtBox.Size = new System.Drawing.Size(164, 31);
            this.nomTxtBox.TabIndex = 35;
            // 
            // prenomLbl
            // 
            this.prenomLbl.AutoSize = true;
            this.prenomLbl.Location = new System.Drawing.Point(467, 256);
            this.prenomLbl.Name = "prenomLbl";
            this.prenomLbl.Size = new System.Drawing.Size(98, 25);
            this.prenomLbl.TabIndex = 33;
            this.prenomLbl.Text = "Prénom :";
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(493, 194);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(74, 25);
            this.nomLbl.TabIndex = 32;
            this.nomLbl.Text = "Nom : ";
            // 
            // listeEmployesListView
            // 
            this.listeEmployesListView.Location = new System.Drawing.Point(53, 429);
            this.listeEmployesListView.Name = "listeEmployesListView";
            this.listeEmployesListView.Size = new System.Drawing.Size(1518, 620);
            this.listeEmployesListView.TabIndex = 30;
            this.listeEmployesListView.UseCompatibleStateImageBehavior = false;
            this.listeEmployesListView.View = System.Windows.Forms.View.Details;
            this.listeEmployesListView.SelectedIndexChanged += new System.EventHandler(this.listeEmployesListView_SelectedIndexChanged);
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.Location = new System.Drawing.Point(968, 356);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(162, 46);
            this.supprimerBtn.TabIndex = 29;
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
            this.modifierBtn.Location = new System.Drawing.Point(749, 356);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(162, 46);
            this.modifierBtn.TabIndex = 28;
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
            this.validerBtn.Location = new System.Drawing.Point(518, 356);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(162, 46);
            this.validerBtn.TabIndex = 27;
            this.validerBtn.Text = "Ajouter";
            this.validerBtn.UseVisualStyleBackColor = false;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // telLbl
            // 
            this.telLbl.AutoSize = true;
            this.telLbl.Location = new System.Drawing.Point(845, 138);
            this.telLbl.Name = "telLbl";
            this.telLbl.Size = new System.Drawing.Size(157, 25);
            this.telLbl.TabIndex = 26;
            this.telLbl.Text = "Date d\'arrivée :";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(911, 259);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(91, 25);
            this.emailLbl.TabIndex = 25;
            this.emailLbl.Text = "Salaire :";
            // 
            // villeLbl
            // 
            this.villeLbl.AutoSize = true;
            this.villeLbl.Location = new System.Drawing.Point(828, 200);
            this.villeLbl.Name = "villeLbl";
            this.villeLbl.Size = new System.Drawing.Size(174, 25);
            this.villeLbl.TabIndex = 24;
            this.villeLbl.Text = "Type de contrat :";
            // 
            // titreLbl
            // 
            this.titreLbl.AutoSize = true;
            this.titreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLbl.Location = new System.Drawing.Point(575, 29);
            this.titreLbl.Name = "titreLbl";
            this.titreLbl.Size = new System.Drawing.Size(527, 59);
            this.titreLbl.TabIndex = 22;
            this.titreLbl.Text = "Gestion des employés";
            // 
            // dateArriveePicker
            // 
            this.dateArriveePicker.Enabled = false;
            this.dateArriveePicker.Location = new System.Drawing.Point(1010, 138);
            this.dateArriveePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateArriveePicker.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateArriveePicker.Name = "dateArriveePicker";
            this.dateArriveePicker.Size = new System.Drawing.Size(164, 31);
            this.dateArriveePicker.TabIndex = 41;
            // 
            // typeContratComboBox
            // 
            this.typeContratComboBox.FormattingEnabled = true;
            this.typeContratComboBox.Items.AddRange(new object[] {
            "CDD",
            "CDI"});
            this.typeContratComboBox.Location = new System.Drawing.Point(1008, 197);
            this.typeContratComboBox.MaxLength = 3;
            this.typeContratComboBox.Name = "typeContratComboBox";
            this.typeContratComboBox.Size = new System.Drawing.Size(166, 33);
            this.typeContratComboBox.TabIndex = 42;
            // 
            // identifiantTxtBox
            // 
            this.identifiantTxtBox.Enabled = false;
            this.identifiantTxtBox.Location = new System.Drawing.Point(573, 132);
            this.identifiantTxtBox.Name = "identifiantTxtBox";
            this.identifiantTxtBox.ReadOnly = true;
            this.identifiantTxtBox.Size = new System.Drawing.Size(164, 31);
            this.identifiantTxtBox.TabIndex = 44;
            // 
            // identifiantLbl
            // 
            this.identifiantLbl.AutoSize = true;
            this.identifiantLbl.Location = new System.Drawing.Point(450, 135);
            this.identifiantLbl.Name = "identifiantLbl";
            this.identifiantLbl.Size = new System.Drawing.Size(117, 25);
            this.identifiantLbl.TabIndex = 43;
            this.identifiantLbl.Text = "Identifiant :";
            // 
            // GestionEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.identifiantTxtBox);
            this.Controls.Add(this.identifiantLbl);
            this.Controls.Add(this.typeContratComboBox);
            this.Controls.Add(this.dateArriveePicker);
            this.Controls.Add(this.salaireTxtBox);
            this.Controls.Add(this.prenomTxtBox);
            this.Controls.Add(this.nomTxtBox);
            this.Controls.Add(this.prenomLbl);
            this.Controls.Add(this.nomLbl);
            this.Controls.Add(this.listeEmployesListView);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.telLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.villeLbl);
            this.Controls.Add(this.titreLbl);
            this.MaximumSize = new System.Drawing.Size(1650, 1150);
            this.MinimumSize = new System.Drawing.Size(1650, 1150);
            this.Name = "GestionEmployes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer les employés";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionEmployes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salaireTxtBox;
        private System.Windows.Forms.TextBox prenomTxtBox;
        private System.Windows.Forms.TextBox nomTxtBox;
        private System.Windows.Forms.Label prenomLbl;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.ListView listeEmployesListView;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Label telLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label villeLbl;
        private System.Windows.Forms.Label titreLbl;
        private System.Windows.Forms.DateTimePicker dateArriveePicker;
        private System.Windows.Forms.ComboBox typeContratComboBox;
        private System.Windows.Forms.TextBox identifiantTxtBox;
        private System.Windows.Forms.Label identifiantLbl;
    }
}