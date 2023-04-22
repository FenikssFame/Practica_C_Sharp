namespace Task_2
{
    class Program
    {
        delegate void EventDelegate(double side);
        public static void Main(string[] args)
        {
            try
            {
                EventDelegate del = new EventDelegate(GetPerimetr);
                del += GetAreaSquare;
                del += GetSideTriangle;
                PrintDelegate(del);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void PrintDelegate(EventDelegate delegat)
        {
            try
            {
                Console.Write("Введите значение: ");
                delegat(double.Parse(Console.ReadLine()));
            }
            catch (FormatException ex)
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