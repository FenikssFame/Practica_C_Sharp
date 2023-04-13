namespace Task_2
{
    class Task_2
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                double numX = double.Parse(Console.ReadLine());
                if (numX > -4 && numX <= 1)
                {
                    try
                    {
                        Console.WriteLine($"f({numX})={(3 * numX + 2) / (4 * numX + 4)}"); 

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Деление на ноль");
                    }
                }
                else if (numX > 1)
                {
                    Console.WriteLine($"f({numX})={Math.Pow(numX, 2)}");
                }
                else throw new Exception("Ошибка выхода из диапазона допустимых значений x");
            }
            catch (FormatException) // выводить через переменную ex (ex.Message) Замечание
            {
                Console.WriteLine("Попытка передать в метод аргумент неверного формата");
            }
        }
    }
}