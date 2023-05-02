namespace Task_1
{/// <summary>
/// Главный класс в котором вводится число для выполнения функции (F). 
/// Результат выводится на консоль.
/// </summary>
    class Task_1
    {
        /// <summary>
        /// Главный метод запуска программы
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"После функции: {F(num)}");
        }
        /// <summary>
        /// Метод вычисляет функцию в зависимости от введенного значения.
        /// </summary>
        /// <param name="num">Число для подсчета функции</param>
        /// <returns>Возвращает число типа int.</returns>
        public static int F(int num)
        {
            int result = 0;
            if (num > 9 && num < 100)
            {
                result = num / 10 + num % 10 * 10;
            }
            else
            {
                result = num;
            }
            return result;
        }
    }
}
