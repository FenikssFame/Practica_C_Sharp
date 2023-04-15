using System.Text.RegularExpressions;

namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("Найти в тексте цифры от 1 до 99");
            PrintMatchCollection(GetMatches(text));
        }
        public static MatchCollection GetMatches(string text)
        {
            Regex reg = new Regex(@"(\b[1-9]?[0-9]\b)", RegexOptions.IgnoreCase);
            MatchCollection match = reg.Matches(text);
            return match;
        }
        public static void PrintMatchCollection(MatchCollection matchCollection)
        {
            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}