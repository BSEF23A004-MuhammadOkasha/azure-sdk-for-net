// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Settings for upgrading an agentpool. </summary>
    internal partial class AgentPoolUpgradeSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AgentPoolUpgradeSettings"/>. </summary>
        public AgentPoolUpgradeSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolUpgradeSettings"/>. </summary>
        /// <param name="maxSurge"> This can either be set to an integer (e.g. '5') or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1. For more information, including best practices, see: https://docs.microsoft.com/azure/aks/upgrade-cluster#customize-node-surge-upgrade. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolUpgradeSettings(string maxSurge, Dictionary<string, BinaryData> rawData)
        {
            MaxSurge = maxSurge;
            _rawData = rawData;
        }

        /// <summary> This can either be set to an integer (e.g. '5') or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1. For more information, including best practices, see: https://docs.microsoft.com/azure/aks/upgrade-cluster#customize-node-surge-upgrade. </summary>
        public string MaxSurge { get; set; }
    }
}
