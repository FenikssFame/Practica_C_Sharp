namespace Task_6
{
    class Task_6
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите номер карты: ");
            int numCard = int.Parse(Console.ReadLine());
            Console.Write("Введите масть карты: ");
            int suitCard = int.Parse(Console.ReadLine());

            switch (numCard)
            {
                case 6:
                    Console.Write("шестерка ");
                    break;
                case 7:
                    Console.Write("семерка ");
                    break;
                case 8:
                    Console.Write("восьмерка ");
                    break;
                case 9:
                    Console.Write("девятка ");
                    break;
                case 10:
                    Console.Write("десятка ");
                    break;
                case 11:
                    Console.Write("валет ");
                    break;
                case 12:
                    Console.Write("дама ");
                    break;
                case 13:
                    Console.Write("король ");
                    break;
                case 14:
                    Console.Write("туз ");
                    break;
                default:
                    Console.WriteLine("нет такого номера карты");
                    break;
            }
            switch (suitCard)
            {
                case 1:
                    Console.Write("крести");
                    break;
                case 2:
                    Console.Write("пик");
                    break;
                case 3:
                    Console.Write("бубен");
                    break;
                case 4:
                    Console.Write("чирва");
                    break;
                default:
                    Console.WriteLine("нет такой масти карты");
                    break;
            }
        }

    }
}