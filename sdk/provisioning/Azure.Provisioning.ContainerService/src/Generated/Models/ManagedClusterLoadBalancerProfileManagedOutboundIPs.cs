// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Desired managed outbound IPs for the cluster load balancer.
/// </summary>
public partial class ManagedClusterLoadBalancerProfileManagedOutboundIPs : ProvisionableConstruct
{
    /// <summary>
    /// The desired number of IPv4 outbound IPs created/managed by Azure for
    /// the cluster load balancer. Allowed values must be in the range of 1 to
    /// 100 (inclusive). The default value is 1.
    /// </summary>
    public BicepValue<int> Count 
    {
        get { Initialize(); return _count!; }
        set { Initialize(); _count!.Assign(value); }
    }
    private BicepValue<int>? _count;

    /// <summary>
    /// The desired number of IPv6 outbound IPs created/managed by Azure for
    /// the cluster load balancer. Allowed values must be in the range of 1 to
    /// 100 (inclusive). The default value is 0 for single-stack and 1 for
    /// dual-stack.
    /// </summary>
    public BicepValue<int> CountIPv6 
    {
        get { Initialize(); return _countIPv6!; }
        set { Initialize(); _countIPv6!.Assign(value); }
    }
    private BicepValue<int>? _countIPv6;

    /// <summary>
    /// Creates a new ManagedClusterLoadBalancerProfileManagedOutboundIPs.
    /// </summary>
    public ManagedClusterLoadBalancerProfileManagedOutboundIPs()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedClusterLoadBalancerProfileManagedOutboundIPs.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _count = DefineProperty<int>("Count", ["count"]);
        _countIPv6 = DefineProperty<int>("CountIPv6", ["countIPv6"]);
    }
}
