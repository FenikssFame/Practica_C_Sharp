namespace Task_2
{
    /// <summary>
    /// Главный класс.
    /// Выполнение метода Main.
    /// </summary>
    class Task_2
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
            foreach (double num in pr.F(start, finish, step))
            {
                Console.WriteLine($"F(x)= {num}");
            }
        }
    }
    /// <summary>
    /// Класс высчитывания функции
    /// </summary>
    class Program
    {
        /// <summary>
        /// Функция вычисления значений на отрезке с завданым шагом.
        /// </summary>
        /// <param name="start">Начальное значение отрезка</param>
        /// <param name="finish">Конечное значение отрезка</param>
        /// <param name="h">Шаг передвижения по отрезку</param>
        /// <returns>Возвращает List типа double.</returns>
        public List<double> F(double start, double finish, double h)
        {
            List<double> list = new List<double>();
            for (double i = start; i <= finish; i += h)
            {
                if (i < 0)
                {
                    list.Add(0);
                }
                else if (i > 0 && i != 1)
                {
                    list.Add(Math.Pow(i, 2) +1);
                }
                else
                {
                    list.Add(1);
                }
            }
            return list;
        }
    }
}