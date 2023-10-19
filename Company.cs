using System;

namespace Company
{

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
}