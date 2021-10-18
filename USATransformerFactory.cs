namespace AbstractFactoryPattern
{
    public class USATransformerFactory : ITransformerFactory
    {
        public IPower CreateTransformerPower()
        {
            return new USATransformerPower();
        }

        public IDistribution CreateTransformerDistribution()
        {
            return new USATransformerDistribution();
        }

        public IPump CreateTransformerPump()
        {
            return new USATransformerPump();
        }
    }
}
