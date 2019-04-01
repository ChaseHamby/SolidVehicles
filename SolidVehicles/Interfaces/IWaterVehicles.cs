using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    public class IWaterVehicles
    {
        public string Name { get; set; }
        public int PassengerCapacity { get; set; }
        public int Wheels { get; set; }
        public bool Winged { get; set; }
        public double MaxWaterSpeed { get; set; }

        public IWaterVehicles(string name, int passengerCapacity, int wheels, bool winged, double maxWaterSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            Wheels = wheels;
            Winged = winged;
            MaxWaterSpeed = maxWaterSpeed;
        }
    }


}
