using System;
using System.Collections.Generic;

namespace Used_Car_Business
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the employee's hours worked: ");
            if (!int.TryParse(Console.ReadLine(), out int hoursWorked))
            {
                Console.WriteLine("Invalid input for hours worked. Please enter a valid number.");
                return;
            }

            Console.WriteLine("Enter the employee's hourly wage: ");
            if (!int.TryParse(Console.ReadLine(), out int hourlyWage))
            {
                Console.WriteLine("Invalid input for hourly wage. Please enter a valid number.");
                return;
            }

            WageSeller wageSeller = new WageSeller("Daniel Werner", "wernerdaniel@gmail.com", "987654321", 315864101, "New York", hoursWorked, hourlyWage);

            Console.WriteLine($"Employee {wageSeller.Name} worked {hoursWorked} hours at an hourly wage of ${hourlyWage}.");
            int salary = wageSeller.CalculateSalary();
            Console.WriteLine($"The employee's salary is: ${salary}");

            List<Car> cars = new List<Car>();

            Location Medallork = new Location("Medallork", 123, false, new List<Car>());
            Location Udea = new Location("UdeA", 4321, true, new List<Car>());
            Location UPB = new Location("UPB", 9876, true, new List<Car>());

            List<string> carRepairments = new List<string> { "Mechanical", "Electrical", "Carriage plate" };

            Car car1 = new TourismCar("Chevrolet", "Tourism", Medallork, false, 10000, 200000, carRepairments, 7);
            Car car2 = new IndustrialCar("Tesla", "Industrial", Udea, false, 500000, 1000000, carRepairments, 1000);
            Car car3 = new OffRoadCar("Toyota", "Off-Road", UPB, false, 10000, 200000, carRepairments, 5);

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            Medallork.BuyCar(car1);
            Udea.SellCar(car2);     
            UPB.RepairCar(car3);    
        }
    }
}
