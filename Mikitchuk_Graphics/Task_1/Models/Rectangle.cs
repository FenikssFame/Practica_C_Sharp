using System.Drawing;
using System.Windows.Forms;

namespace Task_1.Models
{
    public class Rectangle
    {
        public void RectanglePaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, 20, 20, 50, 100);
            g.DrawRectangle(Pens.Black, 40, 85, 50, 100);
            g.DrawRectangle(Pens.Black, 60, 140, 50, 100);
            g.DrawRectangle(Pens.Black, 80, 210, 50, 100);
            g.DrawRectangle(Pens.Black, 100, 280, 50, 100);
        }
    }
}
