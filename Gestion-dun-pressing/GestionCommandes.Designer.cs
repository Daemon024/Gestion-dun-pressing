namespace Gestion_dun_pressing
{
    partial class GestionCommandes
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
            this.listeCommandesListView = new System.Windows.Forms.ListView();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.validerBtn = new System.Windows.Forms.Button();
            this.titreLbl = new System.Windows.Forms.Label();
            this.dateCreationPicker = new System.Windows.Forms.DateTimePicker();
            this.dateDepotPicker = new System.Windows.Forms.DateTimePicker();
            this.dateRecuperationPicker = new System.Windows.Forms.DateTimePicker();
            this.commentaireTxtBox = new System.Windows.Forms.TextBox();
            this.pretRecuperationComboBox = new System.Windows.Forms.ComboBox();
            this.pretRecuperationLbl = new System.Windows.Forms.Label();
            this.commentaireLbl = new System.Windows.Forms.Label();
            this.dateRecuperationLbl = new System.Windows.Forms.Label();
            this.dateDepotLbl = new System.Windows.Forms.Label();
            this.dateCreationLbl = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.prestationComboBox = new System.Windows.Forms.ComboBox();
            this.employeComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.employeLbl = new System.Windows.Forms.Label();
            this.clientLbl = new System.Windows.Forms.Label();
            this.prestationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listeCommandesListView
            // 
            this.listeCommandesListView.Location = new System.Drawing.Point(35, 406);
            this.listeCommandesListView.Name = "listeCommandesListView";
            this.listeCommandesListView.Size = new System.Drawing.Size(1554, 645);
            this.listeCommandesListView.TabIndex = 84;
            this.listeCommandesListView.UseCompatibleStateImageBehavior = false;
            this.listeCommandesListView.View = System.Windows.Forms.View.Details;
            this.listeCommandesListView.SelectedIndexChanged += new System.EventHandler(this.listeCommandesListView_SelectedIndexChanged);
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.Location = new System.Drawing.Point(973, 321);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(162, 46);
            this.supprimerBtn.TabIndex = 83;
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
            this.modifierBtn.Location = new System.Drawing.Point(754, 321);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(162, 46);
            this.modifierBtn.TabIndex = 82;
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
            this.validerBtn.Location = new System.Drawing.Point(523, 321);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(162, 46);
            this.validerBtn.TabIndex = 81;
            this.validerBtn.Text = "Ajouter";
            this.validerBtn.UseVisualStyleBackColor = false;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // titreLbl
            // 
            this.titreLbl.AutoSize = true;
            this.titreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLbl.Location = new System.Drawing.Point(536, 18);
            this.titreLbl.Name = "titreLbl";
            this.titreLbl.Size = new System.Drawing.Size(586, 59);
            this.titreLbl.TabIndex = 80;
            this.titreLbl.Text = "Gestion des commandes";
            // 
            // dateCreationPicker
            // 
            this.dateCreationPicker.Location = new System.Drawing.Point(385, 181);
            this.dateCreationPicker.Name = "dateCreationPicker";
            this.dateCreationPicker.Size = new System.Drawing.Size(200, 31);
            this.dateCreationPicker.TabIndex = 85;
            // 
            // dateDepotPicker
            // 
            this.dateDepotPicker.Location = new System.Drawing.Point(385, 237);
            this.dateDepotPicker.Name = "dateDepotPicker";
            this.dateDepotPicker.Size = new System.Drawing.Size(200, 31);
            this.dateDepotPicker.TabIndex = 86;
            // 
            // dateRecuperationPicker
            // 
            this.dateRecuperationPicker.Location = new System.Drawing.Point(871, 123);
            this.dateRecuperationPicker.Name = "dateRecuperationPicker";
            this.dateRecuperationPicker.Size = new System.Drawing.Size(200, 31);
            this.dateRecuperationPicker.TabIndex = 87;
            // 
            // commentaireTxtBox
            // 
            this.commentaireTxtBox.Location = new System.Drawing.Point(871, 181);
            this.commentaireTxtBox.Name = "commentaireTxtBox";
            this.commentaireTxtBox.Size = new System.Drawing.Size(200, 31);
            this.commentaireTxtBox.TabIndex = 88;
            // 
            // pretRecuperationComboBox
            // 
            this.pretRecuperationComboBox.FormattingEnabled = true;
            this.pretRecuperationComboBox.Location = new System.Drawing.Point(871, 239);
            this.pretRecuperationComboBox.Name = "pretRecuperationComboBox";
            this.pretRecuperationComboBox.Size = new System.Drawing.Size(200, 33);
            this.pretRecuperationComboBox.TabIndex = 89;
            // 
            // pretRecuperationLbl
            // 
            this.pretRecuperationLbl.AutoSize = true;
            this.pretRecuperationLbl.Location = new System.Drawing.Point(627, 242);
            this.pretRecuperationLbl.Name = "pretRecuperationLbl";
            this.pretRecuperationLbl.Size = new System.Drawing.Size(238, 25);
            this.pretRecuperationLbl.TabIndex = 90;
            this.pretRecuperationLbl.Text = "Prêt pour récupération :";
            // 
            // commentaireLbl
            // 
            this.commentaireLbl.AutoSize = true;
            this.commentaireLbl.Location = new System.Drawing.Point(714, 184);
            this.commentaireLbl.Name = "commentaireLbl";
            this.commentaireLbl.Size = new System.Drawing.Size(151, 25);
            this.commentaireLbl.TabIndex = 91;
            this.commentaireLbl.Text = "Commentaire :";
            // 
            // dateRecuperationLbl
            // 
            this.dateRecuperationLbl.AutoSize = true;
            this.dateRecuperationLbl.Location = new System.Drawing.Point(640, 126);
            this.dateRecuperationLbl.Name = "dateRecuperationLbl";
            this.dateRecuperationLbl.Size = new System.Drawing.Size(225, 25);
            this.dateRecuperationLbl.TabIndex = 92;
            this.dateRecuperationLbl.Text = "Date de récupération :";
            // 
            // dateDepotLbl
            // 
            this.dateDepotLbl.AutoSize = true;
            this.dateDepotLbl.Location = new System.Drawing.Point(220, 242);
            this.dateDepotLbl.Name = "dateDepotLbl";
            this.dateDepotLbl.Size = new System.Drawing.Size(159, 25);
            this.dateDepotLbl.TabIndex = 93;
            this.dateDepotLbl.Text = "Date de dépôt :";
            // 
            // dateCreationLbl
            // 
            this.dateCreationLbl.AutoSize = true;
            this.dateCreationLbl.Location = new System.Drawing.Point(197, 184);
            this.dateCreationLbl.Name = "dateCreationLbl";
            this.dateCreationLbl.Size = new System.Drawing.Size(182, 25);
            this.dateCreationLbl.TabIndex = 94;
            this.dateCreationLbl.Text = "Date de création :";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(385, 123);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(200, 31);
            this.idTxtBox.TabIndex = 95;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(262, 126);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(117, 25);
            this.idLbl.TabIndex = 96;
            this.idLbl.Text = "Identifiant :";
            // 
            // prestationComboBox
            // 
            this.prestationComboBox.FormattingEnabled = true;
            this.prestationComboBox.Location = new System.Drawing.Point(1270, 119);
            this.prestationComboBox.Name = "prestationComboBox";
            this.prestationComboBox.Size = new System.Drawing.Size(200, 33);
            this.prestationComboBox.TabIndex = 97;
            // 
            // employeComboBox
            // 
            this.employeComboBox.FormattingEnabled = true;
            this.employeComboBox.Location = new System.Drawing.Point(1270, 239);
            this.employeComboBox.Name = "employeComboBox";
            this.employeComboBox.Size = new System.Drawing.Size(200, 33);
            this.employeComboBox.TabIndex = 98;
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(1270, 183);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(200, 33);
            this.clientComboBox.TabIndex = 99;
            // 
            // employeLbl
            // 
            this.employeLbl.AutoSize = true;
            this.employeLbl.Location = new System.Drawing.Point(1157, 244);
            this.employeLbl.Name = "employeLbl";
            this.employeLbl.Size = new System.Drawing.Size(107, 25);
            this.employeLbl.TabIndex = 100;
            this.employeLbl.Text = "Employé :";
            // 
            // clientLbl
            // 
            this.clientLbl.AutoSize = true;
            this.clientLbl.Location = new System.Drawing.Point(1185, 188);
            this.clientLbl.Name = "clientLbl";
            this.clientLbl.Size = new System.Drawing.Size(79, 25);
            this.clientLbl.TabIndex = 101;
            this.clientLbl.Text = "Client :";
            // 
            // prestationLbl
            // 
            this.prestationLbl.AutoSize = true;
            this.prestationLbl.Location = new System.Drawing.Point(1143, 124);
            this.prestationLbl.Name = "prestationLbl";
            this.prestationLbl.Size = new System.Drawing.Size(121, 25);
            this.prestationLbl.TabIndex = 102;
            this.prestationLbl.Text = "Prestation :";
            // 
            // GestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.prestationLbl);
            this.Controls.Add(this.clientLbl);
            this.Controls.Add(this.employeLbl);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.employeComboBox);
            this.Controls.Add(this.prestationComboBox);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.dateCreationLbl);
            this.Controls.Add(this.dateDepotLbl);
            this.Controls.Add(this.dateRecuperationLbl);
            this.Controls.Add(this.commentaireLbl);
            this.Controls.Add(this.pretRecuperationLbl);
            this.Controls.Add(this.pretRecuperationComboBox);
            this.Controls.Add(this.commentaireTxtBox);
            this.Controls.Add(this.dateRecuperationPicker);
            this.Controls.Add(this.dateDepotPicker);
            this.Controls.Add(this.dateCreationPicker);
            this.Controls.Add(this.listeCommandesListView);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.titreLbl);
            this.MaximumSize = new System.Drawing.Size(1650, 1150);
            this.MinimumSize = new System.Drawing.Size(1650, 1150);
            this.Name = "GestionCommandes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer les commandes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionCommandes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listeCommandesListView;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Label titreLbl;
        private System.Windows.Forms.DateTimePicker dateCreationPicker;
        private System.Windows.Forms.DateTimePicker dateDepotPicker;
        private System.Windows.Forms.DateTimePicker dateRecuperationPicker;
        private System.Windows.Forms.TextBox commentaireTxtBox;
        private System.Windows.Forms.ComboBox pretRecuperationComboBox;
        private System.Windows.Forms.Label pretRecuperationLbl;
        private System.Windows.Forms.Label commentaireLbl;
        private System.Windows.Forms.Label dateRecuperationLbl;
        private System.Windows.Forms.Label dateDepotLbl;
        private System.Windows.Forms.Label dateCreationLbl;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.ComboBox prestationComboBox;
        private System.Windows.Forms.ComboBox employeComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label employeLbl;
        private System.Windows.Forms.Label clientLbl;
        private System.Windows.Forms.Label prestationLbl;
    }
}