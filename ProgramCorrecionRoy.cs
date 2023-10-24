using System;
using System.Collections.Generic;
namespace Used_car_business
{
    class Program
    {
        static void Main()
        {
            // Collect user input for WageSeller
            Console.WriteLine("Enter the employee's hours worked: ");
            int hoursWorked = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the employee's hourly wage: ");
            int hourlyWage = int.Parse(Console.ReadLine()!);

            // Create a WageSeller object with user-provided input
            Used_Car_Business.WageSeller wageSeller = new("Daniel Werner", "wernerdaniel@gmail.com", "987654321", 315864101, "New York", hoursWorked, hourlyWage);

            // Calculate and display the salary
            int salary = wageSeller.CalculateSalary();
            Console.WriteLine("The employee's salary is: " + salary);

            List<Car> cars = new List<Car>();

            Location Medallork = new Location("Medallork", 123, false, new List<Car>());
            Location Udea = new Location("UdeA", 4321, true, new List<Car>());
            Location UPB = new Location("UPB", 9876, true, new List<Car>());

            cars.Add(new TourismCar("Chevrolet", "Tourism", Medallork, false, 10000, 200000, 5));
            cars.Add(new IndustrialCar("Tesla", "Industrial", Udea, false, 500000, 1000000, 1000));
            cars.Add(new OffRoadCar("Toyota", "Off-Road", UPB, false, 10000, 200000, 5));
            cars.Add(new OffRoadCar("Toyota", "Off-Road",UPB, false, 10000,200000,5));

        }
    }
}
