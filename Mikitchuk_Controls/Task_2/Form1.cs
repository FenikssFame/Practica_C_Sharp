using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            double q = 20;
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            double[] x = new double[count];
            double[] y = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y[i] = GetVal(Sh(x[i]), x[i], q);
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].Points.DataBindXY(x, y);
        }
        private double GetVal(double f, double x, double q)
        {
            if (Math.Abs(x * q) > 10.0)
                return Math.Log(Math.Abs(f) + Math.Abs(q));
            if (Math.Abs(x * q) < 10.0)
                return Math.Exp(f + q);
            return f + q;
        }
        public double Sh(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2.0;
        }
    }
}
