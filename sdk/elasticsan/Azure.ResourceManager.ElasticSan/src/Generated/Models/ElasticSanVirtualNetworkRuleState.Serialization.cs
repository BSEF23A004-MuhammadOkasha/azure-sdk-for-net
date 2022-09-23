// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ElasticSan.Models
{
    internal static partial class ElasticSanVirtualNetworkRuleStateExtensions
    {
        public static string ToSerialString(this ElasticSanVirtualNetworkRuleState value) => value switch
        {
            ElasticSanVirtualNetworkRuleState.Provisioning => "provisioning",
            ElasticSanVirtualNetworkRuleState.Deprovisioning => "deprovisioning",
            ElasticSanVirtualNetworkRuleState.Succeeded => "succeeded",
            ElasticSanVirtualNetworkRuleState.Failed => "failed",
            ElasticSanVirtualNetworkRuleState.NetworkSourceDeleted => "networkSourceDeleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ElasticSanVirtualNetworkRuleState value.")
        };

        public static ElasticSanVirtualNetworkRuleState ToElasticSanVirtualNetworkRuleState(this string value)
        {
            if (string.Equals(value, "provisioning", StringComparison.InvariantCultureIgnoreCase)) return ElasticSanVirtualNetworkRuleState.Provisioning;
            if (string.Equals(value, "deprovisioning", StringComparison.InvariantCultureIgnoreCase)) return ElasticSanVirtualNetworkRuleState.Deprovisioning;
            if (string.Equals(value, "succeeded", StringComparison.InvariantCultureIgnoreCase)) return ElasticSanVirtualNetworkRuleState.Succeeded;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return ElasticSanVirtualNetworkRuleState.Failed;
            if (string.Equals(value, "networkSourceDeleted", StringComparison.InvariantCultureIgnoreCase)) return ElasticSanVirtualNetworkRuleState.NetworkSourceDeleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ElasticSanVirtualNetworkRuleState value.");
        }
    }
}
