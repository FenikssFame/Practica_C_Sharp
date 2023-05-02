namespace Task_5
{
    /// <summary>
    /// Главный класс.
    /// Реализует методы вывода и ввода данных на консоль.
    /// </summary>
    class Task_5
    {
        /// <summary>
        /// Вводит информацию о поездах.
        /// Выводит информацию о поезде.
        /// </summary>
        /// <param name="args">Можно передать массив со строками</param>
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
        /// <summary>
        /// Метод вывода информации о поезде по его номеру.
        /// </summary>
        /// <param name="rs">Парпметр является ссылкой на класс RailwayStation.</param>
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
        /// <summary>
        /// Метод вывода поездов которые отправляются после времени введенного пользователем.
        /// </summary>
        /// <param name="rs">Парпметр является ссылкой на класс RailwayStation.</param>
        public static void ShowLastTimeInfoTrain(RailwayStation rs)
        {
            List<string> train; ;
            rs.LastTimeInfoTrain(out train);
            foreach (var tr in train)
            {
                Console.WriteLine(tr);
            }
        }
        /// <summary>
        /// Метод вывода поездов прибывающих в введеный пользователем пункт назвначения.
        /// </summary>
        /// <param name="rs">Парпметр является ссылкой на класс RailwayStation.</param>
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
        /// <summary>
        /// Метод добавления поезда.
        /// </summary>
        /// <param name="rs">Парпметр является ссылкой на класс RailwayStation.</param>
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
    /// <summary>
    /// Класс реализующий вокзал.
    /// </summary>
    class RailwayStation
    {
        /// <summary>
        /// Инициализация списка поездов.
        /// </summary>
        private List<Train> trains = new List<Train>();
        /// <summary>
        /// Возвращает поезд по его индексу.
        /// </summary>
        /// <param name="index">Параметр индекса поезда.</param>
        /// <returns>Возвращает поезд</returns>
        public Train this[int index]
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
        /// <summary>
        /// Метод добавления поезда.
        /// </summary>
        /// <param name="finishPunct">Параметр конечного пункта назначения поезда.</param>
        /// <param name="num">Параметр номера поезда.</param>
        public void Add(string finishPunct, int num)
        {

            Train train = new Train(finishPunct, num);
            trains.Add(train);
            trains.Sort();
        }
        /// <summary>
        /// Метод нахождения поезда отправляющегося после введенного времени.
        /// </summary>
        /// <param name="train">Список поездов.</param>
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
        /// <summary>
        /// Метод для вывода ин-ии о поездах, отправляющихся в заданный пункт назначения.
        /// </summary>
        /// <param name="punkt">Параметр конечного пункта назначения поезда.</param>
        /// <returns></returns>
        public List<Train> ShowFinishPunct(string punkt)
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
    /// <summary>
    /// Класс инициализации поезда.
    /// </summary>
    class Train : IComparable
    {
        /// <summary>
        /// Конструктор инициализации поезда с параметрами.
        /// </summary>
        /// <param name="finishPunct">Параметр конечного пункта назначения.</param>
        /// <param name="namber">Параметр номера поезда.</param>
        public Train(string finishPunct, int namber)
        {
            this.finishPunct = finishPunct;
            this.namber = namber;
            SetTime();
        }
        /// <summary>
        /// Конструктор инициализации поезда с параметрами.
        /// </summary>
        /// <param name="finishPunct">Параметр конечного пункта назначения.</param>
        /// <param name="namber">Параметр номера поезда.</param>
        /// <param name="time">Параметр времени отправки поезда.</param>
        public Train(string finishPunct, int namber, DateTime time)
        {
            this.finishPunct = finishPunct;
            this.namber = namber;
            this.time = time;
        }
        /// <summary>
        /// Переменная конечного пункта назначения.
        /// </summary>
        String finishPunct;
        /// <summary>
        /// Свойство присвоения переменной конечного пункта назначения.
        /// </summary>
        public String FinishPunct
        {
            get { return finishPunct; }
            set { finishPunct = value; }
        }
        /// <summary>
        /// Переменная номера поезда.
        /// </summary>
        int namber;
        /// <summary>
        /// Свойство присвоения переменной номера поезда.
        /// </summary>
        public int Namber
        {
            get { return namber; }
            set
            {
                if (value > 0)
                    namber = value;
            }
        }
        /// <summary>
        /// Переменная времени отправки поезда.
        /// </summary>
        DateTime time;
        /// <summary>
        /// Свойство присвоения переменной времени отправки поезда.
        /// </summary>
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        /// <summary>
        /// Метод отбора поездов по введенному времени.
        /// </summary>
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
        /// <summary>
        /// Метод сортировки.
        /// </summary>
        /// <param name="input">Параметр принимающий параметр для сортировки.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Переопределенный метод ToString.
        /// </summary>
        /// <returns>Возвращает информацию о поезде.</returns>
        public string ToString()
        {
            string info = $"Поезд №{namber} следует в пункт назначения {finishPunct}. Время отправления: {time.Hour}.{time.Minute}!";
            return info;
        }
        /// <summary>
        /// Переопределенный метод сравнения.
        /// </summary>
        /// <param name="p1">Параметр для сравнения.</param>
        /// <param name="p2">Параметр для сравнения.</param>
        /// <returns>Возвращает true или false</returns>
        public static bool operator >(Train p1, Train p2)
        {
            if (p1.Time > p2.Time)
                return true;
            return false;
        }
        /// <summary>
        /// Переопределенный метод сравнения.
        /// </summary>
        /// <param name="p1">Параметр для сравнения.</param>
        /// <param name="p2">Параметр для сравнения.</param>
        /// <returns>Возвращает true или false</returns>
        public static bool operator <(Train p1, Train p2)
        {
            if (p1.Time < p2.Time)
                return true;
            return false;
        }
        /// <summary>
        /// Переопределенный метод сравнения.
        /// </summary>
        /// <param name="p1">Параметр для сравнения.</param>
        /// <param name="p2">Параметр для сравнения.</param>
        /// <returns>Возвращает true или false</returns>
        public static bool operator ==(Train p1, Train p2)
        {
            if (p1.Time == p2.Time)
                return true;
            return false;
        }
        /// <summary>
        /// Переопределенный метод сравнения.
        /// </summary>
        /// <param name="p1">Параметр для сравнения.</param>
        /// <param name="p2">Параметр для сравнения.</param>
        /// <returns>Возвращает true или false</returns>
        public static bool operator !=(Train p1, Train p2)
        {
            if (p1.Time != p2.Time)
                return true;
            return false;
        }
    }
}
