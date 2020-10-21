namespace QCM
{
    partial class FormInscriptionUtilisateur
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
            this.boutonRevenir = new System.Windows.Forms.Button();
            this.boutonQuitter1 = new System.Windows.Forms.Button();
            this.boutonValider1 = new System.Windows.Forms.Button();
            this.boutonAnnuler1 = new System.Windows.Forms.Button();
            this.motdepasseInscription = new System.Windows.Forms.TextBox();
            this.labelMotdepasse = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.pagedeconnexion = new System.Windows.Forms.Label();
            this.identifiantInscription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boutonRevenir
            // 
            this.boutonRevenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRevenir.Location = new System.Drawing.Point(273, 69);
            this.boutonRevenir.Name = "boutonRevenir";
            this.boutonRevenir.Size = new System.Drawing.Size(246, 27);
            this.boutonRevenir.TabIndex = 30;
            this.boutonRevenir.Text = "Revenir à la sélection du mode";
            this.boutonRevenir.UseVisualStyleBackColor = true;
            this.boutonRevenir.Click += new System.EventHandler(this.boutonRevenir_Click);
            // 
            // boutonQuitter1
            // 
            this.boutonQuitter1.ForeColor = System.Drawing.Color.Red;
            this.boutonQuitter1.Location = new System.Drawing.Point(51, 370);
            this.boutonQuitter1.Name = "boutonQuitter1";
            this.boutonQuitter1.Size = new System.Drawing.Size(128, 55);
            this.boutonQuitter1.TabIndex = 29;
            this.boutonQuitter1.Text = "QUITTER";
            this.boutonQuitter1.UseVisualStyleBackColor = true;
            this.boutonQuitter1.Click += new System.EventHandler(this.boutonQuitter1_Click);
            // 
            // boutonValider1
            // 
            this.boutonValider1.ForeColor = System.Drawing.Color.Red;
            this.boutonValider1.Location = new System.Drawing.Point(626, 370);
            this.boutonValider1.Name = "boutonValider1";
            this.boutonValider1.Size = new System.Drawing.Size(128, 55);
            this.boutonValider1.TabIndex = 28;
            this.boutonValider1.Text = "VALIDER";
            this.boutonValider1.UseVisualStyleBackColor = true;
            this.boutonValider1.Click += new System.EventHandler(this.boutonValider1_Click);
            // 
            // boutonAnnuler1
            // 
            this.boutonAnnuler1.ForeColor = System.Drawing.Color.Red;
            this.boutonAnnuler1.Location = new System.Drawing.Point(341, 370);
            this.boutonAnnuler1.Name = "boutonAnnuler1";
            this.boutonAnnuler1.Size = new System.Drawing.Size(128, 55);
            this.boutonAnnuler1.TabIndex = 27;
            this.boutonAnnuler1.Text = "ANNULER";
            this.boutonAnnuler1.UseVisualStyleBackColor = true;
            this.boutonAnnuler1.Click += new System.EventHandler(this.boutonAnnuler1_Click);
            // 
            // motdepasseInscription
            // 
            this.motdepasseInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdepasseInscription.Location = new System.Drawing.Point(285, 216);
            this.motdepasseInscription.Name = "motdepasseInscription";
            this.motdepasseInscription.PasswordChar = '*';
            this.motdepasseInscription.Size = new System.Drawing.Size(216, 29);
            this.motdepasseInscription.TabIndex = 26;
            // 
            // labelMotdepasse
            // 
            this.labelMotdepasse.AutoSize = true;
            this.labelMotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotdepasse.Location = new System.Drawing.Point(46, 215);
            this.labelMotdepasse.Name = "labelMotdepasse";
            this.labelMotdepasse.Size = new System.Drawing.Size(170, 29);
            this.labelMotdepasse.TabIndex = 25;
            this.labelMotdepasse.Text = "Mot de passe :";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(88, 143);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(128, 29);
            this.labelIdentifiant.TabIndex = 24;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // pagedeconnexion
            // 
            this.pagedeconnexion.AutoSize = true;
            this.pagedeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagedeconnexion.ForeColor = System.Drawing.Color.Red;
            this.pagedeconnexion.Location = new System.Drawing.Point(228, 25);
            this.pagedeconnexion.Name = "pagedeconnexion";
            this.pagedeconnexion.Size = new System.Drawing.Size(356, 31);
            this.pagedeconnexion.TabIndex = 23;
            this.pagedeconnexion.Text = "Page d\'inscription Utilisateur";
            // 
            // identifiantInscription
            // 
            this.identifiantInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantInscription.Location = new System.Drawing.Point(285, 143);
            this.identifiantInscription.Name = "identifiantInscription";
            this.identifiantInscription.Size = new System.Drawing.Size(216, 29);
            this.identifiantInscription.TabIndex = 22;
            // 
            // FormInscriptionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boutonRevenir);
            this.Controls.Add(this.boutonQuitter1);
            this.Controls.Add(this.boutonValider1);
            this.Controls.Add(this.boutonAnnuler1);
            this.Controls.Add(this.motdepasseInscription);
            this.Controls.Add(this.labelMotdepasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.pagedeconnexion);
            this.Controls.Add(this.identifiantInscription);
            this.Name = "FormInscriptionUtilisateur";
            this.Text = "Inscription Utilisateur";
            this.Load += new System.EventHandler(this.FormInscriptionUtilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRevenir;
        private System.Windows.Forms.Button boutonQuitter1;
        private System.Windows.Forms.Button boutonValider1;
        private System.Windows.Forms.Button boutonAnnuler1;
        private System.Windows.Forms.TextBox motdepasseInscription;
        private System.Windows.Forms.Label labelMotdepasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label pagedeconnexion;
        private System.Windows.Forms.TextBox identifiantInscription;
    }
}