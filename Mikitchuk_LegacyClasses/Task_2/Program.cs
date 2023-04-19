using Task_2;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                A objectMy = new A();
                Console.WriteLine($"Класс A без параметров\n{objectMy.c}");
                Console.WriteLine($"Класс A с параметрами");
                Console.Write($"Введите значение: ");
                int numOne = int.Parse(Console.ReadLine());
                Console.Write($"Введите значение: ");
                int numTwo = int.Parse(Console.ReadLine());
                A objectMy1 = new A(numOne, numTwo);
                Console.WriteLine(objectMy1.c);
                B objectMy2 = new B();
                Console.WriteLine($"Класс B без параметров\n{objectMy2.c2}");
                Console.WriteLine($"Класс B с параметрами");
                Console.Write("Введите действие (сложение-1 | вычитание-2): ");
                int operation = int.Parse(Console.ReadLine());
                Console.Write($"Введите значение: ");
                int numThree = int.Parse(Console.ReadLine());
                B objectMy3 = new B(operation, numOne, numTwo, numThree);
                Console.WriteLine(objectMy3.c2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class A
    {
        protected int a;
        protected int b;
        public int c
        {
            get
            {
                if (a > b)
                {
                    return a - b;
                }
                else
                {
                    return b - a;
                }
            }
            set { a = value; b = value; }
        }
        public A()
        {
            a = 1;
            b = 1;
        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class B : A
    {
        private int d;
        private int operation;
        public int c2
        {
            get
            {
                switch (operation)
                {
                    case 1:
                        return a + b + d;
                    case 2:
                        return a - b - d;
                    default:
                        return 0;
                }
            }
            set
            { a = value; b = value; d = value; }
        }
        public B()
        {
            a = 1;
            b = 1;
            d = 1;
        }
        public B(int operation, int a, int b, int d) : base(a, b)
        {
            this.d = d;
            this.operation = operation;
        }
    }
}