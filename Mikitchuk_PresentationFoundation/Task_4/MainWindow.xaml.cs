using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void myGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Content = "New Button";
            button.Width = 100;
            button.Height = 30;
            button.Margin = new Thickness(10);
            Grid.SetRow(button, random.Next(5));
            Grid.SetColumn(button, random.Next(5));
            Grid grid = (Grid)this.Content;
            grid.Children.Add(button);

            button.Click += (s, ev) => { myGrid.Children.Remove(button); };
        }
    }
}
