using System;

namespace Used_car_business;


class Program
{
    static void Main(String[] args)
    {

        List<Car> cars = new List<Car>() { };

        cars.Add(new TourismCar("chevrolet", "tour"));
        cars.Add(new IndustrialCar("foton", "indust"));
        cars.Add(new OffRoadCar("toyota", "corolla"));

        Location mainOffice = new Location("San Felix", 32009, true, cars);
    }
}
