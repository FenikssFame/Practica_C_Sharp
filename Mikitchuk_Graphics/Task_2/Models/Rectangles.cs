using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace Task_2.Models
{
    public class Rectangles : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect rect = new Rect(new Point(220, 20), new Size(50, 100));
            drawingContext.DrawRectangle((Brush)null, new Pen(Brushes.Black, 1), rect);
            base.OnRender(drawingContext);
            Rect rect2 = new Rect(new Point(240, 85), new Size(50, 100));
            drawingContext.DrawRectangle((Brush)null, new Pen(Brushes.Black, 1), rect2);
            base.OnRender(drawingContext);
            Rect rect3 = new Rect(new Point(260, 140), new Size(50, 100));
            drawingContext.DrawRectangle((Brush)null, new Pen(Brushes.Black, 1), rect3);
            base.OnRender(drawingContext);
            Rect rect4 = new Rect(new Point(280, 210), new Size(50, 100));
            drawingContext.DrawRectangle((Brush)null, new Pen(Brushes.Black, 1), rect4);
            base.OnRender(drawingContext);
            Rect rect5 = new Rect(new Point(300, 280), new Size(50, 100));
            drawingContext.DrawRectangle((Brush)null, new Pen(Brushes.Black, 1), rect5);
            base.OnRender(drawingContext);
        }
    }
}
