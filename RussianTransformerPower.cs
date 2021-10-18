using System;

namespace AbstractFactoryPattern
{
    public class RussianTransformerPower : IPower
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer power");
        }

        public string MadeIn()
        {
            return "Made in Russian";
        }
    }
}
