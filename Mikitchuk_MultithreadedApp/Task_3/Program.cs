namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
            Console.WriteLine("Одновременно запущеные потоки");
            TwoThread();
        }
        public static void Sum()
        {
            Console.Write("Введите число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());
            double sum = a;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }
            Console.WriteLine($"Сумма = {sum}");
        }
        public static void Mul()
        {
            Console.Write("Введите число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());
            double mult = a;

            for (int i = 1; i <= n; i++)
            {
                mult += Math.Pow(a, i);
            }
            Console.WriteLine($"Произведение = {mult}");
        }
        public static void FirstThread()
        {
            Console.WriteLine("Вызов метода первым потоком: ");
            Mul();
        }
        public static void SecondThread()
        {
            Console.WriteLine("Вызов метода вторым потоком: ");
            Mul();
        }
        public static void TwoThread()
        {
            Thread thread1 = new Thread(new ThreadStart(Sum));
            Thread thread2 = new Thread(new ThreadStart(Sum));
            thread1.Start();
            thread2.Start();
        }
    }
}