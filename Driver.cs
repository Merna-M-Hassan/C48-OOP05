using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal class Driver
    {
        private int driverID;
        private string fullName;
        private string phoneNumber;

        //Driver Class Constructor
        public Driver(int DriverID, string FullName, string PhoneNumber)
        {
            DriverID = driverID;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        //Driver Properties
        public int DriverId
        {
            get => driverID;
            set => driverID = value > 0 ? value : 0;
        }

        public string FullName
        {
            get => fullName;
            set => fullName = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";
        }
    }
}
