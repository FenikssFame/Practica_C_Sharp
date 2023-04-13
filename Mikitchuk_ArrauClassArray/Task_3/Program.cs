using System;

namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы N<10: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите начальный диапазон: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите конечный диапазон: ");
            int finish = int.Parse(Console.ReadLine());
            double[,] matrix = GetCreateSquareMatrix(number, start, finish);
            Console.WriteLine("Исходная матрица");
            Print(matrix, number);
            Console.WriteLine($"Сумму квадратов отрицательных чисел: {GetSumSquareТegativeNumbers(matrix, number)}") ;
            Console.WriteLine("Наименьший элемент в каждой строки");
            foreach (double element in GetMinElement(matrix, number))
            {
                Console.WriteLine(element);
            }


        }
        public static double[,] GetCreateSquareMatrix(int number, int start, int finish)
        {
            Random rnd = new Random();
            double[,] matrix = new double[number, number];
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    matrix[i, j] = rnd.Next(start, finish + 1);
                }
            }
            return matrix;
        }
        public static int GetSumSquareТegativeNumbers(double[,] matrix, int number)
        {
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        sum += (int)Math.Pow(matrix[i, j], 2);
                    }
                }
            }
            return sum;
        }
        public static double[] GetMinElement(double[,] matrix, int number)
        {
            double[] array = new double[number];
            for (int i = 0; i < number; i++)
            {
                double min = matrix[i, 0];
                for (int j = 0; j < number; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                array[i] = min;
            }
            return array;
        }
        public static void Print(double[,] matrix, int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}