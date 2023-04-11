namespace Task_1
{
    class Task_1
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"После функции: {F(num)}");
        }
        public static int F(int num)
        {
            int result = 0;
            if (num > 9 && num < 100)
            {
                result = num / 10 + num % 10 * 10;
            }
            else
            {
                result = num;
            }
            return result;
        }
    }
}
