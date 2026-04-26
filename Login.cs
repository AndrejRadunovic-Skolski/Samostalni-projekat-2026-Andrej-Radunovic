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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Samostalni_projekat_2026_Andrej_Radunovic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextboxEmail.Text == "" || TextboxLozinka.Text == "")
            {
                MessageBox.Show("Polja su prazna.");
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.NapraviVezu();
                    SqlCommand cmd = new SqlCommand("Select * from korisnik where email=@username", veza);
                    cmd.Parameters.AddWithValue("@username", TextboxEmail.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["lozinka"].ToString(), TextboxLozinka.Text) == 0)
                        {
                            Console.WriteLine("Da");
                            MessageBox.Show("Login uspesan!");
                            Sesija.idString = tabela.Rows[0]["korisnik_id"].ToString();
                            Sesija.id = Convert.ToInt32(Sesija.idString);
                            this.Hide();
                            Glavna glavna = new Glavna();
                            glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Pogresna lozinka.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeći emajl");
                    }
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
