namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите нижнюю нраницу: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Введите верзнюю нраницу: ");
            int numB = int.Parse(Console.ReadLine());
            Queue<int> interval = new Queue<int>();
            Queue<int> lessThanA = new Queue<int>();
            Queue<int> greaterThanB = new Queue<int>();
            string path = @"..\..\..\Numbers.txt";
            using (StreamReader sr = new StreamReader(path)) 
            {
                while (!sr.EndOfStream)
                {
                    int number = int.Parse(sr.ReadLine());

                    if (number >= numA && number <= numB)
                    {
                        interval.Enqueue(number);
                    }
                    else if (number < numA)
                    {
                        lessThanA.Enqueue(number);
                    }
                    else if (number > numB)
                    {
                        greaterThanB.Enqueue(number);
                    }
                }
            }
            Console.WriteLine("\nИз интервала");
            foreach (int number in interval)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine($"\nМеньше {numA}");
            foreach (int number in lessThanA)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine($"\nБольше {numB}");
            foreach (int number in greaterThanB)
            {
                Console.Write(number + " ");
            }
        }
    }
}