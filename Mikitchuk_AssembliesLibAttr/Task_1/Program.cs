using AppliancesLibrary;
using MyLibrary;
using Rectangle = MyLibrary.Rectangle;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //StartMyLirary();
                StartAppliancesLibrary();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void StartMyLirary()
        {
            try
            {
                Console.WriteLine("Треугольника");
                Triangle tria = new Triangle();
                Console.Write("Введите сторону А: ");
                tria.A = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону B: ");
                tria.B = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону С: ");
                tria.C = double.Parse(Console.ReadLine());
                Console.WriteLine($"Существует ли треугольник: {tria.IsTriangle}");
                Console.WriteLine($"Периметр треугольника: {tria.CalcPerimeter()}");
                Console.WriteLine($"Площадь треугольника: {tria.CalcArea()}");
                Console.WriteLine($"Вид треугольника: {tria.FormTriangling()}");
                Console.WriteLine("Прямоугольник");
                Rectangle rec = new Rectangle();
                Console.Write("Введите сторону А: ");
                rec.A = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону B: ");
                rec.B = double.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр прямоугольника: {rec.CalcPerimeter()}");
                Console.WriteLine($"Площадь прямоугольника: {rec.CalcArea()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void StartAppliancesLibrary()
        {
            try
            {
                Appliances appl = new Appliances();
                Console.Write("Введите марку техники: ");
                appl.Mark = Console.ReadLine();
                Console.Write("Введите модель техники: ");
                appl.Model = Console.ReadLine();
                Console.Write("Введите название техники: ");
                appl.Name = Console.ReadLine();
                Console.Write("Введите тип поверхности техники: ");
                appl.Body = Console.ReadLine();
                Console.Write("Введите высоту техники: ");
                appl.Height = double.Parse(Console.ReadLine());
                Console.Write("Введите длинну техники: ");
                appl.Length = double.Parse(Console.ReadLine());
                Console.Write("Введите ширину техники: ");
                appl.Width = double.Parse(Console.ReadLine());
                Console.Write("Введите цену техники: ");
                appl.Cost = double.Parse(Console.ReadLine());
                double area = appl.CalcArea();
                string type = appl.TypeAppliances();
                double costAll = appl.CalcCostTransporting();
                Console.WriteLine($"{appl.ToString()}Площадь занимаемой поверхности: {area}\n" +
                    $"Тип техники: {type}\n" +
                    $"Стоимость с транспортировкой: {costAll}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}