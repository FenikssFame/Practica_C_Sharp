namespace Task_2
{
    public enum Post
    {
        Analyst = 164,
        Teacher = 180,
        Gardener = 150,
        Loader = 154,
        Agronomist = 170,
        Programmer = 160,
        Builder = 100
    }
    public class Program
    {
        public static void Main()
        {
            foreach (string post in Enum.GetNames(typeof(Post)))
            {
                Console.Write($"Введите, cколько времени проработал за этот месяц {post}: ");
                int hours = int.Parse(Console.ReadLine());
                Enum.TryParse<Post>(post, true, out Post postEnum);
                Console.WriteLine($"{post} премия: {GetBonusLoc(postEnum, hours)}");
                Console.WriteLine();
            }
        }
        public static string GetBonusLoc(Post worker, int hours)
        {
            Accauntant acc = new Accauntant();
            if (acc.AskForBonus(worker, hours))
            {
                return "Положена премия";
            }
            else
            {
                return "Не положена премия";
            }
        }
    }
    public class Accauntant
    {
        public Accauntant()
        {
        }
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
