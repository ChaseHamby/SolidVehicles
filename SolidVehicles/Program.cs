using System;
using System.Linq;
using System.Collections.Generic;

public interface IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    double MaxWaterSpeed { get; set; }
    double MaxLandSpeed { get; set;}
    double MaxAirSpeed { get; set; }
}

public interface IWaterVehicleStuff
{
    string Name { get; set; }
    int PassengerCapacity { get; set; }
    int Wheels { get; set; }
    bool Winged { get; set; }
    double MaxWaterSpeed { get; set; }
}

public interface IAirVehicleStuff
{
    string Name { get; set; }
    int PassengerCapacity { get; set; }
    int Wheels { get; set; }
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
}

public interface IGroundVehicleStuff
{
    string Name { get; set; }
    int PassengerCapacity { get; set; }
    int Wheels { get; set; }
    bool Winged { get; set; }
    double MaxLandSpeed { get; set; }
}

public interface IDrive
{
    void Drive();
}

public interface IStart
{
    void Start();
}

public interface IStop
{
    void Stop();
}

public interface IFly
{
    void Fly();
}

public class IWaterVehicle: IWaterVehicleStuff, IDrive, IStop, IStart
{
    public string Name { get; set; }
    public int Wheels { get; set; }
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; }
    public double MaxWaterSpeed { get; set; }

    public IWaterVehicle(string name, int wheels, int passengerCapacity, bool winged, double maxWaterSpeed)
    {
        Name = name;
        Wheels = wheels;
        PassengerCapacity = passengerCapacity;
        Winged = winged;
        MaxWaterSpeed = maxWaterSpeed;
    }

    public void Drive()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxWaterSpeed} MPH");
    }

    public void Stop()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxWaterSpeed} MPH");
    }

    public void Start()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxWaterSpeed} MPH");
    }
}

public class IGroundVehicle : IGroundVehicleStuff, IDrive, IStop, IStart
{
    public string Name { get; set; }
    public int Wheels { get; set; }
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; }
    public double MaxLandSpeed { get; set; }

    public IGroundVehicle(string name, int wheels, int passengerCapacity, bool winged, double maxLandSpeed)
    {
        Name = name;
        Wheels = wheels;
        PassengerCapacity = passengerCapacity;
        Winged = winged;
        MaxLandSpeed = maxLandSpeed;
    }

    public void Drive()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxLandSpeed} MPH");
    }

    public void Stop()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and stops after hitting a top speed of {MaxLandSpeed} MPH");
    }

    public void Start()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxLandSpeed} MPH");
    }
}

public class IAirVehicle : IAirVehicleStuff, IFly, IStop, IStart
{
    public string Name { get; set; }
    public int Wheels { get; set; }
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; }
    public double MaxAirSpeed { get; set; }

    public IAirVehicle(string name, int wheels, int passengerCapacity, bool winged, double maxAirSpeed)
    {
        Name = name;
        Wheels = wheels;
        PassengerCapacity = passengerCapacity;
        Winged = winged;
        MaxAirSpeed = maxAirSpeed;
    }

    public void Fly()
    {
        Console.Write($"{Name} can hold {PassengerCapacity} passengers and flies at {MaxAirSpeed} MPH");
    }

    public void Stop()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxAirSpeed} MPH");
    }

    public void Start()
    {
        Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxAirSpeed} MPH");
    }
}


public class Program
{
    public static void Main()
    {
        var waterVehicles = new List<IWaterVehicle>();
        var jetski = new IWaterVehicle("Jetski", 0, 2, false, 100);
        var boat = new IWaterVehicle("Boat", 2, 8, false, 200);

        waterVehicles.Add(jetski);
        waterVehicles.Add(boat);

        foreach (var vehicle in waterVehicles)
        {
            vehicle.Start();
        }

        Console.ReadLine();

        var airVehicles = new List<IAirVehicle>();
        var cessna = new IAirVehicle("Plane", 0, 200, true, 600);
        var helicopter = new IAirVehicle("Helicopter", 0, 6, false, 200);

        airVehicles.Add(cessna);
        airVehicles.Add(helicopter);

        foreach (var vehicle in airVehicles)
        {
            vehicle.Start();
            vehicle.Fly();
        }

        Console.ReadLine();

        var groundVehicles = new List<IGroundVehicle>();
        var motorcycle = new IGroundVehicle("Motorcycle", 2, 2, false, 180);
        var tesla = new IGroundVehicle("Tesla", 4, 5, false, 160);

        groundVehicles.Add(motorcycle);
        groundVehicles.Add(tesla);

        foreach (var vehicle in groundVehicles)
        {
            vehicle.Stop();
        }

        Console.ReadLine();
    }
}