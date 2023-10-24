using System;

namespace Used_car_business
{
    public class Location
    {
        public string name { get; set; }
        public string nit { get; set; }
        public bool canRepair { get; set; }
        private List<Car>? cars { get; set; }

        public Location(string name, string nit, bool canRepair)
        {
            this.name = name;
            this.nit = nit;
            this.canRepair = canRepair;
        }

        public bool RepairCar(Car carToRepair)
        {
            if (cars != null)
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
            }
            Console.WriteLine("No hay automoviles en esta sede.");
            return false;
        }

        public void SetCars(List<Car> cars)
        {
            if (cars == null)
            {
                cars = new() { };
            }
            foreach (Car car in cars)
            {
                cars.Add(car);
            }
        }

        public List<Car> GetCars()
        {
            if (cars == null)
            {
                return new() { };
            }
            return cars;
        }
    }
}
