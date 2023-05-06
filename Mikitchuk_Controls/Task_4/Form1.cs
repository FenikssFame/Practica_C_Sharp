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
                case '�':
                case 'k':
                case '�':
                    newControl = new Button() { Location = new Point(x, y), Text = "������" };
                    break;
                case 'M':
                case '�':
                case '�':
                case 'm':
                    newControl = new Label() { Location = new Point(x, y), Text = "�����" };
                    break;
                case '�':
                case '�':
                    newControl = new TextBox() { Location = new Point(x, y), Text = "����� ����" };
                    break;
                default:
                    MessageBox.Show("������ �������� ���");
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