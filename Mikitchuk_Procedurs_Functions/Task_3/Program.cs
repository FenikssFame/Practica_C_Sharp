namespace Task_3
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите начальное значение: ");
            double start = double.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение: ");
            double finish = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг: ");
            double step = double.Parse(Console.ReadLine());
            Program pr = new Program();
            for (double i = start; i <= finish; i += step)
            {
                double result = 0;
                pr.F(i, out result);
                Console.WriteLine($"F(x)= {result}");
            }
        }
    }
    class Program
    {
        public void F(double x, out double y)
        {

                if (x < 0)
                {
                    y =0;
                }
                else if (x > 0 && x != 1)
                {
                    y = (Math.Pow(x, 2) + 1);
                }
                else
                {
                    y = 1;
                }

        }
    }
}