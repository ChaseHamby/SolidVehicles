using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    public class Helicopter : IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 4;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 25;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; } = 250;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The Helicopter chops through the trees!");
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
