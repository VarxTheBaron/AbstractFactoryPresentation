public static class IVehicleFactoryResolver
{
    static private Dictionary<string, IVehicleFactory> factories = new();

    static public IVehicleFactory GetVehicleFactory(string factoryKey)
    {
        if (factories.ContainsKey(factoryKey))
            return factories[factoryKey];

        throw new InvalidDataException();
    }

    static public void AddFactory(string key, IVehicleFactory vehicleFactory)
    {
        factories.Add(key, vehicleFactory);
    }
}