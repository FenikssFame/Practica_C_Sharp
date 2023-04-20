namespace Task_1
{
    class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                ForSwitch();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ForSwitch()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Введите для вычисления площади прямоугольника-1, квадрата-2: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Rectangle();
                            break;
                        case 2:
                            Square();
                            break;
                        default:
                            Console.WriteLine("Нет такого пункта");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void NameFigure()
        {
            Quadrilateral q = new Quadrilateral();
            q.Input();
            Console.WriteLine(q.GetInfo());
        }
        public static void Rectangle()
        {
            try
            {
                NameFigure();
                Console.WriteLine("Вычисление площади прямоугольника");
                Rectangle r = new Rectangle();
                r.Input();
                r.SquareRectangle();
                Console.WriteLine(r.GetInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Square()
        {
            try
            {
                NameFigure();
                Console.WriteLine("Вычисление площади квадрата");
                Square s = new Square();
                s.Input();
                s.SquareSquare();
                Console.WriteLine(s.GetInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Quadrilateral
    {
        public string name;
        public Quadrilateral()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Console.Write("Введите название фигуры: ");
            name = Console.ReadLine();
        }
        public virtual string GetInfo()
        {
            return $"Название: {name} ";
        }
    }
    class Rectangle : Quadrilateral
    {
        public double sizeA;
        public double sizeB;
        public double S;
        public Rectangle() : base()
        {
            this.sizeA = 0;
            this.sizeB = 0;
        }
        public override void Input()
        {
            Console.Write("Введите длинну прямоугольника: ");
            sizeA = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            sizeB = double.Parse(Console.ReadLine());
        }
        public virtual void SquareRectangle()
        {
            S = sizeA * sizeB;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}Площадь прямоугольника: {S} ";
        }
    }
    class Square : Quadrilateral
    {
        public double sizeA;
        public double S;
        public Square() : base()
        {
            this.sizeA = 0;
        }
        public override void Input()
        {
            Console.Write("Введите сторону квадрата: ");
            sizeA = double.Parse(Console.ReadLine());
        }
        public virtual void SquareSquare()
        {
            S = Math.Pow(sizeA, 2);
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}Площадь квадрата: {S} ";
        }
    }
}