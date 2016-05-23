namespace Gestion_dun_pressing
{
    partial class GestionProduits
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.identifiantTxtBox = new System.Windows.Forms.TextBox();
            this.identifiantLbl = new System.Windows.Forms.Label();
            this.listeProduitsListView = new System.Windows.Forms.ListView();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.validerBtn = new System.Windows.Forms.Button();
            this.typeLbl = new System.Windows.Forms.Label();
            this.titreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(935, 138);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 31);
            this.textBox6.TabIndex = 55;
            // 
            // identifiantTxtBox
            // 
            this.identifiantTxtBox.Location = new System.Drawing.Point(611, 138);
            this.identifiantTxtBox.Name = "identifiantTxtBox";
            this.identifiantTxtBox.Size = new System.Drawing.Size(164, 31);
            this.identifiantTxtBox.TabIndex = 52;
            // 
            // identifiantLbl
            // 
            this.identifiantLbl.AutoSize = true;
            this.identifiantLbl.Location = new System.Drawing.Point(488, 141);
            this.identifiantLbl.Name = "identifiantLbl";
            this.identifiantLbl.Size = new System.Drawing.Size(117, 25);
            this.identifiantLbl.TabIndex = 50;
            this.identifiantLbl.Text = "Identifiant :";
            // 
            // listeProduitsListView
            // 
            this.listeProduitsListView.Location = new System.Drawing.Point(53, 398);
            this.listeProduitsListView.Name = "listeProduitsListView";
            this.listeProduitsListView.Size = new System.Drawing.Size(1518, 651);
            this.listeProduitsListView.TabIndex = 48;
            this.listeProduitsListView.UseCompatibleStateImageBehavior = false;
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.Location = new System.Drawing.Point(949, 249);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(162, 46);
            this.supprimerBtn.TabIndex = 47;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = false;
            // 
            // modifierBtn
            // 
            this.modifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.modifierBtn.FlatAppearance.BorderSize = 0;
            this.modifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBtn.ForeColor = System.Drawing.Color.White;
            this.modifierBtn.Location = new System.Drawing.Point(730, 249);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(162, 46);
            this.modifierBtn.TabIndex = 46;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = false;
            // 
            // validerBtn
            // 
            this.validerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.validerBtn.FlatAppearance.BorderSize = 0;
            this.validerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerBtn.ForeColor = System.Drawing.Color.White;
            this.validerBtn.Location = new System.Drawing.Point(499, 249);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(162, 46);
            this.validerBtn.TabIndex = 45;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = false;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(855, 141);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(72, 25);
            this.typeLbl.TabIndex = 44;
            this.typeLbl.Text = "Type :";
            // 
            // titreLbl
            // 
            this.titreLbl.AutoSize = true;
            this.titreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLbl.Location = new System.Drawing.Point(575, 29);
            this.titreLbl.Name = "titreLbl";
            this.titreLbl.Size = new System.Drawing.Size(490, 59);
            this.titreLbl.TabIndex = 41;
            this.titreLbl.Text = "Gestion des produits";
            // 
            // GestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 1079);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.identifiantTxtBox);
            this.Controls.Add(this.identifiantLbl);
            this.Controls.Add(this.listeProduitsListView);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.titreLbl);
            this.MaximumSize = new System.Drawing.Size(1650, 1150);
            this.MinimumSize = new System.Drawing.Size(1650, 1150);
            this.Name = "GestionProduits";
            this.Text = "Gestion des produits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox identifiantTxtBox;
        private System.Windows.Forms.Label identifiantLbl;
        private System.Windows.Forms.ListView listeProduitsListView;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label titreLbl;
    }
}