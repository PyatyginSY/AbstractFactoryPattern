using System;

namespace AbstractFactoryPattern
{
    public class RussianTransformerPump : IPump
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer pump");
        }

        public string MadeIn()
        {
            return "Made in Russian";
        }
    }
}
