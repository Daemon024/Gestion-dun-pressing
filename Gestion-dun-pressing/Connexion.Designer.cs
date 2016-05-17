namespace Gestion_dun_pressing
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.title2Lbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.mdpLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pressing";
            // 
            // title2Lbl
            // 
            this.title2Lbl.AutoSize = true;
            this.title2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2Lbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.title2Lbl.Location = new System.Drawing.Point(196, 96);
            this.title2Lbl.Name = "title2Lbl";
            this.title2Lbl.Size = new System.Drawing.Size(316, 70);
            this.title2Lbl.TabIndex = 1;
            this.title2Lbl.Text = "des Halles";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(156, 229);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(117, 25);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "Identifiant :";
            // 
            // mdpLbl
            // 
            this.mdpLbl.AutoSize = true;
            this.mdpLbl.Location = new System.Drawing.Point(119, 285);
            this.mdpLbl.Name = "mdpLbl";
            this.mdpLbl.Size = new System.Drawing.Size(154, 25);
            this.mdpLbl.TabIndex = 3;
            this.mdpLbl.Text = "Mot de passe :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 31);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 31);
            this.textBox2.TabIndex = 5;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(279, 347);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(174, 41);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.Text = "Se connecter";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 479);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mdpLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.title2Lbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title2Lbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label mdpLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button connectBtn;
    }
}

