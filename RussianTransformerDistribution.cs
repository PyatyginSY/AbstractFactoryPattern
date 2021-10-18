using System;

namespace AbstractFactoryPattern
{
    public class RussianTransformerDistribution : IDistribution
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer distribution");
        }

        public string MadeIn()
        {
            return "Made in Russian";
        }
    }
}
