namespace Task_10
{
    class Task_10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Числа сумма квадратов цифр которых кратна 13:");
            for (int i = 10; i < 100; i++)
            {
                if ((Math.Pow(i / 10, 2) + Math.Pow(i % 10, 2)) % 13 == 0)
                    Console.Write($"{i} ");
            }
        }
    }
}