// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties of the throttling policy. </summary>
    public partial class EventHubsThrottlingPolicy : EventHubsApplicationGroupPolicy
    {
        /// <summary> Initializes a new instance of <see cref="EventHubsThrottlingPolicy"/>. </summary>
        /// <param name="name"> The Name of this policy. </param>
        /// <param name="rateLimitThreshold"> The Threshold limit above which the application group will be throttled.Rate limit is always per second. </param>
        /// <param name="metricId"> Metric Id on which the throttle limit should be set, MetricId can be discovered by hovering over Metric in the Metrics section of Event Hub Namespace inside Azure Portal. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public EventHubsThrottlingPolicy(string name, long rateLimitThreshold, EventHubsMetricId metricId) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            RateLimitThreshold = rateLimitThreshold;
            MetricId = metricId;
            ApplicationGroupPolicyType = ApplicationGroupPolicyType.ThrottlingPolicy;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsThrottlingPolicy"/>. </summary>
        /// <param name="name"> The Name of this policy. </param>
        /// <param name="applicationGroupPolicyType"> Application Group Policy types. </param>
        /// <param name="rateLimitThreshold"> The Threshold limit above which the application group will be throttled.Rate limit is always per second. </param>
        /// <param name="metricId"> Metric Id on which the throttle limit should be set, MetricId can be discovered by hovering over Metric in the Metrics section of Event Hub Namespace inside Azure Portal. </param>
        internal EventHubsThrottlingPolicy(string name, ApplicationGroupPolicyType applicationGroupPolicyType, long rateLimitThreshold, EventHubsMetricId metricId) : base(name, applicationGroupPolicyType)
        {
            RateLimitThreshold = rateLimitThreshold;
            MetricId = metricId;
            ApplicationGroupPolicyType = applicationGroupPolicyType;
        }

        /// <summary> The Threshold limit above which the application group will be throttled.Rate limit is always per second. </summary>
        public long RateLimitThreshold { get; set; }
        /// <summary> Metric Id on which the throttle limit should be set, MetricId can be discovered by hovering over Metric in the Metrics section of Event Hub Namespace inside Azure Portal. </summary>
        public EventHubsMetricId MetricId { get; set; }
    }
}
