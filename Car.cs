using System;

namespace Car
{
    class Car
    {
        public string Brand { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public Category CarCategory { get; set; }
        public RepairType RepairType { get; set; }
        public Location CurrentLocation { get; set; }
        public bool IsAvailable { get; set; }

        public Car(string brand, string licensePlate, string model, decimal buyingPrice, decimal sellingPrice, Category category, RepairType repairType, Location location)
        {
            Brand = brand;
            LicensePlate = licensePlate;
            Model = model;
            BuyingPrice = buyingPrice;
            SellingPrice = sellingPrice;
            CarCategory = category;
            RepairType = repairType;
            CurrentLocation = location;
            IsAvailable = true;
        }
    }

    enum Category
    {
        Tourism,
        Industrial,
        OffRoad
    }

    enum RepairType
    {
        Mechanical,
        Electrical,
        SheetMetal
    }
}