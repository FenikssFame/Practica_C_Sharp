namespace Task_1
{
    /// <summary>
    /// Главный класс выполнения программы методом Main.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы реализующий вычисления окружности.
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
        public static void Main(string[] args)
        {

            CalkFigur cf = new CalkFigur(GetLength);
            cf += GetArea;
            cf += GetVolume;
            Console.Write("Введите радиус: ");
            cf(double.Parse(Console.ReadLine()));
        }
        /// <summary>
        /// Делегат вызывающий методы вычисления длинны, площади и обьема окружности.
        /// </summary>
        /// <param name="radius">Параметр радиуса окружности.</param>
        /// <returns></returns>
        public delegate double CalkFigur(double radius);
        /// <summary>
        /// Метод вычисления длинны окружности.
        /// </summary>
        /// <param name="r">Параметр радиуса окружности.</param>
        /// <returns></returns>
        static double GetLength(double r)
        {
            double D = 2 * Math.PI * r;
            Console.WriteLine($"Длинна окружности: {D}");
            return D;
        }
        /// <summary>
        /// Метод вычисления площади окружности.
        /// </summary>
        /// <param name="r">Параметр радиуса окружности.</param>
        /// <returns></returns>
        static double GetArea(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга: {S}");
            return S;
        }
        /// <summary>
        /// Метод вычисления обьема окружности.
        /// </summary>
        /// <param name="r">Параметр радиуса окружности.</param>
        /// <returns></returns>
        static double GetVolume(double r)
        {
            double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Обьем шара: {V}");
            return V;
        }
    }
}