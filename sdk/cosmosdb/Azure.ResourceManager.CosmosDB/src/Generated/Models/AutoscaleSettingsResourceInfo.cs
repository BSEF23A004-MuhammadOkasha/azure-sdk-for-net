// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB provisioned throughput settings object. </summary>
    public partial class AutoscaleSettingsResourceInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutoscaleSettingsResourceInfo"/>. </summary>
        /// <param name="maxThroughput"> Represents maximum throughput container can scale up to. </param>
        public AutoscaleSettingsResourceInfo(int maxThroughput)
        {
            MaxThroughput = maxThroughput;
        }

        /// <summary> Initializes a new instance of <see cref="AutoscaleSettingsResourceInfo"/>. </summary>
        /// <param name="maxThroughput"> Represents maximum throughput container can scale up to. </param>
        /// <param name="autoUpgradePolicy"> Cosmos DB resource auto-upgrade policy. </param>
        /// <param name="targetMaxThroughput"> Represents target maximum throughput container can scale up to once offer is no longer in pending state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoscaleSettingsResourceInfo(int maxThroughput, AutoUpgradePolicyResourceInfo autoUpgradePolicy, int? targetMaxThroughput, Dictionary<string, BinaryData> rawData)
        {
            MaxThroughput = maxThroughput;
            AutoUpgradePolicy = autoUpgradePolicy;
            TargetMaxThroughput = targetMaxThroughput;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutoscaleSettingsResourceInfo"/> for deserialization. </summary>
        internal AutoscaleSettingsResourceInfo()
        {
        }

        /// <summary> Represents maximum throughput container can scale up to. </summary>
        public int MaxThroughput { get; set; }
        /// <summary> Cosmos DB resource auto-upgrade policy. </summary>
        internal AutoUpgradePolicyResourceInfo AutoUpgradePolicy { get; set; }
        /// <summary> Represents throughput policy which service must adhere to for auto-upgrade. </summary>
        public ThroughputPolicyResourceInfo AutoUpgradeThroughputPolicy
        {
            get => AutoUpgradePolicy is null ? default : AutoUpgradePolicy.ThroughputPolicy;
            set
            {
                if (AutoUpgradePolicy is null)
                    AutoUpgradePolicy = new AutoUpgradePolicyResourceInfo();
                AutoUpgradePolicy.ThroughputPolicy = value;
            }
        }

        /// <summary> Represents target maximum throughput container can scale up to once offer is no longer in pending state. </summary>
        public int? TargetMaxThroughput { get; }
    }
}
