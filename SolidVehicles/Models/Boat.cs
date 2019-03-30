using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    public class Boat : IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; } = 6;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; } = 80;
        public double MaxLandSpeed { get; set; } = 2;
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The boat moves super fast across the lake and very slow when it hits land.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
