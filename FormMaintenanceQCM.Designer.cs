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
            this.components = new System.ComponentModel.Container();
            this.pagedeconnexion = new System.Windows.Forms.Label();
            this.boutonRevenir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.listeDeroulante = new System.Windows.Forms.ComboBox();
            this.labelcliquedroit = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbTable.SuspendLayout();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagedeconnexion
            // 
            this.pagedeconnexion.AutoSize = true;
            this.pagedeconnexion.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagedeconnexion.ForeColor = System.Drawing.Color.Gold;
            this.pagedeconnexion.Location = new System.Drawing.Point(232, 8);
            this.pagedeconnexion.Name = "pagedeconnexion";
            this.pagedeconnexion.Size = new System.Drawing.Size(353, 32);
            this.pagedeconnexion.TabIndex = 4;
            this.pagedeconnexion.Text = "Administration QCM";
            // 
            // boutonRevenir
            // 
            this.boutonRevenir.BackColor = System.Drawing.Color.LightGray;
            this.boutonRevenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRevenir.Location = new System.Drawing.Point(291, 43);
            this.boutonRevenir.Name = "boutonRevenir";
            this.boutonRevenir.Size = new System.Drawing.Size(246, 27);
            this.boutonRevenir.TabIndex = 21;
            this.boutonRevenir.Text = "Revenir à la sélection du mode";
            this.boutonRevenir.UseVisualStyleBackColor = false;
            this.boutonRevenir.Click += new System.EventHandler(this.boutonRevenir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 11);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(741, 241);
            this.dataGridView.TabIndex = 22;
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.listeDeroulante);
            this.gbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTable.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbTable.Location = new System.Drawing.Point(249, 76);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(317, 59);
            this.gbTable.TabIndex = 24;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Liste des tables";
            // 
            // listeDeroulante
            // 
            this.listeDeroulante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeDeroulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeDeroulante.FormattingEnabled = true;
            this.listeDeroulante.Location = new System.Drawing.Point(6, 25);
            this.listeDeroulante.Name = "listeDeroulante";
            this.listeDeroulante.Size = new System.Drawing.Size(305, 28);
            this.listeDeroulante.TabIndex = 0;
            this.listeDeroulante.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelcliquedroit
            // 
            this.labelcliquedroit.AutoSize = true;
            this.labelcliquedroit.BackColor = System.Drawing.Color.Black;
            this.labelcliquedroit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcliquedroit.ForeColor = System.Drawing.Color.White;
            this.labelcliquedroit.Location = new System.Drawing.Point(91, 412);
            this.labelcliquedroit.Name = "labelcliquedroit";
            this.labelcliquedroit.Size = new System.Drawing.Size(621, 29);
            this.labelcliquedroit.TabIndex = 25;
            this.labelcliquedroit.Text = "Clique Droit pour Ajouter / Supprimer / Modifier une ligne";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 268);
            this.panel1.TabIndex = 26;
            // 
            // FormMaintenanceQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelcliquedroit);
            this.Controls.Add(this.gbTable);
            this.Controls.Add(this.boutonRevenir);
            this.Controls.Add(this.pagedeconnexion);
            this.Name = "FormMaintenanceQCM";
            this.Text = "Espace Administrateur";
            this.Load += new System.EventHandler(this.FormMaintenanceQCM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbTable.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button boutonRevenir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.ComboBox listeDeroulante;
        private System.Windows.Forms.Label labelcliquedroit;
        private new System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Label pagedeconnexion;
        private System.Windows.Forms.Panel panel1;
    }
}