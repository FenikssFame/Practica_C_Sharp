namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double k = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);
            double b = double.Parse(textBox5.Text);
            for (double i = x; i < k; i += h)
            {
                double res = 9 * (Math.Pow(i, 3) + Math.Pow(b, 3)) * Math.Tan(i);
                textBox4.Text += Environment.NewLine + $"x = {i} y = {res}";
            }
        }
    }
}