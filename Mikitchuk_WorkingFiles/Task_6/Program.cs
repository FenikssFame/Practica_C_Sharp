namespace Task_6
{
    class Program
    {
        public static int size = 100;
        public static void Main(string[] args)
        {
            string fileNaameOne = "f1.txt";
            string fileNaameTwo = "f2.txt";
            string fileNaameThree = "f3.txt";
            string path = CreateFileOne(fileNaameOne);
            int[,] array = ReadFile(path);
            Console.WriteLine(TheUnitMatrix(array) == 1 ? "Единичная" : TheUnitMatrix(array) == -1 ? "Не квадратная!" : "НЕ Единичная");
            Console.WriteLine(TheZeroLine(array));
            Console.Write("Введите номер столбца: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine($"Цифры в {row} строке: {OrderedNumbers(array, row)}");
            string pathTwo = CreateFileTwo(fileNaameTwo, array, row);
            string pathThree = CreateFileThree(fileNaameThree, array);


        }
        public static string CreateFileOne(string name)
        {
            Console.WriteLine($"Файл {name}");
            string path = CreateNewFile(name);
            SetInFile(path);
            return path;
        }
        public static string CreateFileTwo(string name, int[,] array, int row)
        {
            Console.WriteLine($"Файл {name}");
            string path = CreateNewFile(name);
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                writer.Write(array[row, i] + " ");
            }
            writer.Close();
            return path;
        }
        public static string CreateFileThree(string name, int[,] array)
        {
            Console.WriteLine($"Файл {name}");
            string path = CreateNewFile(name);
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i < array.GetLength(0); i++)
            {
            int b = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    b += array[i, j];
                }
                if (b == 0)
                {
                    for (int ii = 0; ii < array.GetLength(0); ii++)
                    {
                        writer.Write(array[i, ii] + " ");
                    }
                }
            }
            writer.Close();
            return path;
        }
        public static int[,] ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int[,] array = new int[size, size];

            for (int i = 0; i < lines.Length; i++)
            {
                int j = 0;
                for (int k = 0; k < lines[i].Length; k++)
                {
                    if (lines[i][k] != ' ')
                    {
                        array[i, j] = int.Parse(Convert.ToString(lines[i][k]));
                        j++;
                    }
                }
            }
            return array;
        }
        public static string OrderedNumbers(int[,] array, int row)
        {
            string text = "Упорядочены";
            int ferst = array[row, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[row, i] < ferst)
                {
                    return "Не упорядочены";
                }
                ferst = array[row, i];
            }
            return text;
        }
        public static string TheZeroLine(int[,] array)
        {
            string text = "";
            int b = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    b += array[i, j];
                }
                if (b == 0)
                {
                    text = $"Нулевая строка {i}";
                }
                else
                {
                    text = $"Нулевой строки нет";
                }
            }
            return text;
        }
        public static int TheUnitMatrix(int[,] array)
        {
            if (array.GetLength(0) != array.GetLength(1)) return -1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j && array[i, j] != 1) return 0;
                    if (i != j && array[i, j] != 0) return 0;
                }
            }
            return 1;
        }
        public static string CreateNewFile(string fileName)
        {
            string path = @"..\..\..\..\" + fileName;
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            file.Close();
            return path;
        }
        public static int[,] GenerationIntegerNumbers()
        {
            Random rnd = new Random();
            int[,] array = new int[size, size];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(2);
                }
            }
            return array;
        }
        public static void SetInFile(string path)
        {
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamWriter writer = new StreamWriter(file);
            int[,] array = GenerationIntegerNumbers();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    writer.Write(array[i, j] + " ");

                }
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}