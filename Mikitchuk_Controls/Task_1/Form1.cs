namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] alf = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
            string text = textBox1.Text;
            text.ToLower();
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alf.Length; j++)
                {
                    if (text[i] == ' ')
                    {
                        newText += " ";
                        break;
                    }
                    else if (text[i] == alf[j])
                    {
                        newText += "+";
                        break;
                    }
                }
            }
            textBox2.Text = newText;
        }
    }
}