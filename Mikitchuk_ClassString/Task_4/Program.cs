namespace Task_4
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Введите ваше ФИО: ");
            string name = Console.ReadLine().ToLower();
            int code = GetCode(GetCalculateSum(name));
            Console.WriteLine($"Код: {code}");
        }
        public static int GetCode(int number)
        {
            int code = 0;
            while (number >= 1)
            {
                code += number % 10;
                number /= 10;
            }
            return code;
        }
        private static int GetCalculateSum(string fio)
        {
            char[] alphavite = " абвгдеёзжийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            int sum = 0;
            foreach (char s in fio)
            {
                for (int i = 0; i < 32; i++)
                {
                    if (s == alphavite[i])
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
    }
}