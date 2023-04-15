using System.Text.RegularExpressions;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Слова с 3 подряд соглассными");
            PrintMatchCollection(GetMatches(text));
        }
        public static MatchCollection GetMatches(string text)
        {
            Regex reg = new Regex(@"\b\w*([бвгджзйклмнпрстфхцчшщ]{3,})\w*\b");
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