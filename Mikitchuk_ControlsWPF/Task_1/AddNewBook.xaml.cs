using System.Windows;
using System.Xml;
using Task_1.Interfaces;

namespace Task_1
{
    /// <summary>
    /// Логика взаимодействия для AddNewBook.xaml
    /// </summary>
    public partial class AddNewBook : Window
    {
        private string _xmlFilePath;
        public AddNewBook()
        {
            InitializeComponent();
        }
        public string XmlFilePath
        {
            get { return _xmlFilePath; }
            set { _xmlFilePath = value; }
        }
        public void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(_xmlFilePath);
            var xRoot = document.DocumentElement;
            XmlElement book1 = document.CreateElement("Book");
            if (!string.IsNullOrEmpty(textBoxBookName.Text) || !string.IsNullOrWhiteSpace(textBoxBookName.Text))
            {
                XmlAttribute title1 = document.CreateAttribute("Name");
                title1.InnerText = textBoxBookName.Text;
                book1.Attributes.Append(title1);
                xRoot.AppendChild(book1);
            }
            if (!string.IsNullOrEmpty(textBoxBookAuthor.Text) || !string.IsNullOrWhiteSpace(textBoxBookAuthor.Text))
            {
                XmlElement author1 = document.CreateElement("Author");
                author1.InnerText = textBoxBookAuthor.Text;
                book1.AppendChild(author1);
            }
            if (!string.IsNullOrEmpty(textBoxBookYear.Text) || !string.IsNullOrWhiteSpace(textBoxBookYear.Text))
            {
                XmlElement year1 = document.CreateElement("Year");
                year1.InnerText = textBoxBookYear.Text;
                book1.AppendChild(year1);
            }
            document.Save(_xmlFilePath);
            this.Close();
        }
    }
}
