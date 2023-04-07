namespace Task_5
{
    class Task_5
    {
        public static void Main(string[] args)
        {
            const double distanceM = 1066.8;

            Console.Write("Введите расстояние в верстах: ");
            double distanceVer = double.Parse(Console.ReadLine());

            Console.WriteLine($"{distanceVer} верст(а/ы) - это {distanceVer * distanceM / 1000} км");
        }
    }
}
