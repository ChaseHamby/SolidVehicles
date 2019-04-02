using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
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
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxLandSpeed} MPH. ");
        }

        public void Stop()
        {
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and stops after hitting a top speed of {MaxLandSpeed} MPH. ");
        }

        public void Start()
        {
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxLandSpeed} MPH. ");
        }
    }
}
