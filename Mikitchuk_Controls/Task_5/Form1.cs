namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(-20, 50));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int num = (int)listBox1.Items[i];
                if (num >= 0)
                {
                    listBox2.Items.Add(Math.Pow(num, 2));
                }
                else
                {
                    listBox2.Items.Add(num * 2);
                }
            }
        }
    }
}