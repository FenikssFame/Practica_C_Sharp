namespace Task_9
{
    class Task_9
    {
        public static void Main(string[] args)
        {
            const int numM = 20;
            const double start = Math.PI / 4;
            const double end = 4 / Math.PI;

            double numH = (end - start) / numM;
            for (double i = start; i <= end; i += numH)
            {
                Console.WriteLine($"F({i})= {Math.Cos(1 / i)}");
            }
        }
    }
}