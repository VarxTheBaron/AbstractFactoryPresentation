public class IVehicleFactoryResolver
{
    private Dictionary<string, IVehicleFactory> factories = new();


    public IVehicleFactory GetVehicleFactory(string factoryKey)
    {
        foreach (var factory in factories)
        {
            if (factory.Key == factoryKey) return factory.Value;
        }

        throw new InvalidDataException();
    }

    public void AddFactory(string key, IVehicleFactory vehicleFactory)
    {
        factories.Add(key, vehicleFactory);
    }
}