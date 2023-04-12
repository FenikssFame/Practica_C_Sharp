namespace Task_5
{
    class Task_5
    {
        public static void Main(string[] args)
        {
            RailwayStation rs = new RailwayStation();
            AddTrain(rs);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1-информация о поезде по номеру\n" +
                    "2-информации о поездах, отправляющихся после введенного времени\n" +
                    "3-информации о поездах, отправляющихся в заданный пункт назначения\n" +
                    "0-закрыть");
                int point = int.Parse(Console.ReadLine());
                if (point >= 0 && point <= 3)
                {
                    switch (point)
                    {
                        case 1:
                            ShowInfoTrainNum(rs);
                            break;
                        case 2:
                            ShowLastTimeInfoTrain(rs);
                            break;
                        case 3:
                            ShowFinishPunkt(rs);
                            break;
                        case 0:
                            flag = false;
                            break;
                    }
                }
            }
        }
        public static void ShowInfoTrainNum(RailwayStation rs)
        {
            int num = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("Введите индекс: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Неверный формат");
                }
            }
            Console.WriteLine(rs[num].ToString());
        }
        public static void ShowLastTimeInfoTrain(RailwayStation rs)
        {
            List<string> train; ;
            rs.LastTimeInfoTrain(out train);
            foreach (var tr in train)
            {
                Console.WriteLine(tr);
            }
        }
        public static void ShowFinishPunkt(RailwayStation rs)
        {
            Console.Write("Введите пункт назначения: ");
            string punkt = Console.ReadLine();
            List<Train> list = new List<Train>(rs.ShowFinishPunct(punkt));
            foreach (var tr in list)
            {
                Console.WriteLine(tr.ToString());
            }
        }
        public static void AddTrain(RailwayStation rs)
        {
            for (int i = 0; i < 3; i++)
            {
                int num = 0;
                bool flag = true;
                while (flag)
                {
                    try
                    {
                        Console.Write("Введите номер поезда: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный формат номера");
                    }
                }

                Console.Write("Введите конечный пункт назначения: ");
                string finishPunct = Console.ReadLine();
                rs.Add(finishPunct, num);
            }
        }
    }

    class RailwayStation
    {
        private List<Train> trains = new List<Train>();
        public Train this[int index]    //пользовательский индексатор для класса
        {
            get
            {
                return trains[index];
            }
            set
            {
                if (index >= 0 && value is Train)
                {
                    trains.Add(value);
                    trains.Sort();
                }
            }
        }
        public void Add(string finishPunct, int num)       //метод добавления поезда в коллекцию
        {

            Train train = new Train(finishPunct, num);
            trains.Add(train);
            trains.Sort();
        }
        public void LastTimeInfoTrain(out List<string> train)
        {
            train = new List<string>();
            Train tr = new Train("null", 1);
            for (int i = 0; i < trains.Count; i++)
            {
                if (tr < this[i])
                {
                    train.Add(this[i].ToString());
                }
            }
        }
        public List<Train> ShowFinishPunct(string punkt) //метод для вывода ин-ии о поездах, отправляющихся в заданный пункт назначения
        {
            List<Train> list = new List<Train>();
            for (int i = 0; i < trains.Count; i++)
            {
                if (trains[i].FinishPunct == punkt)
                {
                    list.Add(trains[i]);
                }
            }
            return list;
        }

    }

    class Train : IComparable
    {

        public Train(string finishPunct, int namber)
        {
            this.finishPunct = finishPunct;
            this.namber = namber;
            SetTime();
        }
        public Train(string finishPunct, int namber, DateTime time)
        {
            this.finishPunct = finishPunct;
            this.namber = namber;
            this.time = time;
        }
        String finishPunct;
        public String FinishPunct
        {
            get { return finishPunct; }
            set { finishPunct = value; }
        }

        int namber;
        public int Namber
        {
            get { return namber; }
            set
            {
                if (value > 0)
                    namber = value;
            }
        }

        DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        void SetTime()
        {
            while (true)
            {
                int hour = 0;
                int minute = 0;
                Console.Write("Введите время отправления поезда [hour.minute]: ");
                string t = Console.ReadLine();
                string h = "";
                string m = "";
                int q;
                bool flag = false;
                for (int i = 0; i < t.Length; i++)
                {
                    if (!flag)
                    {
                        if (Int32.TryParse(Convert.ToString(t[i]), out q))
                        {
                            h = h + t[i];
                        }
                        else
                        {
                            flag = true;
                            continue;
                        }
                    }
                    if (flag)
                    {
                        if (Int32.TryParse(Convert.ToString(t[i]), out q))
                        {
                            m = m + t[i];
                        }
                    }
                }
                try
                {
                    hour = Int32.Parse(h);
                    minute = Int32.Parse(m);
                    Time = new DateTime(2023, 12, 12, hour, minute, 0);
                    return;
                }
                catch
                {
                    Console.WriteLine("Введен неверный формат времени");
                }

            }
        }
        public int CompareTo(object input)
        {
            if (input is Train)
            {
                Train p1 = (Train)input;
                if (this.Time > p1.Time)
                    return 1;
                else if (this.Time < p1.Time)
                    return -1;
                else
                    return 0;
            }
            return 0;
        }
        public string ToString()
        {
            string info = $"Поезд №{namber} следует в пункт назначения {finishPunct}. Время отправления: {time.Hour}.{time.Minute}!";
            return info;
        }
        public static bool operator >(Train p1, Train p2)
        {
            if (p1.Time > p2.Time)
                return true;
            return false;
        }
        public static bool operator <(Train p1, Train p2)
        {
            if (p1.Time < p2.Time)
                return true;
            return false;
        }
        public static bool operator ==(Train p1, Train p2)
        {
            if (p1.Time == p2.Time)
                return true;
            return false;
        }
        public static bool operator !=(Train p1, Train p2)
        {
            if (p1.Time != p2.Time)
                return true;
            return false;
        }
    }
}
