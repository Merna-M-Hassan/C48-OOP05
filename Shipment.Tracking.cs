using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal abstract partial class Shipment
    {
        private string trackingStatus;

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
    }
}
