namespace Task_6
{
    class Task_6
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(100, 1000);
            int result = num / 100 + num % 100 / 10;

            Console.WriteLine($"Исходное число: {num}\n" +
                $"Сумма первых двух чисел = {result}");
        }
    }
}
