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
            nomUtilisateur.Text="Facultatif";
            nomUtilisateur.ForeColor = Color.LightGray;
            prenomUtilisateur.Text="Facultatif";
            prenomUtilisateur.ForeColor = Color.LightGray;
            identifiantInscription.Clear();
            motdepasseInscription.Clear();
            remotdepasseInscription.Clear();
        }

        private void boutonValider1_Click(object sender, EventArgs e)
        {
            
            FormInscriptionUtilisateur formCRUD = new FormInscriptionUtilisateur();
            Controleur.Vmodele.charger_donnees("SLAM3_TP2_UTILISATEUR");
            bool trouve = true;
            for (int i = 0; i < Controleur.Vmodele.DT[1].Rows.Count; i++)
            {
                if (Controleur.Vmodele.DT[1].Rows[i]["LOGINUTILISATEUR"].ToString()==identifiantInscription.Text)
                {
                    MessageBox.Show("Cet identifiant existe déja" + " ", "Problème connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    trouve = false;
                }

            }
            if (trouve == true)
            {
                DataRow NouvLigne = Controleur.Vmodele.DT[1].NewRow();
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
                else if(remotdepasseInscription.Text=="")
                {
                    MessageBox.Show("Veuillez confirmer votre mot de passe");
                    trouve = false;
                }
                else if(motdepasseInscription.Text != remotdepasseInscription.Text)
                {
                    MessageBox.Show("Les mots de passes ne sont pas identiques");
                    trouve = false;
                }
               else
                {
                    if(prenomUtilisateur.Text=="Facultatif")
                    {
                        prenomUtilisateur.Text = "";
                    }
                    if(nomUtilisateur.Text=="Facultatif")
                    {
                        nomUtilisateur.Text = "";
                    }
                    NouvLigne["PRENOMUTILISATEUR"] = prenomUtilisateur.Text;
                    NouvLigne["NOMUTILISATEUR"] = nomUtilisateur.Text;
                    NouvLigne["LOGINUTILISATEUR"] = identifiantInscription.Text;
                    NouvLigne["MDPUTILISATEUR"] = motdepasseInscription.Text;
                    trouve = true;
                }
                if (trouve == true)
                {
                    Controleur.Vmodele.DT[1].Rows.Add(NouvLigne);
                    Controleur.Vmodele.DA[1].Update(Controleur.Vmodele.DT[1]);
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

        private void nomUtilisateur_Enter(object sender, EventArgs e)
        {
            string nom = nomUtilisateur.Text;
            if(nom.Trim().Equals("Facultatif"))
            {
                nomUtilisateur.Text = "";
                nomUtilisateur.ForeColor = Color.Black;
            }
        }

        private void nomUtilisateur_Leave(object sender, EventArgs e)
        {
            string nom = nomUtilisateur.Text;
            if (nom.ToLower().Trim().Equals("Facultatif") || nom.Trim().Equals(""))
            {
                nomUtilisateur.Text = "Facultatif";
                nomUtilisateur.ForeColor = Color.LightGray;
            }
        }

        private void prenomUtilisateur_Enter(object sender, EventArgs e)
        {
            string prenom = prenomUtilisateur.Text;
            if (prenom.Trim().Equals("Facultatif"))
            {
                prenomUtilisateur.Text = "";
                prenomUtilisateur.ForeColor = Color.Black;
            }
        }

        private void prenomUtilisateur_Leave(object sender, EventArgs e)
        {
            string prenom = prenomUtilisateur.Text;
            if (prenom.ToLower().Trim().Equals("Facultatif") || prenom.Trim().Equals(""))
            {
                prenomUtilisateur.Text = "Facultatif";
                prenomUtilisateur.ForeColor = Color.LightGray;
            }
        }
    }
}
