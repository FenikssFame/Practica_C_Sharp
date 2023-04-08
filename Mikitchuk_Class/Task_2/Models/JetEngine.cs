using Task_2.Enums;

namespace Task_2.Models
{
    public class JetEngine : Engine
    {
        // Ракетный, Пороховой, Турбореактивный, Турбовинтовой
        public JetEngineType typeJetEngine;
        public JetEngine(string name, int power, double volume, JetEngineType typeJet) : base(name, power, volume)
        {
            typeJetEngine = typeJet;
        }
        public override string Output()
        {
            return $"{base.Output()}, Тип реактивного двигателя: {typeJetEngine}";
        }
    }
}