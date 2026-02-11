internal class Program
{
	private static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("Select the type of car to create:");
			Console.WriteLine("1. Gasoline Car");
			Console.WriteLine("2. Diesel Car");
			Console.WriteLine("3. Electrical Car");

			string input = Console.ReadLine() ?? "";

			switch (input)
			{
				case "1":
					RunCar(new GasolineCarFactory());
					break;
				case "2":
					RunCar(new DieselCarFactory());
					break;
				case "3":
					RunCar(new ElectricalCarFactory());
					break;

				default:
					Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
					break;
			}
		}
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