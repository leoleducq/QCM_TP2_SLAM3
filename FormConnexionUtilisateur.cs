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
    public partial class FormConnexionUtilisateur : Form
    {
        public FormConnexionUtilisateur()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur de connexion");
            }
            else
            {
                MessageBox.Show("BD connectée");
            }
        }

        private void boutonValider_Click(object sender, EventArgs e)
        {
            Controleur.getModele().charger_donnees("SLAM3_TP2_UTILISATEUR");
            bool trouve = false;
            for(int i=0;i < Controleur.getModele().DT1.Rows.Count; i++)
            {
                if (identifiant.Text == Controleur.getModele().DT1.Rows[i]["LOGINUTILISATEUR"].ToString() && motdepasse.Text == Controleur.getModele().DT1.Rows[i]["MDPUTILISATEUR"].ToString())
                {
                    MessageBox.Show("Bienvenue dans le QCM " + " ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    trouve = true;
                    this.Visible = false;
                    FormBienvenueQCM form2 = new FormBienvenueQCM();
                    form2.Show();
                }

            }
            if(trouve==false)
            {
                MessageBox.Show("Erreur dans les identifiants de connexion" + "", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void boutonAnnuler1_Click(object sender, EventArgs e)
        {
            identifiant.Clear();
            motdepasse.Clear();
        }

        private void boutonQuitter1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void identifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void boutonRevenir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChoixMode form3 = new FormChoixMode();
            form3.Show();
        }
    }
}
