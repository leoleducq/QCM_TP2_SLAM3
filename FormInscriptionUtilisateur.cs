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
    public partial class FormInscriptionUtilisateur : Form
    {
        public FormInscriptionUtilisateur()
        {
            InitializeComponent();
        }

        private void FormInscriptionUtilisateur_Load(object sender, EventArgs e)
        {

        }

        private void boutonRevenir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChoixMode form3 = new FormChoixMode();
            form3.Show();
        }

        private void boutonQuitter1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonAnnuler1_Click(object sender, EventArgs e)
        {
            identifiantInscription.Clear();
            motdepasseInscription.Clear();
        }

        private void boutonValider1_Click(object sender, EventArgs e)
        {
            Controleur.getModele().charger_donnees("SLAM3_TP2_UTILISATEUR");
            bool trouve = false;
            for (int i = 0; i < Controleur.getModele().DT1.Rows.Count; i++)
            {
                if (identifiantInscription.Text == Controleur.getModele().DT1.Rows[i]["LOGINUTILISATEUR"].ToString())
                {
                    MessageBox.Show("Cet identifiant existe déja" + " ", "Problème connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    trouve = true;
                }

            }
            if (trouve == false)
            {
                MessageBox.Show("Erreur dans les identifiants de connexion" + "", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
