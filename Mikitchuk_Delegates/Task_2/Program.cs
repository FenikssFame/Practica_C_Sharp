namespace Task_2
{
    delegate void DelegatCalculator();
    class Program
    {
        static void Main()
        {
            try
            {
                MyEvent evt = new MyEvent();
                Console.Write("Введите действие (+,-,*,/): ");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "+":
                        evt.activate += new DelegatCalculator(Add);
                        evt.fire();
                        break;
                    case "-":
                        evt.activate += new DelegatCalculator(Sub);
                        evt.fire();
                        break;
                    case "*":
                        evt.activate += new DelegatCalculator(Mul);
                        evt.fire();
                        break;
                    case "/":
                        evt.activate += new DelegatCalculator(Div);
                        evt.fire();
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода операции!");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка \n{0}", e);
            }
        }
        static (int, int) Input()
        {
            Console.Write("Первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            return (x, y);
        }
        static void Add()
        {
            (int c, int b) = Input();
            Console.WriteLine("Ответ:{0}", c + b);
        }
        static void Sub()
        {
            (int c, int b) = Input();
            Console.WriteLine("Ответ:{0}", c - b);
        }
        static void Mul()
        {
            (int c, int b) = Input();
            Console.WriteLine("Ответ:{0}", c * b);
        }
        static void Div()
        {
            try
            {
                (int c, int b) = Input();
                if (b == 0) throw new DivideByZeroException();
                Console.WriteLine("Ответ:{0}", c / b);
            }
            catch
            {
                Console.WriteLine("Деление на ноль!");
            }
        }
    }
    class MyEvent
    {
        public event DelegatCalculator activate;
        public void fire()
        {
            if (activate != null)
            {
                activate();
            }
        }
    }
}