using System.Xml.Linq;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                MaxSquare(ForSwitch());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Quadrilateral[] ForSwitch()
        {
            try
            {
                int k = 5;
                Quadrilateral[] quadrilaterals = new Quadrilateral[k];
                for (int i = 0; i < k; i++)
                {
                     
                    Console.Write("Введите для вычисления площади прямоугольника-1, квадрата-2: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            quadrilaterals[i] = Rectangle();
                            break;
                        case 2:
                            quadrilaterals[i] = Square();
                            break;
                        default:
                            Console.WriteLine("Нет такого пункта");
                            break;
                    }
                }
                return quadrilaterals;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void MaxSquare(Quadrilateral[] q)
        {
            double max = q[0].Square();
            for (int i = 0; i < q.Length; i++)
            {
                if (max < q[i].Square())
                {
                    max = q[i].Square();
                }
            }
            Console.WriteLine($"Максимальная площадь: {max}");

        }
        public static string NameFigure()
        {
            Console.Write("Введите название фигуры: ");
            return Console.ReadLine();
        }
        public static Rectangle Rectangle()
        {
            try
            {
                Console.WriteLine("Вычисление площади прямоугольника");
                string name = NameFigure();
                Console.Write("Введите длинну прямоугольника: ");
                double sizeA = double.Parse(Console.ReadLine());
                Console.Write("Введите высоту прямоугольника: ");
                double sizeB = double.Parse(Console.ReadLine());
                Rectangle r = new Rectangle(name, sizeA, sizeB);
                r.Square();
                Console.WriteLine(r.GetInfo());
                return r; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static Squareq Square()
        {
            try
            {
                Console.WriteLine("Вычисление площади квадрата");
                string name = NameFigure();
                Console.Write("Введите сторону квадрата: ");
                double sizeA = double.Parse(Console.ReadLine());
                Squareq s = new Squareq(name, sizeA);
                Console.WriteLine(s.GetInfo());
                return s;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
    abstract class Quadrilateral
    {
        public string name;
        public Quadrilateral(string name)
        {
            this.name = name;
        }
        public abstract double Square();
        public virtual string GetInfo()
        {
            return $"Название: {name} ";
        }
    }
    class Rectangle : Quadrilateral
    {
        public double sizeA;
        public double sizeB;
        public Rectangle(string name, double sizeA, double sizeB) : base(name)
        {
            this.sizeA = sizeA;
            this.sizeB = sizeB;
        }
        public override double Square()
        {
            return sizeA * sizeB;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}Площадь прямоугольника: {Square()} ";
        }
    }
    class Squareq : Quadrilateral
    {
        public double sizeA;
        public Squareq(string name, double sizeA) : base(name)
        {
            this.sizeA = sizeA;
        }
        public override double Square()
        {
            return Math.Pow(sizeA, 2);
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}Площадь квадрата: {Square()} ";
        }
    }
}