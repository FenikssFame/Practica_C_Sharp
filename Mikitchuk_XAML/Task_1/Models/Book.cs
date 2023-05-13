using System.Text;

namespace Task_1.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string  Author { get; set; }
        public int Yers { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Название книги: {Name}")
                .AppendLine($"Автор: {Author}")
                .AppendLine($"Год издания: {Yers}")
                .ToString();
        }
    }
}
