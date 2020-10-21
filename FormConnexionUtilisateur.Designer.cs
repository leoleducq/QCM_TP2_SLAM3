namespace QCM
{
    partial class FormConnexionUtilisateur
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
            this.identifiant = new System.Windows.Forms.TextBox();
            this.pagedeconnexion = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotdepasse = new System.Windows.Forms.Label();
            this.motdepasse = new System.Windows.Forms.TextBox();
            this.boutonAnnuler1 = new System.Windows.Forms.Button();
            this.boutonValider1 = new System.Windows.Forms.Button();
            this.boutonQuitter1 = new System.Windows.Forms.Button();
            this.boutonRevenir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // identifiant
            // 
            this.identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiant.Location = new System.Drawing.Point(296, 146);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(216, 29);
            this.identifiant.TabIndex = 2;
            this.identifiant.TextChanged += new System.EventHandler(this.identifiant_TextChanged);
            // 
            // pagedeconnexion
            // 
            this.pagedeconnexion.AutoSize = true;
            this.pagedeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagedeconnexion.ForeColor = System.Drawing.Color.Red;
            this.pagedeconnexion.Location = new System.Drawing.Point(239, 28);
            this.pagedeconnexion.Name = "pagedeconnexion";
            this.pagedeconnexion.Size = new System.Drawing.Size(373, 31);
            this.pagedeconnexion.TabIndex = 3;
            this.pagedeconnexion.Text = "Page de connexion Utilisateur";
            this.pagedeconnexion.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(99, 146);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(128, 29);
            this.labelIdentifiant.TabIndex = 4;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // labelMotdepasse
            // 
            this.labelMotdepasse.AutoSize = true;
            this.labelMotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotdepasse.Location = new System.Drawing.Point(57, 218);
            this.labelMotdepasse.Name = "labelMotdepasse";
            this.labelMotdepasse.Size = new System.Drawing.Size(170, 29);
            this.labelMotdepasse.TabIndex = 7;
            this.labelMotdepasse.Text = "Mot de passe :";
            // 
            // motdepasse
            // 
            this.motdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdepasse.Location = new System.Drawing.Point(296, 219);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.PasswordChar = '*';
            this.motdepasse.Size = new System.Drawing.Size(216, 29);
            this.motdepasse.TabIndex = 8;
            // 
            // boutonAnnuler1
            // 
            this.boutonAnnuler1.ForeColor = System.Drawing.Color.Red;
            this.boutonAnnuler1.Location = new System.Drawing.Point(352, 373);
            this.boutonAnnuler1.Name = "boutonAnnuler1";
            this.boutonAnnuler1.Size = new System.Drawing.Size(128, 55);
            this.boutonAnnuler1.TabIndex = 9;
            this.boutonAnnuler1.Text = "ANNULER";
            this.boutonAnnuler1.UseVisualStyleBackColor = true;
            this.boutonAnnuler1.Click += new System.EventHandler(this.boutonAnnuler1_Click);
            // 
            // boutonValider1
            // 
            this.boutonValider1.ForeColor = System.Drawing.Color.Red;
            this.boutonValider1.Location = new System.Drawing.Point(637, 373);
            this.boutonValider1.Name = "boutonValider1";
            this.boutonValider1.Size = new System.Drawing.Size(128, 55);
            this.boutonValider1.TabIndex = 10;
            this.boutonValider1.Text = "VALIDER";
            this.boutonValider1.UseVisualStyleBackColor = true;
            this.boutonValider1.Click += new System.EventHandler(this.boutonValider_Click);
            // 
            // boutonQuitter1
            // 
            this.boutonQuitter1.ForeColor = System.Drawing.Color.Red;
            this.boutonQuitter1.Location = new System.Drawing.Point(62, 373);
            this.boutonQuitter1.Name = "boutonQuitter1";
            this.boutonQuitter1.Size = new System.Drawing.Size(128, 55);
            this.boutonQuitter1.TabIndex = 11;
            this.boutonQuitter1.Text = "QUITTER";
            this.boutonQuitter1.UseVisualStyleBackColor = true;
            this.boutonQuitter1.Click += new System.EventHandler(this.boutonQuitter1_Click);
            // 
            // boutonRevenir
            // 
            this.boutonRevenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRevenir.Location = new System.Drawing.Point(284, 72);
            this.boutonRevenir.Name = "boutonRevenir";
            this.boutonRevenir.Size = new System.Drawing.Size(246, 27);
            this.boutonRevenir.TabIndex = 21;
            this.boutonRevenir.Text = "Revenir à la sélection du mode";
            this.boutonRevenir.UseVisualStyleBackColor = true;
            this.boutonRevenir.Click += new System.EventHandler(this.boutonRevenir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.boutonRevenir);
            this.Controls.Add(this.boutonQuitter1);
            this.Controls.Add(this.boutonValider1);
            this.Controls.Add(this.boutonAnnuler1);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.labelMotdepasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.pagedeconnexion);
            this.Controls.Add(this.identifiant);
            this.Name = "Form1";
            this.Text = "Connexion Utilisateur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox identifiant;
        private System.Windows.Forms.Label pagedeconnexion;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotdepasse;
        private System.Windows.Forms.TextBox motdepasse;
        private System.Windows.Forms.Button boutonAnnuler1;
        private System.Windows.Forms.Button boutonValider1;
        private System.Windows.Forms.Button boutonQuitter1;
        private System.Windows.Forms.Button boutonRevenir;
    }
}

