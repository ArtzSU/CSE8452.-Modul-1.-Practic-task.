using System;

namespace Transport
{
    public class Car : Vehicle
    {
        protected int countOfDoors;
        protected string transmissionType;

        public Car(
            string mark,
            string model,
            string date,
            int countOfDoors,
            string transmissionType,
            string plate
        ) : base(mark, model, date, plate)
        {
            this.countOfDoors = countOfDoors;
            this.transmissionType = transmissionType;
        }
    }
}