// Purpose: Contains the Person, Seller, CommissionSeller, WageSeller, RecurrentCustomer, and PotentialCustomer classes.
using Used_car_business;

namespace Used_Car_Business
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public uint Phone { get; set; }
        public string Id { get; set; }

        public Person(string name, string email, string id, uint phone)
        {
            Name = name;
            Email = email;
            Id = id;
            Phone = phone;
        }
    }

    public class Seller : Person
    {
        public Location Location { get; set; }

        public Seller(string name, string email, string id, uint phone, Location location) : base(name, email, id, phone)
        {
            Location = location;
        }
    }

    public class CommissionSeller : Seller
    {
        public int CarsSold { get; set; }

        public CommissionSeller(string name, string email, string id, uint phone, Location location, int carsSold) : base(name, email, id, phone, location)
        {
            CarsSold = carsSold;
        }

        public int CalculateSalary()
        {
            return CarsSold * 10000;
        }
    }

    public class WageSeller : Seller
    {
        public int HoursWorked { get; set; }
        public int HourlyWage { get; set; }

        public WageSeller(string name, string email, string id, uint phone, Location location, int hoursWorked, int hourlyWage) : base(name, email, id, phone, location)
        {
            HoursWorked = hoursWorked;
            HourlyWage = hourlyWage;
        }

        public int CalculateSalary()
        {
            return HoursWorked * HourlyWage;
        }
    }

    public class RecurrentCustomer : Person
    {
        public int CarsBought { get; set; }

        public RecurrentCustomer(string name, string email, string id, uint phone, int carsBought) : base(name, email, id, phone)
        {
            CarsBought = carsBought;
        }

        public string BuyCar()
        {
            return "You have bought " + CarsBought + " cars.";
        }
    }

    public class PotentialCustomer : Person
    {
        public List<Car> InterestedCars { get; set; }
        public List<Car> PreOrders { get; set; }

        public PotentialCustomer(string name, string email, string id, uint phone, List<Car> interestedCars, List<Car> preOrders) : base(name, email, id, phone)
        {
            InterestedCars = interestedCars;
            PreOrders = preOrders;
        }

        public string PreorderCar()
        {
            return "You have preordered " + PreOrders + " cars.";
        }
    }
}
