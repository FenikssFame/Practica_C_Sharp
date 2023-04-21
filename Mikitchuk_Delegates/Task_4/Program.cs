namespace Task_4
{
    public delegate int DelegatCalculator();
    public delegate int MediumCalcc(DelegatCalculator[] array);
    class Program
    {
        private static readonly Random rnd = new Random();

        public static int Randomizer()
        {
            return rnd.Next(10);
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Числа для выполнения последовательных орераций с ними (+,-,*,/)");
                DelegatCalculator[] delCalc = new DelegatCalculator[4];
                delCalc[0] = new DelegatCalculator(Add);
                delCalc[1] = new DelegatCalculator(Sub);
                delCalc[2] = new DelegatCalculator(Mul);
                delCalc[3] = new DelegatCalculator(Div);
                MediumCalcc mediumCalc = delegate (DelegatCalculator[] array)
                {
                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i]();
                    }
                    Console.WriteLine($"Сумма: {sum}");
                    return ((sum) / (array.Length));
                };
                Console.WriteLine($"Среднее: {mediumCalc(delCalc)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка \n{0}", e);
            }
        }
        static (int, int) Input()
        {
            int x = Randomizer();
            int y = Randomizer();
            return (x, y);
        }
        static int Add()
        {
            (int c, int b) = Input();
            Console.WriteLine($"Ответ:{c + b}");
            int z = c + b;
            return z;
        }
        static int Sub()
        {
            (int c, int b) = Input();
            Console.WriteLine($"Ответ:{c - b}");
            int z = c - b;
            return z;
        }
        static int Mul()
        {
            (int c, int b) = Input();
            Console.WriteLine($"Ответ:{c * b}");

            int z = c * b;
            return z;
        }
        static int Div()
        {
            try
            {
                (int c, int b) = Input();
                if (b == 0)
                Console.WriteLine($"Ответ:{c / b}");

                int z = c / b;
                return z;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}