using Microsoft.Win32;
using System.IO;
using System;
using System.Windows;
using Task_1.Interfaces;
using Task_1.Share;
using System.Collections.Generic;
using Task_1.Models;
using Microsoft.Extensions.Logging;
using System.Windows.Controls;

namespace Task_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;

        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder
            .SetMinimumLevel(LogLevel.Information))
            .CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }

        private void buttonFindBookByName_Click(object sender, RoutedEventArgs e)
        {
            var book = _worker.FindBy(textBoxBookName.Text);
            PrintBook(book);
        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

            AddNewBook addNewBook = new AddNewBook();
            addNewBook.XmlFilePath = textBlockXMLPathFile.Text;
            addNewBook.Show();
            _worker.Load(_xmlFilePath);
            PrintBooks(_worker.GetAll());
        }
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteBookName.Text) || !string.IsNullOrWhiteSpace(textBoxDeleteBookName.Text))
            {
                _worker.Delete(textBoxDeleteBookName.Text);
                PrintBooks(_worker.GetAll());
            }
        }
        private void PrintBook(Book book)
        {
            textBlockXmlFileContent.Text = "Book" + Environment.NewLine;
            textBlockXmlFileContent.Text += book?.ToString() ?? "Country not founds";
        }
        private void PrintBooks(List<Book> books)
        {
            textBlockXmlFileContent.Text = "Books" + Environment.NewLine;
            foreach (var book in books)
            {
                textBlockXmlFileContent.Text += book.ToString();
            }
        }
        private void textBoxBookName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBookName.Text))
            {
                PrintBooks(_worker.GetAll());
            }
        }
        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
            .Parent
            .Parent
            .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {

                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintBooks(_worker.GetAll());
            }
        }
    }
}