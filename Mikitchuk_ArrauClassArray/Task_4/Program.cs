namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите кол-во сотрудников: ");
            int people = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во месяцев: ");
            int month = int.Parse(Console.ReadLine());
            double[,] salaryMatrix = GetCreateMatrix(people, month);
            Console.WriteLine("Зарплатная матрица");
            Print(salaryMatrix);
            Console.Write("Введите месяц: ");
            int monthOne = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int monthTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Зарплата всех сотрудников в {monthOne} месяце была меньше, чем в {monthTwo} месяце: {GetSalaryComparison(salaryMatrix ,monthOne, monthTwo)}");
        }
        public static bool GetSalaryComparison(double[,] matrix, int monthOne, int monthTwo)
        {
            double salarySumOne = 0;
            double salarySumTwo = 0;
            int rows = matrix.GetUpperBound(0) + 1;    // количество строк
            for (int i = 0; i < rows; i++)
            {
                salarySumOne += matrix[i, monthOne - 1];
                salarySumTwo += matrix[i, monthTwo - 1];
            }
            if (salarySumOne > salarySumTwo)
            {
                return true;
            }

            return false;
        }
        public static double[,] GetCreateMatrix(int row, int colum)
        {
            double[,] matrix = new double[row, colum];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    matrix[i, j] = GetNumberRandom(); ;
                }
            }
            return matrix;
        }
        public static double GetNumberRandom()
        {
            Random rnd = new Random();
            return rnd.Next(9, 100);
        }
        public static double GetNumber()
        {
            Console.Write("Введите зарплату: ");
            return double.Parse(Console.ReadLine());
        }
        public static void Print(double[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;    // количество строк
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}