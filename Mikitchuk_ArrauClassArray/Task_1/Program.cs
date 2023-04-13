namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Введите размерность массива: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значения массива: ");
            double[] array = CreateArray(number);
            for (int i = 0; i < array.Length; i++)
            {
                if (GetIndex(array[i]))
                {
                    Console.WriteLine($"Индекс: {i}");
                }
            }
        }
        public static double[] CreateArray(int number)
        {
            double[] array = new double[number];
            for (int i = 0; i < number; i++)
            {
                array[i] = double.Parse(Console.ReadLine()); ;
            }
            return array;
        }
        public static bool GetIndex(double numX)
        {
            if (numX > 0 && numX < 3.2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}