using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samostalni_projekat_2026_Andrej_Radunovic
{
    public partial class PostControl : UserControl
    {
        public PostControl()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                c.Click += (s, e) => this.OnClick(e);
            }
        }

        public void PromeniPodatke(string Naslov, string ImeObjavljaca, string glasovi)
        {
            labelNaslov.Text = Naslov;
            imeLabel.Text = "Od: " + ImeObjavljaca;
            labelGlasovi.Text = "Glasovi: " + glasovi;
        }

    }
}
