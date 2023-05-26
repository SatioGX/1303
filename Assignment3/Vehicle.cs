// Base Vehicle class
public class Vehicle
{
    public string brand { get; set; }
    public int year { get; set; }
    public int numWheels { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine($"Driving a {brand} with {numWheels} wheels");
    }
}

// Car class derived from Vehicle
public class Car : Vehicle
{
    public int NumDoors { get; set; }

}

// Truck class derived from Vehicle
public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

}

// Bus class derived from Vehicle
public class Bus : Vehicle
{
    public int NumSeats { get; set; }

}

// Motorcycle class derived from Vehicle
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

}
