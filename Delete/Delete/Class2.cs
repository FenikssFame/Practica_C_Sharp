namespace Delete
{
    public class Rectangle
    {
        double a;
        double b;

        // Конструктор, позволяющий создать экземпляр класса
        public Rectangle()
        {
        }

        // Метод для расчёта периметра
        public double CalcPerimeter()
        {
            double perimeter = 2*(a + b);
            return perimeter;
        }

        // Метод для расчёта площадь
        public double CalcArea()
        {
            double area = a * b;
            return area;
        }

        // Свойство, позволяющее получить-установить длины сторон
        public double A
        {
            get { return a; }
            set
            {
                if (value < 0)
                    a = 0;
                else
                    a = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value < 0)
                    b = 0;
                else
                    b = value;
            }
        }
    }
}
