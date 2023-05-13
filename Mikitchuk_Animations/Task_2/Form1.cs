using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap baner;
        Rectangle rect;
        public Form1()
        {
            InitializeComponent();
            try
            {
                baner = new Bitmap(@"..\..\baner.png");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка загрузки файла баннера\n" + e.ToString(), "Баннер");
                this.Close();
                return;
            }
            g = this.CreateGraphics();
            rect.X = 0;
            rect.Y = 0;
            rect.Width = baner.Width;
            rect.Height = baner.Height;
            timer1.Interval = 50;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ClearForm();
            rect.X += 1;
            if (Math.Abs(rect.X) > rect.Width)
            {
                rect.X += rect.Width;
            }
            for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rect.Width) + 1; i++)
            {
                g.DrawImage(baner, rect.X + i * rect.Width, rect.Y);
            }
            if (rect.X == this.Width)
                rect.X = 0;
        }
        private void ClearForm()
        {
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(0, 0, this.Width, this.Height));
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rect.Y + rect.Height) && (e.Y > rect.Y))
            {
                if (timer1.Enabled != false)
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                if (timer1.Enabled != true)
                {
                    timer1.Enabled = true;
                }
            }
        }
    }
}
