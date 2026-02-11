internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Select the type of car to create:");
		Console.WriteLine("1. Gasoline");
		Console.WriteLine("2. Diesel");
		Console.WriteLine("3. Electrical");

		string input = Console.ReadLine() ?? "";


		RunCar(IVehicleFactoryResolver.GetVehicleFactory(input.ToLower().Trim()));
	}

	public static void RunCar(IVehicleFactory factory)
	{
		Car car = new Car(factory);
		car.ShowInfo();
	}

	public class Car(IVehicleFactory factory)
	{
		IEngine engine = factory.CreateEngine();
		IInterior interior = factory.CreateInterior();
		IWheel wheel = factory.CreateWheel();

		public void ShowInfo()
		{
			Console.WriteLine($"Engine: {engine.GetSpecs()}");
			Console.WriteLine($"Interior: {interior.GetStyle()}");
			Console.WriteLine($"Wheel: {wheel.GetWheelType()}");
		}
	}
}