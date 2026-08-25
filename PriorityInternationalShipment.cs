using Assignment_9_C__OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string TrackCode, string Description, decimal Weight, decimal DeliverFee, DeliveryAddress Destination, string DestinationCountry, decimal CustomFees)
            : base(TrackCode, Description, Weight, DeliverFee, Destination, DestinationCountry, CustomFees)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
        }
    }
}
