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
    public partial class FormElev : Form
    {
        public FormElev()
        {
            InitializeComponent();
            ListaElevi = FisierToList();
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
            SituatieScolaraFolderToDataGrid();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = contact;
        }

        private void btnDetaliiPersonale_Click(object sender, EventArgs e)
        {
            tabControlElev.SelectedTab = detaliiPersonale;
            AfisareDetaliiElev();
        }

        private void AfisareDetaliiElev()
        {
            DetaliiPersonaleElevrichTextBox.Text = ListaElevi[variabilaElevSelectat].ToString();
        }
       
        private void btnAcademicOrar_Click(object sender, EventArgs e)
        {
            if (ComboBox_Clasa.Text!="")
            {
                lblPlaceOrar.Hide();
                Afisare_Orar(ComboBox_Clasa.SelectedItem.ToString());
            }
        }

        private void btnAcademicStructura_Click(object sender, EventArgs e)
        {   
            lblPlaceAn.Hide();
            Structura_An_Tabel();
        }

        private void Structura_An_Tabel()
        {
            DataTable t = new DataTable();
            t.Columns.Add("Activitate", typeof(string));
            t.Columns.Add("Perioada", typeof(string));
            Structura.DataSource = t;
            string[] lines = System.IO.File.ReadAllLines(@"Structura_an.txt");
            string[] values;
            for (int i = 1; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                t.Rows.Add(row);
            }
        }

        private void Afisare_Orar(string clasa)
        {
            DataTable t = new DataTable();
            t.Columns.Add("LUNI", typeof(string));
            t.Columns.Add("MARTI", typeof(string));
            t.Columns.Add("MIERCURI", typeof(string));
            t.Columns.Add("JOI", typeof(string));
            t.Columns.Add("VINERI", typeof(string));
            Orar.DataSource = t;

            string[] lines = File.ReadAllLines(@""+clasa+".txt");

            string[] values;
            for (int i = 1; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                t.Rows.Add(row);
            }
            for (int i = 1; i < Orar.RowCount; i++)
            {
                if (Orar.Rows[i].Cells[0].Value.ToString() == "")
                {
                    Orar.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (ComboBox_Clasa.Text != "")
            {
                string[] lines = File.ReadAllLines(@"" + ComboBox_Clasa.SelectedItem.ToString() + ".txt");
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "Orar.txt";
                save.Filter = "Text File | *.txt";
                if (save.ShowDialog() == DialogResult.OK)

                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    for (int i = 0; i < lines.Length; i++)
                    {
                        writer.WriteLine(lines[i].ToString());
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }
        }

        private void brnDescarcareStructuraAn_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"Structura_an.txt");
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "StructuraAn.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());
                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i].ToString());
                }
                writer.Dispose();
                writer.Close();

            }
        }

        private void Orar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void SituatieScolaraFolderToDataGrid()
        {
            //HEADER INFO PENTRU DATA GRID
            DataTable table = new DataTable();
            table.Columns.Add("Materie", typeof(string));
            table.Columns.Add("Note", typeof(string));
            table.Columns.Add("Teza S1", typeof(string));
            table.Columns.Add("Teza S2", typeof(string));
            table.Columns.Add("Absente", typeof(string));

            SituatieScolaraDataGrid.DataSource = table;

            //CITIRE DIN FISIER AFISARE IN DATAGRID (TREBUIE MODIFICAT PENTRU BAZA DE DATE)
            //FOLDER FISIERE -> TextFileSituatieScolara
            string[] lines = File.ReadAllLines("C:\\Users\\Stefan\\Documents\\GitHub\\ProjectHermes\\ProjectHermes\\Fisiere\\SituatieScolara.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //PATH PENTRU FISIERUL TextFileDateElevi
        private string FilePath = @"C:\Users\Stefan\Documents\GitHub\ProjectHermes\ProjectHermes\Fisiere\DateElevi.txt";

        private int variabilaElevSelectat = 7;

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
        //BUTON SITUATIE SCOLARA--------------------------------------------------------------------------------------------------------------------------
        private void SituatieScolaraListaToDataGrid()
        {
            //HEADER INFO PENTRU DATA GRID
            DataTable table = new DataTable();

            table.Columns.Add("Materie", typeof(string));
            table.Columns.Add("Note", typeof(string));
            table.Columns.Add("Absente", typeof(string));

            //ELEMENTELE DIN LISTA SUNT AFISATE IN LISTBOX ELEVI (FOLOSESTE TO STRING!!!)
            SituatieScolaraDataGrid.DataSource = table;

            string[] separareMateriiNOTE = ListaElevi[variabilaElevSelectat].NoteElev.Split(';');
            string[] separareMateriiPREZENTA = ListaElevi[variabilaElevSelectat].AbsenteElev.Split(';');

            string[] separareNote;
            string[] separareAbsente;

            for (int i = 0; i < separareMateriiNOTE.Length; i++)
            {
                separareNote = separareMateriiNOTE[i].Split(':');
                separareAbsente = separareMateriiPREZENTA[i].Split(':');

                DataRow tableRow = table.NewRow();

                string[] rowMaterie = new string[separareNote.Length];
                string[] rowNote = new string[separareNote.Length];
                string[] rowAbs = new string[separareNote.Length];

                for (int j = 0; j < separareNote.Length; j++)
                {
                    rowAbs[j] = ""; rowNote[j] = ""; rowMaterie[j] = "";

                    rowAbs[j] = separareAbsente[j].Trim();
                    rowNote[j] = separareNote[j].Trim();
                    if (j != 0)
                    {
                        rowMaterie[j] = separareNote[j - 1].Trim();
                    }
                    else
                    {
                        rowMaterie[j] = separareNote[j].Trim();
                    }
                    tableRow["Materie"] = rowMaterie[j].Trim();
                    tableRow["Note"] = rowNote[j].Trim();
                    tableRow["Absente"] = rowAbs[j].Trim();
                }
                table.Rows.Add(tableRow);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SituatieScolaraDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
