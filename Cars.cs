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
        public List<string>? repairments { get; set; }

        private int sellingPrice { get; set; }

        public Car(string brand, string model, Location office, bool isNew, int providerPrice, List<string>? repairments)
        {
            this.brand = brand;
            this.model = model;
            this.office = office;
            this.isNew = isNew;
            this.providerPrice = providerPrice;
            this.repairments = repairments;
        }

        public int GetSellingPrice()
        {
            return sellingPrice;
        }

        public void SetSellingPrice(float proffitPercentage)
        {
            // This method should receive percentages in the form of integers,
            // such as "20" for 20%, instead of "0.2" for 20%
            if (proffitPercentage >= 1)
            {
                sellingPrice = (int)(providerPrice + (providerPrice * (1 / proffitPercentage)));
                return;
            }
            Console.WriteLine("Please enter a valid percentage as a integer. (I.E: '20' for 20%)");
        }

    }


    public class TourismCar : Car
    {
        public int passengerCapacity;
        public TourismCar(string brand, string model, Location office, bool isNew, int providerPrice, int passengerCapacity, List<string> repairments) : base(brand, model, office, isNew, providerPrice, repairments)
        {
            this.passengerCapacity = passengerCapacity;
        }
    }

    public class IndustrialCar : Car
    {
        public int maxium_carry_weight;
        public IndustrialCar(string brand, string model, Location office, bool isNew, int providerPrice, int maxium_carry_weight, List<string> repairments) : base(brand, model, office, isNew, providerPrice, repairments)
        {
            this.maxium_carry_weight = maxium_carry_weight;
        }
    }

    public class OffRoadCar : Car
    {
        public int horsePower;
        public OffRoadCar(string brand, string model, Location office, bool isNew, int providerPrice, int horsePower, List<string> repairments) : base(brand, model, office, isNew, providerPrice, repairments)
        {
            this.horsePower = horsePower;
        }
    }
}

