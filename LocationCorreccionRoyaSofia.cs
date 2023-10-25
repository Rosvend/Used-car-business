using System;
using System.Collections.Generic;

namespace Used_Car_Business
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

        public bool SellCar(Car carToSell)
        {
            if (Cars.Contains(carToSell))
            {
                Cars.Remove(carToSell);
                Console.WriteLine("Car sold successfully.");
                return true;
            }
            return false;
        }

        public bool BuyCar(Car carToBuy)
        {
            if (!Cars.Contains(carToBuy))
            {
                Cars.Add(carToBuy);
                Console.WriteLine("Car bought successfully.");
                return true;
            }
            return false;
        }

        public bool check_stock(List<Car> cars)
        {
            if (cars.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
