using System.Runtime.CompilerServices;
using System.Text;

namespace Task_4
{
    class Program
    {
        public static int sum = 0;
        public static int n = 0;
        public static int a = 0;
        public static int b = 0;
        public static Barrier barrier = new Barrier(2, (b) =>
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(" ");
            }
        });
        public static void Main(string[] args)
        {
            Console.Write("Введите кол-во последовательностей: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите шаг: ");
            b = int.Parse(Console.ReadLine());
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();
            for (int i = 0; i < n; i++)
            {
                a += b;
                if (a % 2 == 0)
                {
                    Console.WriteLine("Главный поток:");
                    Console.WriteLine(sum + a);
                    barrier.SignalAndWait();
                }
            }
        }
        public static void Count()
        {
            for (int i = 0; i < n; i++)
            {
                a += b;
                if (a % 2 == 0)
                {
                    Console.WriteLine("Второй поток:");
                    Console.WriteLine(sum + a);
                    barrier.SignalAndWait();
                }
            }
        }
    }
}