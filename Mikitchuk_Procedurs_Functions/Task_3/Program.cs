namespace Task_3
{
    /// <summary>
    /// Главный класс.
    /// Выполнение метода Main.
    /// </summary>
    class Task_3
    {
        /// <summary>
        /// Главный метод.
        /// Вводятся значения.
        /// Создается ссылка на класс Program.
        /// Выполняется цикл вывода значений результата функции.
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите начальное значение: ");
            double start = double.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение: ");
            double finish = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг: ");
            double step = double.Parse(Console.ReadLine());
            Program pr = new Program();
            for (double i = start; i <= finish; i += step)
            {
                double result = 0;
                pr.F(i, out result);
                Console.WriteLine($"F(x)= {result}");
            }
        }
    }
    /// <summary>
    /// Класс высчитывания функции(F)
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод для вычисления функции 
        /// x&lt;0 = 0;
        /// 0&lt;x!=1 = x^2+1;
        /// x&gt;1 = 1.
        /// </summary>
        /// <param name="x">Значения типа double для вычисления функции.</param>
        /// <param name="y">Возвращает рещультат вычисления функции.</param>
        public void F(double x, out double y)
        {

                if (x < 0)
                {
                    y =0;
                }
                else if (x > 0 && x != 1)
                {
                    y = (Math.Pow(x, 2) + 1);
                }
                else
                {
                    y = 1;
                }

        }
    }
}