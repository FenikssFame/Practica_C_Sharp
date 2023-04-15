namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(GetTextWhereFerstEquallyLast(AddWordsInMassiv(text)));
        }
        public static string[] AddWordsInMassiv(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        public static string GetTextWhereFerstEquallyLast(string[] words)
        {
            string text = "";
            foreach (string word in words)
            {
                if (word.LastIndexOf(word[0]) == word.Length - 1)
                {
                    text += " " + word;
                }
            }
            return text;
        }
    }
}