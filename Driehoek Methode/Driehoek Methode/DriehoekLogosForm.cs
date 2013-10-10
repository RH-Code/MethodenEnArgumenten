using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Driehoek_Methode
{
    public partial class DriehoekLogosForm : Form
    {
        public DriehoekLogosForm()
        {
            InitializeComponent();
        }

        private void btnTeken_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            TekenLogo(paper, pen, 10, 20);
            TekenLogo(paper, pen, 100, 100);
            TekenDriehoek(paper, pen, 100, 10, 40, 40);
            TekenDriehoek(paper, pen, 10, 100, 20, 60);
        }

        private void TekenLogo(Graphics Tekengebied,
                                Pen penToUse,
                                int xPos,
                                int yPos)
        {
            Tekengebied.DrawRectangle(penToUse, xPos, yPos, 20, 20);
            Tekengebied.DrawRectangle(penToUse, xPos, yPos, 40, 40);
            Tekengebied.DrawRectangle(penToUse, xPos, yPos, 60, 60);
        }

        private void TekenDriehoek(Graphics Tekengebied,
                                    Pen penToUse,
                                    int xPos,
                                    int yPos,
                                    int breedte,
                                    int hoogte)
        {
            Tekengebied.DrawLine(penToUse, xPos, yPos, xPos, yPos + hoogte);
            Tekengebied.DrawLine(penToUse, xPos, yPos, xPos + breedte, yPos + hoogte);
            Tekengebied.DrawLine(penToUse, xPos, yPos + hoogte, xPos + breedte, yPos + hoogte);
        }
    }
}
