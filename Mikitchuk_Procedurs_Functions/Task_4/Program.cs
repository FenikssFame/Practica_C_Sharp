namespace Task_4
{
    /// <summary>
    /// Главный класс выполнения программы методом Main.
    /// </summary>
    class Task_4
    {
        /// <summary>
        /// Главный метод выполнения программы.
        /// Вводится размерность двумерного массива.
        /// Создается ссылка на класс Array и выполняется два действия,
        /// первое с конструктором без параметров;
        /// второе с конструктором с параметрами.
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите размерность двумерного массива:\nСтрок= ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Колонок= ");
            int colum = int.Parse(Console.ReadLine());

            Console.WriteLine("Action One");
            Array array = new Array(row, colum);
            InputNumInMas(array, row, colum);
            Console.WriteLine($"Перемножением положительных элементов массива, меньших 10: {array.ArrayAction()}");
            
            Console.WriteLine("\nAction Two");
            Array ar = new Array();
            ar.CreateArrayMas(row, colum);
            InputNumInMas(ar, row, colum);
            int[,] mas = ar.GetArray();
            Console.WriteLine($"Перемножением положительных элементов массива, меньших 10: {ar.ArrayAction(mas)}");
        }
        /// <summary>
        /// Метод ввода значений в двумерный массив.
        /// </summary>
        /// <param name="array">Ссылка на класс Array.</param>
        /// <param name="row">Параметр количества строк в массиве.</param>
        /// <param name="colum">Параметр количества колонок в массиве.</param>
        private static void InputNumInMas(Array array, int row, int colum)
        {
            Console.WriteLine("Введите значения массива: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Console.Write(i + "," + j + "=");
                    int num = int.Parse(Console.ReadLine());
                    array.SetNumArray(num, i, j);
                }
            }
        }
    }
    /// <summary>
    /// Класс обработки и создания массива типа Array.
    /// </summary>
    public class Array
    {
        /// <summary>
        /// Закрытый, не инициализированный двумерный массив.
        /// </summary>
        private int[,] masDuo;
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Array()
        {

        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="row">Параметр количества строк в массиве.</param>
        /// <param name="colum">Параметр количества колонок в массиве.</param>
        public Array(int row, int colum)
        {
            masDuo = new int[row, colum];
        }
        /// <summary>
        /// Метод добавления значения в двумерный массив.
        /// </summary>
        /// <param name="x">Параметр добавляемого значения</param>
        /// <param name="i">Параметр номера строки</param>
        /// <param name="j">Параметр номера колонки</param>
        public void SetNumArray(int x, int i, int j)
        {
            masDuo[i, j] = x;
        }
        /// <summary>
        /// Метод инициализации двумерного массива.
        /// </summary>
        /// <param name="row">Параметр количества строк в массиве.</param>
        /// <param name="colum">Параметр количества колонок в массиве.</param>
        public void CreateArrayMas(int row, int colum)
        {
            masDuo = new int[row, colum];
        }
        /// <summary>
        /// Метод возвращения двумерного массива.
        /// </summary>
        /// <returns>Возаращает двумерный массив типа int.</returns>
        public int [,] GetArray()
        {
            return masDuo;
        }
        /// <summary>
        /// Метод суммирования значений двумерного массива в диапазоне 0&lt;i&lt;10.
        /// </summary>
        /// <returns>Возаращает сумму значений типа int.</returns>
        public int ArrayAction()
        {
            int result = 0;
            foreach (var i in masDuo)
            {
                if (i >= 0 && i < 10)
                {
                    result += i;
                }
            }
            return result;
        }
        /// <summary>
        /// Метод суммирования значений двумерного массива в диапазоне 0&lt;i&lt;10.
        /// </summary>
        /// <param name="mas">Параметр передаваемого массива</param>
        /// <returns>Возаращает сумму значений типа int.</returns>
        public int ArrayAction(int[,] mas)
        {
            int result = 0;
            foreach (var i in mas)
            {
                if (i >= 0 && i < 10)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}