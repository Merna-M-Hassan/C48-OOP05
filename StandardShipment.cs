using Assignment_9_C__OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal class StandardShipment : Shipment
    {

        //Every derived class calls the base Shipment constructor with base(...) instead of repeating its initialization code.
        //first constructor call
        public StandardShipment(string trackCode) : base(trackCode)
        {
        }

        //second constructor call
        public StandardShipment(string TrackCode, string Description, decimal Weight, decimal DeliverFee, DeliveryAddress Destination)
            : base(TrackCode, Description, Weight, DeliverFee, Destination)
        {
        }

        //Calculates estimated cost for standard shipment.
        public override decimal EstimatedCost
        {
            get => DeliveryFee + (Weight * 5);
        }

        //IInsurable =>  decimal CalculateInsurance();
        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        //Copy method : creates a new independent copy
        //Creates a new independent copy of the shipment
        // All data is copied to a new object
        public override Shipment CopyShipment()
        {
            return new StandardShipment(
                TrackingCode,
                Description,
                Weight,
                DeliveryFee,
                Destination
            );
        }
     

        //Change the address of the copied shipment.
        public override Shipment DeepCopy()
        {
            return new StandardShipment(
                TrackingCode,
                Description,
                Weight,
                DeliveryFee,
                new DeliveryAddress(Destination.City, Destination.Street, Destination.BuildingNumber)
            );
        }

        // Overrides PrintShipment().
        // Prints standard shipment information.
        public override void PrintShipment()
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("-------------------Standard Shipment ------------------------");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fees: {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress() ?? "Not specified yet"}");
        }
    }
}
