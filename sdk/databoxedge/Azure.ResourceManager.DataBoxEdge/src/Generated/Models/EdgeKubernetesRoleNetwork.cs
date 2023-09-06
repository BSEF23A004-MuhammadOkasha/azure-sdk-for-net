// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Kubernetes role network resource. </summary>
    public partial class EdgeKubernetesRoleNetwork
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleNetwork"/>. </summary>
        internal EdgeKubernetesRoleNetwork()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleNetwork"/>. </summary>
        /// <param name="cniConfig"> Cni configuration. </param>
        /// <param name="loadBalancerConfig"> Load balancer configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeKubernetesRoleNetwork(CniConfig cniConfig, DataBoxEdgeLoadBalancerConfig loadBalancerConfig, Dictionary<string, BinaryData> rawData)
        {
            CniConfig = cniConfig;
            LoadBalancerConfig = loadBalancerConfig;
            _rawData = rawData;
        }

        /// <summary> Cni configuration. </summary>
        public CniConfig CniConfig { get; }
        /// <summary> Load balancer configuration. </summary>
        public DataBoxEdgeLoadBalancerConfig LoadBalancerConfig { get; }
    }
}
