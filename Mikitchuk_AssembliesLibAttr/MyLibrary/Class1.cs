namespace MyLibrary
{
    public class Triangle
    {
        double a;
        double b;
        double c;
        public Triangle()
        {
        }
        public double CalcPerimeter()
        {
            double perimeter = a + b + c;
            return perimeter;
        }
        public double CalcArea()
        {
            double semiperimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            return area;
        }
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
        public double C
        {
            get { return c; }
            set
            {
                if (value < 0)
                    c = 0;
                else
                    c = value;
            }
        }
        public bool IsTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }
        }
        public string FormTriangling()
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return "Треугольника с такими сторонами не существует!!!";
            }
            if (a == b && a == c && b == c)
            {
                return "Треугольник равносторонний!";
            }
            if (((a * a) == (b * b) + (c * c)) || ((b * b) == ((a * a) + (c * c)) || ((c * c) == (b * b) + (a * a))))
            {
                return "Треугольник прямоугольный!";
            }
            if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b))
            {
                return "Треугольник равнобедренный!";
            }
            return "Треугольник разносторонний!";
        }
    }
    public class Rectangle
    {
        double a;
        double b;
        public Rectangle()
        {
        }
        public double CalcPerimeter()
        {
            double perimeter = 2 * (a + b);
            return perimeter;
        }
        public double CalcArea()
        {
            double area = a * b;
            return area;
        }
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