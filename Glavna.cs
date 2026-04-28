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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Objava objava = new Objava(0, 0);
            objava.Show();
        }

        void ucitajObjave(int Kategorija)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"SELECT 
                            o.objava_id,
                            o.naslov, 
                            o.sadrzaj, 
                            k.ime AS Autor,
                            ISNULL(SUM(g.vrednost), 0) AS UkupnoGlasova
                            FROM Objava o
                            INNER JOIN Korisnik k ON o.korisnik_id = k.korisnik_id
                            LEFT JOIN Glas g ON o.objava_id = g.objava_id
                            GROUP BY o.objava_id, o.naslov, o.sadrzaj, k.ime, o.datum_objave
                            ORDER BY o.datum_objave DESC;";   
            SqlCommand cmd = new SqlCommand(query, veza);
            veza.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PostControl post = new PostControl();

                post.PromeniPodatke(
                    reader["naslov"].ToString(),
                    reader["Autor"].ToString(),
                    reader["UkupnoGlasova"].ToString()
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
