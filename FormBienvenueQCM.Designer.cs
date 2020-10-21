namespace QCM
{
    partial class FormBienvenueQCM
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
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.boutonValider2 = new System.Windows.Forms.Button();
            this.boutonQuitter2 = new System.Windows.Forms.Button();
            this.labelchoixtheme = new System.Windows.Forms.Label();
            this.radioButtonGeographie = new System.Windows.Forms.RadioButton();
            this.radioButtonHistoire = new System.Windows.Forms.RadioButton();
            this.radioButtonMathematiques = new System.Windows.Forms.RadioButton();
            this.groupBoxTheme = new System.Windows.Forms.GroupBox();
            this.labelChoixNiveau = new System.Windows.Forms.Label();
            this.radioButtonDifficile = new System.Windows.Forms.RadioButton();
            this.radioButtonMoyen = new System.Windows.Forms.RadioButton();
            this.radioButtonFacile = new System.Windows.Forms.RadioButton();
            this.groupBoxNiveau = new System.Windows.Forms.GroupBox();
            this.groupBoxTheme.SuspendLayout();
            this.groupBoxNiveau.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Red;
            this.labelBienvenue.Location = new System.Drawing.Point(282, 34);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(273, 29);
            this.labelBienvenue.TabIndex = 0;
            this.labelBienvenue.Text = "Bienvenue dans le QCM";
            // 
            // boutonValider2
            // 
            this.boutonValider2.ForeColor = System.Drawing.Color.Red;
            this.boutonValider2.Location = new System.Drawing.Point(591, 363);
            this.boutonValider2.Name = "boutonValider2";
            this.boutonValider2.Size = new System.Drawing.Size(128, 55);
            this.boutonValider2.TabIndex = 11;
            this.boutonValider2.Text = "VALIDER";
            this.boutonValider2.UseVisualStyleBackColor = true;
            // 
            // boutonQuitter2
            // 
            this.boutonQuitter2.ForeColor = System.Drawing.Color.Red;
            this.boutonQuitter2.Location = new System.Drawing.Point(80, 363);
            this.boutonQuitter2.Name = "boutonQuitter2";
            this.boutonQuitter2.Size = new System.Drawing.Size(128, 55);
            this.boutonQuitter2.TabIndex = 13;
            this.boutonQuitter2.Text = "QUITTER";
            this.boutonQuitter2.UseVisualStyleBackColor = true;
            this.boutonQuitter2.Click += new System.EventHandler(this.boutonQuitter2_Click);
            // 
            // labelchoixtheme
            // 
            this.labelchoixtheme.AutoSize = true;
            this.labelchoixtheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchoixtheme.Location = new System.Drawing.Point(75, 132);
            this.labelchoixtheme.Name = "labelchoixtheme";
            this.labelchoixtheme.Size = new System.Drawing.Size(247, 29);
            this.labelchoixtheme.TabIndex = 1;
            this.labelchoixtheme.Text = "Choisissez un thème :";
            this.labelchoixtheme.Click += new System.EventHandler(this.labelchoixtheme_Click);
            // 
            // radioButtonGeographie
            // 
            this.radioButtonGeographie.AutoSize = true;
            this.radioButtonGeographie.Location = new System.Drawing.Point(16, 122);
            this.radioButtonGeographie.Name = "radioButtonGeographie";
            this.radioButtonGeographie.Size = new System.Drawing.Size(80, 17);
            this.radioButtonGeographie.TabIndex = 3;
            this.radioButtonGeographie.TabStop = true;
            this.radioButtonGeographie.Text = "Géographie";
            this.radioButtonGeographie.UseVisualStyleBackColor = true;
            // 
            // radioButtonHistoire
            // 
            this.radioButtonHistoire.AutoSize = true;
            this.radioButtonHistoire.Location = new System.Drawing.Point(16, 79);
            this.radioButtonHistoire.Name = "radioButtonHistoire";
            this.radioButtonHistoire.Size = new System.Drawing.Size(60, 17);
            this.radioButtonHistoire.TabIndex = 4;
            this.radioButtonHistoire.TabStop = true;
            this.radioButtonHistoire.Text = "Histoire";
            this.radioButtonHistoire.UseVisualStyleBackColor = true;
            // 
            // radioButtonMathematiques
            // 
            this.radioButtonMathematiques.AutoSize = true;
            this.radioButtonMathematiques.Location = new System.Drawing.Point(16, 33);
            this.radioButtonMathematiques.Name = "radioButtonMathematiques";
            this.radioButtonMathematiques.Size = new System.Drawing.Size(97, 17);
            this.radioButtonMathematiques.TabIndex = 2;
            this.radioButtonMathematiques.TabStop = true;
            this.radioButtonMathematiques.Text = "Mathématiques";
            this.radioButtonMathematiques.UseVisualStyleBackColor = true;
            // 
            // groupBoxTheme
            // 
            this.groupBoxTheme.Controls.Add(this.radioButtonMathematiques);
            this.groupBoxTheme.Controls.Add(this.radioButtonHistoire);
            this.groupBoxTheme.Controls.Add(this.radioButtonGeographie);
            this.groupBoxTheme.Location = new System.Drawing.Point(80, 164);
            this.groupBoxTheme.Name = "groupBoxTheme";
            this.groupBoxTheme.Size = new System.Drawing.Size(242, 172);
            this.groupBoxTheme.TabIndex = 15;
            this.groupBoxTheme.TabStop = false;
            // 
            // labelChoixNiveau
            // 
            this.labelChoixNiveau.AutoSize = true;
            this.labelChoixNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoixNiveau.Location = new System.Drawing.Point(457, 132);
            this.labelChoixNiveau.Name = "labelChoixNiveau";
            this.labelChoixNiveau.Size = new System.Drawing.Size(250, 29);
            this.labelChoixNiveau.TabIndex = 5;
            this.labelChoixNiveau.Text = "Choisissez un niveau :";
            this.labelChoixNiveau.Click += new System.EventHandler(this.labelChoixNiveau_Click);
            // 
            // radioButtonDifficile
            // 
            this.radioButtonDifficile.AutoSize = true;
            this.radioButtonDifficile.Location = new System.Drawing.Point(12, 122);
            this.radioButtonDifficile.Name = "radioButtonDifficile";
            this.radioButtonDifficile.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDifficile.TabIndex = 6;
            this.radioButtonDifficile.TabStop = true;
            this.radioButtonDifficile.Text = "Difficile";
            this.radioButtonDifficile.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoyen
            // 
            this.radioButtonMoyen.AutoSize = true;
            this.radioButtonMoyen.Location = new System.Drawing.Point(12, 79);
            this.radioButtonMoyen.Name = "radioButtonMoyen";
            this.radioButtonMoyen.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMoyen.TabIndex = 7;
            this.radioButtonMoyen.TabStop = true;
            this.radioButtonMoyen.Text = "Moyen";
            this.radioButtonMoyen.UseVisualStyleBackColor = true;
            // 
            // radioButtonFacile
            // 
            this.radioButtonFacile.AutoSize = true;
            this.radioButtonFacile.Location = new System.Drawing.Point(12, 33);
            this.radioButtonFacile.Name = "radioButtonFacile";
            this.radioButtonFacile.Size = new System.Drawing.Size(53, 17);
            this.radioButtonFacile.TabIndex = 8;
            this.radioButtonFacile.TabStop = true;
            this.radioButtonFacile.Text = "Facile";
            this.radioButtonFacile.UseVisualStyleBackColor = true;
            // 
            // groupBoxNiveau
            // 
            this.groupBoxNiveau.Controls.Add(this.radioButtonFacile);
            this.groupBoxNiveau.Controls.Add(this.radioButtonMoyen);
            this.groupBoxNiveau.Controls.Add(this.radioButtonDifficile);
            this.groupBoxNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNiveau.Location = new System.Drawing.Point(462, 164);
            this.groupBoxNiveau.Name = "groupBoxNiveau";
            this.groupBoxNiveau.Size = new System.Drawing.Size(245, 172);
            this.groupBoxNiveau.TabIndex = 14;
            this.groupBoxNiveau.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTheme);
            this.Controls.Add(this.groupBoxNiveau);
            this.Controls.Add(this.boutonQuitter2);
            this.Controls.Add(this.boutonValider2);
            this.Controls.Add(this.labelChoixNiveau);
            this.Controls.Add(this.labelchoixtheme);
            this.Controls.Add(this.labelBienvenue);
            this.Name = "Form2";
            this.Text = "Espace Utillisateur";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxTheme.ResumeLayout(false);
            this.groupBoxTheme.PerformLayout();
            this.groupBoxNiveau.ResumeLayout(false);
            this.groupBoxNiveau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Button boutonValider2;
        private System.Windows.Forms.Button boutonQuitter2;
        private System.Windows.Forms.Label labelchoixtheme;
        private System.Windows.Forms.RadioButton radioButtonGeographie;
        private System.Windows.Forms.RadioButton radioButtonHistoire;
        private System.Windows.Forms.RadioButton radioButtonMathematiques;
        private System.Windows.Forms.GroupBox groupBoxTheme;
        private System.Windows.Forms.Label labelChoixNiveau;
        private System.Windows.Forms.RadioButton radioButtonDifficile;
        private System.Windows.Forms.RadioButton radioButtonMoyen;
        private System.Windows.Forms.RadioButton radioButtonFacile;
        private System.Windows.Forms.GroupBox groupBoxNiveau;
    }
}