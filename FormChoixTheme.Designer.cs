namespace QCM
{
    partial class FormChoixTheme
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
            this.labelChoixTheme = new System.Windows.Forms.Label();
            this.boutonRevenir = new System.Windows.Forms.Button();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.listeDeroulante = new System.Windows.Forms.ComboBox();
            this.gbTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChoixTheme
            // 
            this.labelChoixTheme.AutoSize = true;
            this.labelChoixTheme.BackColor = System.Drawing.Color.Black;
            this.labelChoixTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoixTheme.ForeColor = System.Drawing.Color.White;
            this.labelChoixTheme.Location = new System.Drawing.Point(273, 164);
            this.labelChoixTheme.Name = "labelChoixTheme";
            this.labelChoixTheme.Size = new System.Drawing.Size(247, 29);
            this.labelChoixTheme.TabIndex = 6;
            this.labelChoixTheme.Text = "Choisissez un thème :";
            // 
            // boutonRevenir
            // 
            this.boutonRevenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRevenir.Location = new System.Drawing.Point(148, 74);
            this.boutonRevenir.Name = "boutonRevenir";
            this.boutonRevenir.Size = new System.Drawing.Size(246, 27);
            this.boutonRevenir.TabIndex = 18;
            this.boutonRevenir.Text = "Revenir à la sélection du mode";
            this.boutonRevenir.UseVisualStyleBackColor = true;
            this.boutonRevenir.Click += new System.EventHandler(this.boutonRevenir_Click);
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelBienvenue.ForeColor = System.Drawing.Color.Gold;
            this.labelBienvenue.Location = new System.Drawing.Point(225, 23);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(388, 32);
            this.labelBienvenue.TabIndex = 19;
            this.labelBienvenue.Text = "Bienvenue dans le QCM";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(400, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Revenir à la sélection du niveau :";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.listeDeroulante);
            this.gbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTable.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbTable.Location = new System.Drawing.Point(242, 196);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(317, 59);
            this.gbTable.TabIndex = 25;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Liste des thèmes";
            // 
            // listeDeroulante
            // 
            this.listeDeroulante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeDeroulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeDeroulante.FormattingEnabled = true;
            this.listeDeroulante.Location = new System.Drawing.Point(6, 21);
            this.listeDeroulante.Name = "listeDeroulante";
            this.listeDeroulante.Size = new System.Drawing.Size(305, 28);
            this.listeDeroulante.TabIndex = 0;
            this.listeDeroulante.SelectedIndexChanged += new System.EventHandler(this.listeDeroulante_SelectedIndexChanged);
            // 
            // FormChoixTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBienvenue);
            this.Controls.Add(this.boutonRevenir);
            this.Controls.Add(this.labelChoixTheme);
            this.Name = "FormChoixTheme";
            this.Text = "FormChoixTheme";
            this.Load += new System.EventHandler(this.FormChoixTheme_Load);
            this.gbTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoixTheme;
        private System.Windows.Forms.Button boutonRevenir;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.ComboBox listeDeroulante;
    }
}