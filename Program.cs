using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AbstractFactoryPattern");

            ITransformerFactory factory;
            IPower transformerPower;
            IDistribution transformerDistribution;
            IPump transformerPump;

            factory = new RussianTransformerFactory();
            transformerPower = factory.CreateTransformerPower();
            Console.WriteLine($"Produced: {transformerPower.MadeIn()}");
            transformerPower.GetVoltage();

            transformerDistribution = factory.CreateTransformerDistribution();
            Console.WriteLine($"Produced: {transformerDistribution.MadeIn()}");
            transformerDistribution.GetVoltage();

            transformerPump = factory.CreateTransformerPump();
            Console.WriteLine($"Produced: {transformerPump.MadeIn()}");
            transformerPump.GetVoltage();

            factory = new USATransformerFactory();
            transformerPower = factory.CreateTransformerPower();
            Console.WriteLine($"Produced: {transformerPower.MadeIn()}");
            transformerPower.GetVoltage();

            transformerDistribution = factory.CreateTransformerDistribution();
            Console.WriteLine($"Produced: {transformerDistribution.MadeIn()}");
            transformerDistribution.GetVoltage();

            transformerPump = factory.CreateTransformerPump();
            Console.WriteLine($"Produced: {transformerPump.MadeIn()}");
            transformerPump.GetVoltage();

            Console.ReadLine();
        }
    }
}
