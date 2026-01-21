using System;
using Transport;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём транспорт с номерами
            var car0 = new Car("Huandai", "Corolla", "2020", 4, "Automatic", "ABC123");
            var car1 = new Car("Toyota", "Corolla", "2010", 4, "Robotic", "XYZ098");
            var car2 = new Car("Xiaomi", "Corolla", "2024", 4, "Automatic", "BOP777");

            var moto0 = new Motocycle("Ferrari", "MT-07", "2021", "Sport", true, "BDS709");
            var moto1 = new Motocycle("", "MT-07", "2021", "Sport", true, "XXX000");
            var moto2 = new Motocycle("Yamaha", "MT-07", "2021", "Sport", true, "XYZ789");

            // Демонстрация работы двигателя
            car0.StartEngine(true);
            moto0.StartEngine(true);

            car0.StopEngine(true);
            moto0.StopEngine(true);



            // Создаем Гаражи (Garage)
            var garage1 = new Garage();
            garage1.AddTransport(car0);
            garage1.AddTransport(car1);
            garage1.AddTransport(car2);

            var garage2 = new Garage();
            garage1.AddTransport(moto0);
            garage1.AddTransport(moto1);
            garage1.AddTransport(moto2);



            // Создаём Автопарк (Fleet)
            var fleet = new Fleet();
            fleet.AddGarage(garage1);
            fleet.AddGarage(garage2);


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
