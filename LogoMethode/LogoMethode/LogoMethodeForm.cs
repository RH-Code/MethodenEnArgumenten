using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Logo_Methode
{
    public partial class LogoMethodeForm : Form
    {
        public LogoMethodeForm()
        {
            InitializeComponent();
        }

        

        private void btnTeken_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

        //Hier gaan we onze methode aanroepen:
            TekenLogo(paper, pen, 10, 20);
            TekenLogo(paper, pen, 100, 100);
        }


        //Hier maken we de methode aan:
        //Methode header
        private void TekenLogo(Graphics paper1,
                                Pen pen1,
                                int xPos,
                                int yPos)
        //einde methode header

        //Methode body
        {
            paper1.DrawRectangle(pen1, xPos, yPos, 60, 60);
            paper1.DrawRectangle(pen1, xPos, yPos, 40, 40);
            paper1.DrawRectangle(pen1, xPos, yPos, 20, 20);
        }
        //einde methode body
    }
}
