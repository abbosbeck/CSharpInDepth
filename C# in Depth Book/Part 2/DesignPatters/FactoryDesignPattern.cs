namespace Part2.DesignPatters
{
    public interface IVehicle
    {
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Drive() =>
            Console.WriteLine("Driving a Car");
    }

    public class Bike : IVehicle
    {
        public void Drive() =>
            Console.WriteLine("Riding a Bike");
    }

    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            return type switch
            {
                "Car" => new Car(),
                "Bike" => new Bike(),
                _ => throw new ArgumentException("Invalid vehicle type.")
            };
        }
    }

    public class FactoryDesignPattern
    {
    }
}
