namespace Task_2
{
    class Task_2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Цифры данного трехзначного числа образуют возрастающую или убывающую последовательность");
            Console.Write("Введите трехзначное число: ");
            string num = Console.ReadLine();
            if (num[0] < num[1] && num[1] < num[2])
            {
                Console.WriteLine($"Число {num} образует возрастающую последовательность.");
            }
            else
            {
                Console.WriteLine($"Число {num} образует убывающую последовательность.");
            }
        }
    }
}