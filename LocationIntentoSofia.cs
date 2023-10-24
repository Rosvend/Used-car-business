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
            if (canRepair)
            {
                if (cars.Contains(carToRepair) && (carToRepair.repairments == null || carToRepair.repairments.Count == 0))
                {
                    Console.WriteLine("No hay reparaciones para este carro.");
                    return false;
                }

                foreach (string repairment in carToRepair.repairments)
                {
                    Console.WriteLine($"{repairment}, reparado");
                }

                return true;
            }
            return false;
        }
    }
}

