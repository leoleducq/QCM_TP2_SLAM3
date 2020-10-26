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
    public partial class FormChoixNiveau : Form
    {
        string niveau = "";
        public FormChoixNiveau()
        {
            InitializeComponent();
        }

        private void labelchoixtheme_Click(object sender, EventArgs e)
        {

        }

        private void boutonQuitter2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelChoixNiveau_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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
            niveau = "Débutant";
            MessageBox.Show("Vous avez choisi la difficulté : " + niveau);
            this.Visible = false;
            FormChoixTheme form7 = new FormChoixTheme();
            form7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            niveau = "Confirmé";
            MessageBox.Show("Vous avez choisi la difficulté : " + niveau);
            this.Visible = false;
            FormChoixTheme form7 = new FormChoixTheme();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            niveau = "Expert";
            MessageBox.Show("Vous avez choisi la difficulté : " + niveau);
            this.Visible = false;
            FormChoixTheme form7 = new FormChoixTheme();
            form7.Show();
        }
    }
}
