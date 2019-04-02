using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    public class IWaterVehicle : IWaterVehicleStuff, IDrive, IStop, IStart
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
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxWaterSpeed} MPH. ");
        }

        public void Stop()
        {
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxWaterSpeed} MPH. ");
        }

        public void Start()
        {
            Console.Write($"{Name} rides on {Wheels} wheels, holds {PassengerCapacity} passengers and can travel at {MaxWaterSpeed} MPH. ");
        }
    }
}
