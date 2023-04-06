namespace Task_7
{
    class Task_7
    {
        public static void Main(string[] args)
        {
            const double a = 20; // 4

            double zedOne = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) /
                (Math.Cos(a) + 1 - 2 * Math.Sin(Math.Pow(2 * a, 2)));
            double zedTwo = 2 * Math.Sin(a);

            Console.WriteLine($"z1= {zedOne}\nz2= {zedTwo}");
        }
    }
}