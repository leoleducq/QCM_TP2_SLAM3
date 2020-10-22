using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM
{
    public partial class FormMaintenanceQCM : Form
    {
        private BindingSource bindingSource1;
        public FormMaintenanceQCM()
        {
            InitializeComponent();
        }

        private void boutonRevenir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChoixMode form3 = new FormChoixMode();
            form3.Show();
        }

        private void FormMaintenanceQCM_Load(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
            Controleur.Vmodele.charger_donnees("toutes");

            if (Controleur.Vmodele.Chargement)
            {
                //   MessageBox.Show("BD chargée dans DataTable  : " + Controleur.Vmodele.DT1.Rows.Count.ToString());
                for (int i = 0; i < Controleur.Vmodele.DT[0].Rows.Count; i++)
                {
                    listeDeroulante.Items.Add(Controleur.Vmodele.DT[0].Rows[i][0].ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeDeroulante.SelectedIndex != -1)
            {
                string table = listeDeroulante.SelectedItem.ToString(); // récupération de la table sélectionnée
                Controleur.Vmodele.charger_donnees(table);      // chargement des données de la table sélectionné dans le DT correspondant
                if (Controleur.Vmodele.Chargement)
                {
                    // un DT par table
                    bindingSource1 = new BindingSource();
                    if (table == "SLAM3_TP2_UTILISATEUR")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[1];
                        dataGridView.DataSource = bindingSource1;
                        dataGridView.Columns["IDUTILISATEUR"].HeaderText = "Numéro";
                        dataGridView.Columns["NOMUTILISATEUR"].HeaderText = "Nom";
                        dataGridView.Columns["PRENOMUTILISATEUR"].HeaderText = "Prénom";
                        dataGridView.Columns["LOGINUTILISATEUR"].HeaderText = "Identifiant";
                        dataGridView.Columns["MDPUTILISATEUR"].HeaderText = "Mot de passe";
                    }
                    dataGridView.Refresh();
                    dataGridView.Visible = true;
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas l'accès à cette table pour le moment", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Selectionner une table dans la liste déroulante", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
