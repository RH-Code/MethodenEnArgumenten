using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2Logos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTekenen_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            /*Dit is de bewerking voluit geschreven:
            paper.DrawRectangle(pen, 10, 20, 20, 20);
            paper.DrawRectangle(pen, 10, 20, 40, 40);
            paper.DrawRectangle(pen, 10, 20, 60, 60);

            paper.DrawRectangle(pen, 100, 100, 20, 20);
            paper.DrawRectangle(pen, 100, 100, 40, 40);
            paper.DrawRectangle(pen, 100, 100, 60, 60);
            */

            //We kunnen ook methodes gaan gebruiken:
            TekenLogo(paper, pen, 10, 20);
            TekenLogo(paper, pen, 100, 100);

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
    }
}
