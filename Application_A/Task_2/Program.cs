namespace Task_2
{
    class Task_2
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            string num = Convert.ToString(rnd.Next(1000,10000));

            Console.WriteLine($"Исходное число = {num}\n" +
                $"После перестановки = {num[0]}{num[2]}{num[1]}{num[3]}");
        }
    }
}