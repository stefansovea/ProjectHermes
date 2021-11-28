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
    public partial class FormProfesor : Form
    {
        public FormProfesor()
        {
            InitializeComponent();
        }

        private void pictureBoxLogoTeacher_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = homePageProf;
        }

        private void btnAvizierProf_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = avizierProf;
        }

        private void btnPrezentaProf_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = prezentaProf;
        }

        private void btnNotareProf_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = notareProf;
        }

        private void btnAcademicProf_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = academicProf;
        }

        private void btnContactProf_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = contactProf;
        }

        private void btnDetaliiPersonaleProf_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = detaliiPersonaleProf;
        }

        private void elevClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
