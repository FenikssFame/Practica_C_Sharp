namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Marker markers = new Marker();
                markers.ProductCost();
                markers.GetInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Product
    {
        private int count;
        private double cost;
        private double result;
        public int Count
        {
            get { return count; }
            set { count = value; }

        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }

        }
        public double Result
        {
            get { return result; }
            set { result = value; }

        }
        public Product()
        {
            this.count = 0;
            this.cost = 0;
            this.result = 0;
            Input();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Кол-во: {count}\n" +
                $"Цена: {cost}");
        }
        public virtual void ProductCost()
        {
            result = cost * count;
        }
        public void Input()
        {
            Console.Write("Введите цену: ");
            cost = double.Parse(Console.ReadLine());
            Console.Write("Введите количество: ");
            count = int.Parse(Console.ReadLine());
        }
    }
    class Marker : Product
    {
        private string name;
        private int sort;
        public Marker() : base()
        {
            this.name = "Фломастерс";
            this.sort = 1;
            Input();
        }
        public override void ProductCost()
        {
            Result = Count * Cost * (1 / Math.Sqrt(sort));
        }
        public void GetInfo()
        {
            Console.WriteLine($"Кол-во: {Count}\n" +
                $"Цена: {Cost}\n" +
                $"Название фломастеров: {name}\n" +
                $"Сорт: {sort}\n" +
                $"Новая стоимость: {Result}");
        }
        public void Input()
        {
            Console.Write("Введите название: ");
            name = Console.ReadLine();
            Console.Write("Введите сорт: ");
            sort = int.Parse(Console.ReadLine());
        }
    }
}