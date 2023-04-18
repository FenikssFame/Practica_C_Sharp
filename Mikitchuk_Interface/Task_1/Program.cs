using Task_1;

namespace Task_1
{
    // Пара интерфейсов, содержащих объявления одноимённых методов
    // с одной и той же сигнатурой.
    interface Ix
    {
        int IxF0(int num);
        int IxF1();
    }
    interface Iy
    {
        int F0(int num);
        int F1();
    }
    interface Iz
    {
        int F0(int num);
        int F1();
    }
    class TestClass : Ix, Iy, Iz
    {
        public int wValue;
        public TestClass()
        {
            wValue = 12;
        }
        public TestClass(int value)
        {
            wValue = value;
        }
        // Реализация неявная и однозначная
        public int IxF0(int num)
        {
            wValue = 7 * num;
            return wValue;
        }
        public int IxF1()
        {
            wValue = 7 * wValue;
            return wValue;
        }
        // Неявная неоднозначная реализация интерфейсов
        public int F0(int num)
        {
            wValue = num * 8;
            return wValue;
        }
        public int F1()
        {
            wValue = wValue * 8;
            return wValue;
        }
        // Явная непосредственная реализация интерфейса
        int Iz.F0(int num)
        {
            wValue = 6 + num;
            return wValue;
        }
        int Iz.F1()
        {
            wValue = 6 + wValue;
            return wValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для функции F1: ");
            int numF1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число для функции F0: ");
            int numF0 = int.Parse(Console.ReadLine());
            TestClass tc = new TestClass();
            TestClass tcNum = new TestClass(numF1);
            // Неявная неоднозначная реализация интерфейсов Iy и Iz
            Console.WriteLine($"Неявная неоднозначная реализация интерфейсов\n" +
                $"Iy и Iz = {tc.F0(numF0)}\n" +
                $"Iy и Iz = {tcNum.F1()}");
            // Явное приведение к типу интерфейса
            Console.WriteLine($"Явное приведение к типу интерфейса\n" +
                $"Iy = {(tc as Iy).F0(numF0)}\n" +
                $"Iy = {(tcNum as Iy).F1()}\n" +
                $"Iz = {(tc as Iz).F0(numF0)} \n" +
                $"Iz = {(tcNum as Iz).F1()}");
            // Ссылки различных типов интерфейсов
            Console.WriteLine("Ссылки различных типов интерфейсов");
            Ix ix = tcNum;
            Console.WriteLine($"IxF0 = {ix.IxF0(numF0)}\n" +
                $"IxF1 = {ix.IxF1()}");
            Iy iy = tcNum;
            Console.WriteLine($"IyF0 = {iy.F0(numF0)}\n" +
                $"IyF1 = {iy.F1()}");
            Iz iz = tcNum;
            Console.WriteLine($"IxF0 = {iz.F0(numF0)}\n" +
                $"IxF1 = {iz.F1()}");
        }
    }
}
