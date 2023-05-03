namespace Task_1
{
    /// <summary>
    /// Реализация решения задачи выполнения в объектах класса Task используя
    /// три варианта создания объектов класса Task: 
    /// Дано четырехзначное число. 
    /// Найти число, образуемое при перестановке второй и третьей цифр заданного числа.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод выполнения.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            string num = Console.ReadLine();
            Console.WriteLine("TaskOne");
            Task task1 = new Task(() => Console.WriteLine(PermutationSecondTherdNumbrs(num)));
            task1.Start();
            Console.WriteLine("TaskTwo");
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine(PermutationSecondTherdNumbrs(num)));
            Console.WriteLine("TaskThree");
            Task task3 = Task.Run(() => Console.WriteLine(PermutationSecondTherdNumbrs(num)));
        }
        /// <summary>
        /// Метод перестановки второй и третьей цифры в четырехзначном числе.
        /// </summary>
        /// <param name="number">Параметр четырехзначное число</param>
        /// <returns>Возвращает измененную числовую строку.</returns>
        public static string PermutationSecondTherdNumbrs(string number)
        {
            return $"{number[0]}{number[2]}{number[1]}{number[3]}";
        }
    }
}