using Assignment_9_C__OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal static class DeliveryHelper
    {

        //It calls shipment.PrintShipment(); — whichever override matches the object's real type runs automatically.
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment == null)
            {
                Console.WriteLine("Error: shipment is null.");
                return;
            }
            shipment.PrintShipment();
        }
    }
}
