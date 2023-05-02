using System.Collections;

namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Movie MovieList = new Movie();
                Dictionary<int, string> dMovie = new Dictionary<int, string>(3);
                for (int i = 0; i < 3; i++)
                {
                    Time Time = new Time();
                    Console.Write("Введите имя игрока: ");
                    Time.Name = Console.ReadLine();
                    Console.Write("Введите действие: ");
                    Time.Status = Console.ReadLine();
                    Console.Write("Введите кол-во очков: ");
                    Time.Timee = int.Parse(Console.ReadLine());
                    MovieList.Add(Time);
                    dMovie[i + 1] = Time.status;
                }
                foreach (KeyValuePair<int, string> keyValue in dMovie)
                {
                    Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
                }
                Print(MovieList);
                Console.Write("Вышел из игры игрок под номером: ");
                int num = int.Parse(Console.ReadLine());
                MovieList.RemoveAt(num);
                Movie Movie = (Movie)MovieList.Clone();
                Print(Movie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Print(Movie list)
        {
            foreach (Time Time in list)
            {
                Console.WriteLine(Time.GetMovie());
            }
        }
    }
    public class Moving
    {
        public string name;
        public string status;
        public Moving()
        {
            name = Name;
            status = Status;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                    name = "Не указано";
                else
                    name = value;
            }
        }
        public string Status
        {
            get { return status; }
            set
            {
                if (value == "")
                    status = "Ожидает";
                else
                    status = value;
            }
        }
        virtual public string GetMovie()
        {
            return $"Игрок {name} сейчас {status}";
        }
    }
    public class Time : Moving
    {
        public int Time;
        public Time() : base()
        {
            name = Name;
            status = Status;
            Time = Timee;
        }
        public int Timee
        {
            get { return Time; }
            set
            {
                if (value < 0)
                    Time = 0;
                else
                    Time = value;
            }
        }
        public override string GetMovie()
        {
            return $"{base.GetMovie()}, на счету {Time} очко(в).";
        }
    }
    class Movie : IEnumerable
    {
        private List<Time> list;
        public Movie()
        {
            list = new List<Time>();
        }
        public Movie(List<Time> list)
        {
            this.list = list;
        }
        public void Add(Time Time)
        {
            list.Add(Time);
        }
        public Movie Clone()
        {
            return new Movie(list);
        }
        public void RemoveAt(int i)
        {
            i--;
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}