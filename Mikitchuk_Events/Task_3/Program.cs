namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите ФИО: ");
                string name = Console.ReadLine();
                if (name.Length < 10) throw new FormatException();
                MyInfo mi = new MyInfo(name);

                mi.Notify += (string notify) => { Console.WriteLine(notify); };
                Console.Write("Выберите 1-сменить ФИО, 2-не менять ФИО: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Введите ФИО: ");
                        mi.Name = Console.ReadLine();
                        break;
                    case 2:
                        mi.Name = name;
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class MyInfo
    {
        public event Action<string> Notify;
        private string _name;
        public MyInfo(string name)
        {
            _name = name;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!_name.Equals(value))
                {
                    Notify?.Invoke($"Значение поля {nameof(Name)} изменено.\n" +
                        $"Предыдущее значение = {_name}, актуальное = {value}.");
                }
                _name = value;
            }
        }
    }
}