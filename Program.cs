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
            WageSeller wageSeller = new("Daniel Werner", "wernerdaniel@gmail.com", "987654321", 315864101, "New York", hoursWorked, hourlyWage);

            // Calculate and display the salary
            int salary = wageSeller.CalculateSalary();
            Console.WriteLine("The employee's salary is: " + salary);


            List<Car> cars = new List<Car>() { };

            Location medallork = new Location("Medallork",123,false,cars);
            Location udea = new Location("UdeA", 4321, true,cars);
            Location santaElena = new Location("Santa Elena", 9876, true,cars);


            cars.Add(new TourismCar("chevrolet", "tour","medallork", false, 10000,200000,5));
            cars.Add(new IndustrialCar("Tesla", "indust","udea", false,500000,1000000,1000));
            cars.Add(new OffRoadCar("toyota", "corolla","santaElena", false, 10000,200000,5));

            Location mainOffice = new Location("San Felix", 32009, true, cars);
        }
    }
}
