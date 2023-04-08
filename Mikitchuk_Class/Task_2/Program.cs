using Task_2.Enums;
using Task_2.Models;

namespace Task_2
{
    class Task_2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберете тип двигателя: 1-двигатель внутреннего сгорания / 2-дизельный двигатель / 3-реактивный двигатель");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                var PetrolEngine = CreatePetrolEngine();
                Console.WriteLine(PetrolEngine.Output());
            }
            else if (num == 2)
            {
                var DieselEngine = CreateDieselEngine();
                Console.WriteLine(DieselEngine.Output());
            }
            else if (num == 3)
            {
                var jetEngine = CreateJetEngine();
                Console.WriteLine(jetEngine.Output());
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
        }

        private static void Input(out string name, out int power, out double volume)
        {
            Console.Write("Введите наименование двигателя: ");
            name = Console.ReadLine();
            Console.Write("Введите мощность двигателя: ");
            power = int.Parse(Console.ReadLine());
            Console.Write("Введите обьем двигателя: ");
            volume = double.Parse(Console.ReadLine());

        }

        private static JetEngine CreateJetEngine()
        {
            string name;
            int power;
            double volume;
            Input(out name, out power, out volume);
            Console.Write("Введите тип реактивного двигателя: ");
            JetEngineType jetEngineType = JetEngineType.Rocket;
            while (!Enum.TryParse<JetEngineType>(Console.ReadLine(), true, out jetEngineType))
            {
                Console.Write("Введите тип реактивного двигателя:");

            }
            return new JetEngine(name, power, volume, jetEngineType);
        }
        private static DieselEngine CreateDieselEngine()
        {
            string name;
            int power;
            double volume;
            Input(out name, out power, out volume);
            Console.Write("Введите тип камеры сгорания: ");
            DieselEngineType DieselEngineType = DieselEngineType.Separate;
            while (!Enum.TryParse<DieselEngineType>(Console.ReadLine(), true, out DieselEngineType))
            {
                Console.Write("Введите тип камеры сгорания:");

            }
            return new DieselEngine(name, power, volume, DieselEngineType);
        }
        private static PetrolEngine CreatePetrolEngine()
        {
            string name;
            int power;
            double volume;
            Input(out name, out power, out volume);
            Console.Write("Введите тип камеры сгорания: ");
            PetrolEngineType PetrolEngineType = PetrolEngineType.Single;
            while (!Enum.TryParse<PetrolEngineType>(Console.ReadLine(), true, out PetrolEngineType))
            {
                Console.Write("Введите тип камеры сгорания:");

            }
            return new PetrolEngine(name, power, volume, PetrolEngineType);
        }
    }

    public class Engine
    {
        string nameEngine;
        int powerEngine;
        double volumeEngine;

        public Engine(string name, int power, double volume)
        {
            this.nameEngine = name;
            this.powerEngine = power;
            this.volumeEngine = volume;
        }

        public virtual string Output()
        {
            return $"Название двигателя: {nameEngine}, " +
                $"Обьем двигателя: {volumeEngine}, " +
                $"Мощность двигателя: {powerEngine}";
        }
    }
}