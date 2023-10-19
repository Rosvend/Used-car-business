using System;
namespace Used_car_business

{
	public class Location
	{
		public string name { get; set; }
		public int nit { get; set; }
		public bool canRepair { get; set; }
		private List<Car> cars { get; set; }

        public Location(string name, int nit, bool canRepair, List<Car> cars)
		{
			this.name = name;
			this.nit = nit;
			this.canRepair = canRepair;
			this.cars = cars;

        }
	}
}

