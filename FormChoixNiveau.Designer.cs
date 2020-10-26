namespace QCM
{
    partial class FormChoixNiveau
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
            this.labelChoixNiveau = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.boutonRevenir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelBienvenue.ForeColor = System.Drawing.Color.Gold;
            this.labelBienvenue.Location = new System.Drawing.Point(226, 31);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(388, 32);
            this.labelBienvenue.TabIndex = 0;
            this.labelBienvenue.Text = "Bienvenue dans le QCM";
            // 
            // labelChoixNiveau
            // 
            this.labelChoixNiveau.AutoSize = true;
            this.labelChoixNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoixNiveau.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelChoixNiveau.Location = new System.Drawing.Point(292, 166);
            this.labelChoixNiveau.Name = "labelChoixNiveau";
            this.labelChoixNiveau.Size = new System.Drawing.Size(250, 29);
            this.labelChoixNiveau.TabIndex = 5;
            this.labelChoixNiveau.Text = "Choisissez un niveau :";
            this.labelChoixNiveau.Click += new System.EventHandler(this.labelChoixNiveau_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(164, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 98);
            this.button1.TabIndex = 14;
            this.button1.Text = "DÉBUTANT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(340, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 98);
            this.button2.TabIndex = 15;
            this.button2.Text = "CONFIRMÉ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(515, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 98);
            this.button3.TabIndex = 16;
            this.button3.Text = "EXPERT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // boutonRevenir
            // 
            this.boutonRevenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRevenir.Location = new System.Drawing.Point(296, 80);
            this.boutonRevenir.Name = "boutonRevenir";
            this.boutonRevenir.Size = new System.Drawing.Size(246, 27);
            this.boutonRevenir.TabIndex = 17;
            this.boutonRevenir.Text = "Revenir à la sélection du mode";
            this.boutonRevenir.UseVisualStyleBackColor = true;
            this.boutonRevenir.Click += new System.EventHandler(this.boutonRevenir_Click);
            // 
            // FormChoixNiveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boutonRevenir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelChoixNiveau);
            this.Controls.Add(this.labelBienvenue);
            this.Name = "FormChoixNiveau";
            this.Text = "Espace Utillisateur";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Label labelChoixNiveau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button boutonRevenir;
    }
}