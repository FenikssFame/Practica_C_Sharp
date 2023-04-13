using System.Drawing;

namespace Task_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы: ");
            int size = int.Parse(Console.ReadLine());
            Print(GetCreateSquareMatrix(size), size);
        }
        public static double[,] GetCreateSquareMatrix(int size)
        {
            int number = 1;
            int i = 0;
            int j = 0;
            int iStart = 0;
            int iFinish = 0;
            int jStart = 0;
            int jFinish = 0;
            int sizeMatrix = size * size;
            double[,] matrix = new double[size, size];
            while (number <= sizeMatrix)
            {
                matrix[i, j] = number;
                if (i == iStart && j < size - jFinish - 1)
                    j++;
                else if (j == size - jFinish - 1 && i < size - iFinish - 1)
                    i++;
                else if (i == size - iFinish - 1 && j > jStart)
                    j--;
                else
                    i--;

                if ((i == iStart + 1) && (j == jStart) && (jStart != size - jFinish - 1))
                {
                    iStart++;
                    iFinish++;
                    jStart++;
                    jFinish++;
                }
                number++;
            }
            return matrix;
        }
        public static void Print(double[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}