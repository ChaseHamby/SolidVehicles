using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
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
            Console.Write($"{Name} can hold {PassengerCapacity} passengers and flies at {MaxAirSpeed} MPH. ");
        }

        public void Stop()
        {
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxAirSpeed} MPH. ");
        }

        public void Start()
        {
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxAirSpeed} MPH. ");
        }
    }
}
