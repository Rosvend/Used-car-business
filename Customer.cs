using System;

namespace Customer
{
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
}