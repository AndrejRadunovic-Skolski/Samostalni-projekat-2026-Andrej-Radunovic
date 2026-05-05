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
    public partial class PregledObjave : Form
    {
        int objavaId = 0;
        public PregledObjave(int id)
        {
            InitializeComponent();
            objavaId = id;
            DataTable dt = GetObjavaById(id);
            if (dt.Rows.Count > 0)
            {
                DataRow red = dt.Rows[0];
                string naslov = red["naslov"].ToString();
                TextboxNaslov.Text = naslov;
                string sadrzaj = red["sadrzaj"].ToString();
                TextboxTekst.Text = sadrzaj;
                DateTime datum = Convert.ToDateTime(red["datum_objave"]);
                labelDatum.Text = datum.ToString();

                string odgovorId = red["odgovor_id"].ToString();
                LabelOdgovor.Text = odgovorId;

                Console.WriteLine($"Naslov: {naslov}, Objavljeno: {datum}");
            }
            else
            {
                Console.WriteLine("Objava nije pronađena.");
            }

            ucitajObjave();
            vratiGlasove();
        }

        public DataTable GetObjavaById(int id)
        {
            DataTable podaci = new DataTable();

            using (SqlConnection veza = Konekcija.NapraviVezu())
            {
                string query = "SELECT * FROM Objava WHERE objava_id = @id";

                using (SqlCommand komanda = new SqlCommand(query, veza))
                {
                    komanda.Parameters.AddWithValue("@id", id);

                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                    try
                    {
                        veza.Open();
                        adapter.Fill(podaci);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Greška: " + ex.Message);
                    }
                }
            }
            return podaci;
        }

        void ucitajObjave()
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"SELECT o.naslov, o.objava_id, o.sadrzaj, k.ime AS Autor 
                     FROM Objava o 
                     INNER JOIN Korisnik k ON o.korisnik_id = k.korisnik_id 
                     WHERE o.odgovor_id = @objavaId";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@objavaId", objavaId);
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
                //MessageBox.Show("Radimo");
            }
            veza.Close();

        }

        void vratiGlasove()
        {
            int ukupno = 0;
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"SELECT COUNT(*) from glas
                     WHERE glas.objava_id = @objavaId and glas.vrednost = 1";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@objavaId", objavaId);
            veza.Open();
            ukupno = (int )cmd.ExecuteScalar();
            veza.Close();

            query = @"SELECT COUNT(*) from glas
                     WHERE glas.objava_id = @objavaId and glas.vrednost = -1";
            cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@objavaId", objavaId);
            veza.Open();
            ukupno = ukupno - (int)cmd.ExecuteScalar();
            veza.Close();
            labelGlasovi.Text = ukupno.ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOdgovor_Click(object sender, EventArgs e)
        {
            Objava objava = new Objava(objavaId, 0);
            objava.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavna glavna = new Glavna();
            glavna.Show();
            this.Hide();
        }

        private void Button_GlasDobar_Click(object sender, EventArgs e)
        {
            int korisnikId = Sesija.id;

            using (SqlConnection veza = Konekcija.NapraviVezu())
            {

                using (SqlCommand komanda = new SqlCommand("Glas_Dodavanje", veza))
                {

                    komanda.CommandType = CommandType.StoredProcedure;

                    komanda.Parameters.AddWithValue("@objava_id", objavaId);
                    komanda.Parameters.AddWithValue("@korisnik_id", korisnikId);
                    komanda.Parameters.AddWithValue("@vrednost", 1);

                    try
                    {
                        veza.Open();
                        komanda.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Greška: " + ex.Message);
                    }
                }
            }
        }

        private void Button_GlasLos_Click(object sender, EventArgs e)
        {
            int korisnikId = Sesija.id;

            using (SqlConnection veza = Konekcija.NapraviVezu())
            {

                using (SqlCommand komanda = new SqlCommand("Glas_Dodavanje", veza))
                {

                    komanda.CommandType = CommandType.StoredProcedure;

                    komanda.Parameters.AddWithValue("@objava_id", objavaId);
                    komanda.Parameters.AddWithValue("@korisnik_id", korisnikId);
                    komanda.Parameters.AddWithValue("@vrednost", -1);

                    try
                    {
                        veza.Open();
                        komanda.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Greška: " + ex.Message);
                    }
                }
            }
        }
    }
}
