using System;

namespace Transport
{
    public class Vehicle
    {
        protected string mark;
        protected string model;
        protected string date;
        protected bool engineIsWork = false;

        public string plate;

        public Vehicle(string mark, string model, string date, string plate)
        {
            this.mark = mark;
            this.model = model;
            this.date = date;
            this.plate = plate;
        }

        public string Plate { get { return plate; } }

        public bool StartEngine(bool debug = false)
        {
            this.engineIsWork = true;
            if (debug)
            {
                Console.WriteLine("Engine started");
            }
            return this.engineIsWork;
        }

        public bool StopEngine(bool debug = false)
        {
            this.engineIsWork = false;
            if (debug)
            {
                Console.WriteLine("Engine stopped");
            }
            return this.engineIsWork;
        }
    }
}