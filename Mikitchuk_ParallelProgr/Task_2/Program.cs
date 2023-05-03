namespace Task_2
{
    /// <summary>
    /// Создание массива из 2 задач (объектов класс Task)
    /// в каждом объекте выполняется вычисление значения функций
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод выполнения.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double num = double.Parse(Console.ReadLine());
            Task[] tasks1 = new Task[2]
            {
                new Task(() => Console.WriteLine(FOne(num))),
                new Task(() => Console.WriteLine(FTwo(num)))
            };
            Console.WriteLine("Выполнение двух хадач");
            foreach (var t in tasks1)
            {
                t.Start();
                Thread.Sleep(50);
            }
        }
        /// <summary>
        /// Метод вычисления уравнения sin2x+sin5x-sin3x/cosx+1-2*sin^(2)2x.
        /// </summary>
        /// <param name="x">Параметр числа.</param>
        /// <returns>Возвращает результат типа double.</returns>
        public static double FOne(double x)
        {
            return (Math.Sin(2 * x) + Math.Sin(5 * x) - Math.Sin(3 * x)) /
                (Math.Cos(x) + 1 - 2 * Math.Sin(Math.Pow(2 * x, 2)));
        }
        /// <summary>
        /// Метод вычисления уравнения 2sinx.
        /// </summary>
        /// <param name="x">Параметр числа.</param>
        /// <returns>Возвращает результат типа double.</returns>
        public static double FTwo(double x)
        {
            return 2 * Math.Sin(x);
        }
    }
}