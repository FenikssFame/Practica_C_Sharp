using System.Drawing;
using System.Windows.Forms;

namespace Task_1.Models
{
    public class ChesDask
    {
        public void ChesDaskPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush blackBrash = new SolidBrush(Color.Black);
            Brush whiteBrash = new SolidBrush(Color.White);
            int y = 10;
            for (int i = 0; i < 8; i++)
            {
            int x = 10;
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            g.FillRectangle(whiteBrash, x, y, 50, 50);
                        }
                        else
                        {
                            g.FillRectangle(blackBrash, x, y, 50, 50);
                        }
                        x += 50;
                    }
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            g.FillRectangle(blackBrash, x, y, 50, 50);
                        }
                        else
                        {
                            g.FillRectangle(whiteBrash, x, y, 50, 50);
                        }
                        x += 50;
                    }
                }
                y += 50;
            }
        }
    }
}
