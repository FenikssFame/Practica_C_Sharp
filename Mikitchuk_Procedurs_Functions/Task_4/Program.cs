using System.Data;
using System.Drawing;

namespace Task_4
{
    class Task_4
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размерность двумерного массива:\nСтрок= ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Колонок= ");
            int colum = int.Parse(Console.ReadLine());

            Console.WriteLine("Action One");
            Array array = new Array(row, colum);
            InputNumInMas(array, row, colum);
            Console.WriteLine($"Перемножением положительных элементов массива, меньших 10: {array.ArrayAction()}");
            
            Console.WriteLine("\nAction Two");
            Array ar = new Array();
            ar.CreateArrayMas(row, colum);
            InputNumInMas(ar, row, colum);
            int[,] mas = ar.GetArray();
            Console.WriteLine($"Перемножением положительных элементов массива, меньших 10: {ar.ArrayAction(mas)}");
        }
        private static void InputNumInMas(Array array, int row, int colum)
        {
            Console.WriteLine("Введите значения массива: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Console.Write(i + "," + j + "=");
                    int num = int.Parse(Console.ReadLine());
                    array.SetNumArray(num, i, j);
                }
            }
        }
    }

    public class Array
    {
        private int[,] masDuo;
        public Array()
        {

        }
        public Array(int row, int colum)
        {
            masDuo = new int[row, colum];
        }
        public void SetNumArray(int x, int i, int j)
        {
            masDuo[i, j] = x;
        }
        public void CreateArrayMas(int row, int colum)
        {
            masDuo = new int[row, colum];
        }
        public int [,] GetArray()
        {
            return masDuo;
        }
        public int ArrayAction()
        {
            int result = 0;
            foreach (var i in masDuo)
            {
                if (i >= 0 && i < 10)
                {
                    result += i;
                }
            }
            return result;
        }
        public int ArrayAction(int[,] mas)
        {
            int result = 0;
            foreach (var i in mas)
            {
                if (i >= 0 && i < 10)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}