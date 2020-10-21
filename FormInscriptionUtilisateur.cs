using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            nomUtilisateur.Clear();
            prenomUtilisateur.Clear();
            identifiantInscription.Clear();
            motdepasseInscription.Clear();                       
        }

        private void boutonValider1_Click(object sender, EventArgs e)
        {
            
            FormInscriptionUtilisateur formCRUD = new FormInscriptionUtilisateur();
            Controleur.getModele().charger_donnees("SLAM3_TP2_UTILISATEUR");
            bool trouve = true;
            for (int i = 0; i < Controleur.getModele().DT1.Rows.Count; i++)
            {
                if (Controleur.getModele().DT1.Rows[i]["LOGINUTILISATEUR"].ToString()==identifiantInscription.Text)
                {
                    MessageBox.Show("Cet identifiant existe déja" + " ", "Problème connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    trouve = false;
                }

            }
            if (trouve == true)
            {
                DataRow NouvLigne = Controleur.Vmodele.DT1.NewRow();
                if(identifiantInscription.Text =="")
                {
                    MessageBox.Show("Veuillez entrer un identifiant");
                    trouve = false;
                }
                else if(motdepasseInscription.Text=="")
                {
                    MessageBox.Show("Veuillez entrer un mot de passe");
                    trouve = false;
                }
                else
                {
                    NouvLigne["PRENOMUTILISATEUR"] = prenomUtilisateur.Text;
                    NouvLigne["NOMUTILISATEUR"] = nomUtilisateur.Text;
                    NouvLigne["LOGINUTILISATEUR"] = identifiantInscription.Text;
                    NouvLigne["MDPUTILISATEUR"] = motdepasseInscription.Text;
                    trouve = true;
                }
                if (trouve == true)
                {
                    Controleur.Vmodele.DT1.Rows.Add(NouvLigne);
                    MessageBox.Show("Vous êtes maintenant inscrit");
                    FormConnexionUtilisateur FCU = new FormConnexionUtilisateur();
                    FCU.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur dans la saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


    }
}
