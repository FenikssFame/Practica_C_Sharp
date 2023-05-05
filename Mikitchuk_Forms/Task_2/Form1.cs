namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            string result = "";
            double res;
            if (radioButton1.Checked)
            {
                res = Math.Min(Math.Sinh(x) + y, y - z) /
                               Math.Max(Math.Sinh(x), y);
                result = res.ToString();
            }
            else if (radioButton2.Checked)
            {
                res = Math.Min(Math.Pow(x, 2) + y, y - z) /
                                Math.Max(Math.Pow(x, 2), y);
                result = res.ToString();
            }
            else if (radioButton3.Checked)
            {
                res = Math.Min(Math.Pow(Math.E, x) + y, y - z) /
                                Math.Max(Math.Pow(Math.E, x), y);
                result = res.ToString();
            }
            else
            {
                result = "Не выбрана функция";
            }
            textBox4.Text = result;
        }
    }
}