using System;
using System.Collections.Generic;

class Car
{
    public string Brand { get; set; }
    public string LicensePlate { get; set; }
    public string Model { get; set; }
    public decimal BuyingPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public Category CarCategory { get; set; }
    public RepairType RepairType { get; set; }
    public Location CurrentLocation { get; set; }
    public bool IsAvailable { get; set; }

    public Car(string brand, string licensePlate, string model, decimal buyingPrice, decimal sellingPrice, Category category, RepairType repairType, Location location)
    {
        Brand = brand;
        LicensePlate = licensePlate;
        Model = model;
        BuyingPrice = buyingPrice;
        SellingPrice = sellingPrice;
        CarCategory = category;
        RepairType = repairType;
        CurrentLocation = location;
        IsAvailable = true;
    }
}

enum Category
{
    Tourism,
    Industrial,
    OffRoad
}

enum RepairType
{
    Mechanical,
    Electrical,
    SheetMetal
}

class Location
{
    public string LocationName { get; set; }
    public string Address { get; set; }

    public Location(string locationName, string address)
    {
        LocationName = locationName;
        Address = address;
    }
}

class Employee
{
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public decimal Commission { get; set; }
    public decimal BaseSalary { get; set; }

    public Employee(string name, EmployeeType employeeType, decimal commission = 0, decimal baseSalary = 0)
    {
        Name = name;
        EmployeeType = employeeType;
        Commission = commission;
        BaseSalary = baseSalary;
    }
}

enum EmployeeType
{
    Commission,
    BaseSalary
}

class CommissionEmployee : Employee
{
    public CommissionEmployee(string name, decimal commission) : base(name, EmployeeType.Commission, commission)
    {
    }
}

class BaseSalaryEmployee : Employee
{
    public BaseSalaryEmployee(string name, decimal baseSalary) : base(name, EmployeeType.BaseSalary, baseSalary)
    {
    }
}

class Customer
{
    public string Name { get; set; }
    public List<Car> OwnedCars { get; set; }
    public List<Car> InterestedCars { get; set; }
    public List<Car> PreOrders { get; set; }

    public Customer(string name)
    {
        Name = name;
        OwnedCars = new List<Car>();
        InterestedCars = new List<Car>();
        PreOrders = new List<Car>();
    }
}

class RecurrentCustomer : Customer
{
    public RecurrentCustomer(string name) : base(name)
    {
    }
}

class PotentialCustomer : Customer
{
    public PotentialCustomer(string name) : base(name)
    {
    }
}

class Company
{
    public List<Employee> Employees { get; set; }
    public List<Car> AvailableCars { get; set; }
    public List<Location> Locations { get; set; }

    public Company()
    {
        Employees = new List<Employee>();
        AvailableCars = new List<Car>();
        Locations = new List<Location>();
    }

    public void BuyCar(Car car, decimal buyingPrice)
    {
        car.IsAvailable = true;
        car.BuyingPrice = buyingPrice;
        AvailableCars.Add(car);
    }

    public void SellCar(Car car, Customer customer)
    {
        if (AvailableCars.Contains(car))
        {
            AvailableCars.Remove(car);
            car.IsAvailable = false;
            customer.OwnedCars.Add(car);
        }
    }

    public void RepairCar(Car car, RepairType repairType)
    {
        car.RepairType = repairType;
    }

    public void AssignLocation(Car car, Location location)
    {
        car.CurrentLocation = location;
    }

    public void HireEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public List<Car> ListCarsByCategory(Category category)
    {
        return AvailableCars.FindAll(car => car.CarCategory == category);
    }

    public List<Car> ListCarsByLocation(Location location)
    {
        return AvailableCars.FindAll(car => car.CurrentLocation == location);
    }

    public decimal CalculateEmployeeSalary(Employee employee)
    {
        if (employee.EmployeeType == EmployeeType.Commission)
        {
            int soldCars = AvailableCars.Count(car => !car.IsAvailable);
            return employee.BaseSalary + (employee.Commission * soldCars);
        }
        return employee.BaseSalary;
    }
}

class Program
{
    static void Main()
    {
        Company myCompany = new Company();

        // Create instances of cars, employees, customers, and locations.
        // Populate and manage your company's data and operations.
    }
}
