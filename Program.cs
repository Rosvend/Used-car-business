using System;
using System.Runtime.InteropServices;
using Used_Car_Business;

namespace Used_car_business
{
    class Program
    {
        static void Main()
        {

        }

        static dynamic[] SetupDemo()
        {
            // This method sets up an enviroment for the demo
            // returns an array with the setup data in the next order:
            //      First position:  A list of locations
            //      Second position: A list of cars
            //      Third position: A list of sellers
            //      Fourth position: A list of customers

            Location sanFelix = new("San Felix", "00001", true);
            Location junin = new("Junin", "00002", false);
            Location principal = new("La Principal", "00003", true);

            Location[] locations = { sanFelix, junin, principal };

            TourismCar tourismCar1 = new("Chevrolet", "Tour", sanFelix, true, 5000000, 10, new());
            TourismCar tourismCar2 = new("Nissan", "Tour", junin, false, 4000000, 8, new() { "Motor", "Luces delanteras", "Caja de cambios" });
            TourismCar tourismCar3 = new("Chevrolet", "Tour", sanFelix, false, 7000000, 12, new());

            OffRoadCar offRoadCar1 = new("Toyota", "Corolla", junin, true, 6900000, 150, new());
            OffRoadCar offRoadCar2 = new("Masda", "434", principal, false, 850000, 80, new() { "Retrovisores", "" });
            OffRoadCar offRoadCar3 = new("Nissan", "Cruiser", principal, true, 8000000, 200, new());

            IndustrialCar industrialCar1 = new("Aveus", "Oviparus", sanFelix, false, 15000000, 80, new() { "Motor", "" });
            IndustrialCar industrialCar2 = new("GenericCompanyName", "Ferrus", junin, false, 15000000, 50, new() { });
            IndustrialCar industrialCar3 = new("Foton", "Tonton", principal, true, 15000000, 40, new() { });

            Car[] cars = { tourismCar1, tourismCar2, tourismCar3, offRoadCar1, offRoadCar2, offRoadCar3, industrialCar1, industrialCar2, industrialCar3 };

            WageSeller wageSeller1 = new("Pedro Perez Piedrahita", "pedro.perez@company.com", "100001", 3130000001, sanFelix, 8, 25000);
            WageSeller wageSeller2 = new("Daniel Werner", "daniel.werner@company.com", "esclavo1", 3130000002, principal, 16, 5000);

            CommissionSeller commissionSeller1 = new("Jose Alejandro Reyes Ospino", "jose.reyeso@company.com", "20001", 3130000003, principal, 50);
            CommissionSeller commissionSeller2 = new("Fulano de Jesus Detal", "fulano.detal@company.com", "200002", 3130000004, junin, 3);

            Seller[] sellers = { wageSeller1, wageSeller2, commissionSeller1, commissionSeller2 };

            PotentialCustomer potentialBuyer1 = new("", "", "300001", 3200000001, new() { tourismCar1, offRoadCar2 }, new() { offRoadCar2 });
            PotentialCustomer potentialBuyer2 = new("", "", "", 3200000002, new() { tourismCar3, industrialCar1 }, new() { industrialCar2 });

            dynamic[] demoData = { locations, cars, sellers };

            return demoData;

        }
    }
}
