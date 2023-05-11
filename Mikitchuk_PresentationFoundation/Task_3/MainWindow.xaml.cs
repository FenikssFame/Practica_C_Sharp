using System;
using System.Windows;
using System.Windows.Documents;

namespace Task_3
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
            textBoxEnterX.MouseEnter += TBMouse_Enter;
            textBoxEnterH.MouseEnter += TBMouse_EnterH;
            textBoxEnterXN.MouseEnter += TBMouse_EnterXN;
        }
        private void TBMouse_Enter(object sender, RoutedEventArgs e)
        {
            textBoxEnterX.Text = "";
        }
        private void TBMouse_EnterH(object sender, RoutedEventArgs e)
        {
            textBoxEnterH.Text = "";
        }
        private void TBMouse_EnterXN(object sender, RoutedEventArgs e)
        {
            textBoxEnterXN.Text = "";
        }
        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEnterX.Text) || !string.IsNullOrWhiteSpace(textBoxEnterX.Text) && textBoxEnterX.Text != "Введите X" &&
                !string.IsNullOrEmpty(textBoxEnterX.Text) || !string.IsNullOrWhiteSpace(textBoxEnterX.Text) && textBoxEnterX.Text != "Введите H" &&
                !string.IsNullOrEmpty(textBoxEnterX.Text) || !string.IsNullOrWhiteSpace(textBoxEnterX.Text) && textBoxEnterX.Text != "Введите XN")
            {
                double inputX = double.Parse(textBoxEnterX.Text);
                double inputH = double.Parse(textBoxEnterH.Text);
                double inputXN = double.Parse(textBoxEnterXN.Text);
                double y = 0;

                for (double i = inputX; i < inputXN; i = i + inputH)
                {
                    y = Math.Abs(i);
                    textBlockHello.Text += $"y = {y}\n";
                }
            }
        }
    }
}
