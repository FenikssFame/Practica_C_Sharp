using static Task_4.Program;

namespace Task_4
{
    class Program
    {
        public delegate void DelegateEvent(double sideA, double sideB, double sideC);
        public static void Main(string[] args)
        {
            Console.Write("Введите сторону А: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону В: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону С: ");
            double sideC = double.Parse(Console.ReadLine());
            ActionClass ac = new ActionClass(sideA, sideB, sideC);
            ObservationOne observation1 = new ObservationOne();
            ac.Action += observation1.SquareTriangle;
            ac.Action += observation1.PerimetrTriangle;
            ObservationTwo observation2 = new ObservationTwo();
            ac.Action += observation2.ViewTriangle;
            ac.Raise();
            ac.Action -= observation2.ViewTriangle;
            ac.Raise();
        }
    }
    class ActionClass
    {
        public event DelegateEvent Action;
        private double sideA;
        private double sideB;
        private double sideC;
        public ActionClass(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public void Raise()
        {
            if (Action != null)
            {
                Action(sideA, sideB, sideC);
            }
        }
    }
    class ObservationOne
    {
        public void SquareTriangle(double sideA, double sideB, double sideC)
        {
            double semi = (sideA + sideB + sideC) / 2;
            double result = Math.Sqrt(semi * (semi - sideA) * (semi - sideB) * (semi - sideC));
            Console.WriteLine($"Площадь треугольника: {result}");
        }
        public void PerimetrTriangle(double sideA, double sideB, double sideC)
        {
            Console.WriteLine($"Периметр треугольника: {sideA + sideB + sideC}");
        }
    }
    class ObservationTwo
    {
        public void ViewTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA == sideB && sideA == sideC)
            {
                Console.WriteLine($"Тип: Равносторонний");
            }
            else if (sideB == sideC)
            {
                Console.WriteLine($"Тип: Равнобедренный");
            }
            else
            {
                Console.WriteLine($"Тип: Разносторонний");
            }
        }
    }
}