﻿namespace QCM
{
    partial class FormConnexionAdministrateur
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
            this.boutonQuitter4 = new System.Windows.Forms.Button();
            this.boutonValider4 = new System.Windows.Forms.Button();
            this.boutonAnnuler4 = new System.Windows.Forms.Button();
            this.motdepasseadministrateur = new System.Windows.Forms.TextBox();
            this.labelMotdepasse = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.pagedeconnexionadministrateur = new System.Windows.Forms.Label();
            this.identifiantadministrateur = new System.Windows.Forms.TextBox();
            this.boutonRevenir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonQuitter4
            // 
            this.boutonQuitter4.ForeColor = System.Drawing.Color.Red;
            this.boutonQuitter4.Location = new System.Drawing.Point(51, 366);
            this.boutonQuitter4.Name = "boutonQuitter4";
            this.boutonQuitter4.Size = new System.Drawing.Size(128, 55);
            this.boutonQuitter4.TabIndex = 19;
            this.boutonQuitter4.Text = "QUITTER";
            this.boutonQuitter4.UseVisualStyleBackColor = true;
            this.boutonQuitter4.Click += new System.EventHandler(this.boutonQuitter4_Click);
            // 
            // boutonValider4
            // 
            this.boutonValider4.ForeColor = System.Drawing.Color.Red;
            this.boutonValider4.Location = new System.Drawing.Point(626, 366);
            this.boutonValider4.Name = "boutonValider4";
            this.boutonValider4.Size = new System.Drawing.Size(128, 55);
            this.boutonValider4.TabIndex = 18;
            this.boutonValider4.Text = "VALIDER";
            this.boutonValider4.UseVisualStyleBackColor = true;
            this.boutonValider4.Click += new System.EventHandler(this.boutonValider4_Click);
            // 
            // boutonAnnuler4
            // 
            this.boutonAnnuler4.ForeColor = System.Drawing.Color.Red;
            this.boutonAnnuler4.Location = new System.Drawing.Point(341, 366);
            this.boutonAnnuler4.Name = "boutonAnnuler4";
            this.boutonAnnuler4.Size = new System.Drawing.Size(128, 55);
            this.boutonAnnuler4.TabIndex = 17;
            this.boutonAnnuler4.Text = "ANNULER";
            this.boutonAnnuler4.UseVisualStyleBackColor = true;
            this.boutonAnnuler4.Click += new System.EventHandler(this.boutonAnnuler4_Click);
            // 
            // motdepasseadministrateur
            // 
            this.motdepasseadministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdepasseadministrateur.Location = new System.Drawing.Point(285, 212);
            this.motdepasseadministrateur.Name = "motdepasseadministrateur";
            this.motdepasseadministrateur.PasswordChar = '*';
            this.motdepasseadministrateur.Size = new System.Drawing.Size(216, 29);
            this.motdepasseadministrateur.TabIndex = 16;
            // 
            // labelMotdepasse
            // 
            this.labelMotdepasse.AutoSize = true;
            this.labelMotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotdepasse.Location = new System.Drawing.Point(46, 211);
            this.labelMotdepasse.Name = "labelMotdepasse";
            this.labelMotdepasse.Size = new System.Drawing.Size(170, 29);
            this.labelMotdepasse.TabIndex = 15;
            this.labelMotdepasse.Text = "Mot de passe :";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(88, 139);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(128, 29);
            this.labelIdentifiant.TabIndex = 14;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // pagedeconnexionadministrateur
            // 
            this.pagedeconnexionadministrateur.AutoSize = true;
            this.pagedeconnexionadministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagedeconnexionadministrateur.ForeColor = System.Drawing.Color.Red;
            this.pagedeconnexionadministrateur.Location = new System.Drawing.Point(205, 28);
            this.pagedeconnexionadministrateur.Name = "pagedeconnexionadministrateur";
            this.pagedeconnexionadministrateur.Size = new System.Drawing.Size(426, 31);
            this.pagedeconnexionadministrateur.TabIndex = 13;
            this.pagedeconnexionadministrateur.Text = "Page de connexion Administrateur";
            // 
            // identifiantadministrateur
            // 
            this.identifiantadministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantadministrateur.Location = new System.Drawing.Point(285, 139);
            this.identifiantadministrateur.Name = "identifiantadministrateur";
            this.identifiantadministrateur.Size = new System.Drawing.Size(216, 29);
            this.identifiantadministrateur.TabIndex = 12;
            // 
            // boutonRevenir
            // 
            this.boutonRevenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRevenir.Location = new System.Drawing.Point(269, 71);
            this.boutonRevenir.Name = "boutonRevenir";
            this.boutonRevenir.Size = new System.Drawing.Size(246, 27);
            this.boutonRevenir.TabIndex = 20;
            this.boutonRevenir.Text = "Revenir à la sélection du mode";
            this.boutonRevenir.UseVisualStyleBackColor = true;
            this.boutonRevenir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boutonRevenir);
            this.Controls.Add(this.boutonQuitter4);
            this.Controls.Add(this.boutonValider4);
            this.Controls.Add(this.boutonAnnuler4);
            this.Controls.Add(this.motdepasseadministrateur);
            this.Controls.Add(this.labelMotdepasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.pagedeconnexionadministrateur);
            this.Controls.Add(this.identifiantadministrateur);
            this.Name = "Form4";
            this.Text = "Connexion Administrateur";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonQuitter4;
        private System.Windows.Forms.Button boutonValider4;
        private System.Windows.Forms.Button boutonAnnuler4;
        private System.Windows.Forms.TextBox motdepasseadministrateur;
        private System.Windows.Forms.Label labelMotdepasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label pagedeconnexionadministrateur;
        private System.Windows.Forms.TextBox identifiantadministrateur;
        private System.Windows.Forms.Button boutonRevenir;
    }
}