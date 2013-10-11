using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomVanDrieGetallen
{
    public partial class SomVanDrieGetallenForm : Form
    {
        public SomVanDrieGetallenForm()
        {
            InitializeComponent();
        }

        private void btnMaakSom_Click(object sender, EventArgs e)
        {
            int getal1, getal2, getal3, som;
            getal1 = Convert.ToInt32(txtGetal1.Text);
            getal2 = Convert.ToInt32(txtGetal2.Text);
            getal3 = Convert.ToInt32(txtGetal3.Text);

            som = Som(getal1, getal2, getal3);

            lblSom.Text = Convert.ToString(som);
        }

        private int Som(int getal1, int getal2, int getal3)
        {
            return getal1 + getal2 + getal3;
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            txtGetal1.Text = "";
            txtGetal1.Focus();
            txtGetal2.Text = "";
            txtGetal3.Text = "";
            lblSom.Text = null;
        }
    }
}
