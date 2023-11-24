// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A Network Mapping fabric specific settings. </summary>
    public partial class A2ANetworkMappingSettings : NetworkMappingFabricSpecificSettings
    {
        /// <summary> Initializes a new instance of <see cref="A2ANetworkMappingSettings"/>. </summary>
        internal A2ANetworkMappingSettings()
        {
            InstanceType = "AzureToAzure";
        }

        /// <summary> Initializes a new instance of <see cref="A2ANetworkMappingSettings"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="primaryFabricLocation"> The primary fabric location. </param>
        /// <param name="recoveryFabricLocation"> The recovery fabric location. </param>
        internal A2ANetworkMappingSettings(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, AzureLocation? primaryFabricLocation, AzureLocation? recoveryFabricLocation) : base(instanceType, serializedAdditionalRawData)
        {
            PrimaryFabricLocation = primaryFabricLocation;
            RecoveryFabricLocation = recoveryFabricLocation;
            InstanceType = instanceType ?? "AzureToAzure";
        }

        /// <summary> The primary fabric location. </summary>
        public AzureLocation? PrimaryFabricLocation { get; }
        /// <summary> The recovery fabric location. </summary>
        public AzureLocation? RecoveryFabricLocation { get; }
    }
}
