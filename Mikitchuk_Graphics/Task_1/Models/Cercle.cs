using System.Drawing;
using System.Windows.Forms;

namespace Task_1.Models
{
    public class Cercle
    {
        public void CerclePaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(Pens.Black, 270, 125, 200, 200);
            g.DrawEllipse(Pens.Black, 285, 140, 170, 170);
            g.DrawEllipse(Pens.Black, 310, 165, 120, 120);
        }
    }
}
