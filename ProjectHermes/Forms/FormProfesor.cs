using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            ListaElevi = FisierToList();
        }

        private string FilePath = @"D:\Downloads\ProjectHermes30NovMarcela\ProjectHermesFullInterface\ProjectHermes\Fisiere\TextFileDateElevi.txt";

        //LOCALIZARE COMPONENTE IN FISIER (POZITIA PE CARE SE VOR AFLA IN FISIER PENTRU STRING)
        const int EMAIL = 0;
        const int NUME = 1;
        const int PRENUME = 2;
        const int VARSTA = 3;
        const int CLASA = 4;
        const int SPECIALIZARE = 5;
        const int PROFIL = 6;
        const int NOTE = 7;
        const int ABSENTE = 8;
        const int TELEFON = 9;
        const int ADRESA = 10;
        const int PAROLA = 11;

        private int variabilaElevSelectat = 0;

        //INITIALIZARE LISTA DE LUCRU CU ELEVI
        List<Classes.Elev> ListaElevi = new List<Classes.Elev>();

        //INITIALIZARE DATE DIN FISIER IN LISTA
        private List<Classes.Elev> FisierToList()//returneaza lista cu datele din fisier
        {
            List<Classes.Elev> StocareFisier = new List<Classes.Elev>();//lista temporara care va fi returnata
            string line = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] ComponenteElev = line.Split('|');//array of strings, fiecare element e un camp din elev
                        StocareFisier.Add(new Classes.Elev(ComponenteElev[EMAIL], ComponenteElev[NUME], ComponenteElev[PRENUME], Int32.Parse(ComponenteElev[VARSTA]), ComponenteElev[CLASA], ComponenteElev[SPECIALIZARE], ComponenteElev[PROFIL], ComponenteElev[NOTE], ComponenteElev[ABSENTE], ComponenteElev[TELEFON], ComponenteElev[ADRESA], ComponenteElev[PAROLA]));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare fisier!");
            }
            return StocareFisier;
        }
        //UPDATE FISIER DIN LISTA
        private void ActualizareFisier()
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(FilePath, false))
                {
                    foreach (Classes.Elev element in ListaElevi)
                        swFisierText.WriteLine(element.SirPenruFisier());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare actualizare fisier!!!");
            }
        }
        //BUTON NOTE--------------------------------------------------------------------------------------------------------------------------------------
        private void ListToDataGrid()//Afiseaza notele unui elev specific in data grid
        {
            //ELEMENTELE DIN LISTA SUNT AFISATE IN LISTBOX ELEVI (FOLOSESTE TO STRING!!!)
            ListBoxElevi.DataSource = ListaElevi;

            //HEADER INFO PENTRU DATA GRID
            DataTable table = new DataTable();

            table.Columns.Add("Materie", typeof(string));
            table.Columns.Add("Note", typeof(string));

            NoteDataGridView.DataSource = table;

            string[] separareMaterii = ListaElevi[variabilaElevSelectat].NoteElev.Split(';');
            string[] separareNote;

            for (int i = 0; i < separareMaterii.Length; i++)
            {
                separareNote = separareMaterii[i].Split(':');
                string[] row = new string[separareNote.Length];

                for (int j = 0; j < separareNote.Length; j++)
                {
                    row[j] = separareNote[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
        private void DataGridToList()//Update la lista cu modificarile din data grid
        {
            string lines = "";
            for (int row = 0; row < NoteDataGridView.RowCount - 2; row++)
            {
                for (int col = 0; col < NoteDataGridView.ColumnCount; col++)
                {
                    if (col % 2 == 0)
                    {
                        lines += NoteDataGridView.Rows[row].Cells[col].Value.ToString() + ":";
                    }
                    else
                        lines += NoteDataGridView.Rows[row].Cells[col].Value.ToString() + ";";

                }
            }
            ListaElevi[variabilaElevSelectat].NoteElev = lines;
        }
        private void btnNotareProf_Click(object sender, EventArgs e)
        {
            tabControlProf.SelectedTab = notareProf;
            ListToDataGrid();//Afiseaza notele unui elev specific in data grid
        }
        private void SearchTileButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool gasit = false;
                foreach (Classes.Elev elem in ListaElevi)
                {
                    if (elem.Nume == SearchTextBox.Text)
                    {
                        ListBoxElevi.SelectedIndex = ListaElevi.IndexOf(elem);
                        variabilaElevSelectat = ListBoxElevi.SelectedIndex;
                        ListToDataGrid();
                        gasit = true;
                        return;
                    }
                }
                if (!gasit)
                {
                    SearchTextBox.Text = "Elevul nu a fost gasit!";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selectati un element!");
                return;
            }
        }
        private void SalvareTileButton_Click(object sender, EventArgs e)
        {
            DataGridToList();//Actualizeaza lista cu notele
            ActualizareFisier();//Actualizeaza fisierul cu lista modificata
            ListaElevi = FisierToList();
        }
        private void AfisareTileButton_Click(object sender, EventArgs e)
        {
            variabilaElevSelectat = ListBoxElevi.SelectedIndex;//elev selectat din listbox
            ListToDataGrid();//Afiseaza notele unui elev specific in data grid
        }
        //BUTON PREZENTA-----------------------------------------------------------------------------------------------------------------------------------
        private void ListToDataGridPrezenta()//Afiseaza notele unui elev specific in data grid
        {
            //ELEMENTELE DIN LISTA SUNT AFISATE IN LISTBOX ELEVI (FOLOSESTE TO STRING!!!)
            listBoxPrezenta.DataSource = ListaElevi;

            //HEADER INFO PENTRU DATA GRID
            DataTable table = new DataTable();

            table.Columns.Add("Materie", typeof(string));
            table.Columns.Add("Absente", typeof(string));

            DataGridViewPrezenta.DataSource = table;

            string[] separareMaterii = ListaElevi[variabilaElevSelectat].AbsenteElev.Split(';');
            string[] separareAbsente;

            for (int i = 0; i < separareMaterii.Length; i++)
            {
                separareAbsente = separareMaterii[i].Split(':');
                string[] row = new string[separareAbsente.Length];

                for (int j = 0; j < separareAbsente.Length; j++)
                {
                    row[j] = separareAbsente[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
        private void DataGridToListPrezenta()//Update la lista cu modificarile din data grid
        {
            string lines = "";
            for (int row = 0; row < DataGridViewPrezenta.RowCount - 2; row++)
            {
                for (int col = 0; col < DataGridViewPrezenta.ColumnCount; col++)
                {
                    if (col % 2 == 0)
                    {
                        lines += DataGridViewPrezenta.Rows[row].Cells[col].Value.ToString() + ":";
                    }
                    else
                        lines += DataGridViewPrezenta.Rows[row].Cells[col].Value.ToString() + ";";
                }
            }
            ListaElevi[variabilaElevSelectat].AbsenteElev = lines;
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
            ListToDataGridPrezenta();
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

        private void SalvareTileButtonPrezenta_Click(object sender, EventArgs e)
        {
            DataGridToListPrezenta();
            ActualizareFisier();
            ListaElevi = FisierToList();
        }

        private void AfisareTileButtonPrezenta_Click(object sender, EventArgs e)
        {
            variabilaElevSelectat = ListBoxElevi.SelectedIndex;
            ListToDataGridPrezenta();
        }

        private void SearchTileButtonPrezenta_Click(object sender, EventArgs e)
        {
            try
            {
                bool gasit = false;
                foreach (Classes.Elev elem in ListaElevi)
                {
                    if (elem.Nume == SearchtextBoxPrezenta.Text)
                    {
                        listBoxPrezenta.SelectedIndex = ListaElevi.IndexOf(elem);
                        variabilaElevSelectat = ListBoxElevi.SelectedIndex;
                        ListToDataGridPrezenta();
                        gasit = true;
                        return;
                    }
                }
                if (!gasit)
                {
                    SearchTextBox.Text = "Elevul nu a fost gasit!";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selectati un element!");
                return;
            }
        }

        private void SearchTileButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool gasit = false;
                foreach (Classes.Elev elem in ListaElevi)
                {
                    if (elem.Nume == SearchTextBox.Text)
                    {
                        ListBoxElevi.SelectedIndex = ListaElevi.IndexOf(elem);
                        variabilaElevSelectat = ListBoxElevi.SelectedIndex;
                        ListToDataGrid();
                        gasit = true;
                        return;
                    }
                }
                if (!gasit)
                {
                    SearchTextBox.Text = "Elevul nu a fost gasit!";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selectati un element!");
                return;
            }
        }

        private void AfisareTileButton_Click_1(object sender, EventArgs e)
        {
            variabilaElevSelectat = ListBoxElevi.SelectedIndex;//elev selectat din listbox
            ListToDataGrid();//Afiseaza notele unui elev specific in data grid
        }

        private void SalvareTileButton_Click_1(object sender, EventArgs e)
        {
            DataGridToList();//Actualizeaza lista cu notele
            ActualizareFisier();//Actualizeaza fisierul cu lista modificata
            ListaElevi = FisierToList();
        }

        private void ListBoxElevi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
