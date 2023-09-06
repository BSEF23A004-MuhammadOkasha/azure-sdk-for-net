// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App scaling configurations. </summary>
    public partial class ContainerAppScale
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppScale"/>. </summary>
        public ContainerAppScale()
        {
            Rules = new ChangeTrackingList<ContainerAppScaleRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppScale"/>. </summary>
        /// <param name="minReplicas"> Optional. Minimum number of container replicas. </param>
        /// <param name="maxReplicas"> Optional. Maximum number of container replicas. Defaults to 10 if not set. </param>
        /// <param name="rules"> Scaling rules. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppScale(int? minReplicas, int? maxReplicas, IList<ContainerAppScaleRule> rules, Dictionary<string, BinaryData> rawData)
        {
            MinReplicas = minReplicas;
            MaxReplicas = maxReplicas;
            Rules = rules;
            _rawData = rawData;
        }

        /// <summary> Optional. Minimum number of container replicas. </summary>
        public int? MinReplicas { get; set; }
        /// <summary> Optional. Maximum number of container replicas. Defaults to 10 if not set. </summary>
        public int? MaxReplicas { get; set; }
        /// <summary> Scaling rules. </summary>
        public IList<ContainerAppScaleRule> Rules { get; }
    }
}
