using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Xml;
using Task_1.Interfaces;
using Task_1.Models;

namespace Task_1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }
        public void Add(Book book)
        {
            var xRoot = _document.DocumentElement;
            XmlElement bookElem = _document.CreateElement("book");
            XmlAttribute nameAttribute = _document.CreateAttribute("name");
            XmlText nameText = _document.CreateTextNode(book.Name);
            nameAttribute.AppendChild(nameText);
            XmlElement authorElem = _document.CreateElement("author");
            XmlText authorInnerText = _document.CreateTextNode(book.Author);
            authorElem.AppendChild(authorInnerText);
            bookElem.AppendChild(authorElem);
            XmlElement yersElem = _document.CreateElement("yers");
            XmlText yersInnerText = _document.CreateTextNode(book.Yers.ToString());
            yersElem.AppendChild(yersInnerText);
            bookElem.AppendChild(yersElem);
            xRoot.AppendChild(bookElem);
            _document.Save(_xmlFilePath);
        }
        public void Delete(string name)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeName = xNode.Attributes.GetNamedItem("name");
                    try
                    {
                        var attributeNameText = attributeName?.InnerText;
                        if (attributeNameText.Equals(name))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeName));
                    }
                }
            }
        }
        public Book FindBy(string name)
        {
            Book book = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xmlNode in xRoot)
            {
                book = GetBook(xmlNode);
                if (book.Name.Equals(name))
                {
                    return book;
                }
            }
            return book;
        }
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                var book = GetBook(node);
                books.Add(book);
            }
            return books;
        }
        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }
        private Book GetBook(XmlNode node)
        {
            var book = new Book();
            if (node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("name");
                book.Name = attributeName?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("author"))
                    {
                        book.Author = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("yers"))
                    {
                        book.Yers = int.Parse(childNode.InnerText);
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return book;
        }
    }
}
