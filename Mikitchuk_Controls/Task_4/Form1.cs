namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            char alf = char.Parse(textBox3.Text);
            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox1.Text);
            Control newControl = new Control();
            switch (alf)
            {
                case 'K':
                case 'К':
                case 'k':
                case 'к':
                    newControl = new Button() { Location = new Point(x, y), Text = "Кнопка" };
                    break;
                case 'M':
                case 'М':
                case 'м':
                case 'm':
                    newControl = new Label() { Location = new Point(x, y), Text = "Метка" };
                    break;
                case 'П':
                case 'п':
                    newControl = new TextBox() { Location = new Point(x, y), Text = "Текст бокс" };
                    break;
                default:
                    MessageBox.Show("Такого элемента нет");
                    break;
            }
            this.Controls.Add(newControl);
            newControl.MouseHover += new EventHandler((s, ev) =>
            {
                this.Controls.Remove(newControl);
            });
        }
    }
}