public interface IVehicleFactory
{
    IEngine CreateEngine();
    IInterior CreateInterior();
    IWheel CreateWheel();
}