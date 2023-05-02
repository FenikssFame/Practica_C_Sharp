namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine(TextTransformation(text));

        }
        public static string TextTransformation(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in text)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            string result = new string(stack.Reverse().ToArray());
            return result;
        }
    }
}