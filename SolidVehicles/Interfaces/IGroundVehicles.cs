using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    public class IGroundVehicles
    {
        public string Name { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public IGroundVehicles(string name, int passengerCapacity, bool winged, double engineVolume, double maxLandSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            Winged = winged;
            EngineVolume = engineVolume;
            MaxLandSpeed = maxLandSpeed;
        }
    }
}
