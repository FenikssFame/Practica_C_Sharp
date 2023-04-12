namespace Task_1
{
    class Task_1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                double numY = double.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine((numY + 4) / (numY + 8));
                    Console.WriteLine(Math.Pow(Math.Cos(numY), 3) / (numY - 1));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Попытка передать в метод аргумент неверного формата");
            }
        }
    }
}