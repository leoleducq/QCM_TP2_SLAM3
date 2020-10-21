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
    public partial class FormChoixMode : Form
    {
        public FormChoixMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConnexionUtilisateur form1 = new FormConnexionUtilisateur();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConnexionAdministrateur form4 = new FormConnexionAdministrateur();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormInscriptionUtilisateur form6 = new FormInscriptionUtilisateur();
            form6.Show();
        }

        private void FormChoixMode_Load(object sender, EventArgs e)
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
    }
}
