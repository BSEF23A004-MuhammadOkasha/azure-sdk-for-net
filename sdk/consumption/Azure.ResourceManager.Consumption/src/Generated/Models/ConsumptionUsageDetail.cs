// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// An usage detail resource.
    /// Please note <see cref="ConsumptionUsageDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConsumptionLegacyUsageDetail"/> and <see cref="ConsumptionModernUsageDetail"/>.
    /// </summary>
    public partial class ConsumptionUsageDetail : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConsumptionUsageDetail"/>. </summary>
        internal ConsumptionUsageDetail()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionUsageDetail"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of usage details. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionUsageDetail(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, UsageDetailsKind kind, ETag? etag, IReadOnlyDictionary<string, string> tags, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ETag = etag;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Specifies the kind of usage details. </summary>
        internal UsageDetailsKind Kind { get; set; }
        /// <summary> The etag for the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
