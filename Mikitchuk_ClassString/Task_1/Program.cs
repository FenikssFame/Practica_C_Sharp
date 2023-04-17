namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            Console.WriteLine(GetMassivWordsInsertNumber(AddWordsInMassiv(text)));
        }
        public static string[] AddWordsInMassiv(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        public static string GetMassivWordsInsertNumber(string[] words)
        {
            string text = "";
            foreach (string word in words)
            {
                if (word.LastIndexOfAny(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }) > -1)
                {
                    text += " " + word;
                }
            }
            return text;
        }
    }
}