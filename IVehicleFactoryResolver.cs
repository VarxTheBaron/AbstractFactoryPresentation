public class IVehicleFactoryResolver
{
    public IVehicleFactory GetVehicleFactory(string factoryName)
    {
        if (factoryName == "gasoline")
            return new GasolineCarFactory();
        else if (factoryName == "diesel")
            return new DieselCarFactory();
        else if (factoryName == "electric")
            return new ElectricalCarFactory();
        else
            throw new InvalidDataException();
    }
}