// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the NatGateway data model. </summary>
    public partial class NatGatewayData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of NatGatewayData. </summary>
        public NatGatewayData()
        {
            Zones = new ChangeTrackingList<string>();
            PublicIPAddresses = new ChangeTrackingList<WritableSubResource>();
            PublicIPPrefixes = new ChangeTrackingList<WritableSubResource>();
            Subnets = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of NatGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The nat gateway SKU. </param>
        /// <param name="zones"> A list of availability zones denoting the zone in which Nat Gateway should be deployed. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the nat gateway. </param>
        /// <param name="publicIPAddresses"> An array of public ip addresses associated with the nat gateway resource. </param>
        /// <param name="publicIPPrefixes"> An array of public ip prefixes associated with the nat gateway resource. </param>
        /// <param name="subnets"> An array of references to the subnets using this nat gateway resource. </param>
        /// <param name="resourceGuid"> The resource GUID property of the NAT gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the NAT gateway resource. </param>
        internal NatGatewayData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, NatGatewaySku sku, IList<string> zones, ETag? etag, int? idleTimeoutInMinutes, IList<WritableSubResource> publicIPAddresses, IList<WritableSubResource> publicIPPrefixes, IReadOnlyList<WritableSubResource> subnets, Guid? resourceGuid, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags)
        {
            Sku = sku;
            Zones = zones;
            ETag = etag;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            PublicIPAddresses = publicIPAddresses;
            PublicIPPrefixes = publicIPPrefixes;
            Subnets = subnets;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> The nat gateway SKU. </summary>
        internal NatGatewaySku Sku { get; set; }
        /// <summary> Name of Nat Gateway SKU. </summary>
        public NatGatewaySkuName? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new NatGatewaySku();
                Sku.Name = value;
            }
        }

        /// <summary> A list of availability zones denoting the zone in which Nat Gateway should be deployed. </summary>
        public IList<string> Zones { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The idle timeout of the nat gateway. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> An array of public ip addresses associated with the nat gateway resource. </summary>
        public IList<WritableSubResource> PublicIPAddresses { get; }
        /// <summary> An array of public ip prefixes associated with the nat gateway resource. </summary>
        public IList<WritableSubResource> PublicIPPrefixes { get; }
        /// <summary> An array of references to the subnets using this nat gateway resource. </summary>
        public IReadOnlyList<WritableSubResource> Subnets { get; }
        /// <summary> The resource GUID property of the NAT gateway resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the NAT gateway resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
