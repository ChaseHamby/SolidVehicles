//using SolidVehicles.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SolidVehicles.Vehicles
//{
//    public interface Boat : IVehicle
//    {
//        int Wheels { get; set; }
//        int Doors { get; set; }
//        int PassengerCapacity { get; set; } = 6;
//        bool Winged { get; set; } = false;
//        string TransmissionType { get; set; }
//        double EngineVolume { get; set; }
//        double MaxWaterSpeed { get; set; } = 80;
//        double MaxLandSpeed { get; set; } = 2;
//        double MaxAirSpeed { get; set; }

//        public void Drive()
//        {
//            Console.WriteLine("The boat moves super fast across the lake and very slow when it hits land.");
//        }

//        public void Fly()
//        {
//            throw new NotImplementedException();
//        }

//        public void Start()
//        {
//            throw new NotImplementedException();
//        }
//        public void Stop()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
