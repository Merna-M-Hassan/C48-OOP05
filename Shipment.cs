using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml;

namespace Assignment_9_C__OOP
{
    internal abstract class Shipment : ITrackable, IInsurable
    {
        // Part 2) 1) Change the Shipment class into an abstract class. It should still contain, with all validation rules kept

        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;
        private string trackingStatus;


        //Static Fields
        //Add a static field to Shipment: TotalShipmentsCreated.
        private static int totalShipmentsCreated = 0;

        //Initialize the shipment counter
        private static DateTime initializationTime;


        //Static Properties
        // It should keep track of the total number of Shipment objects created.
        public static int TotalShipmentsCreated => totalShipmentsCreated;

        public static DateTime InitializationTime => initializationTime;

        //Constructors

        // Static constructor initializes static members.
        //It runs automatically once before any static member is accessed or any instance is created.
        static Shipment()
        {
            totalShipmentsCreated = 0;
            initializationTime = DateTime.Now;

            Console.WriteLine("-----Shipment Initialized-----");
            Console.WriteLine($"Initialization Time: {initializationTime:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Total Shipments Created: {totalShipmentsCreated}");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();
        }



        //The first constructor.
        public Shipment(string TrackCode)
        {
            //receives only trackingCode
            trackingCode = !string.IsNullOrWhiteSpace(TrackCode) ? TrackCode : "Unknown";

            //constructor uses default values: Description = "Unknown", Weight = 1, DeliveryFee = 50, and a default destination.
            description = !string.IsNullOrWhiteSpace(Description) ? Description : "Unknown";
            weight = 1;
            deliveryFee = 50;
            destination = new DeliveryAddress("Not specifies yet", "Not specifies yet", 0);
            trackingStatus = "Ready";

            // Every time a shipment is created, increment the counter. 
            totalShipmentsCreated++;
        }

        //The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
        public Shipment(string TrackCode, string Description, decimal Weight, decimal DeliverFee, DeliveryAddress Destination)
        {
            //TrackingCode cannot be null, empty, or whitespace.
            trackingCode = !string.IsNullOrWhiteSpace(TrackCode) ? TrackCode : "Unknown";

            //Description cannot be null, empty, or whitespace.
            description = !string.IsNullOrWhiteSpace(Description) ? Description : "Unknown";

            //Weight must be greater than 0.
            weight = Weight > 0 ? Weight : 1;

            //DeliveryFee must be greater than 0.
            deliveryFee = DeliverFee > 0 ? DeliverFee : 2;

            destination = Destination;

            trackingStatus = "Ready";

            // Every time a shipment is created, increment the counter. 
            totalShipmentsCreated++;
        }

        //TrackingCode cannot be null, empty, or whitespace.
        //public string TrackingCode
        //{
        //    get => trackingCode;
        //    set => trackingCode = !string.IsNullOrWhiteSpace(value) ? value: trackingCode;
        //}

        //TrackingCode: read-only from outside the class. 
        public string TrackingCode
        {
            get => trackingCode;
        }

        //Description: read/write property with validation. & //Description cannot be null, empty, or whitespace.
        public string Description
        {
            get => description;
            set => description = !string.IsNullOrWhiteSpace(value) ? value : description;
        }

        //Weight: read/write property with validation. & //Weight must be greater than 0.
        public decimal Weight
        {
            get => weight;
            set => weight = value > 0 ? value : weight;
        }

        //DeliveryFee: public getter and private setter. & //DeliveryFee must be greater than 0.
        public decimal DeliveryFee
        {
            get => deliveryFee;
            private set => deliveryFee = value > 0 ? value : deliveryFee;
        }

        //Destination: public read/write property.
        public DeliveryAddress Destination
        {
            get => destination;
            set => destination = value;
        }

        //EstimatedCost: calculated property that returns DeliveryFee + (Weight* 5).
        //Abstract Property: Estimated Cost. Each shipment type calculates its own estimated cost.
        public abstract decimal EstimatedCost
        {
            get;
        }

        //IInsurable =>  decimal CalculateInsurance();
        public virtual decimal CalculateInsurance()
        {
            return EstimatedCost;
        }

        // trackingStatus property 
        public string TrackingStatus
        {
            get => trackingStatus;
            set => trackingStatus = value;
        }

        //Gets the current tracking status of the shipment.
        public virtual string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is {TrackingStatus}";
        }

        // Updates the tracking status.
        public void UpdateTrackingStatus(string status)
        {
            TrackingStatus = status;
        }


        //UpdateDeliveryFee(decimal newFee): updates the fee only when newFee is greater than 0.
        public void UpdateDeliveryFee(decimal newFee)
        {
            //if (newFee > 0)
            //{
            //    deliveryFee = newFee;
            //}

            deliveryFee = newFee > 0 ? newFee : deliveryFee;
        }

        //Updates the shipment weight.
        public virtual void UpdateWeight(decimal newWeight)
        {
            weight = newWeight > 0 ? newWeight : weight;
        }

        //Updates the shipment weight after adding the extra packing weight.
        public void AddPackingWeight(decimal packingWeight)
        {
            if (packingWeight >= 0)
            {
                weight += packingWeight;
            }
        }

        //Create a method: Shipment CopyShipment().
        public abstract Shipment CopyShipment();

        //Create Shipment ShallowCopy(). Use MemberwiseClone() to create the copy.
        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        // Creates a deeo copy with a new DeliveryAddress.
        // Derived classes must override this method.
        public abstract Shipment DeepCopy();

        //PrintShipment(): prints all shipment information, including the estimated cost.
        //Abstract Method: Print Shipment. Each shipment type prints its own information.
        public abstract void PrintShipment();
        //{
        //    Console.WriteLine("*****************************************************************");
        //    Console.WriteLine("------------------- Shipment Information ------------------------");
        //    Console.WriteLine("*****************************************************************");

        //    Console.WriteLine($"Tracking Code: {TrackingCode}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Weight: {Weight}kg");
        //    Console.WriteLine($"Delivey Fee: {DeliveryFee} EGP");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        //    Console.WriteLine($"Destination: {Destination.GetFullAddress() ?? "Not Specifies yet"}");
        //}
    }
}
