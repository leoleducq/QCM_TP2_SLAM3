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
    public partial class FormChoixTheme : Form
    {
        public FormChoixTheme()
        {
            InitializeComponent();
        }

        private void listeDeroulante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void boutonRevenir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChoixMode form3 = new FormChoixMode();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChoixNiveau form2 = new FormChoixNiveau();
            form2.Show();
        }

        private void FormChoixTheme_Load(object sender, EventArgs e)
        {
            Controleur.Vmodele.charger_donnees("SLAM3_TP2_THEME");
            for (int i = 0; i < Controleur.Vmodele.DT[3].Rows.Count; i++)
            {
                listeDeroulante.Items.Add(Controleur.Vmodele.DT[3].Rows[i]["LIBELLETHEME"].ToString());
            }
        }
    }
}
