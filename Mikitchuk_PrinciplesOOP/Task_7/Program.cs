namespace Task_7
{
    class Task_7
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите начальное значение: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число (x) : ");
            int numX = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число (y): ");
            int numY = int.Parse(Console.ReadLine());

            Console.WriteLine("Цикл for");
            for (int i = end; i >= start; i--)
            {
                if (i % 2 == 0)
                {
                    if (i % 10 == numX || i % 10 == numY)
                    {
                        Console.Write($"Числo: {i} ");
                    }
                }
            }
            Console.WriteLine("\nЦикл while");
            int j = end;
            while ( j >= start)
            {
                if (j % 2 == 0)
                {
                    if (j % 10 == numX || j % 10 == numY)
                    {
                        Console.Write($"Числo: {j} ");
                    }
                }
                j--;
            }
            Console.WriteLine("\nЦикл do while");
            j = end;
            do
            {
                if (j % 2 == 0)
                {
                    if (j % 10 == numX || j % 10 == numY)
                    {
                        Console.Write($"Числo: {j} ");
                    }
                }
                j--;
            }
            while (j >= start);
        }
    }
}