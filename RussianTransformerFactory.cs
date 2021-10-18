namespace AbstractFactoryPattern
{
    public class RussianTransformerFactory : ITransformerFactory
    {
        public IPower CreateTransformerPower()
        {
            return new RussianTransformerPower();
        }

        public IDistribution CreateTransformerDistribution()
        {
            return new RussianTransformerDistribution();
        }

        public IPump CreateTransformerPump()
        {
            return new RussianTransformerPump();
        }
    }
}
