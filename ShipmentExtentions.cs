using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal static class ShipmentExtentions
    {
        public static string GetSummary(this Shipment shipment)
        {
            if (shipment == null)
            {
                return "Shipment is null";
            }

            string shipmentType = GetShipmentType(shipment);

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment == null)
            {
                return false;
            }

            return shipment.TrackingStatus == "Delivered";
        }

        private static string GetShipmentType(Shipment shipment)
        {
            if (shipment is ExpressShipment)
                return "Express";
            else if (shipment is InternationalShipment)
                return "International";
            else if (shipment is StandardShipment)
                return "Standard";
            else
                return "Unknown";
        }
    }
}
