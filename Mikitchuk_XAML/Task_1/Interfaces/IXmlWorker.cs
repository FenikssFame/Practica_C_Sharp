using System.Collections.Generic;
using Task_1.Models;

namespace Task_1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Book book);
        void Delete(string name);
        Book FindBy(string name);
        List<Book> GetAll();
    }
}
