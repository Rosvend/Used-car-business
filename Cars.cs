using System;
namespace Used_car_business
{
	public class Car
	{
		public bool isNew { get; set; }
        public int providerPrice { get; set; }
        public string? brand { get; set; }
        public string? model { get; set; }
        public Location office { get; set; }

        private int sellingPrice { get; set; }

        public Car (string brand, string model, Location office, bool isNew)
		{
			this.brand = brand;
			this.model = model;
            this.office = office;
            this.isNew = isNew;
		}

	}


	public class TourismCar : Car
	{
		public int passengerCapacity;
		public TourismCar(string brand, string model) : base(brand, model, office)
		{

		}
	}

    public class IndustrialCar : Car
    {
		public float maxTons; 
        public IndustrialCar(string brand, string model) : base(brand, model)
        {

        }

    }

    public class OffRoadCar : Car
    {
		public int horsePower;
        public OffRoadCar(string brand, string model) : base(brand, model)
        {

        }

    }
}

