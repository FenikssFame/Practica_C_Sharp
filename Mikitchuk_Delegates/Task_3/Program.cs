using System.Diagnostics;

namespace Task_3
{
    public delegate void StringOperation(string[] str);
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите слово затем что заменить в слове на что: ");
                string[] array = Console.ReadLine().Split(" ").ToArray();
                StringOperation oper = new StringOperation(StringReplace);
                oper(array);
                Console.Write("Введите слово затем индекс и то что надо вставить: ");
                array = Console.ReadLine().Split(" ").ToArray();
                oper = StringInsert;
                oper(array);
                Console.Write("Введите слово затем индекс с какого момента произвести удаление\nи сколько удалить: ");
                array = Console.ReadLine().Split(" ").ToArray();
                oper = StringDelete;
                oper(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void StringReplace(string[] str)
        {
            Console.WriteLine(str[0].Replace(str[1], str[2]));
        }
        public static void StringInsert(string[] str)
        {
            Console.WriteLine(str[0].Insert(int.Parse(str[1]), str[2]));
        }
        public static void StringDelete(string[] str)
        {
            Console.WriteLine(str[0].Remove(int.Parse(str[1]), int.Parse(str[2])));
        }
    }
}