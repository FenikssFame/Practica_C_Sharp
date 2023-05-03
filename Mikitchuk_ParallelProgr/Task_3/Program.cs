namespace Task_3
{
    /// <summary>
    /// Создание двух объектов класса Task.
    /// Первый объект возвращает результат вычисления,
    /// второй объект является задачей продолжения первого объекта и выводит результат первой задачи на консоль.
    /// Дано трёхзначное число. Найти сумму его первой и второй цифр.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод выполнения.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int num = int.Parse(Console.ReadLine());
            Task<int> task1 = new Task<int>(() => SumFerstSecondNumbers(num));
            task1.Start();
            Task task2 = Task.Run(() => Console.WriteLine(task1.Result));
        }
        /// <summary>
        /// Метод вычисления суммы первой и второй цифры трехзначного числа.
        /// </summary>
        /// <param name="num">Параметр трехзначное число.</param>
        /// <returns>Возвращает сумму типа int.</returns>
        public static int SumFerstSecondNumbers(int num)
        {
            return (num/100) + (num/10%10);
        }
    }
}