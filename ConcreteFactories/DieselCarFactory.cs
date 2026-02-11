public class DieselCarFactory : IVehicleFactory
{
    public IEngine CreateEngine()
    {
        return new DieselEngine();
    }

    public IInterior CreateInterior()
    {
        return new DieselCarInterior();
    }

    public IWheel CreateWheel()
    {
        return new DieselCarWheel();
    }
}