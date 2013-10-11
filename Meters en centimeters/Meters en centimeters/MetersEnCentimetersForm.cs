using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Meters_en_centimeters
{
    public partial class MetersEnCentimetersForm : Form
    {
        public MetersEnCentimetersForm()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int invoerCentimeters, aantalMeters, aantalCentimeters, aantalMilimeters;
            invoerCentimeters = Convert.ToInt32(txtCentimeters.Text);
            MetersEnCentimeters(invoerCentimeters, out aantalMeters, out aantalCentimeters);
            lblAantalMeters.Text = Convert.ToString(aantalMeters);
            lblCentimeters.Text = Convert.ToString(aantalCentimeters);
            
        }

        private void MetersEnCentimeters(int invoerCentimeters,
                                            out int aantalMeters,
                                            out int aantalCentimeters)
                                            
        {
            aantalMeters = invoerCentimeters / 100;
            aantalCentimeters = invoerCentimeters % 100;
            
        }
    }
}
