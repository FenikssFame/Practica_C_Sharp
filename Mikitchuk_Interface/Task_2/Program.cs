using System.Threading.Channels;

namespace MainProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Massiv mas = new Massiv();
                mas.list = mas.GetCreateArray(GetSizeArray());
                mas.list = mas.GetCreateArray(GetSizeArray());
                Console.WriteLine($"Перечень массивов");
                PrintListArray(mas.list);

                Console.WriteLine("Введите номер массива и его значение к которому хотите обратится");
                Console.Write("Номер массива:");
                int indexArray = int.Parse(Console.ReadLine());
                Console.Write("Значение:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Вы обратились к элементу под индексом: {mas.GetElementIndex(indexArray, number)}");

                Console.Write($"Выберите массивы для операций\n" +
                    $"Введите номер массива в списке: ");
                int one = int.Parse(Console.ReadLine());
                Console.Write("Введите номер массива в списке: ");
                int two = int.Parse(Console.ReadLine());
                Console.WriteLine("Сложение массивов");
                PrintArray(mas.GetResultOperationSum(mas.list[one], mas.list[two]));
                Console.WriteLine("Вычитание массивов");
                PrintArray(mas.GetResultOperationSub(mas.list[one], mas.list[two]));

                Console.Write($"Выберите массив\n" +
                    $"Введите номер массива в списке: ");
                int[] array = mas.GetArray(mas.list, int.Parse(Console.ReadLine()));
                Console.Write("Выберите номер элемента массива: ");
                Console.WriteLine($"Вы выбрали: {mas.GetElement(array, int.Parse(Console.ReadLine()))}");
                Console.Write($"Из массива: ");
                PrintArray(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static int GetSizeArray()
        {
            try
            {
                Console.Write("Введите размерность массива: ");
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public static void PrintArray(int[] array)
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void PrintListArray(List<int[]> list)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int[] array = list[i];
                    Console.WriteLine($"{i} массив");
                    PrintArray(array);
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Massiv : IComparable
    {
        public List<int[]> list;
        public Massiv()
        {
            list = new List<int[]>();
        }
        public List<int[]> GetCreateArray(int Length)
        {
            try
            {
                int[] array = new int[Length];
                Random R = new Random();
                for (int i = 0; i < Length; i++)
                {
                    array[i] = R.Next(100);
                }
                list.Add(array);
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return list;
            }
        }
        public int[] GetArray(List<int[]> list, int index)
        {
            try
            {
                return list[index];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new int[] { 0 };
            }
        }
        public int GetElement(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public int GetElementIndex(int indexArray, int num)
        {
            try
            {
                int[] array = GetArray(list, indexArray);
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == num)
                    {
                        return i;
                    }
                }
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public int[] GetResultOperationSum(int[] ferstArray, int[] secondArray)
        {
            if (GetBoolEqualLengthArray(ferstArray, secondArray))
            {
                int length = ferstArray.Length;
                int[] resultArray = new int[length];
                for (int i = 0; i < length; i++)
                {
                    resultArray[i] = ferstArray[i] + secondArray[i];
                }
                return resultArray;
            }
            else
            {
                return new int[] { 0 };
            }
        }
        public int[] GetResultOperationSub(int[] ferstArray, int[] secondArray)
        {
            if (GetBoolEqualLengthArray(ferstArray, secondArray))
            {
                int length = ferstArray.Length;
                int[] resultArray = new int[length];
                for (int i = 0; i < length; i++)
                {
                    resultArray[i] = ferstArray[i] - secondArray[i];
                }
                return resultArray;
            }
            else
            {
                return new int[] { 0 };
            }
        }
        public bool GetBoolEqualLengthArray(int[] ferstArray, int[] secondArray)
        {
            if (ferstArray.Length == secondArray.Length) return true;
            else return false;
        }
        public int CompareTo(object? other)
        {
            throw new NotImplementedException();
        }
    }
}
