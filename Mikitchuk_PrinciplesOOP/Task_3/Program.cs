namespace Task_3
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите целое число N (1<=n<=20): ");
            int num = int.Parse(Console.ReadLine());
            double number = 1.1;
            int minNum = 1;
            double result = 0;
            for (int i = 0; i < num; i++)
            {
                result += number * minNum;
                number += 0.1;
                minNum *= -1;

            }
            Console.WriteLine($"{result:F4}");
        }
    }
}