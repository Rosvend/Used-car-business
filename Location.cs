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

        public bool RepairCar(Car carToRepair)
        {
            if (cars.Contains(carToRepair))
            {
                if (canRepair)
                {
                    foreach (string repairment in carToRepair.repairments)
                    {
                        Console.WriteLine($"{repairment}, reparado");
                        carToRepair.repairments.Remove(repairment);
                    }
                    return true;
                }
                Console.WriteLine("Esta sede no esta habilitada para realizar reparaciones.");
                return false;
            }
            Console.WriteLine("Este auto no se encuentra en esta sede.");
            return false;
        }

        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
