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
    public partial class FormSecretar : Form
    {
        public FormSecretar()
        {
            InitializeComponent();
        }

        private void elevClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxLogoStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = homePageStaff;
        }

        private void btnAvizierStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = avizierStaff;
        }

        private void btnIntroducereUsersStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = adaugaMembriiStaff;
        }

        private void btnActeStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = acteStaff;
        }

        private void btnAcademicStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = academicStaff;
        }

        private void btnContactStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = contactStaff;
        }

        private void btnDetaliiPersonaleStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = detaliiPersonaleStaff;
        }
    }
}
