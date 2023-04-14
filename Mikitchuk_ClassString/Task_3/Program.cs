namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            Console.WriteLine($"\nПоменять местами первое и последнее слова в предложении \n{GetSubstitution(text)}");
            Console.WriteLine($"\nСклеить второе и третье слова в предложении \n{GetGluiSecondAndThirdWords(text)}");
            Console.WriteLine($"\nТретье слово предложения вывести в обратном порядке \n{GetReversThirdWord(text)}");
            Console.WriteLine($"\nВырезать первые две буквы \n{CutTwoCharInFerstWord(text)}");
        }
        public static string GetSubstitution(string text)
        {
            string ferstWord = text.Substring(0, text.IndexOf(" "));
            string lastWord = text.Substring(text.LastIndexOf(" ") + 1);
            string newText = text.Remove(text.LastIndexOf(" ") + 1);
            return newText.Replace(ferstWord, lastWord) + ferstWord;
        }
        public static string GetGluiSecondAndThirdWords(string text)
        {
            return text.Remove(text.IndexOf(" ", text.IndexOf(" ") + 1), 1);
        }
        public static string GetReversThirdWord(string text)
        {
            string word = text.Substring(text.IndexOf(" ") + 1, text.IndexOf(" "));
            string reversWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversWord += word[i];
            }
            return reversWord;
        }
        public static string CutTwoCharInFerstWord(string text)
        {
            return text.Remove(0, 2);
        }
    }
}