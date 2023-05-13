using System.Drawing;
using System.Windows.Forms;

namespace Task_1.Models
{
    public class Lines
    {
        public void LinesPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < 50; i++)
                g.DrawLine(new Pen(Brushes.Black, 2),
                10, 4 * i + 20, 200, 4 * i + 20);
        }
        public void LinesZigZagPaint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[50];
            Pen pen = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;

            for (int i = 0; i < 20; i++)
            {
                int xPos;
                if (i % 2 == 0)
                {
                    xPos = 10;
                }
                else
                {
                    xPos = 400;
                }
                points[i] = new Point(xPos, 10 * i);
            }
            g.DrawLines(pen, points);
        }
    }
}

