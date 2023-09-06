// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the configuration for the region. </summary>
    public partial class RegionConfigurationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RegionConfigurationContent"/>. </summary>
        public RegionConfigurationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegionConfigurationContent"/>. </summary>
        /// <param name="scheduleAvailabilityRequest">
        /// Request body to get the availability for scheduling orders.
        /// Please note <see cref="ScheduleAvailabilityContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxScheduleAvailabilityContent"/>, <see cref="DiskScheduleAvailabilityContent"/> and <see cref="HeavyScheduleAvailabilityContent"/>.
        /// </param>
        /// <param name="transportAvailabilityRequest"> Request body to get the transport availability for given sku. </param>
        /// <param name="dataCenterAddressRequest"> Request body to get the datacenter address for given sku. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RegionConfigurationContent(ScheduleAvailabilityContent scheduleAvailabilityRequest, TransportAvailabilityRequest transportAvailabilityRequest, DataCenterAddressContent dataCenterAddressRequest, Dictionary<string, BinaryData> rawData)
        {
            ScheduleAvailabilityRequest = scheduleAvailabilityRequest;
            TransportAvailabilityRequest = transportAvailabilityRequest;
            DataCenterAddressRequest = dataCenterAddressRequest;
            _rawData = rawData;
        }

        /// <summary>
        /// Request body to get the availability for scheduling orders.
        /// Please note <see cref="ScheduleAvailabilityContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxScheduleAvailabilityContent"/>, <see cref="DiskScheduleAvailabilityContent"/> and <see cref="HeavyScheduleAvailabilityContent"/>.
        /// </summary>
        public ScheduleAvailabilityContent ScheduleAvailabilityRequest { get; set; }
        /// <summary> Request body to get the transport availability for given sku. </summary>
        internal TransportAvailabilityRequest TransportAvailabilityRequest { get; set; }
        /// <summary> Type of the device. </summary>
        public DataBoxSkuName? TransportAvailabilityRequestSkuName
        {
            get => TransportAvailabilityRequest is null ? default : TransportAvailabilityRequest.SkuName;
            set
            {
                if (TransportAvailabilityRequest is null)
                    TransportAvailabilityRequest = new TransportAvailabilityRequest();
                TransportAvailabilityRequest.SkuName = value;
            }
        }

        /// <summary> Request body to get the datacenter address for given sku. </summary>
        public DataCenterAddressContent DataCenterAddressRequest { get; set; }
    }
}
