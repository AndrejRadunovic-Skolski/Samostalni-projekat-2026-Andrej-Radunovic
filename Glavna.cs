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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //nisam kliknuo ovo
        }
    }
}
