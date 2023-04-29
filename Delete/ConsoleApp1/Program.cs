using Delete;
namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
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
    }
}