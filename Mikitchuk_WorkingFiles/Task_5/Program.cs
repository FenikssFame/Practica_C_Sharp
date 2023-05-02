namespace Task_5
{
    /// <summary>
    /// Главный класс выполнения программы методом Main.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы реализующий действия над файлвми.
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
        public static void Main(string[] args)
        {
            string fileNaameOne = "f1.txt";
            string fileNaameTwo = "f2.txt";
            string fileNaameThree = "f3.txt";
            Console.WriteLine($"Файл {fileNaameOne}");
            string pathOne = CreateNewFile(fileNaameOne);
            SetInFile(pathOne);
            OutputFile(pathOne);
            Console.WriteLine($"Файл {fileNaameTwo}");
            string pathTwo = CreateNewFile(fileNaameTwo);
            SetInFile(pathTwo);
            OutputFile(pathTwo);
            Console.WriteLine($"Файл {fileNaameThree}");
            string pathThree = CreateNewFile(fileNaameThree);
            Generalization(pathOne, pathTwo, pathThree);
            SortedFile(pathThree);
            OutputFile(pathThree);
        }
        /// <summary>
        /// Метод соединения значений из двух файлов в третий.
        /// </summary>
        /// <param name="pathOne">Название первого файла</param>
        /// <param name="pathTwo">Название второго файла</param>
        /// <param name="pathWriter">Параметр пути к файлу записи</param>
        public static void Generalization(string pathOne, string pathTwo, string pathWriter)
        {
            string[] file1 = File.ReadAllLines(pathOne);
            string[] file2 = File.ReadAllLines(pathTwo);
            StreamWriter writer = File.CreateText(pathWriter);
            int lineNum = 0;
            while (lineNum < file1.Length || lineNum < file2.Length)
            {
                if (lineNum < file1.Length)
                    writer.WriteLine(file1[lineNum]);
                if (lineNum < file2.Length)
                    writer.WriteLine(file2[lineNum]);
                lineNum++;
            }
            writer.Close();
        }
        /// <summary>
        /// Метод создания файла и присвоения ему названия.
        /// </summary>
        /// <param name="fileName">Параметр название файла</param>
        /// <returns>Возвращает путь к файлу.</returns>
        public static string CreateNewFile(string fileName)
        {
            string path = @"..\..\..\..\" + fileName;
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            file.Close();
            return path;
        }
        /// <summary>
        /// Метод генерации списка чисел.
        /// </summary>
        /// <returns>Возвращает список значений.</returns>
        public static List<int> GenerationIntegerNumbers()
        {
            Random rnd = new Random();
            List<int> array = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                array.Add(rnd.Next(100));
            }
            array.Sort();
            return array;
        }
        /// <summary>
        /// Метод добавления в файл значений из списка.
        /// </summary>
        /// <param name="path">Параметр пути к файлу.</param>
        public static void SetInFile(string path)
        {
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamWriter writer = new StreamWriter(file);
            List<int> array = GenerationIntegerNumbers();
            for (int i = 0; i < array.Count; i++)
                writer.WriteLine(array[i]);
            writer.Close();
        }
        /// <summary>
        /// Метод вывода значений из файла.
        /// </summary>
        /// <param name="path">Параметр пути к файлу.</param>
        public static void OutputFile(string path)
        {
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                Console.Write(line + " ");
            }
            Console.WriteLine();
            reader.Close();
        }
        /// <summary>
        /// Метод сортировки значений файла.
        /// </summary>
        /// <param name="path">Параметр пути к файлу.</param>
        public static void SortedFile(string path)
        {
            List<string> lines = File.ReadAllLines(path).ToList();
            List<int> list = lines.Select(int.Parse).ToList();
            list.Sort();
            StreamWriter writer = new StreamWriter(path);
            for (int i = 0; i < list.Count; i++)
                writer.WriteLine(list[i]);
            writer.Close();
        }
    }
}