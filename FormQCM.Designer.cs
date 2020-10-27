namespace QCM
{
    partial class FormQCM
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
            this.SuspendLayout();
            // 
            // pagedeconnexion
            // 
            this.pagedeconnexion.AutoSize = true;
            this.pagedeconnexion.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagedeconnexion.ForeColor = System.Drawing.Color.Gold;
            this.pagedeconnexion.Location = new System.Drawing.Point(359, 21);
            this.pagedeconnexion.Name = "pagedeconnexion";
            this.pagedeconnexion.Size = new System.Drawing.Size(82, 32);
            this.pagedeconnexion.TabIndex = 5;
            this.pagedeconnexion.Text = "QCM";
            // 
            // FormQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pagedeconnexion);
            this.Name = "FormQCM";
            this.Text = "FormQCM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pagedeconnexion;
    }
}