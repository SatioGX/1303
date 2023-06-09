using System;

public enum VehicleType
{
    Car,
    Truck,
    Bus,
    Motorcycle
}

public class Engine
{
    public string Model { get; set; }
    public int Horsepower { get; set; }
}

public class Body
{
    public string Color { get; set; }
    public int Doors { get; set; }
}

public class Vehicle<TVehicleType, TEngine, TBody>
    where TVehicleType : Enum
    where TEngine : Engine
    where TBody : Body
{
    public TVehicleType Type { get; set; }
    public TEngine Engine { get; set; }
    public TBody Body { get; set; }

    public void Start()
    {
        Console.WriteLine($"Starting the {Type} with {Engine.Horsepower} horsepower");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving the {Type}");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping the {Type}");
    }

}


