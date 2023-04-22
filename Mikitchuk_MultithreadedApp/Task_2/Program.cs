namespace Task_2
{
    class Program
    {
        public static int Sum()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static void FirstThread()
        {
            Console.WriteLine("Вызов метода первым потоком: ");
            Console.WriteLine($"Сумма чисел = {Sum()}");
            Thread.Sleep(40);
            Console.WriteLine("Первый поток выполнен за {0} миллисекунд", DateTime.Now.Millisecond);
        }
        public static void SecondThread()
        {
            Console.WriteLine("Вызов метода вторым потоком: ");
            Console.WriteLine($"Сумма чисел = {Sum()}");
            Thread.Sleep(20);
            Console.WriteLine("Второй поток выполнен за {0} миллисекунд", DateTime.Now.Millisecond);
        }

        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread1.Start();
            thread2.Start();
        }
    }
}