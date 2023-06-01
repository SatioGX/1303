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

    public virtual void info()
    {
        Console.WriteLine($"The car is {brand} from {year} and has {numWheels} wheels.");
    }
}

// Car class derived from Vehicle
public class Car : Vehicle
{
    private int doors;
    public int NumDoors { get; set; }

    public override void info()
    {
        base.info();
    }

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
