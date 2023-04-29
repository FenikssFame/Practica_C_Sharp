namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pathOne = "..\\..\\..\\TextOne.txt";
            string pathTwo = "..\\..\\..\\TextTwo.txt";
            FileStream fileOne = new FileStream(@pathOne, FileMode.Open);
            StreamReader readerOne = new StreamReader(fileOne);
            FileStream fileTwo = new FileStream(@pathTwo, FileMode.Open);
            StreamReader readerTwo = new StreamReader(fileTwo);
            string one = null;
            string two = null;
            int i = 1;
            while ((one = readerOne.ReadLine()) != null && (two = readerTwo.ReadLine()) != null)
            {
                if (one != two)
                {
                    Console.WriteLine($"Строка № {i}");
                    break;
                }
                i++;
            }
            fileOne.Close();
            fileTwo.Close();
        }
    }
}