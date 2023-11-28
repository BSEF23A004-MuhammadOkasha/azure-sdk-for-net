// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Logical Network Properties. </summary>
    public partial class SiteRecoveryLogicalNetworkProperties
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryLogicalNetworkProperties"/>. </summary>
        internal SiteRecoveryLogicalNetworkProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryLogicalNetworkProperties"/>. </summary>
        /// <param name="friendlyName"> The Friendly Name. </param>
        /// <param name="networkVirtualizationStatus"> A value indicating whether Network Virtualization is enabled for the logical network. </param>
        /// <param name="logicalNetworkUsage"> A value indicating whether logical network is used as private test network by test failover. </param>
        /// <param name="logicalNetworkDefinitionsStatus"> A value indicating whether logical network definitions are isolated. </param>
        internal SiteRecoveryLogicalNetworkProperties(string friendlyName, string networkVirtualizationStatus, string logicalNetworkUsage, string logicalNetworkDefinitionsStatus)
        {
            FriendlyName = friendlyName;
            NetworkVirtualizationStatus = networkVirtualizationStatus;
            LogicalNetworkUsage = logicalNetworkUsage;
            LogicalNetworkDefinitionsStatus = logicalNetworkDefinitionsStatus;
        }

        /// <summary> The Friendly Name. </summary>
        public string FriendlyName { get; }
        /// <summary> A value indicating whether Network Virtualization is enabled for the logical network. </summary>
        public string NetworkVirtualizationStatus { get; }
        /// <summary> A value indicating whether logical network is used as private test network by test failover. </summary>
        public string LogicalNetworkUsage { get; }
        /// <summary> A value indicating whether logical network definitions are isolated. </summary>
        public string LogicalNetworkDefinitionsStatus { get; }
    }
}
