namespace Task_3
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    public delegate void StringOperation(string[] str);
    /// <summary>
    /// Главный класс выполнения программы методом Main.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы реализующий действия над солвами.
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
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
        /// <summary>
        /// Метод заменяющий часть слова на другое слово.
        /// </summary>
        /// <param name="str">Параметр массив из слов.</param>
        public static void StringReplace(string[] str)
        {
            Console.WriteLine(str[0].Replace(str[1], str[2]));
        }
        /// <summary>
        /// Метод вставляющий на заданный индекс другое слово.
        /// </summary>
        /// <param name="str">Параметр массив из слов.</param>
        public static void StringInsert(string[] str)
        {
            Console.WriteLine(str[0].Insert(int.Parse(str[1]), str[2]));
        }
        /// <summary>
        /// Метод удаления части слова или предложения.
        /// </summary>
        /// <param name="str">Параметр массив из слов.</param>
        public static void StringDelete(string[] str)
        {
            Console.WriteLine(str[0].Remove(int.Parse(str[1]), int.Parse(str[2])));
        }
    }
}