using Assignment_9_C__OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        //ExtraFee must be greater than or equal to 0.
        public decimal ExtraFee
        {
            get => extraFee;
            set => extraFee = value >= 0 ? value : 0;
        }

        //constructor that initializes all inherited members and ExtraFee.
        //Every derived class calls the base Shipment constructor with base(...) instead of repeating its initialization code.
        public ExpressShipment(string TrackCode, string Description, decimal Weight, decimal DeliverFee, DeliveryAddress Destination, decimal ExtraFees)
            : base(TrackCode, Description, Weight, DeliverFee, Destination)
        {
            extraFee = ExtraFees;
        }

        //Calculates estimated cost for express shipment.
        //Override the EstimatedCost property to include the extra fee.
        public override decimal EstimatedCost
        {
            get => DeliveryFee + (Weight * 5) + ExtraFee;
        }

        //IInsurable =>  decimal CalculateInsurance();
        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        // Overrides PrintShipment().
        public override void PrintShipment()
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("------------------- Express Shipment ------------------------");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivey Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee: {ExtraFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress() ?? "Not specified yet"}");
        }


    }
}
