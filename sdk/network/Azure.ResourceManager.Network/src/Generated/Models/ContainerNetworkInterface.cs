// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Container network interface child resource. </summary>
    public partial class ContainerNetworkInterface : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ContainerNetworkInterface"/>. </summary>
        public ContainerNetworkInterface()
        {
            IPConfigurations = new ChangeTrackingList<ContainerNetworkInterfaceIPConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerNetworkInterface"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="containerNetworkInterfaceConfiguration"> Container network interface configuration from which this container network interface is created. </param>
        /// <param name="container"> Reference to the container to which this container network interface is attached. </param>
        /// <param name="ipConfigurations"> Reference to the ip configuration on this container nic. </param>
        /// <param name="provisioningState"> The provisioning state of the container network interface resource. </param>
        internal ContainerNetworkInterface(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, ContainerNetworkInterfaceConfiguration containerNetworkInterfaceConfiguration, WritableSubResource container, IReadOnlyList<ContainerNetworkInterfaceIPConfiguration> ipConfigurations, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            ContainerNetworkInterfaceConfiguration = containerNetworkInterfaceConfiguration;
            Container = container;
            IPConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Container network interface configuration from which this container network interface is created. </summary>
        public ContainerNetworkInterfaceConfiguration ContainerNetworkInterfaceConfiguration { get; }
        /// <summary> Reference to the container to which this container network interface is attached. </summary>
        internal WritableSubResource Container { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ContainerId
        {
            get => Container is null ? default : Container.Id;
            set
            {
                if (Container is null)
                    Container = new WritableSubResource();
                Container.Id = value;
            }
        }

        /// <summary> Reference to the ip configuration on this container nic. </summary>
        public IReadOnlyList<ContainerNetworkInterfaceIPConfiguration> IPConfigurations { get; }
        /// <summary> The provisioning state of the container network interface resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
