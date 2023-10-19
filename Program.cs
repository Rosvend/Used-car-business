using System;

namespace Used_car_business;


class Program
{
    static void Main(String[] args)
    {
        //List<Car> lista_de_carros = new List<Car>();
        //Car carro1 = new Car("Toyota", "AVX124", "Hilux", 1000000, 2000000, Category.OffRoad, RepairType.Mechanical, Location.Bogota);
        //lista_de_carros.Add(carro1);
        //Console.WriteLine(carro1.Model);

        //Car carro2 = new Car("Kia", "MIP201", "Picao", 400000, 600000, Category.Tourism, RepairType.Electrical, Location.Medellin);
        //lista_de_carros.Add(carro2);

        //Car carro3 = new Car("Chevrolet", "PQE387", "Twingo", 100, 500, Category.Industrial, RepairType.SheetMetal, Location.Cali);
        //lista_de_carros.Add(carro3);

        //foreach (Car car in lista_de_carros)
        //{
        //    Console.WriteLine($"Car Model: {car.Model}");
        //}


        List<Car> cars = new List<Car>() { };

        cars.Add(new TourismCar("chevrolet", "tour"));
        cars.Add(new IndustrialCar("foton", "indust"));
        cars.Add(new OffRoadCar("toyota", "corolla"));

        Location mainOffice = new Location("San Felix", 32009, true, cars);
    }
}
