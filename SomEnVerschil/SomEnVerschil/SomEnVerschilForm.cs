using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomEnVerschil
{
    public partial class SomEnVerschilForm : Form
    {
        public SomEnVerschilForm()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int getal1, getal2, som, verschil;
            
            getal1 = Convert.ToInt32(txtGetal1.Text);
            getal2 = Convert.ToInt32(txtGetal2.Text);

            som = Som(getal1, getal2);
            verschil = Verschil(getal1, getal2);

            lblSom.Text = Convert.ToString(som);
            lblVerschil.Text = Convert.ToString(verschil);
        }

        private int Som(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        private int Verschil(int getal1, int getal2)
        {
            return getal1 - getal2;
        }
    }
}
