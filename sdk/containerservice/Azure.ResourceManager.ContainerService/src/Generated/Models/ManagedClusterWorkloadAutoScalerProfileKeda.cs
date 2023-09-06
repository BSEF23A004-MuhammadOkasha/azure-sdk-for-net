// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile. </summary>
    internal partial class ManagedClusterWorkloadAutoScalerProfileKeda
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterWorkloadAutoScalerProfileKeda"/>. </summary>
        /// <param name="enabled"> Whether to enable KEDA. </param>
        public ManagedClusterWorkloadAutoScalerProfileKeda(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterWorkloadAutoScalerProfileKeda"/>. </summary>
        /// <param name="enabled"> Whether to enable KEDA. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterWorkloadAutoScalerProfileKeda(bool enabled, Dictionary<string, BinaryData> rawData)
        {
            Enabled = enabled;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterWorkloadAutoScalerProfileKeda"/> for deserialization. </summary>
        internal ManagedClusterWorkloadAutoScalerProfileKeda()
        {
        }

        /// <summary> Whether to enable KEDA. </summary>
        public bool Enabled { get; set; }
    }
}
