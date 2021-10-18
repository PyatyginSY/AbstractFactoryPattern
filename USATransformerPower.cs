using System;

namespace AbstractFactoryPattern
{
    public class USATransformerPower : IPower
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer power");
        }

        public string MadeIn()
        {
            return "Made in USA";
        }
    }
}
