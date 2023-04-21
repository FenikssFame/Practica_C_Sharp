namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {

            CalkFigur cf = new CalkFigur(GetLength);
            cf += GetArea;
            cf += GetVolume;
            Console.Write("Введите радиус: ");
            cf(double.Parse(Console.ReadLine()));
        }
        public delegate double CalkFigur(double radius);
        static double GetLength(double r)
        {
            double D = 2 * Math.PI * r;
            Console.WriteLine($"Длинна окружности: {D}");
            return D;
        }
        static double GetArea(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга: {S}");
            return S;
        }
        static double GetVolume(double r)
        {
            double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Обьем шара: {V}");
            return V;
        }
    }
}