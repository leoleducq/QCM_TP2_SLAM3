namespace QCM
{
    partial class FormMaintenanceQCM
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
            this.pagedeconnexion = new System.Windows.Forms.Label();
            this.boutonRevenir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pagedeconnexion
            // 
            this.pagedeconnexion.AutoSize = true;
            this.pagedeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagedeconnexion.ForeColor = System.Drawing.Color.Red;
            this.pagedeconnexion.Location = new System.Drawing.Point(275, 9);
            this.pagedeconnexion.Name = "pagedeconnexion";
            this.pagedeconnexion.Size = new System.Drawing.Size(276, 31);
            this.pagedeconnexion.TabIndex = 4;
            this.pagedeconnexion.Text = "Maintenance du QCM";
            // 
            // boutonRevenir
            // 
            this.boutonRevenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRevenir.Location = new System.Drawing.Point(291, 43);
            this.boutonRevenir.Name = "boutonRevenir";
            this.boutonRevenir.Size = new System.Drawing.Size(246, 27);
            this.boutonRevenir.TabIndex = 21;
            this.boutonRevenir.Text = "Revenir à la sélection du mode";
            this.boutonRevenir.UseVisualStyleBackColor = true;
            this.boutonRevenir.Click += new System.EventHandler(this.boutonRevenir_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boutonRevenir);
            this.Controls.Add(this.pagedeconnexion);
            this.Name = "Form5";
            this.Text = "Espace Administrateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pagedeconnexion;
        private System.Windows.Forms.Button boutonRevenir;
    }
}