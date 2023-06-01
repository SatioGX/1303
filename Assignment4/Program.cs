class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.brand = "Toyota";
        myCar.year = 2020;
        myCar.numWheels = 4;
        myCar.NumDoors = 4;
        myCar.Drive();

        Truck myTruck = new Truck();
        myTruck.brand = "Ford";
        myTruck.year = 2018;
        myTruck.numWheels = 6;
        myTruck.LoadCapacity = 5000;
        myTruck.Drive();

        Bus myBus = new Bus();
        myBus.brand = "Transit Bus";
        myBus.year = 2015;
        myBus.numWheels = 8;
        myBus.NumSeats = 40;
        myBus.Drive();

        Motorcycle myMotorcycle = new Motorcycle();
        myMotorcycle.brand = "Harley Davidson";
        myMotorcycle.year = 2021;
        myMotorcycle.numWheels = 2;
        myMotorcycle.HasSidecar = false;
        myMotorcycle.Drive();
    }
}
