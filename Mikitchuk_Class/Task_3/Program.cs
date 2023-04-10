using System.Collections.Generic;

namespace Task_3
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите 1-е двоичное число: ");
            string bynNumOne = Console.ReadLine();
            Console.Write("Введите 2-е двоичное число: ");
            string bynNumTwo = Console.ReadLine();
            BynaryNumberSystem bns = new BynaryNumberSystem();
            Console.WriteLine($"Cложение: {bns.Sum(bynNumOne, bynNumTwo)}");
            Console.WriteLine($"Вычитание: {bns.Sub(bynNumOne, bynNumTwo)}");
            Console.WriteLine($"Умножение: {bns.Mul(bynNumOne, bynNumTwo)}");
            Console.WriteLine($"Деление: {bns.Div(bynNumOne, bynNumTwo)}");
        }
    }

    class BynaryNumberSystem
    {
        public bool CheckBynary(string bynary)
        {
            for (int i = 0; i < bynary.Length; i++)
            {
                if (bynary[i] != '1' && bynary[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }

        public string Sum(string bynOne, string bynTwo)
        {
            if (CheckBynary(bynOne) && CheckBynary(bynTwo))
            {
                return Convert.ToString(Convert.ToInt32(bynOne, 2) + Convert.ToInt32(bynTwo, 2), 2);
            }
            else
            {
                return "Значение введено неверно";
            }
        }
        public string Sub(string bynOne, string bynTwo)
        {
            if (CheckBynary(bynOne) && CheckBynary(bynTwo))
            {
                return Convert.ToString(Convert.ToInt32(bynOne, 2) - Convert.ToInt32(bynTwo, 2), 2);
            }
            else
            {
                return "Значение введено неверно";
            }
        }
        public string Mul(string bynOne, string bynTwo)
        {
            if (CheckBynary(bynOne) && CheckBynary(bynTwo))
            {
                return Convert.ToString(Convert.ToInt32(bynOne, 2) * Convert.ToInt32(bynTwo, 2), 2);
            }
            else
            {
                return "Значение введено неверно";
            }
        }
        public string Div(string bynOne, string bynTwo)
        {
            if (CheckBynary(bynOne) && CheckBynary(bynTwo))
            {
                return Convert.ToString(Convert.ToInt32(bynOne, 2) / Convert.ToInt32(bynTwo, 2), 2);
            }
            else
            {
                return "Значение введено неверно";
            }
        }
    }
}
