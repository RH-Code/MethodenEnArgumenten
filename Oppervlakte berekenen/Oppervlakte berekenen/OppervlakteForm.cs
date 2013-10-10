using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oppervlakte_berekenen
{
    public partial class OppervlakteForm : Form
    {
        public OppervlakteForm()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int oppervlakte, breedte, lengte;
            breedte = Convert.ToInt32(txtBreedte.Text);
            lengte=Convert.ToInt32(txtHoogte.Text);
            oppervlakte = OppervlakteRechthoek(breedte, lengte);
            MessageBox.Show("De oppervlakte bedraagt " + Convert.ToString(oppervlakte) + "cm².");
        }

        private int OppervlakteRechthoek(int breedte, int lengte)
        {
            int oppervlakteRechthoek;
            oppervlakteRechthoek = breedte * lengte;
            return oppervlakteRechthoek;
        }
    }
}
