using System;


namespace Transport
{
    public class Motocycle : Vehicle
    {
        protected string BodyType;
        protected bool hasBox;

        public Motocycle(
            string mark,
            string model,
            string date,
            string BodyType,
            bool hasBox,
            string plate
        ) : base(mark, model, date, plate)
        {
            this.BodyType = BodyType;
            this.hasBox = hasBox;
        }
    }
}