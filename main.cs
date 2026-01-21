using System;
using Transport;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём транспорт с номерами
            var car = new Car("Toyota", "Corolla", "2020", 4, "Automatic", "ABC123");

            var moto = new Motocycle("Yamaha", "MT-07", "2021", "Sport", true, "XYZ789");

            // Создаём гараж (Fleet)
            var fleet = new Fleet();
            fleet.AddTransport(car, true);
            fleet.AddTransport(moto, true);

            // Демонстрация работы двигателя
            car.StartEngine(true);
            moto.StartEngine(true);

            car.StopEngine(true);
            moto.StopEngine(true);


            // Поиск транспорта по номеру
            string searchPlate = "XYZ789";
            var foundVehicle = fleet.SearchVehicle(searchPlate);
            if (foundVehicle != null)
            {
                System.Console.WriteLine($"Transport with plate {searchPlate} found.");
            }
        }
    }
}
