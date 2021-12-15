// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Reverse shipment details. </summary>
    public partial class ReverseShippingDetails
    {
        /// <summary> Initializes a new instance of ReverseShippingDetails. </summary>
        internal ReverseShippingDetails()
        {
        }

        /// <summary> Initializes a new instance of ReverseShippingDetails. </summary>
        /// <param name="sasKeyForLabel"> SAS key to download the reverse shipment label of the package. </param>
        /// <param name="carrierName"> Name of the carrier. </param>
        /// <param name="carrierDisplayName"> Carrier Name for display purpose. Not to be used for any processing. </param>
        /// <param name="trackingId"> TrackingId of the package. </param>
        /// <param name="trackingUrl"> TrackingUrl of the package. </param>
        internal ReverseShippingDetails(string sasKeyForLabel, string carrierName, string carrierDisplayName, string trackingId, string trackingUrl)
        {
            SasKeyForLabel = sasKeyForLabel;
            CarrierName = carrierName;
            CarrierDisplayName = carrierDisplayName;
            TrackingId = trackingId;
            TrackingUrl = trackingUrl;
        }

        /// <summary> SAS key to download the reverse shipment label of the package. </summary>
        public string SasKeyForLabel { get; }
        /// <summary> Name of the carrier. </summary>
        public string CarrierName { get; }
        /// <summary> Carrier Name for display purpose. Not to be used for any processing. </summary>
        public string CarrierDisplayName { get; }
        /// <summary> TrackingId of the package. </summary>
        public string TrackingId { get; }
        /// <summary> TrackingUrl of the package. </summary>
        public string TrackingUrl { get; }
    }
}
