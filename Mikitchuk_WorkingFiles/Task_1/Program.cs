using System.Reflection.PortableExecutable;

namespace Task_1
{
    class Program
    {
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
        public static double SumMaxMinFromArray(double[] array)
        {

            return array.Max() + array.Min();
        }
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