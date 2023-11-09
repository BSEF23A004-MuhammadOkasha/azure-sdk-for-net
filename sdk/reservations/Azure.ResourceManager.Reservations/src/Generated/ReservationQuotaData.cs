// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A class representing the ReservationQuota data model.
    /// Quota properties.
    /// </summary>
    public partial class ReservationQuotaData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReservationQuotaData"/>. </summary>
        public ReservationQuotaData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationQuotaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Quota properties for the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationQuotaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, QuotaProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Quota properties for the resource. </summary>
        public QuotaProperties Properties { get; set; }
    }
}
