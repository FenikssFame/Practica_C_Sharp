namespace Task_5
{
    class Task_5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника:");
            Console.Write("a= ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double sideC = double.Parse(Console.ReadLine());
            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine($"Треугольник равносторонний");
            }
            else
            {
                Console.WriteLine($"Треугольник не равносторонний");
            }
        }
    }
}