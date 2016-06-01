namespace Gestion_dun_pressing
{
    partial class GestionClients
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
            this.titreLbl = new System.Windows.Forms.Label();
            this.codePostalLbl = new System.Windows.Forms.Label();
            this.villeLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.validerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.listeClientsListView = new System.Windows.Forms.ListView();
            this.telLbl = new System.Windows.Forms.Label();
            this.adresseLbl = new System.Windows.Forms.Label();
            this.prenomLbl = new System.Windows.Forms.Label();
            this.nomLbl = new System.Windows.Forms.Label();
            this.nomTxtBox = new System.Windows.Forms.TextBox();
            this.prenomTxtBox = new System.Windows.Forms.TextBox();
            this.telTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.villeTxtBox = new System.Windows.Forms.TextBox();
            this.codePostalTxtBox = new System.Windows.Forms.TextBox();
            this.adresseTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.mdpTxtBox = new System.Windows.Forms.TextBox();
            this.mdpLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titreLbl
            // 
            this.titreLbl.AutoSize = true;
            this.titreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLbl.Location = new System.Drawing.Point(596, 9);
            this.titreLbl.Name = "titreLbl";
            this.titreLbl.Size = new System.Drawing.Size(454, 59);
            this.titreLbl.TabIndex = 0;
            this.titreLbl.Text = "Gestion des clients";
            // 
            // codePostalLbl
            // 
            this.codePostalLbl.AutoSize = true;
            this.codePostalLbl.Location = new System.Drawing.Point(632, 200);
            this.codePostalLbl.Name = "codePostalLbl";
            this.codePostalLbl.Size = new System.Drawing.Size(139, 25);
            this.codePostalLbl.TabIndex = 1;
            this.codePostalLbl.Text = "Code postal :";
            // 
            // villeLbl
            // 
            this.villeLbl.AutoSize = true;
            this.villeLbl.Location = new System.Drawing.Point(705, 259);
            this.villeLbl.Name = "villeLbl";
            this.villeLbl.Size = new System.Drawing.Size(65, 25);
            this.villeLbl.TabIndex = 2;
            this.villeLbl.Text = "Ville :";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(1083, 138);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(77, 25);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email :";
            // 
            // validerBtn
            // 
            this.validerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.validerBtn.FlatAppearance.BorderSize = 0;
            this.validerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerBtn.ForeColor = System.Drawing.Color.White;
            this.validerBtn.Location = new System.Drawing.Point(512, 355);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(162, 46);
            this.validerBtn.TabIndex = 10;
            this.validerBtn.Text = "Ajouter";
            this.validerBtn.UseVisualStyleBackColor = false;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.modifierBtn.FlatAppearance.BorderSize = 0;
            this.modifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBtn.ForeColor = System.Drawing.Color.White;
            this.modifierBtn.Location = new System.Drawing.Point(743, 355);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(162, 46);
            this.modifierBtn.TabIndex = 11;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = false;
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click);
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.Location = new System.Drawing.Point(962, 355);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(162, 46);
            this.supprimerBtn.TabIndex = 12;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = false;
            this.supprimerBtn.Click += new System.EventHandler(this.supprimerBtn_Click);
            // 
            // listeClientsListView
            // 
            this.listeClientsListView.Location = new System.Drawing.Point(52, 448);
            this.listeClientsListView.Name = "listeClientsListView";
            this.listeClientsListView.Size = new System.Drawing.Size(1518, 592);
            this.listeClientsListView.TabIndex = 8;
            this.listeClientsListView.UseCompatibleStateImageBehavior = false;
            this.listeClientsListView.View = System.Windows.Forms.View.Details;
            this.listeClientsListView.SelectedIndexChanged += new System.EventHandler(this.listeClientsListView_SelectedIndexChanged);
            // 
            // telLbl
            // 
            this.telLbl.AutoSize = true;
            this.telLbl.Location = new System.Drawing.Point(1104, 203);
            this.telLbl.Name = "telLbl";
            this.telLbl.Size = new System.Drawing.Size(54, 25);
            this.telLbl.TabIndex = 9;
            this.telLbl.Text = "Tel :";
            // 
            // adresseLbl
            // 
            this.adresseLbl.AutoSize = true;
            this.adresseLbl.Location = new System.Drawing.Point(665, 138);
            this.adresseLbl.Name = "adresseLbl";
            this.adresseLbl.Size = new System.Drawing.Size(103, 25);
            this.adresseLbl.TabIndex = 13;
            this.adresseLbl.Text = "Adresse :";
            // 
            // prenomLbl
            // 
            this.prenomLbl.AutoSize = true;
            this.prenomLbl.Location = new System.Drawing.Point(303, 262);
            this.prenomLbl.Name = "prenomLbl";
            this.prenomLbl.Size = new System.Drawing.Size(98, 25);
            this.prenomLbl.TabIndex = 12;
            this.prenomLbl.Text = "Prénom :";
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(327, 203);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(74, 25);
            this.nomLbl.TabIndex = 11;
            this.nomLbl.Text = "Nom : ";
            // 
            // nomTxtBox
            // 
            this.nomTxtBox.Location = new System.Drawing.Point(407, 197);
            this.nomTxtBox.Name = "nomTxtBox";
            this.nomTxtBox.Size = new System.Drawing.Size(164, 31);
            this.nomTxtBox.TabIndex = 1;
            // 
            // prenomTxtBox
            // 
            this.prenomTxtBox.Location = new System.Drawing.Point(407, 256);
            this.prenomTxtBox.Name = "prenomTxtBox";
            this.prenomTxtBox.Size = new System.Drawing.Size(164, 31);
            this.prenomTxtBox.TabIndex = 2;
            // 
            // telTxtBox
            // 
            this.telTxtBox.Location = new System.Drawing.Point(1166, 200);
            this.telTxtBox.Name = "telTxtBox";
            this.telTxtBox.Size = new System.Drawing.Size(164, 31);
            this.telTxtBox.TabIndex = 7;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(1166, 135);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(166, 31);
            this.emailTxtBox.TabIndex = 6;
            // 
            // villeTxtBox
            // 
            this.villeTxtBox.Location = new System.Drawing.Point(776, 256);
            this.villeTxtBox.Name = "villeTxtBox";
            this.villeTxtBox.Size = new System.Drawing.Size(164, 31);
            this.villeTxtBox.TabIndex = 5;
            // 
            // codePostalTxtBox
            // 
            this.codePostalTxtBox.Location = new System.Drawing.Point(777, 197);
            this.codePostalTxtBox.Name = "codePostalTxtBox";
            this.codePostalTxtBox.Size = new System.Drawing.Size(164, 31);
            this.codePostalTxtBox.TabIndex = 4;
            // 
            // adresseTxtBox
            // 
            this.adresseTxtBox.Location = new System.Drawing.Point(777, 135);
            this.adresseTxtBox.Name = "adresseTxtBox";
            this.adresseTxtBox.Size = new System.Drawing.Size(164, 31);
            this.adresseTxtBox.TabIndex = 3;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(407, 135);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(164, 31);
            this.idTxtBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(278, 138);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(123, 25);
            this.IDLabel.TabIndex = 22;
            this.IDLabel.Text = "Identifiant : ";
            // 
            // mdpTxtBox
            // 
            this.mdpTxtBox.Location = new System.Drawing.Point(1166, 259);
            this.mdpTxtBox.Name = "mdpTxtBox";
            this.mdpTxtBox.PasswordChar = '*';
            this.mdpTxtBox.Size = new System.Drawing.Size(164, 31);
            this.mdpTxtBox.TabIndex = 8;
            // 
            // mdpLbl
            // 
            this.mdpLbl.AutoSize = true;
            this.mdpLbl.Location = new System.Drawing.Point(1006, 262);
            this.mdpLbl.Name = "mdpLbl";
            this.mdpLbl.Size = new System.Drawing.Size(154, 25);
            this.mdpLbl.TabIndex = 10;
            this.mdpLbl.Text = "Mot de passe :";
            // 
            // GestionClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.mdpTxtBox);
            this.Controls.Add(this.mdpLbl);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.codePostalTxtBox);
            this.Controls.Add(this.adresseTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.villeTxtBox);
            this.Controls.Add(this.telTxtBox);
            this.Controls.Add(this.prenomTxtBox);
            this.Controls.Add(this.nomTxtBox);
            this.Controls.Add(this.adresseLbl);
            this.Controls.Add(this.prenomLbl);
            this.Controls.Add(this.nomLbl);
            this.Controls.Add(this.telLbl);
            this.Controls.Add(this.listeClientsListView);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.villeLbl);
            this.Controls.Add(this.codePostalLbl);
            this.Controls.Add(this.titreLbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1650, 1150);
            this.MinimumSize = new System.Drawing.Size(1650, 1150);
            this.Name = "GestionClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gérer les clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreLbl;
        private System.Windows.Forms.Label codePostalLbl;
        private System.Windows.Forms.Label villeLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.ListView listeClientsListView;
        private System.Windows.Forms.Label telLbl;
        private System.Windows.Forms.Label adresseLbl;
        private System.Windows.Forms.Label prenomLbl;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.TextBox nomTxtBox;
        private System.Windows.Forms.TextBox prenomTxtBox;
        private System.Windows.Forms.TextBox telTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox villeTxtBox;
        private System.Windows.Forms.TextBox codePostalTxtBox;
        private System.Windows.Forms.TextBox adresseTxtBox;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label mdpLbl;
        private System.Windows.Forms.TextBox mdpTxtBox;
    }
}