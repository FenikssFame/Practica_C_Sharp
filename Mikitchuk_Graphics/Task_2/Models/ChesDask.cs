using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task_2.Models
{
    public class ChesDask : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            int y = 10;
            for (int i = 0; i < 8; i++)
            {
                int x = 400;
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Rect rect = new Rect(new Point(x, y), new Size(50, 50));
                            drawingContext.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), rect);
                            base.OnRender(drawingContext);
                        }
                        else
                        {
                            Rect rect = new Rect(new Point(x, y), new Size(50, 50));
                            drawingContext.DrawRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rect);
                            base.OnRender(drawingContext);
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
                            Rect rect = new Rect(new Point(x, y), new Size(50, 50));
                            drawingContext.DrawRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rect);
                            base.OnRender(drawingContext);
                        }
                        else
                        {
                            Rect rect = new Rect(new Point(x, y), new Size(50, 50));
                            drawingContext.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), rect);
                            base.OnRender(drawingContext);
                        }
                        x += 50;
                    }
                }
                y += 50;
            }
        }
    }
}
