// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Statistics related to Pool usage information.
    /// </summary>
    public partial class UsageStatistics
    {
        /// <summary>
        /// Initializes a new instance of the UsageStatistics class.
        /// </summary>
        public UsageStatistics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageStatistics class.
        /// </summary>
        /// <param name="startTime">The start time of the time range covered by
        /// the statistics.</param>
        /// <param name="lastUpdateTime">The time at which the statistics were
        /// last updated. All statistics are limited to the range between
        /// startTime and lastUpdateTime.</param>
        /// <param name="dedicatedCoreTime">The aggregated wall-clock time of
        /// the dedicated Compute Node cores being part of the Pool.</param>
        public UsageStatistics(System.DateTime startTime, System.DateTime lastUpdateTime, System.TimeSpan dedicatedCoreTime)
        {
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            DedicatedCoreTime = dedicatedCoreTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start time of the time range covered by the
        /// statistics.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the statistics were last updated.
        /// All statistics are limited to the range between startTime and
        /// lastUpdateTime.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the aggregated wall-clock time of the dedicated
        /// Compute Node cores being part of the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "dedicatedCoreTime")]
        public System.TimeSpan DedicatedCoreTime { get; set; }

    }
}
