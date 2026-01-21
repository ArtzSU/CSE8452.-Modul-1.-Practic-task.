using System;
using System.Collections.Generic;

namespace Transport
{
    public class Fleet
    {
        private List<Vehicle> fleet = new List<Vehicle>();

        public int AddTransport(Vehicle garage, bool debug = false)
        {
            fleet.Add(garage);
            if (debug)
            {
                Console.WriteLine("Garage added");
            }
            return 1;
        }

        public int RemoveTransport(Vehicle garage, bool debug = false)
        {
            fleet.Remove(garage);
            if (debug)
            {
                Console.WriteLine("Garage removed");
            }
            return 1;
        }

        public Vehicle SearchVehicle(string plate)
        {
            foreach (var vehicle in fleet)
            {
                if (vehicle.plate == plate)
                    return vehicle;
            }
            return null;
        }
    }
}
