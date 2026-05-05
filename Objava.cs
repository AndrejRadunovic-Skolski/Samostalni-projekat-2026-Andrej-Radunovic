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
    public partial class Objava : Form
    {
        int glavnaKategorija;
        int glavanOdgovor;
        public Objava(int odgovor, int kategorija)
        {
            glavnaKategorija = kategorija;
            glavanOdgovor = odgovor;
            InitializeComponent();

            ComboKategorija.DisplayMember = "ime";
            ComboKategorija.ValueMember = "kategorija_id";
            SqlConnection veza = Konekcija.NapraviVezu();
            SqlCommand cmd = new SqlCommand("Select * from kategorija", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            ComboKategorija.DataSource = tabela;

            if (odgovor != 0)
            {
                ComboKategorija.Enabled = false;
                LabelOdgovor.Text = odgovor.ToString();
                veza = Konekcija.NapraviVezu();
                cmd = new SqlCommand("Select kategorija_id from objava where objava_id=@odgovor", veza);
                cmd.Parameters.AddWithValue("@odgovor", odgovor);
                adapter = new SqlDataAdapter(cmd);
                tabela = new DataTable();
                adapter.Fill(tabela);
                kategorija = Convert.ToInt32(tabela.Rows[0][0].ToString());
            }
            else if (kategorija != 0)
            {
                ComboKategorija.Enabled = false;
                LabelOdgovor.Text = "Nije odgovor.";
            }
            else
            {
                ComboKategorija.Enabled = true;
                LabelOdgovor.Text = "Nije odgovor.";
            }
        }

        private void buttonObjavi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            DataTable tabela = new DataTable();
            if (glavnaKategorija == 0)
            {
                glavnaKategorija = Convert.ToInt32(ComboKategorija.SelectedValue);
            }

            if (TextboxNaslov.Text == "" || TextboxTekst.Text == "")
            {
                MessageBox.Show("Polja su prazna.");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into objava(korisnik_id, odgovor_id, kategorija_id, glavna, datum_objave, naslov, sadrzaj) values(@korisnik_id, @odgovor_id, @kategorija_id, @glavna, GETDATE(), @naslov, @sadrzaj)", veza);
                cmd.Parameters.AddWithValue("@korisnik_id", Sesija.id);
                cmd.Parameters.AddWithValue("@odgovor_id", glavanOdgovor);
                cmd.Parameters.AddWithValue("@kategorija_id", glavnaKategorija);
                cmd.Parameters.AddWithValue("@naslov", TextboxNaslov.Text);
                cmd.Parameters.AddWithValue("@sadrzaj", TextboxTekst.Text);
                if (glavanOdgovor == 0)
                {
                    cmd.Parameters.AddWithValue("glavna", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("glavna", 0);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.InsertCommand = cmd;
                veza.Open();
                cmd.ExecuteNonQuery();
                veza.Close();
            }
            Glavna glavna = new Glavna();
            glavna.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavna glavna = new Glavna();
            glavna.Show();
            this.Hide();
        }

        private void ComboKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            glavnaKategorija = Convert.ToInt32(ComboKategorija.SelectedValue.ToString());
        }
    }
}
