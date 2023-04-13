namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Исходный массив");
            int[] array = GetCreateArray(size);
            PrintArray(array);
            Console.Write("\nВведите индекс (0-9) для замены: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Массив с заменами");
            PrintArray(Function(array, index));
        }
        public static int[] Function(int[] array, int num)
        {
            int max = array[num];
            int min = array[num];
            int size = array.Length;
            for (int i = num; i < size; i++)
            {
                if (array[i] > max) max = array[i];
                else
                    if (array[i] < min) min = array[i];
            }
            array[num] = max;
            array[num + 10] = min;
            return array;
        }
        public static int[] GetCreateArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = GetNumber();
            }
            return array;
        }
        public static int GetNumber()
        {
            Console.Write("Введмте значение: ");
            return int.Parse(Console.ReadLine());
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}