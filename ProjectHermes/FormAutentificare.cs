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
    public partial class FormAutentificare : Form
    {
        //Hardcodare user
        string profesorUsername = "profesor"; string profesorPassword = "profesor";
        string elevUsername = "elev"; string elevPassword = "elev";
        string secretarUsername = "secretar"; string secretarPassword = "secretar";
        //Hardcodare user

        public FormAutentificare()
        {
            InitializeComponent();
        }

        private void ValidareImput(String nume, String parola)
        {
            const int nrCaractere = 4;

            if (nume.Length < nrCaractere)
            {
                adviceLabel.Visible = true;
                adviceLabel.ForeColor = Color.Red;
              //  adviceLabel.Text = nameLabel.Text + " trebuie sa contina cel putin " + nrCaractere + " caractere";
            }
            else if (parola.Length < nrCaractere)
            {
                adviceLabel.Visible = true;
                adviceLabel.ForeColor = Color.Red;
               // adviceLabel.Text = passwordLabel.Text + " trebuie sa contina cel putin " + nrCaractere + " caractere";
            }
            else if (nume == secretarUsername || nume == elevUsername || nume == profesorUsername)
            {
                adviceLabel.Visible = true;
                adviceLabel.ForeColor = Color.Red;
                adviceLabel.Text = "Parola incorecta!";
            }
            else if (nume != secretarUsername || nume != elevUsername || nume != profesorUsername)
            {
                adviceLabel.Visible = true;
                adviceLabel.ForeColor = Color.Red;
                adviceLabel.Text = "Numele de utilizator nu este inregistrat!";
            }
            else
            {
                adviceLabel.Visible = true;
                adviceLabel.ForeColor = Color.Red;
                adviceLabel.Text = "Exceptie nerezolvata!";
            }
        }     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Redirectionare catre formularul corespunzator
            if (textBoxUsername.Text == profesorUsername && textBoxPassword.Text == profesorPassword)
            {
                FormProfesor formProfesor = new FormProfesor();
                formProfesor.Show();
                this.Hide();
            }
            else if (textBoxUsername.Text == elevUsername && textBoxPassword.Text == elevPassword)
            {
                FormElev formElev = new FormElev();
                formElev.Show();
                this.Hide();
            }
            else if (textBoxUsername.Text == secretarUsername && textBoxPassword.Text == secretarPassword)
            {
                FormSecretar formSecretar = new FormSecretar();
                formSecretar.Show();
                this.Hide();
            }
            else
            {
                ValidareImput(textBoxUsername.Text, textBoxPassword.Text);
            }
        }
    }
}
