// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The delivery information associated with a export. </summary>
    public partial class ExportDeliveryInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExportDeliveryInfo"/>. </summary>
        /// <param name="destination"> Has destination for the export being delivered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="destination"/> is null. </exception>
        public ExportDeliveryInfo(ExportDeliveryDestination destination)
        {
            Argument.AssertNotNull(destination, nameof(destination));

            Destination = destination;
        }

        /// <summary> Initializes a new instance of <see cref="ExportDeliveryInfo"/>. </summary>
        /// <param name="destination"> Has destination for the export being delivered. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportDeliveryInfo(ExportDeliveryDestination destination, Dictionary<string, BinaryData> rawData)
        {
            Destination = destination;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExportDeliveryInfo"/> for deserialization. </summary>
        internal ExportDeliveryInfo()
        {
        }

        /// <summary> Has destination for the export being delivered. </summary>
        public ExportDeliveryDestination Destination { get; set; }
    }
}
