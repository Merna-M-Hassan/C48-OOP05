using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal struct DeliveryAddress
    {
        //part 2) 
        //Create a DeliveryAddress struct

        private string city;
        private string street;
        private int buildingNumber;

        public string City
        {
            get => city;
            set { city = value; }
        }

        public string Street
        {
            get => street;
            set { street = value; }
        }

        public int BuildingNumber
        {
            get => buildingNumber;
            set { buildingNumber = value; }
        }

        public DeliveryAddress(string city, string street, int buildingNo)
        {
            this.city = city;
            this.street = street;
            buildingNumber = buildingNo;
        }

        public string GetFullAddress()
        {
            return $"{city},{street},{buildingNumber}";
        }
    }
}
