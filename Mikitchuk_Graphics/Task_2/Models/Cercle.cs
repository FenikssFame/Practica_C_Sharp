using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task_2.Models
{
    public class Cercle : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse((Brush)null, new Pen(Brushes.Black, 1), new Point(115, 200), 50, 50);
            base.OnRender(drawingContext);
            drawingContext.DrawEllipse((Brush)null, new Pen(Brushes.Black, 1), new Point(115, 200), 80, 80);
            base.OnRender(drawingContext);
            drawingContext.DrawEllipse((Brush)null, new Pen(Brushes.Black, 1), new Point(115, 200), 100, 100);
            base.OnRender(drawingContext);
        }
    }
}
