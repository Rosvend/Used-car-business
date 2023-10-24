// Purpose: Contains the Person, Seller, CommissionSeller, WageSeller, RecurrentCustomer, and PotentialBuyer classes.
namespace Used_Car_Business
{
    public class Person
    {
        public string Name { get; }
        public string Email { get; }
        public int Phone { get; }
        public string Id { get; }

        public Person(string name, string email, string id, int phone)
        {
            Name = name;
            Email = email;
            Id = id;
            Phone = phone;
        }
    }

    public class Seller : Person
    {
        public string Location { get; }

        public Seller(string name, string email, string id, int phone, string location) : base(name, email, id, phone)
        {
            Location = location;
        }
    }

    public class CommissionSeller : Seller
    {
        public int CarsSold { get; }

        public CommissionSeller(string name, string email, string id, int phone, string location, int carsSold) : base(name, email, id, phone, location)
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
        public int HoursWorked { get; }
        public int HourlyWage { get; }

        public WageSeller(string name, string email, string id, int phone, string location, int hoursWorked, int hourlyWage) : base(name, email, id, phone, location)
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
        public int CarsBought { get; }

        public RecurrentCustomer(string name, string email, string id, int phone, int carsBought) : base(name, email, id, phone)
        {
            CarsBought = carsBought;
        }

        public string BuyCar()
        {
            return "You have bought " + CarsBought + " cars.";
        }
    }

    public class PotentialBuyer : Person
    {
        public string InterestedCars { get; }
        public string PreOrders { get; }

        public PotentialBuyer(string name, string email, string id, int phone, string interestedCars, string preOrders) : base(name, email, id, phone)
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
