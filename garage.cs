using System;
using System.Collections.Generic;

namespace Transport
{
    public class Garage
    {
        private List<Vehicle> transports = new List<Vehicle>();
        public List<Vehicle> Transports => transports;

        public void AddTransport(Vehicle transport, bool debug = false)
        {
            transports.Add(transport);
            if (debug)
            {
                Console.WriteLine("Transport added");
            }
        }

        public void RemoveTransport(Vehicle transport, bool debug = false)
        {
            transports.Remove(transport);
            if (debug)
            {
                Console.WriteLine("Transport removed");
            }
        }
    }
}
