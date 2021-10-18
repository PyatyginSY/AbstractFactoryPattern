namespace AbstractFactoryPattern
{
    public interface ITransformerFactory
    {
        IPower CreateTransformerPower();
        IDistribution CreateTransformerDistribution();
        IPump CreateTransformerPump();
    }
}
