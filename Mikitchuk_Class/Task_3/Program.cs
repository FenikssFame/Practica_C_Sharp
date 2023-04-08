namespace Task_3
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            ClassA ca = new ClassA();
        }
    }

    class ClassA
    {
        int numA;
        int numB;

        public static double Function(int numA, int numB)
        {
            return 1 / numA + 1 / Math.Sqrt(numB);
        }

        public static double Function(int numA)
        {
            return Math.Pow(numA, 6);
        }
    }
}