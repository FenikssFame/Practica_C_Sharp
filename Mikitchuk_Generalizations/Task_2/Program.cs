namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyDictionary<int,string> diction = new MyDictionary<int, string>();
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Введите номер зачетки: ");
                int zach = int.Parse(Console.ReadLine());
                Console.Write("Введите имя учащегося: ");
                string name = Console.ReadLine();
                diction.Add(zach, name);
            }
            Console.WriteLine("Введите номер зачетки: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Зачеткой под номером ({index}) владеет: {diction[index]}");
            Console.WriteLine($"Кол-во элементов в словаре: {diction.Counter}");
        }
    }
    class MyDictionary<TKey, TVal>
    {
        private int counter = 0;
        private TKey[] keysArray = null;
        private TVal[] valsArray = null;
        public int Counter
        {
            get { return this.counter; }
        }
        public void Add(TKey key, TVal val)
        {
            this.counter++;

            Array.Resize(ref keysArray, counter);
            keysArray[counter - 1] = key;

            Array.Resize(ref valsArray, counter);
            valsArray[counter - 1] = val;
        }
        public TVal this[TKey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }
    }
}