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
            ucitajIme();

            if (Sesija.dozvole < 1)
            {
                buttonAdmin.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Objava objava = new Objava(0, 0);
            objava.Show();

            this.Hide();
        }

        private void ucitajIme()
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"SELECT korisnik.ime from korisnik
                             WHERE korisnik.korisnik_id = @korisnik_id";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@korisnik_id", Sesija.id);
            DataTable podaci = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            veza.Open();
            adapter.Fill(podaci);
            textboxUsername.Text = podaci.Rows[0]["ime"].ToString();
            veza.Close();
        }
        private void promeniIme()
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"update korisnik
                             set korisnik.ime = @ime
                             WHERE korisnik.korisnik_id = @korisnik_id";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@korisnik_id", Sesija.id);
            cmd.Parameters.AddWithValue("@ime", textboxUsername.Text);
            veza.Open();
            cmd.ExecuteNonQuery();
            veza.Close();
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
                    vratiGlasove(Convert.ToInt32(reader["objava_id"]))
                );
                post.Click += Post_Click;
                    
                flowLayoutPanel1.Controls.Add(post);
            }
            veza.Close();

        }
        string vratiGlasove(int objavaId)
        {
            int ukupno = 0;
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"SELECT COUNT(*) from glas
                     WHERE glas.objava_id = @objavaId and glas.vrednost = 1";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@objavaId", objavaId);
            veza.Open();
            ukupno = (int)cmd.ExecuteScalar();
            veza.Close();

            query = @"SELECT COUNT(*) from glas
                     WHERE glas.objava_id = @objavaId and glas.vrednost = -1";
            cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@objavaId", objavaId);
            veza.Open();
            ukupno = ukupno - (int)cmd.ExecuteScalar();
            veza.Close();
            return ukupno.ToString();
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

        private void buttonPromeniIme_Click(object sender, EventArgs e)
        {
            promeniIme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
