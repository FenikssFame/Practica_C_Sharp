namespace Task_3
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            const double x = 1;

            double y = Math.Log(Math.Pow(x, 2)) +
                (Math.Sin(Math.Pow(x, 2) + 1)) /
                (2 * Math.Sqrt(Math.Pow(Math.E, 2) + 1) - Math.Cos(x - Math.PI));

            Console.WriteLine($"y = {y}");
        }
    }
}
