using Task_2.Enums;

namespace Task_2.Models
{
    public class DieselEngine : Engine
    {
        // Раздельный, Нераздельный
        public DieselEngineType typeChamberEngine;
        public DieselEngine(string name, int power, double volume, DieselEngineType typeChamber) : base(name, power, volume)
        {
            typeChamberEngine = typeChamber;
        }
        public override string Output()
        {
            return $"{base.Output()}, Тип камеры сгорания двигателя: {typeChamberEngine}";
        }
    }
}