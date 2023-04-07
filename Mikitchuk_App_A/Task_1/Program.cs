namespace Task_1
{
    class Task_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественные числа:");
            Console.Write("a= ");
            double num_a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double num_b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double num_c = double.Parse(Console.ReadLine());
            Console.Write("d= ");
            double num_d = double.Parse(Console.ReadLine());

            double rezult = num_a / num_b + num_c / num_d;

            Console.WriteLine($"{num_a:F2} / {num_b:F2} + {num_c:F2} / {num_d:F2} = {rezult:F2}");
        }
    }
}
