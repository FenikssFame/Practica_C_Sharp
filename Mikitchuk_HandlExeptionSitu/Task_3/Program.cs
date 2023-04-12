namespace Task_3
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Введите первое число: ");
                    double numA = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double numB = double.Parse(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    double numC = double.Parse(Console.ReadLine());
                    Tuple<double, double, double> tuple = SortInc3(numA, numB, numC);
                    Console.WriteLine($"Отсортированное: {tuple.Item1},{tuple.Item2},{tuple.Item3}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Попытка передать в метод аргумент неверного формата");
            }
        }
        public static Tuple<double, double, double> SortInc3(double numA,double numB, double numC)
        {
            List<double> mas = new List<double> { numA, numB, numC };
            mas.Sort();
            return Tuple.Create(mas[0], mas[1], mas[2]);

        }
    }
}