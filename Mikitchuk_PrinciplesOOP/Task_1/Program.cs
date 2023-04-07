namespace Task_1
{
    class Task_1
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double numOne = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double numTwo = double.Parse(Console.ReadLine());

            double sum = numOne + numTwo;
            double sub = numOne - numTwo;
            double mul = numOne * numTwo;
            double div = numOne / numTwo;
            Console.WriteLine($"Сумма = {sum}\nРазность = {sub}\nУмножение = {mul}\nДеление = {div:F2}\n");
        }
    }
}