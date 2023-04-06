namespace Task_4
{
    class Task_4
    {
        public static void Main(string[] args)
        {
            Console.Write("Длинна квадратной комнаты: ");
            double widthRoom = double.Parse(Console.ReadLine());
            Console.Write("Высота квадратной комнаты: ");
            double heightRoom = double.Parse(Console.ReadLine());
            Console.Write("Длинна двери: ");
            double widthDoor = double.Parse(Console.ReadLine());
            Console.Write("Высота двери: ");
            double heightDoor = double.Parse(Console.ReadLine());
            Console.Write("Длинна окна: ");
            double widthWindow = double.Parse(Console.ReadLine());
            Console.Write("Высота окна: ");
            double heightWindow = double.Parse(Console.ReadLine());

            double result = widthRoom * heightRoom * 4 - widthDoor * heightDoor - widthWindow * heightWindow;

            Console.WriteLine($"Площадь для обклеивания составляет: {result}") ;
        }
    }
}