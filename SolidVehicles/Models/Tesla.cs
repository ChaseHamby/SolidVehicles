using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    public class Tesla : IVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 5;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; } = 155;
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The Tesla can back itself out of the parking spot and drive up to the store to pick you up - without a driver.");
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
