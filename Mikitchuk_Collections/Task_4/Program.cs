using System.Collections;
namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            for (int i = 0; i < 2; i++)
            {
                CD cd = new CD();
                Console.Write("Введите название диска: ");
                cd.Title = Console.ReadLine();
                Console.Write("Введите исполнителя: ");
                cd.Artist = Console.ReadLine();
                Console.Write("Введите год: ");
                cd.Year = int.Parse(Console.ReadLine());
                cd.Songs = GetSetSongs();
                catalog.AddCD(cd);
            }
            Console.WriteLine($"Содержимое каталога\n{catalog.GetCatalog()}");
            Console.Write("Введите название для отображения диска: ");
            string name = Console.ReadLine();
            Console.WriteLine(catalog.GetCD(name));
            Console.Write("Введите название диска: ");
            name = Console.ReadLine();
            Console.Write("Введите название песни для добавления: ");
            string song = Console.ReadLine();
            catalog.AddSong(name, song);
            Console.Write("Введите название диска: ");
            name = Console.ReadLine();
            Console.Write("Введите название песни для удаления: ");
            song = Console.ReadLine();
            catalog.RemoveSong(name, song);
            Console.Write("Введите название диска для удаления: ");
            name = Console.ReadLine();
            catalog.RemoveCD(name);
            Console.WriteLine($"Содержимое обновленного каталога\n{catalog.GetCatalog()}");
        }
        public static List<string> GetSetSongs()
        {
            Console.Write("Введите композицию: ");
            List<string> list = new List<string>();
            string s = "";
            while (!string.IsNullOrEmpty(s = Console.ReadLine()))
            {
                list.Add(s);
                Console.Write("Введите композицию: ");
            }
            return list;
        } 
    }
    class CD
    {
        public string title;
        public string artist;
        public int year;
        public List<string> songs;

        public CD()
        {
            title = Title;
            artist = Artist;
            year = Year;
            songs = Songs;
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (title == "")
                    title = "Не указан";
                else
                    title = value;
            }
        }
        public string Artist
        {
            get { return artist; }
            set
            {
                if (artist == "")
                    artist = "Не указан";
                else
                    artist = value;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (year < 0)
                    year = 0;
                else
                    year = value;
            }
        }
        public List<string> Songs
        {
            get { return songs; }
            set
            {
                    songs = value;
            }
        }
    }
    class Catalog
    {
        private Hashtable _cdt;
        public Catalog()
        {
            _cdt = new Hashtable();
        }
        public void AddCD(CD cd)
        {
            _cdt.Add(cd.Title, cd);
        }
        public void RemoveCD(string title)
        {
            _cdt.Remove(title);
        }
        public void AddSong(string title, string song)
        {
            if (_cdt.ContainsKey(title))
            {
                CD cd = (CD)_cdt[title];
                cd.Songs.Add(song);
            }
            else
            {
                Console.WriteLine("Диск не найден");
            }
        }
        public void RemoveSong(string title, string song)
        {
            if (_cdt.ContainsKey(title))
            {
                CD cd = (CD)_cdt[title];
                cd.Songs.Remove(song);
            }
            else
            {
                Console.WriteLine("Композиция не найдена");
            }
        }
        public string GetSong(CD cd)
        {
            string songs = "";
            foreach (string song in cd.songs)
                songs += song + " / ";
            return songs;
        }
        public string GetCatalog()
        {
            string catalog = "";
            foreach (DictionaryEntry entry in _cdt)
            {
                CD cd = (CD)entry.Value;
                catalog += $"Группа: {cd.title}, Исполнители: {cd.artist}, Год: {cd.year}\nКомпозиции: {GetSong(cd)}\n";
            }
            return catalog;
        }
        public string GetCD(string title)
        {
            if (_cdt.ContainsKey(title))
                {
                CD cd = (CD)_cdt[title];
                return $"Группа: {cd.title}, Исполнители: {cd.artist}\nГод: {cd.year}, Композиции: {GetSong(cd)}";
            }
            else
            {
                return "Композиция не найдена";
            }
        }
    }
}