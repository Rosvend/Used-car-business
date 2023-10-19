using System;

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
        public Seller()
        {
        }
    }

    public class CommissionSeller : Seller
    {
        public CommissionSeller()
        {
        }
    }

    public class WageSeller : Seller
    {
        public WageSeller()
        {
        }
    }

    public class Buyer : Person
    {
        public Buyer()
        {
        }
    }

    public class PotentialBuyer : Person
    {
        public PotentialBuyer()
        {
        }
    }
}

