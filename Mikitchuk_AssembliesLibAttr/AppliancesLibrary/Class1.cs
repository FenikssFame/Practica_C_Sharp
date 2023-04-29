namespace AppliancesLibrary
{
    public class Appliances
    {
        string mark;
        string model;
        string name;
        string body;
        double height;
        double length;
        double width;
        double cost;
        public Appliances() { }
        public string Mark
        {
            get { return mark; }
            set
            {
                if (value == "")
                    mark = "Не указано";
                else
                    mark = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value == "")
                    model = "Не указано";
                else
                    model = value;
            }
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
        public string Body
        {
            get { return body; }
            set
            {
                if (value == "")
                    body = "Не указано";
                else
                    body = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }
        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                    length = 0;
                else
                    length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }
        public double Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                    cost = 0;
                else
                    cost = value;
            }
        }
        public double CalcArea()
        {
            return length * width;
        }
        public string TypeAppliances()
        {
            double S = height * width * length;
            if (S < 70)
            {
                return "Малогабаритная техника";
            }
            else
            {
                return "Крупногабаритная техника";
            }
        }
        public double CalcCostTransporting()
        {
            if (TypeAppliances() == "Малогабаритная техника")
            {
                return cost + (cost / 100 * 20);
            }
            else
            {
                return cost + (cost / 100 * 50);
            }
        }
        public override string ToString()
        {
            return $"Марка: {mark}\n" +
                $"Модель: {model}\n" +
                $"Наименование: {name}\n" +
                $"Материал корпуса: {body}\n" +
                $"Размеры: h: {height}, l: {length}, w: {width}\n" +
                $"Цена: {cost}\n";
        }
    }
}