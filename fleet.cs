using System;
using System.Collections.Generic;

namespace Transport
{
    public class Fleet
    {
        private List<Garage> fleet = new List<Garage>();

        public int AddGarage(Garage garage, bool debug = false)
        {
            fleet.Add(garage);
            if (debug)
            {
                Console.WriteLine("Garage added");
            }
            return 1;
        }

        public int RemoveGarage(Garage garage, bool debug = false)
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
            foreach (var garage in fleet)
            {
                foreach (var vehicle in garage.Transports)
                {
                    if (vehicle.Plate == plate)
                        return vehicle;
                }
            }
            return null;
        }
    }
}
