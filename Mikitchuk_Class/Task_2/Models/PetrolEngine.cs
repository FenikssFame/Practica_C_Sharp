using Task_2.Enums;

namespace Task_2.Models
{
    public class PetrolEngine : Engine
    {
        // Одноцилиндровые, Двухцилиндровые, Многоцилиндровые
        public PetrolEngineType numCylindersEngine;
        public PetrolEngine(string name, int power, double volume, PetrolEngineType numCylinders) : base(name, power, volume)
        {
            numCylindersEngine = numCylinders;
        }
        public override string Output()
        {
            return $"{base.Output()}, Тип камеры сгорания двигателя: {numCylindersEngine}";
        }
    }
}