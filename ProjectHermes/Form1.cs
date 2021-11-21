using Microsoft.Data.SqlClient;
using System;


namespace ProjectHermes
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Stefan\\Documents\\GitHub\\ProjectHermes\\ProjectHermes\\Database1.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from elevi");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Connected");
                con.Close();
            }
            else
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }
    }
}