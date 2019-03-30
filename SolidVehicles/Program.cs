using System;
using System.Linq;
using System.Collections.Generic;
public interface IVehicle
{ // an int property called Wheels // an int property called Doors // an int property called PassengerCapacity // a bool property called Winged // a string property called TransmissionType // a double property called EngineVolume // a double property called MaxWaterSpeed // a double property called MaxLandSpeed // a double property called MaxAirSpeed // a method called Start() that returns void // a method called Stop() that returns void // a method called Drive() that returns void // a method called Fly() that returns void
}

public class Program
{
    public static void Main()
    {

        // Build a collection of all vehicles that fly

        // With a single `foreach`, have each vehicle Fly()


        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
    }
}