namespace Task_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            string dir = @"D:";
            Console.WriteLine($"Вывод каталогов с диска {dir}");
            string[] dirs = GetDirs(dir);
            OutDir(dirs);
            string path = @"D:\Exmple_30tp\";
            CreateDir(path);
            string pathCopy = @"D:\Автомобили\citroen\ситроен\";
            CopyPDFFiles(pathCopy, path);
            GetHidenAttributsFile(path);
            string linkPath1 = @"D:\Exmple_30tp\Citroen C5.pdf";
            string linkPath2 = @"D:\Exmple_30tp\citroen-c5-i (1).pdf";
            LinkFile(path + "c5", linkPath1);
            LinkFile(path + "nextC5", linkPath2);
            Console.WriteLine($"Вывод каталогов с диска {dir}");
            OutDir(GetDirs(dir));
        }
        public static string[] GetDirs(string dir)
        {
            return Directory.GetDirectories(dir);
        }
        public static void OutDir(string[] dirs)
        {
            Console.WriteLine(String.Join(Environment.NewLine, dirs));
        }
        public static void CreateDir(string path)
        {
            Directory.CreateDirectory(path);
        }
        public static void CopyPDFFiles(string path, string pathTo)
        {
            foreach (string file in Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories))
            {
                File.Copy(path + Path.GetFileName(file), pathTo + Path.GetFileName(file));
            }
        }
        public static void GetHidenAttributsFile(string path)
        {
            foreach (string file in Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories))
            {
                File.SetAttributes(file, FileAttributes.Hidden);
            }
        }
        public static void LinkFile(string path, string linkPath)
        {
            File.CreateSymbolicLink(path, linkPath);
        }
    }
}