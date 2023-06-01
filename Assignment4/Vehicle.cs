// Base Vehicle class
public class Vehicle
{
    public string type { get; set; }
    public string brand { get; set; }
    public string make { get; set; }
    public string model { get; set; }
    public string bodyType { get; set; }
    public string color { get; set; }
    public int numWheels { get; set; }

    public EngineType engineType;
    public double mileage { get; set; }
    public string VIN { get; set; }
    public string licenseNumber { get; set; }
    public int numDoors { get; set; }
    public double speed { get; set; }
    public double maxSpeed { get; set; }

    public Status status;

    public enum EngineType
    {
        Electric,
        Combustion
    }

    public enum Status
    {
        Driving,
        Maintenece,
        For_Sale,
    }

    public virtual void currentStatus()
    {
        Console.WriteLine($"{brand} is {status}.\n");
    }

    public virtual void info()
    {
        Console.WriteLine($"No Specific Vehicle Selected.\n");
    }
}

// Car class derived from Vehicle
public class Car : Vehicle
{

    private int doors;
    public int NumDoors
    {
        get { return doors; }
        set { doors = value; }
    }

    public override void info()
    {
        Console.WriteLine(
            $"Selected Type: {type}\n" +
            $"\tBrand: {brand} \n" +
            $"\tMake: {make} \n" +
            $"\tModel: {model} \n" +
            $"\tBody Type: {bodyType}\n" +
            $"\tColor: {color}\n" +
            $"\tNumber of Wheels: {numWheels}\n" +
            $"\tEngine Type: {engineType}\n" +
            $"\tMilage: {mileage}\n" +
            $"\tVIN: {VIN} \n" +
            $"\tLicense Plate: {licenseNumber}\n" +
            $"\tSpeed: {speed}\n" +
            $"\tMax Speed: {maxSpeed}\n"+
            $"\tNumber of Doors: {NumDoors}\n");

    }

}

// Truck class derived from Vehicle
public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public override void info()
    {
        Console.WriteLine(
            $"Selected Type: {type}\n" +
            $"\tBrand: {brand} \n" +
            $"\tMake: {make} \n" +
            $"\tModel: {model} \n" +
            $"\tBody Type: {bodyType}\n" +
            $"\tColor: {color}\n" +
            $"\tNumber of Wheels: {numWheels}\n" +
            $"\tEngine Type: {engineType}\n" +
            $"\tMilage: {mileage}\n" +
            $"\tVIN: {VIN} \n" +
            $"\tLicense Plate: {licenseNumber}\n" +
            $"\tSpeed: {speed}\n" +
            $"\tMax Speed: {maxSpeed}\n" +
            $"\tLoad Capacity: {LoadCapacity}\n");
    }

    public override void currentStatus()
    {
        Console.WriteLine($"This {type} is not for sale!\n");
    }
}

// Bus class derived from Vehicle
public class Bus : Vehicle
{
    public int NumSeats { get; set; }

    public override void info()
    {
        Console.WriteLine(
            $"Selected Type: {type}\n" +
            $"\tBrand: {brand} \n" +
            $"\tMake: {make} \n" +
            $"\tModel: {model} \n" +
            $"\tBody Type: {bodyType}\n" +
            $"\tColor: {color}\n" +
            $"\tNumber of Wheels: {numWheels}\n" +
            $"\tEngine Type: {engineType}\n" +
            $"\tMilage: {mileage}\n" +
            $"\tVIN: {VIN} \n" +
            $"\tLicense Plate: {licenseNumber}\n" +
            $"\tSpeed: {speed}\n" +
            $"\tMax Speed: {maxSpeed}\n" +
            $"\tNumber of Seats: {NumSeats}\n");
    }

    public override void currentStatus()
    {
        Console.WriteLine($"This {type} Belongs to Transit!\n");
    }
}

// Motorcycle class derived from Vehicle
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void info()
    {
        Console.WriteLine(
            $"Selected Type: {type}\n" +
            $"\tBrand: {brand} \n" +
            $"\tModel: {model} \n" +
            $"\tColor: {color}\n" +
            $"\tNumber of Wheels: {numWheels}\n" +
            $"\tEngine Type: {engineType}\n" +
            $"\tMilage: {mileage}\n" +
            $"\tVIN: {VIN} \n" +
            $"\tLicense Plate: {licenseNumber}\n" +
            $"\tMax Speed: {maxSpeed}\n" +
            $"\tSide Car: {HasSidecar}\n");

    }

    public override void currentStatus()
    {
        Console.WriteLine($"This {type} is in the lot!\n");
    }

}
