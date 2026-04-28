using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samostalni_projekat_2026_Andrej_Radunovic
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();

            ComboKategorija.DisplayMember = "ime";
            ComboKategorija.ValueMember = "kategorija_id";
            SqlConnection veza = Konekcija.NapraviVezu();
            SqlCommand cmd = new SqlCommand("Select * from kategorija", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            ComboKategorija.DataSource = tabela;

            ucitajObjave(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Objava objava = new Objava(0, 0);
            objava.Show();
        }

        void ucitajObjave(int Kategorija)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"SELECT o.naslov, o.sadrzaj, k.ime AS Autor 
                     FROM Objava o 
                     INNER JOIN Korisnik k ON o.korisnik_id = k.korisnik_id 
                     WHERE o.glavna = 1";
            SqlCommand cmd = new SqlCommand(query, veza);
            veza.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PostControl post = new PostControl();

                post.PromeniPodatke(
                    reader["naslov"].ToString(),
                    reader["Autor"].ToString(),
                    "NaN"
                );

                flowLayoutPanel1.Controls.Add(post);
            }
            veza.Close();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //nisam kliknuo ovo
        }
    }
}
