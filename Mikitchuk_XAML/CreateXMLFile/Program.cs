using System;
using System.Xml;

namespace Notebook
{
    class Program
    {
        static void Main()
        {
            try
            {
               XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Library");
                xmlDoc.AppendChild(root);
                XmlElement book1 = xmlDoc.CreateElement("Book");
                XmlAttribute title1 = xmlDoc.CreateAttribute("Name");
                title1.InnerText = "The Great Gatsby";
                book1.Attributes.Append(title1);
                root.AppendChild(book1);
                XmlElement author1 = xmlDoc.CreateElement("Author");
                author1.InnerText = "F. Scott Fitzgerald";
                book1.AppendChild(author1);
                XmlElement year1 = xmlDoc.CreateElement("Year");
                year1.InnerText = "1925";
                book1.AppendChild(year1);

                XmlElement book2 = xmlDoc.CreateElement("Book");
                XmlAttribute title2 = xmlDoc.CreateAttribute("Name");
                title2.InnerText = "To Kill a Mockingbird";
                book2.Attributes.Append(title2);
                root.AppendChild(book2);
                XmlElement author2 = xmlDoc.CreateElement("Author");
                author2.InnerText = "Harper Lee";
                book2.AppendChild(author2);
                XmlElement year2 = xmlDoc.CreateElement("Year");
                year2.InnerText = "1960";
                book2.AppendChild(year2);
                xmlDoc.Save("Library.xml");

                XmlElement book3 = xmlDoc.CreateElement("Book");
                XmlAttribute title3 = xmlDoc.CreateAttribute("Name");
                title3.InnerText = "From New Country";
                book3.Attributes.Append(title3);
                root.AppendChild(book3);
                XmlElement author3 = xmlDoc.CreateElement("Author");
                author3.InnerText = "Andreev";
                book3.AppendChild(author3);
                XmlElement year3 = xmlDoc.CreateElement("Year");
                year3.InnerText = "1966";
                book3.AppendChild(year3);

                XmlElement book4 = xmlDoc.CreateElement("Book");
                XmlAttribute title4 = xmlDoc.CreateAttribute("Name");
                title4.InnerText = "Dorofeiv in line";
                book4.Attributes.Append(title4);
                root.AppendChild(book4);
                XmlElement author4 = xmlDoc.CreateElement("Author");
                author4.InnerText = "Gaga";
                book4.AppendChild(author4);
                XmlElement year4 = xmlDoc.CreateElement("Year");
                year4.InnerText = "1950";
                book4.AppendChild(year4);

                XmlElement book5 = xmlDoc.CreateElement("Book");
                XmlAttribute title5 = xmlDoc.CreateAttribute("Name");
                title5.InnerText = "Step";
                book5.Attributes.Append(title5);
                root.AppendChild(book5);
                XmlElement author5 = xmlDoc.CreateElement("Author");
                author5.InnerText = "Dronov";
                book5.AppendChild(author5);
                XmlElement year5 = xmlDoc.CreateElement("Year");
                year5.InnerText = "1999";
                book5.AppendChild(year5);

                XmlElement book6 = xmlDoc.CreateElement("Book");
                XmlAttribute title6 = xmlDoc.CreateAttribute("Name");
                title6.InnerText = "Input Program";
                book6.Attributes.Append(title6);
                root.AppendChild(book6);
                XmlElement author6 = xmlDoc.CreateElement("Author");
                author6.InnerText = "Kremko";
                book3.AppendChild(author6);
                XmlElement year6 = xmlDoc.CreateElement("Year");
                year6.InnerText = "1984";
                book6.AppendChild(year6);

                XmlElement book7 = xmlDoc.CreateElement("Book");
                XmlAttribute title7 = xmlDoc.CreateAttribute("Name");
                title7.InnerText = "Diki";
                book7.Attributes.Append(title7);
                root.AppendChild(book7);
                XmlElement author7 = xmlDoc.CreateElement("Author");
                author7.InnerText = "Ivanovich";
                book3.AppendChild(author7);
                XmlElement year7 = xmlDoc.CreateElement("Year");
                year7.InnerText = "1988";
                book7.AppendChild(year7);

                xmlDoc.Save(@"../../../../Task_1/Library.xml");
            }
            catch (Exception e)
            {
                // Log the error
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}