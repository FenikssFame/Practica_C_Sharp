namespace Task_2
{
    class Task_2
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
            foreach (double num in pr.F(start, finish, step))
            {
                Console.WriteLine($"F(x)= {num}");
            }
        }
    }
    class Program
    {
        public List<double> F(double start, double finish, double h)
        {
            List<double> list = new List<double>();
            for (double i = start; i <= finish; i += h)
            {
                if (i < 0)
                {
                    list.Add(0);
                }
                else if (i > 0 && i != 1)
                {
                    list.Add(Math.Pow(i, 2) +1);
                }
                else
                {
                    list.Add(1);
                }
            }
            return list;
        }
    }
}