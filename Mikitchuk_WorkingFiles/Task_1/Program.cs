namespace Task_1
{
    /// <summary>
    /// Главный класс выполнения программы методом Main.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод вывода в консоль суммы наибольшего и наименьшего значений файла.
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
        static void Main(string[] args)
        {
            string path = "..\\..\\..\\f.txt";
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string s;
            int n = 0;
            while ((s = reader.ReadLine()) != null)
            {
                n++;
            }
            reader.Close();
            Console.WriteLine($"Сумма наибольшего и наименьшего значений компонент: " +
                $"{SumMaxMinFromArray(FillArrayFromFile(n, path))}");
        }
        /// <summary>
        /// Метод подсчитывает сумму максимального и минимального значения.
        /// </summary>
        /// <param name="array">Параметр массив.</param>
        /// <returns></returns>
        public static double SumMaxMinFromArray(double[] array)
        {

            return array.Max() + array.Min();
        }
        /// <summary>
        /// Метод считывания файла в массив.
        /// </summary>
        /// <param name="n">Параметр еоличества строк массива.</param>
        /// <param name="path">Параметр пути к файлу.</param>
        /// <returns></returns>
        public static double[] FillArrayFromFile(int n, string path)
        {
            FileStream file1 = new FileStream(@path, FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(reader1.ReadLine());
            }
            file1.Close();
            return array;
        }
    }
}