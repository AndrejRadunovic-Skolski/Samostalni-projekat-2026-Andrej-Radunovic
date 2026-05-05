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

            flowLayoutPanel1.Controls.Clear();
            ucitajObjave(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Objava objava = new Objava(0, 0);
            objava.Show();

            this.Hide();
        }

        void ucitajObjave(int Kategorija)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"SELECT o.naslov, o.objava_id, o.sadrzaj, k.ime AS Autor 
                     FROM Objava o 
                     INNER JOIN Korisnik k ON o.korisnik_id = k.korisnik_id 
                     WHERE o.glavna = 1 and o.kategorija_id = @kategorija";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@kategorija", Kategorija);
            veza.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PostControl post = new PostControl();

                post.Tag = reader["objava_id"];

                post.PromeniPodatke(
                    reader["naslov"].ToString(),
                    reader["Autor"].ToString(),
                    "NaN"
                );
                post.Click += Post_Click;
                    
                flowLayoutPanel1.Controls.Add(post);
            }
            veza.Close();

        }
        private void Post_Click(object sender, EventArgs e)
        {
            Control kliknutaKontrola = (Control)sender;

            if (kliknutaKontrola.Tag != null)
            {
                PregledObjave pregledObjave = new PregledObjave(Convert.ToInt32(kliknutaKontrola.Tag));
                pregledObjave.Show();
                string id = kliknutaKontrola.Tag.ToString();
                this.Hide();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //nisam kliknuo ovo
        }

        private void ComboKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ucitajObjave(Convert.ToInt32(ComboKategorija.SelectedValue.ToString()));
        }
    }
}
