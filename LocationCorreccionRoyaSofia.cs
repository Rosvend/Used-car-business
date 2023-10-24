using System;
using System.Collections.Generic;

namespace Used_car_business
{
    public class Location
    {
        public string Name { get; set; }
        public int Nit { get; set; }
        public bool CanRepair { get; set; }
        private List<Car> Cars { get; set; }

        public Location(string name, int nit, bool canRepair, List<Car> cars)
        {
            Name = name;
            Nit = nit;
            CanRepair = canRepair;
            Cars = cars;
        }

        public bool RepairCar(Car carToRepair)
        {
            if (CanRepair)
            {
                if (Cars.Contains(carToRepair))
                {
                    
                    Console.WriteLine("Car repaired successfully.");
                    return true;
                }
            }
            return false;
        }
    }
}
