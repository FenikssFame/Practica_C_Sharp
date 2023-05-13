using System.Windows;

namespace Task_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonRun.Click += ButtonRun_Click;
            buttonClose.Click += ButtonClose_Click;
            buttonAbout.Click += ButtonAbout_Click;
            textBoxEnterName.MouseEnter += TBMouse_Enter;
        }
        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе {this.Title}";
            AboutApp aboutApp = new AboutApp(info);
            aboutApp.ShowDialog();
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void TBMouse_Enter(object sender, RoutedEventArgs e)
        {
            textBoxEnterName.Text = "";
        }
        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string input = string.Empty;
            if (string.IsNullOrEmpty(textBoxEnterName.Text) || string.IsNullOrWhiteSpace(textBoxEnterName.Text) || textBoxEnterName.Text == "Введите имя")
            {
                input = "World";
                textBoxEnterName.Text = "Введите имя";
            }
            else
            {
                input = textBoxEnterName.Text;
            }
            textBlockHello.Text = $"{hello} {input}";
        }
    }
}
