using System;
using Used_car_business;

namespace Used_car_business
{
    public class Person
    {
        public string name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string id { get; set; }

        public Person(string name, string email, string id, int phone)
        {
            this.name = name;
            this.email = email;
            this.id = id;
            this.phone = phone;
        }
    }

    public class Seller : Person
    {
        public string location { get; set; }

        public Seller(string name, string email, string id, int phone, string location) : base(name, email, id, phone)
        {
            this.location = location;
        }
    }

    public class CommissionSeller : Seller
    {
        public int cars_sold { get; set; }

        public CommissionSeller(string name, string email, string id, int phone, string location, int cars_sold) : base(name, email, id, phone, location)
        {
            this.cars_sold = cars_sold;
        }

        public int calculate_salary()
        {
            return cars_sold * 5000;
        }
    }

    public class WageSeller : Seller
    {
        public int hours_worked { get; set; }
        public int hourly_wage { get; set; }

        public WageSeller(string name, string email, string id, int phone, string location, int hours_worked, int hourly_wage) : base(name, email, id, phone, location)
        {
            this.hours_worked = hours_worked;
            this.hourly_wage = hourly_wage;
        }

        public int calculate_salary()
        {
            return hours_worked * hourly_wage;
        }
    }

    public class Buyer : Person
    {
        public int cars_bought { get; set; }

        public Buyer(string name, string email, string id, int phone, int cars_bought) : base(name, email, id, phone)
        {
            this.cars_bought = cars_bought;
        }

        public string buy_car()
        {
            return "You have bought " + cars_bought + " cars.";
        }

    }

    public class PotentialBuyer : Person
    {
        public string InterestedCars { get; set; }
        public string PreOrders { get; set; }

        public PotentialBuyer(string name, string email, string id, int phone, string interestedCars, string preOrders) : base(name, email, id, phone)
        {
            this.InterestedCars = interestedCars;
            this.PreOrders = preOrders;
        }

        public string preorder_car()
        {
            return "You have preordered " + PreOrders + " cars.";
        }
    }
}
