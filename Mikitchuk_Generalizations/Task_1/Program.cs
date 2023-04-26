using System.Collections;

namespace Task_1
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
        }
    }
    public class MyList<T>
    {
        private ArrayList myList;
        public T this[int index]
        {
            get { return (T)myList[index]; }
            set { myList[index] = value; }
        }
        public MyList()
        {
            this.myList = new ArrayList();
        }
        public MyList(int count)
        {
            this.myList = new ArrayList(count);
        }
        public void Add(T item)
        {
            myList.Add(item);
        }
        public int Count
        {
            get { return myList.Count; }
        }
    }
}