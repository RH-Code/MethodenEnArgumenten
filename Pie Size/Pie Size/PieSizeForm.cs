using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pie_Size
{
    public partial class PieSizeForm : Form
    {
        public PieSizeForm()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int pieWidth, pieLength;
            pieWidth = Convert.ToInt32(txtWidth.Text);
            pieLength = Convert.ToInt32(txtLength.Text);
            IncreaseSize(ref pieWidth, ref pieLength);
            IncreaseSize(ref pieWidth, ref pieLength);
            IncreaseSize(ref pieWidth, ref pieLength);
        }

        private void IncreaseSize(ref int pieWidth, ref int pieLength)
        {
            int area;
            pieWidth = pieWidth + 2;
            pieLength = pieLength + 2;
            area = pieWidth * pieLength;
            string message = String.Format("Pie size: {0} by {1}. Area is {2}", pieWidth, pieLength, area);
            MessageBox.Show(message);
        }
    }
}
