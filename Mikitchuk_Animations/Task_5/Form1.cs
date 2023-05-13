using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        int y = 530;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Graphics g1 = e.Graphics;
            Graphics g2 = e.Graphics;
            Graphics g3 = e.Graphics;
            g.Clear(Color.Blue);
            SolidBrush peg = new SolidBrush(Color.Red);
            SolidBrush peg1 = new SolidBrush(Color.Yellow);
            SolidBrush peg2 = new SolidBrush(Color.Yellow);
            SolidBrush peg3 = new SolidBrush(Color.Aqua);
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp1 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp2 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp3 = new GraphicsPath(FillMode.Winding);
            gp.AddPolygon(new Point[] { new Point(450, y), new Point(465, y + 100), new Point(485, y + 100), new Point(500, y), new Point(475, y - 30), new Point(450, y) });
            gp1.AddPolygon(new Point[] { new Point(465, y + 100), new Point(445, y + 120), new Point(445, y + 90), new Point(460, y + 70), new Point(465, y + 100) });
            gp2.AddPolygon(new Point[] { new Point(485, y + 100), new Point(505, y + 120), new Point(505, y + 90), new Point(490, y + 70), new Point(485, y + 100) });
            gp3.AddEllipse(465, y + 5, 20, 20);
            g.FillPath(peg, gp);
            g1.FillPath(peg1, gp1);
            g2.FillPath(peg2, gp2);
            g3.FillPath(peg3, gp3);
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int H = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            y--;
            H++;
            if (H == 680)
            {
                timer1.Stop();
                H = 0;
                y = 530;
            }
            Invalidate();
        }
    }
}
