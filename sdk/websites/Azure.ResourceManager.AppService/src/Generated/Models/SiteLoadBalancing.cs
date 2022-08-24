// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Site load balancing.
    /// Serialized Name: SiteLoadBalancing
    /// </summary>
    public enum SiteLoadBalancing
    {
        /// <summary>
        /// WeightedRoundRobin
        /// Serialized Name: SiteLoadBalancing.WeightedRoundRobin
        /// </summary>
        WeightedRoundRobin,
        /// <summary>
        /// LeastRequests
        /// Serialized Name: SiteLoadBalancing.LeastRequests
        /// </summary>
        LeastRequests,
        /// <summary>
        /// LeastResponseTime
        /// Serialized Name: SiteLoadBalancing.LeastResponseTime
        /// </summary>
        LeastResponseTime,
        /// <summary>
        /// WeightedTotalTraffic
        /// Serialized Name: SiteLoadBalancing.WeightedTotalTraffic
        /// </summary>
        WeightedTotalTraffic,
        /// <summary>
        /// RequestHash
        /// Serialized Name: SiteLoadBalancing.RequestHash
        /// </summary>
        RequestHash,
        /// <summary>
        /// PerSiteRoundRobin
        /// Serialized Name: SiteLoadBalancing.PerSiteRoundRobin
        /// </summary>
        PerSiteRoundRobin
    }
}
