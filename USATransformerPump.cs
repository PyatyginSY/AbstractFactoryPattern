using System;

namespace AbstractFactoryPattern
{
    public class USATransformerPump : IPump
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer pump");
        }

        public string MadeIn()
        {
            return "Made in USA";
        }
    }
}
