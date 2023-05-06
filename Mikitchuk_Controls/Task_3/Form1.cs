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
            g.Clear(Color.Azure);
            g.DrawEllipse(Pens.Yellow, 50, 100, 200, 200);
            g.DrawEllipse(Pens.Yellow, 70, 125, 50, 70);
            g.FillEllipse(Brushes.Black, 80, 125, 30, 40);
            g.DrawArc(Pens.Gold, 100, 200 ,100, 100, 0, 100);

            g.DrawEllipse(Pens.Red, 300, 100, 200, 200);
            g.DrawEllipse(Pens.Red, 330, 125, 50, 50);
            g.FillEllipse(Brushes.Black, 340, 145, 30, 30);
            g.DrawEllipse(Pens.Red, 420, 125, 50, 50);
            g.FillEllipse(Brushes.Black, 430, 145, 30, 30);
            g.DrawArc(Pens.Gold, 350, 200 ,100, 100, 180, 180);

            g.DrawEllipse(Pens.Green, 550, 100, 200, 200);
            g.DrawEllipse(Pens.Red, 580, 135, 50, 50);
            g.FillEllipse(Brushes.Black, 590, 145, 30, 30);
            g.DrawEllipse(Pens.Red, 670, 135, 50, 50);
            g.FillEllipse(Brushes.Black, 680, 145, 30, 30);
            g.DrawLine(Pens.Gold, 600, 250, 700, 250);
        }
    }
}
