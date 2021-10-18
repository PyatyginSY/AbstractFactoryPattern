using System;

namespace AbstractFactoryPattern
{
    public class USATransformerDistribution : IDistribution
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer distribution");
        }

        public string MadeIn()
        {
            return "Made in USA";
        }
    }
}
