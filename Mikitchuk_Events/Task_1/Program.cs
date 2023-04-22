namespace Task_1
{
    delegate void EventDelegate(double side);
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
            EventDelegate del = new EventDelegate(GetPerimetr);
            del += GetAreaSquare;
            del += GetSideTriangle;
            Console.Write("Введите значение: ");
            del(double.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void GetPerimetr(double sideA)
        {
            Console.WriteLine($"Периметр квадрата: {4 * sideA}");
        }
        static void GetAreaSquare(double sizeA)
        {
            Console.WriteLine($"Площадь квадрата: {Math.Pow(sizeA, 2)}");
        }
        static void GetSideTriangle(double side)
        {
            Console.WriteLine($"Сторона треугольника: {side}");
        }
    }
}