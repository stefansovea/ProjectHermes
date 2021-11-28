using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHermes
{
    public partial class FormElev : Form
    {
        public FormElev()
        {
            InitializeComponent();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = academic;
        }

        private void elevClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = homePage;
        }

        private void btnAvizier_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = avizier;
        }

        private void btnSolicitareActe_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = solicitareActe;
        }

        private void btnSituatieScolara_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = situatieScolara;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = contact;
        }

        private void btnDetaliiPersonale_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = detaliiPersonale;
        }
    }
}
