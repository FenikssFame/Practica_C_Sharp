using Task_1;
namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Введите значение в массив: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Введите индекс значения: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Значение под индексом ({index}): {list[index]}");
            Console.WriteLine($"Кол-во элементов: {list.Count}");
            Console.WriteLine("Список значений");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.GetArray()[i] + " ");
            }
        }
    }
    static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
                array[i] = list[i];
            return array;
        }
    }

}