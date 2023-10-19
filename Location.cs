using System;

namespace Location
{

    class Location
    {
        public string LocationName { get; set; }
        public string Address { get; set; }

        public Location(string locationName, string address)
        {
            LocationName = locationName;
            Address = address;
        }
    }
}