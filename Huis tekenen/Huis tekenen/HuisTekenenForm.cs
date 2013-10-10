using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Huis_tekenen
{
    public partial class HuisTekenenForm : Form
    {
        public HuisTekenenForm()
        {
            InitializeComponent();
        }

        private void btnTekenen_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            TekenHuis(paper, pen, 10, 20, 70, 20);
            TekenHuis(paper, pen, 10, 90, 50, 50);
        }

        private void TekenHuis(Graphics Tekengebied,
                                Pen penToUse,
                                int xPos,
                                int yPos,
                                int breedte,
                                int hoogte)
        {
            TekenDak(Tekengebied, penToUse,
                                    xPos, yPos, breedte, hoogte);
            Tekengebied.DrawRectangle(penToUse, xPos, yPos + hoogte, breedte, hoogte); 
        }

        private void TekenDak(Graphics Tekengebied,
                                Pen penToUse,
                                int xPos,
                                int yPos,
                                int breedte,
                                int hoogte)
        {
            Tekengebied.DrawLine(penToUse, xPos, yPos, xPos, yPos + hoogte);
            Tekengebied.DrawLine(penToUse, xPos, yPos + hoogte, xPos + breedte, yPos + hoogte);
            Tekengebied.DrawLine(penToUse, xPos + breedte, yPos + hoogte, xPos, yPos);
        }
    }
}
