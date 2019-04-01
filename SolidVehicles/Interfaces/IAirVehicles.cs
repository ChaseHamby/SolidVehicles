using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    public class IAirVehicles
    {
        public string Name { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public IAirVehicles(string name, int passengerCapacity, bool winged, double engineVolume, double maxAirSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            Winged = winged;
            EngineVolume = engineVolume;
            MaxAirSpeed = maxAirSpeed;
        }
    }
}
