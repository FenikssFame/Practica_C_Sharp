using System.Windows;

namespace Task_1
{
    /// <summary>
    /// Логика взаимодействия для AboutApp.xaml
    /// </summary>
    public partial class AboutApp : Window
    {
        public AboutApp()
        {
            InitializeComponent();
            buttonClose.Click += ButtonClose_Click;
        }
        public AboutApp(string appInfo) : this()
        {
            textBlockInfo.Text = appInfo;
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
