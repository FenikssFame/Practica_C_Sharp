namespace Task_4
{
    /// <summary>
    /// Выполнение параллельного вычисления значений функции для каждого значения на отрезке.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод выполнения.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите начальное число: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное число: ");
            int finish = int.Parse(Console.ReadLine());
            Parallel.For(start, finish, F);
        }
        /// <summary>
        /// Метод высчитывания функции cos(x).
        /// Вывод результата в консоль.
        /// </summary>
        /// <param name="x">Параметр передаваемого числа.</param>
        public static void F(int x)
        {
            Console.WriteLine(Math.Cos(x));    
        }
    }
}