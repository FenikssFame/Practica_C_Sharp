using System.Windows.Controls;
using System.Windows.Media;

namespace Task_2
{
    public class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
                                    new System.Windows.Point(0,0),
                                    new System.Windows.Point(this.Height, this.Width));
            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
                                    new System.Windows.Point(0, this.Width),
                                    new System.Windows.Point(this.Height, 0));
            base.OnRender(drawingContext);
        }
    }
}
