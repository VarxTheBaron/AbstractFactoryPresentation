public interface IVehicleFactory
{
    IEngine CreateEngine();
    IInterior CreateInterior();
}