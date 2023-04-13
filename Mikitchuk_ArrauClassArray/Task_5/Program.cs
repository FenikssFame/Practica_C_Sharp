namespace Task_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число для возведения в факториал: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Факториал({number})= {Function(number):F4}");
        }
        public static double Function(int number)
        {
            double result = Factorial(number - 1) / Factorial(number);
            return result;
        }
        public static int Factorial(int number)
        {
            int result;
            if (number == 0 || number == 1)
            {
                result = 1;
            }
            else
            {
                result = Factorial(number - 1) * number;
            }
            return result;
        }
    }
}