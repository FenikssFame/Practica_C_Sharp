namespace Task_8
{
    class Task_8
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите начальное значение: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение: ");
            int end = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = start; i <= end; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Произведение: {result}");
        }
    }
}