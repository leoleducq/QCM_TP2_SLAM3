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
    }
}
