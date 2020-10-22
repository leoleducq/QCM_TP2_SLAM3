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
    public partial class FormConnexionAdministrateur : Form
    {
        public FormConnexionAdministrateur()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void boutonQuitter4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonAnnuler4_Click(object sender, EventArgs e)
        {
            identifiantadministrateur.Clear();
            motdepasseadministrateur.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChoixMode form3 = new FormChoixMode();
            form3.Show();
        }

        private void boutonValider4_Click(object sender, EventArgs e)
        {
            Controleur.Vmodele.charger_donnees("SLAM3_TP2_ADMINISTRATEUR");
            bool trouve = false;
            for (int i = 0; i < Controleur.Vmodele.DT[2].Rows.Count; i++)
            {
                if (identifiantadministrateur.Text == Controleur.Vmodele.DT[2].Rows[i]["LOGINADMINISTRATEUR"].ToString() && motdepasseadministrateur.Text == Controleur.Vmodele.DT[2].Rows[i]["MDPADMINISTRATEUR"].ToString())
                {
                    MessageBox.Show("Vous êtes en mode administrateur " + " ", "Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    trouve = true;
                    this.Visible = false;
                    FormMaintenanceQCM form5 = new FormMaintenanceQCM();
                    form5.Show();
                }

            }
            if (trouve == false)
            {
                MessageBox.Show("Erreur dans les identifiants de connexion" + "", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
