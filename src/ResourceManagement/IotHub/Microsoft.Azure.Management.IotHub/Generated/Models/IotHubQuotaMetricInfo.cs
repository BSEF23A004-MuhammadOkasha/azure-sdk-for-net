// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties related to quota metrics.
    /// </summary>
    public partial class IotHubQuotaMetricInfo
    {
        /// <summary>
        /// Initializes a new instance of the IotHubQuotaMetricInfo class.
        /// </summary>
        public IotHubQuotaMetricInfo() { }

        /// <summary>
        /// Initializes a new instance of the IotHubQuotaMetricInfo class.
        /// </summary>
        public IotHubQuotaMetricInfo(string name = default(string), long? currentValue = default(long?), long? maxValue = default(long?))
        {
            Name = name;
            CurrentValue = currentValue;
            MaxValue = maxValue;
        }

        /// <summary>
        /// The name of the quota metric.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// The current value for the quota metric.
        /// </summary>
        [JsonProperty(PropertyName = "CurrentValue")]
        public long? CurrentValue { get; set; }

        /// <summary>
        /// The maximum value of the quota metric.
        /// </summary>
        [JsonProperty(PropertyName = "MaxValue")]
        public long? MaxValue { get; set; }

    }
}
