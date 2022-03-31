// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Api input base class for LogAnalytics Api. </summary>
    public partial class LogAnalyticsInputBase
    {
        /// <summary> Initializes a new instance of LogAnalyticsInputBase. </summary>
        /// <param name="blobContainerSasUri"> SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to. </param>
        /// <param name="fromTime"> From time of the query. </param>
        /// <param name="toTime"> To time of the query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobContainerSasUri"/> is null. </exception>
        public LogAnalyticsInputBase(Uri blobContainerSasUri, DateTimeOffset fromTime, DateTimeOffset toTime)
        {
            if (blobContainerSasUri == null)
            {
                throw new ArgumentNullException(nameof(blobContainerSasUri));
            }

            BlobContainerSasUri = blobContainerSasUri;
            FromTime = fromTime;
            ToTime = toTime;
        }

        /// <summary> SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to. </summary>
        public Uri BlobContainerSasUri { get; }
        /// <summary> From time of the query. </summary>
        public DateTimeOffset FromTime { get; }
        /// <summary> To time of the query. </summary>
        public DateTimeOffset ToTime { get; }
        /// <summary> Group query result by Throttle Policy applied. </summary>
        public bool? GroupByThrottlePolicy { get; set; }
        /// <summary> Group query result by Operation Name. </summary>
        public bool? GroupByOperationName { get; set; }
        /// <summary> Group query result by Resource Name. </summary>
        public bool? GroupByResourceName { get; set; }
        /// <summary> Group query result by Client Application ID. </summary>
        public bool? GroupByClientApplicationId { get; set; }
        /// <summary> Group query result by User Agent. </summary>
        public bool? GroupByUserAgent { get; set; }
    }
}
