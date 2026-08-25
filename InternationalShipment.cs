using Assignment_9_C__OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        //Create a constructor that initializes all inherited members and the new properties.
        //Every derived class calls the base Shipment constructor with base(...) instead of repeating its initialization code.
        public InternationalShipment(string TrackCode, string Description, decimal Weight, decimal DeliverFee, DeliveryAddress Destination, string DestinationCountry, decimal CustomFees)
            : base(TrackCode, Description, Weight, DeliverFee, Destination)
        {
            destinationCountry = DestinationCountry;
            customsFee = CustomFees;
        }

        //DestinationCountry cannot be null, empty, or whitespace.
        public string DestinationCountry
        {
            get => destinationCountry;
            set => destinationCountry = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";
        }

        //CustomsFee must be greater than or equal to 0.
        public decimal CustomsFee
        {
            get => customsFee;
            set => customsFee = value >= 0 ? value : 0;
        }

        //Calculates estimated cost for international shipment.
        //Override the EstimatedCost property to include the customs fee.
        public override decimal EstimatedCost
        {
            get => DeliveryFee + (Weight * 5) + CustomsFee;
        }

        //IInsurable =>  decimal CalculateInsurance();
        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        //creates a new independent copy
        public override Shipment CopyShipment()
        {
            return new InternationalShipment(
                TrackingCode,
                Description,
                Weight,
                DeliveryFee,
                Destination,
                DestinationCountry,
                CustomsFee
            );
        }

        // Overrides PrintShipment().
        public override void PrintShipment()
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("------------------- International Shipment ------------------------");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}kg");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Delivey Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Custom Fee: {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress() ?? "Not Specifies yet"}");

        }

        //A virtual GenerateCustomsReport().
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Custom Report");
            Console.WriteLine("****************************************************************");
            Console.WriteLine($"Shipment Tracking: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: ${CustomsFee}");
            Console.WriteLine($"Total Value: ${EstimatedCost}");
        }
    }
}
