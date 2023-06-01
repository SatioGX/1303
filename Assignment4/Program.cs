using static Vehicle;

class Program
{
    static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle();
        myVehicle.info();

        Car myCar = new Car();
        myCar.type = "Car";
        myCar.brand = "Tesla";
        myCar.make = "Model 3";
        myCar.model = "2020";
        myCar.bodyType = "Sedan";
        myCar.color = "Black";
        myCar.numWheels = 4;
        myCar.engineType = EngineType.Electric;
        myCar.mileage = 5000;
        myCar.VIN = "12345";
        myCar.licenseNumber = "ABC123";
        myCar.NumDoors = 4;
        myCar.speed = 60;
        myCar.maxSpeed = 120;
        myCar.status = Status.For_Sale;
        myCar.info();
        myCar.currentStatus();

        Truck myTruck = new Truck();
        myTruck.type = "Truck";
        myTruck.brand = "Ford";
        myTruck.make = "F150";
        myTruck.model = "2018";
        myTruck.bodyType = "Pickup";
        myTruck.color = "Red";
        myTruck.numWheels = 6;
        myTruck.engineType = EngineType.Combustion;
        myTruck.mileage = 10000;
        myTruck.VIN = "67890";
        myTruck.licenseNumber = "XYZ789";
        myTruck.LoadCapacity = 5000;
        myTruck.speed = 50;
        myTruck.maxSpeed = 80;
        myTruck.info();
        myTruck.currentStatus();

        Bus myBus = new Bus();
        myBus.type = "Bus";
        myBus.brand = "Transit";
        myBus.make = "Standard";
        myBus.model = "2021";
        myBus.bodyType = "Double Decker";
        myBus.color = "Blue";
        myBus.numWheels = 10;
        myBus.engineType = EngineType.Combustion;
        myBus.mileage = 150000;
        myBus.VIN = "85469";
        myBus.licenseNumber = "GCD159";
        myBus.NumSeats = 30;
        myBus.speed = 40;
        myBus.maxSpeed = 60;
        myBus.info();
        myBus.currentStatus();

        Motorcycle myMotorcycle = new Motorcycle();
        myMotorcycle.type = "Motorcycle";
        myMotorcycle.brand = "Harley Davidson";
        myMotorcycle.model = "2019";
        myMotorcycle.color = "Black";
        myMotorcycle.numWheels = 2;
        myMotorcycle.engineType = EngineType.Combustion;
        myMotorcycle.mileage = 2000;
        myMotorcycle.VIN = "951753";
        myMotorcycle.licenseNumber = "ICL15G";
        myMotorcycle.HasSidecar = true;
        myMotorcycle.speed = 50;
        myMotorcycle.maxSpeed = 120;
        myMotorcycle.info();
        myMotorcycle.currentStatus();
    }
}
