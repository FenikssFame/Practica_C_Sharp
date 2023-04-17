namespace Task_1
{
    // Структура
    public struct Note : IComparable<Note>
    {
        public string fNameSName;
        public string telehpone;
        public DateOnly berthday;

        public int CompareTo(Note other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return ($"{fNameSName}\t{telehpone}\t{berthday}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите кол-во записей: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите данные");
            Note[] note = GetSortNote(InputUserData(size));
            PrintNotes(note);
            Console.Write("Введите номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            PrintNotes(GetUserByMonthBirth(note, month));

        }
        public static Note[] InputUserData(int size)
        {
            Note[] note = new Note[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Фамилия и Имя: ");
                note[i].fNameSName = Console.ReadLine();
                Console.Write("Номер телефона: ");
                note[i].telehpone = Console.ReadLine();
                Console.Write("Дату рождения: ");
                note[i].berthday = DateOnly.Parse(Console.ReadLine());
            }
            return note;
        }
        public static void PrintNotes(IEnumerable<Note> notes)
        {
            if (notes.Count() == 0)
            {
                Console.WriteLine("Нет такого человека");
            }
            else
            {
                foreach (var note in notes)
                {
                    Console.WriteLine(note.ToString());
                }
            }
        }
        public static Note[] GetSortNote(Note[] note)
        {
            Array.Sort(note, (note1, note2) => note1.fNameSName.CompareTo(note2.fNameSName));
            return note;
        }
        public static List<Note> GetUserByMonthBirth(Note[] note, int month)
        {
            List<Note> noteByMonth = new List<Note>();
            for (int i = 0; i < note.Length; i++)
            {
                if (month == note[i].berthday.Month)
                {
                    noteByMonth.Add(note[i]);
                }
            }
            return noteByMonth;
        }
    }
}