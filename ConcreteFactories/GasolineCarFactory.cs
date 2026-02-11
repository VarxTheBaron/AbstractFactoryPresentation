public class GasolineCarFactory : IVehicleFactory
{
    public IEngine CreateEngine()
    {
        return new GasolineEngine();
    }

    public IInterior CreateInterior()
    {
        return new GasolineInterior();
    }

    public IWheel CreateWheel()
    {
        return new GasolineWheel();
    }
}