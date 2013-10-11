using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euros_en_Cents
{
    public partial class EurosEnCentsForm : Form
    {
        public EurosEnCentsForm()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int inputCenten, geheleEuros, resterendeCenten;
            inputCenten = Convert.ToInt32(txtEurocenten.Text);
            EurosEnCenten(inputCenten, out geheleEuros, out resterendeCenten);
            lblEuros.Text = Convert.ToString(geheleEuros);
            lblCenten.Text = Convert.ToString(resterendeCenten);
        }

        private void EurosEnCenten(int inputCenten,
                                    out int geheleEuros,
                                    out int resterendeCenten)
        {
            geheleEuros = inputCenten / 100;
            resterendeCenten = inputCenten % 100;
        }
    }
}
