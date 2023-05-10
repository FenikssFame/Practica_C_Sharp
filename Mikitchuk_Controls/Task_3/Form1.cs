using System.Drawing;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            //g.Clear(Color.Azure);
            //g.DrawEllipse(Pens.Yellow, 50, 100, 200, 200);
            //g.DrawEllipse(Pens.Yellow, 70, 125, 50, 70);
            //g.FillEllipse(Brushes.Black, 80, 125, 30, 40);
            //g.DrawArc(Pens.Gold, 100, 200 ,100, 100, 0, 100);


            g.DrawEllipse(Pens.Red, 300, 100, 200, 200);
            g.DrawEllipse(Pens.Red, 330, 125, 50, 50);
            g.FillEllipse(Brushes.Black, 340, 145, 30, 30);
            g.DrawEllipse(Pens.Red, 420, 125, 50, 50);
            g.FillEllipse(Brushes.Black, 430, 145, 30, 30);
            g.DrawArc(Pens.Gold, 350, 200, 100, 100, 180, 180);
            g.DrawArc(Pens.Red, 450, 236, 100, 100, 90, 90);
            g.DrawArc(Pens.Red, 250, 236, 100, 100, 0, 90);
            g.DrawArc(Pens.Red, 248, 336, 100, 100, 220, 50);
            g.DrawArc(Pens.Red, 448, 336, 100, 100, 270, 50);
            g.DrawLine(Pens.Red, 289, 370, 280, 618);
            g.DrawLine(Pens.Red, 259, 356, 250, 600);
            g.DrawEllipse(Pens.Red, 530, 600, 50, 50);
            g.DrawLine(Pens.Red, 538, 356, 559, 600);
            g.DrawLine(Pens.Red, 508, 370, 529, 618);
            g.DrawEllipse(Pens.Red, 230, 600, 50, 50);
            g.DrawLine(Pens.Red, 508, 370, 508, 618);
            g.DrawLine(Pens.Red, 289, 370, 289, 618);
            g.DrawLine(Pens.Red, 508, 618, 289, 618);
            g.DrawLine(Pens.Red, 438, 718, 459, 918);
            g.DrawLine(Pens.Red, 508, 618, 529, 918);
            g.DrawLine(Pens.Red, 359, 718, 329, 918);
            g.DrawLine(Pens.Red, 289, 618, 269, 918);
            g.DrawArc(Pens.Red, 348, 698, 100, 100, 218, 105);
            g.FillEllipse(Brushes.Black, 460, 900, 70, 50);
            g.FillEllipse(Brushes.Black, 265, 900, 70, 50);

            //g.DrawEllipse(Pens.Green, 550, 100, 200, 200);
            //g.DrawEllipse(Pens.Red, 580, 135, 50, 50);
            //g.FillEllipse(Brushes.Black, 590, 145, 30, 30);
            //g.DrawEllipse(Pens.Red, 670, 135, 50, 50);
            //g.FillEllipse(Brushes.Black, 680, 145, 30, 30);
            //g.DrawLine(Pens.Gold, 600, 250, 700, 250);
        }
    }
}
