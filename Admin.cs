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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonBrisanjeKorisnika_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"delete from korisnik
                             WHERE korisnik.korisnik_id = @korisnik_id";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@korisnik_id", textBoxKorisnik.Text);
            veza.Open();
            cmd.ExecuteNonQuery();
            veza.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"delete from objava
                             WHERE objava.objava_id = @objava_id";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@objava_id", textBoxObjava.Text);
            veza.Open();
            cmd.ExecuteNonQuery();
            veza.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"insert into kategorija(ime, opis) values(@kategorija_ime, 'test')";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@kategorija_ime", textBoxKategorija.Text);
            veza.Open();
            cmd.ExecuteNonQuery();
            veza.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string query = @"delete from kategorija
                             WHERE kategorija.ime = @kategorija_ime";
            SqlCommand cmd = new SqlCommand(query, veza);
            cmd.Parameters.AddWithValue("@kategorija_ime", textBoxKategorija.Text);
            veza.Open();
            cmd.ExecuteNonQuery();
            veza.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Glavna glavna = new Glavna();
            glavna.Show();
            this.Hide();
        }
    }
}
