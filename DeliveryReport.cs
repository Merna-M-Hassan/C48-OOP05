using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal class DeliveryReport
    {

        //Prints the tracking status of any shipment.
        public static void PrintShipment(ITrackable shipment)
        {
            if (shipment == null)
            {
                Console.WriteLine("Shipment is empty..........");
                return;
            }

            Console.WriteLine("---------------TRACKING STATUS-----------------");
            Console.WriteLine(shipment.GetTrackingStatus());
            Console.WriteLine("----------------------------------------------");
        }

        //Prints the insurance cost of any shipment
        public static void PrintInsurance(IInsurable shipment)
        {
            if (shipment == null)
            {
                Console.WriteLine("Shipment is empty..................");
                return;
            }

            Console.WriteLine("--------------------INSURANCE COST ----------------------");
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()} EGP");
            Console.WriteLine("----------------------------------------------------");
        }

    }
}
