using System;
namespace Used_car_business
{
    public class Car
    {
        public bool isNew { get; set; }
        public int providerPrice { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public Location office { get; set; }
        public int sellingPrice { get; set; }
        public List<string> repairments { get; set; }


        public Car(string brand, string model, Location office, bool isNew, int providerPrice, int sellingPrice, List<string> repairments)
        {
            this.brand = brand;
            this.model = model;
            this.office = office;
            this.isNew = isNew;
            this.providerPrice = providerPrice;
            this.sellingPrice = sellingPrice;
            this.repairments = repairments;
        }

    }


    public class TourismCar : Car
    {
        public int passengerCapacity;
        public TourismCar(string brand, string model, Location office, bool isNew, int providerPrice, int sellingPrice, int passengerCapacity) : base(brand, model, office, isNew, providerPrice, sellingPrice)
        {
            this.passengerCapacity = passengerCapacity;
        }
    }

    public class IndustrialCar : Car
    {
        public int maxium_carry_weight;
        public IndustrialCar(string brand, string model, Location office, bool isNew, int providerPrice, int sellingPrice, int maxium_carry_weight) : base(brand, model, office, isNew, providerPrice, sellingPrice)
        {
            this.maxium_carry_weight = maxium_carry_weight;
        }
    }

    public class OffRoadCar : Car
    {
        public int horsePower;
        public OffRoadCar(string brand, string model, Location office, bool isNew, int providerPrice, int sellingPrice, int horsePower) : base(brand, model, office, isNew, providerPrice, sellingPrice)
        {
            this.horsePower = horsePower;
        }
    }
}

