public static class IVehicleFactoryResolver
{
    static private Dictionary<string, IVehicleFactory> factories = new();

    static public IVehicleFactory GetVehicleFactory(string factoryKey)
    {
        foreach (var factory in factories)
        {
            if (factory.Key == factoryKey) return factory.Value;
        }

        throw new InvalidDataException();
    }

    static public void AddFactory(string key, IVehicleFactory vehicleFactory)
    {
        factories.Add(key, vehicleFactory);
    }
}