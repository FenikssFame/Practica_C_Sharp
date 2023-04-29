namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите название папки: ");
            string nameFolder = Console.ReadLine();
            string path = "..\\..\\..\\";
            Directory.CreateDirectory(path + nameFolder);
        }
    }
}