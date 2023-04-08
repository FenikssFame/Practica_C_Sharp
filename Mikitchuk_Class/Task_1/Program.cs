namespace Task_1
{
    class Task_1
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое значение (a): ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Введите второе значение (b): ");
            int numB = int.Parse(Console.ReadLine());
            ClassA ca = new ClassA(numA, numB);
            Console.Write($"Выражение 1/a + 1/sqrt(b)= {ca.Function()}");
            Console.Write($"\nВыражение a^6= {ca.FunctionPow()}");
        }
    }

    class ClassA
    {
        public int numA;
        public int numB;
        public ClassA(int numA, int numB)
        {
            this.numA = numA;
            this.numB = numB;
        }


        public double Function()
        {
            return 1 / numA + 1 / Math.Sqrt(numB);
        }

        public double FunctionPow()
        {
            return Math.Pow(numA, 6);
        }
    }
}