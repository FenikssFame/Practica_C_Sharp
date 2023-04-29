namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string path = "..\\..\\..\\Text.txt";
                Console.WriteLine("Содержимое файла: ");
                OutputFile(path);
                Console.WriteLine("Кол-во строк в файле: ");
                Console.WriteLine(FileRowCount(path));
                Console.WriteLine("Кол-во символов в каждой строке файла: ");
                CharCountRowInFile(path);
                Console.WriteLine("Файл с удаленной последней строкой: ");
                OutputFile(DeleteLastLine(path));
                Console.Write("Введите с какой строки вывести сообщение: ");
                int s1 = int.Parse(Console.ReadLine());
                Console.Write("Введите по какую строку вывести сообщение: ");
                int s2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Строки с {s1} по {s2}: ");
                OutText(s1, s2, path);
                Console.WriteLine("Самая длинная строка в файле: ");
                OutLongRow(path);
                Console.Write("Введите букву: ");
                char alf = char.Parse(Console.ReadLine());
                Console.WriteLine("Все строки начинающиеся с заданной буквы: ");
                OutRowStartAlf(alf, path);
                Console.WriteLine("Реверсия строк: ");
                OutputFile(ReversStringInFile(path));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static string ReversStringInFile(string path)
        {
            string newPath = "..\\..\\..\\reversText.txt";
            string[] textFile = File.ReadAllLines(path);
            StreamWriter reversFile = new StreamWriter(new FileStream(newPath, FileMode.Create, FileAccess.Write));
            for (int i = textFile.Length; i > 0; i--)
                reversFile.WriteLine(textFile[i - 1]);
            reversFile.Close();
            return newPath;
        }
        public static void OutRowStartAlf(char alf, string path)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line[0] == alf)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }
        public static void OutLongRow(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int max = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > lines[max].Length)
                {
                    max = i;
                }
            }
            Console.WriteLine(lines[max]);
        }
        public static void OutText(int s1, int s2, string path)
        {
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line = "";
            int i = 1;
            while ((line = reader.ReadLine()) != null)
            {
                if (i >= s1 && i <= s2)
                    Console.WriteLine(line);
                i++;
            }
            reader.Close();
        }
        public static string DeleteLastLine(string path)
        {
            string newPath = "..\\..\\..\\newText.txt";
            var lines = File.ReadAllLines(path);
            File.WriteAllLines(newPath, lines.Take(lines.Length - 1).ToArray());
            return newPath;
        }
        public static void CharCountRowInFile(string path)
        {
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line = "";
            int i = 1;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine($"Строка({i}): {line.Length}");
                i++;
            }
            reader.Close();
        }
        public static int FileRowCount(string path)
        {
            return File.ReadAllLines(path).Length;
        }
        public static void OutputFile(string path)
        {
            FileStream file = new FileStream(@path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            reader.Close();
        }

    }
}