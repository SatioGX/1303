using static VehicleType;

class Program
{

    static void Main(string[] args)
    {
        // Create a car
        var carEngine = new Engine { Model = "V6", Horsepower = 300 };
        var carBody = new Body { Color = "Red", Doors = 4 };
        var car = new Vehicle<VehicleType, Engine, Body>
        {
            Type = VehicleType.Car,
            Engine = carEngine,
            Body = carBody
        };

        car.Start();
        car.Drive();
        car.Stop();

        // Create a truck
        var truckEngine = new Engine { Model = "V8", Horsepower = 500 };
        var truckBody = new Body { Color = "Blue", Doors = 2 };
        var truck = new Vehicle<VehicleType, Engine, Body>
        {
            Type = VehicleType.Truck,
            Engine = truckEngine,
            Body = truckBody
        };

        truck.Start();
        truck.Drive();
        truck.Stop();

        // Create a motorcycle
        var motorcycleEngine = new Engine { Model = "V2", Horsepower = 100 };
        var motorcycleBody = new Body { Color = "Black", Doors = 0 };
        var motorcycle = new Vehicle<VehicleType, Engine, Body>
        {
            Type = VehicleType.Motorcycle,
            Engine = motorcycleEngine,
            Body = motorcycleBody
        };

        motorcycle.Start();
        motorcycle.Drive();
        motorcycle.Stop();

    }
}