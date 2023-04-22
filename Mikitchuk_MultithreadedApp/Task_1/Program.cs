namespace Task_1
{
    class Program
    {
        public static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(120);
                Console.Write($"{i} ");
            }
        }
        public static void SecondThread()
        {
            for (int i = 10; i < 20; i++)
            {
                Thread.Sleep(120);
                Console.Write($"{i} ");
            }
        }
        public static void ThirdThread()
        {
            for (int i = 20; i < 30; i++)
            {
                Thread.Sleep(120);
                Console.Write($"{i} ");
            }
        }
        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;
            thread3.Priority = ThreadPriority.Normal;
            Console.Write("Первый поток: ");
            thread1.Start();
            thread1.Join();
            Console.Write("\nВторой поток: ");
            thread2.Start();
            thread2.Join();
            Console.Write("\nТретий поток: ");
            thread3.Start();
            thread3.Join();
            Console.WriteLine("\nВыполнено");
        }
    }
}