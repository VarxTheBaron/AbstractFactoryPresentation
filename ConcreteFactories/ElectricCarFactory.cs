public class ElectricalCarFactory : IVehicleFactory
{
    public IEngine CreateEngine()
    {
        return new ElectricEngine();
    }

    public IInterior CreateInterior()
    {
        return new ElectricInterior();
    }

    public IWheel CreateWheel()
    {
        return new ElectricWheel();
    }
}