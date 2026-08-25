using Assignment_9_C__OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal class DeliveryCenter
    {
        //The Shipment array must be private.
        private Shipment[] shipments;
        private string centerName;
        private Driver driver;


        public DeliveryCenter(string CenterName)
        {
            //The center can store up to 20 shipments.
            shipments = new Shipment[20];
            this.centerName = CenterName;
            driver = null;
        }

        //second ctor with driver
        public DeliveryCenter(string CenterName, Driver driver)
        {
            shipments = new Shipment[20];
            CenterName = centerName;
            this.driver = driver;
        }

        //Driver Property
        public Driver Driver
        {
            get => driver;
            set => driver = value;
        }

        //Add an integer indexer this[int index] to get or set a shipment by position.
        public Shipment this[int index]
        {

            //If the integer index is invalid, the getter returns null.
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                return null;
            }

            //The setter does nothing.
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        //Add a string indexer this[string trackingCode] that returns the first shipment with the matching tracking code.
        public Shipment this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                {
                    return null;
                }

                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                //If no matching shipment is found, the string indexer returns null.
                return null;
            }
        }

        //Add bool AddShipment(Shipment shipment), which adds the shipment to the first empty position and returns true.
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            //Return false when the center is full.
            if (shipment == null)
            {
                return false;
            }

            return false;
        }

        //Searches for a shipment using its tracking code.
        public bool RemoveShipment(string trackingCode)
        {
            //if not valid eeturn false.
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                return false;
            }

            //if valid remove the shipment & return true.
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            //if not found
            return false;
        }

        //Print all stored shipments.
        //PrintAllShipments() loop through the array and simply call shipment.PrintShipment(); — no manual type-checking. That single call resolving to a different method per object is dynamic binding.

        public void PrintAllShipment()
        {
            Console.WriteLine("-------------------Delivery Center Shipments-------------------");
            Console.WriteLine("");

            int count = 0;
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    Console.WriteLine($"--- Shipment {i + 1} ---");
                    shipments[i].PrintShipment(); // Uses Shipment's PrintShipment method
                    Console.WriteLine();
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No shipments in the delivery center.");
            }
            else
            {
                Console.WriteLine($"Total shipments: {count} of {shipments.Length}");
            }
        }

        //Prints tracking status for all shipments using ITrackable interface.
        public void PrintTrackingStatuses()
        {
            Console.WriteLine($"--------{centerName} - Tracking Status ---------");
            Console.WriteLine();

            int count = 0;

            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    // Cast to ITrackable interface
                    ITrackable trackable = shipment;
                    Console.WriteLine($"{trackable.GetTrackingStatus()}");
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Shipment are Empty............");
            }
            else
            {
                Console.WriteLine($"Total: {count} shipment(s) are tracked");
            }

            Console.WriteLine();
        }

        // Prints insurance costs for all shipments using IInsurable interface.
        public void PrintInsurances()
        {
            Console.WriteLine($"------------- {centerName} -Insurance Cost----------");
            Console.WriteLine();

            int count = 0;
            decimal totalInsurance = 0;

            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    // Cast to IInsurable interface
                    IInsurable insurable = shipment;
                    decimal insurance = insurable.CalculateInsurance();
                    Console.WriteLine($"   {shipment.TrackingCode}: {insurance} EGP");
                    totalInsurance += insurance;
                    count++;
                }

                if (count == 0)
                {
                    Console.WriteLine("Shipments are Empty");
                }
                else
                {
                    Console.WriteLine($" Total Insurance: {totalInsurance} EGP for {count} shipment(s)");
                }

                Console.WriteLine();
            }

        }

        // Prints both tracking statuses and insurance costs using both interfaces.
        public int Count
        {
            get
            {
                int count = 0;
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }



    }
}
