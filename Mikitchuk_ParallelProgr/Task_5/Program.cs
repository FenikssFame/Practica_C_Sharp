namespace Task_5
{
    /// <summary>
    /// Выполнения метода Parallel.Foreach.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод выполнения.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            int[] array = InputNumInArray();
            ParallelLoopResult resultSum = Parallel.ForEach<int>(array, SumNumInArray);
            ParallelLoopResult resultMul = Parallel.ForEach<int>(array, MulNumInArray);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int[] InputNumInArray()
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите число в массив: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        /// <summary>
        /// Метод высчитывания суммы чисел от 0 до введенного значения.
        /// </summary>
        /// <param name="x">Параметр передаваемого числа.</param>
        public static void SumNumInArray(int x)
        {
            int result = 0;
            for (int i = 0;i < x; i++)
            {
                result += i;
            }
            Console.WriteLine($"Сумма значений до {x} = {result}");
        }
        /// <summary>
        /// Метод высчитывания произведения чисел от 0 до введенного значения.
        /// </summary>
        /// <param name="x">Параметр передаваемого числа.</param>
        public static void MulNumInArray(int x)
        {
            int result = 1;
            for (int i = 0; i < x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Произведение значений до {x} = {result}");
        }
    }
}