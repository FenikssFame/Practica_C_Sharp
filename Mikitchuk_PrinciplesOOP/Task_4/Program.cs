namespace Task_4
{
    class Task_4
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double num = double.Parse(Console.ReadLine());
            if (num > 6.7)
            {
                Console.WriteLine($"y= {4 - Math.Pow(Math.E, 4 * num)}");
            }
            else
            {
                Console.WriteLine($"y= {Math.Log(3.5 + num)}");
            }
        }
    }
}