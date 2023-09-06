// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing the VirtualNetwork data model.
    /// Define the virtualNetwork.
    /// </summary>
    public partial class VirtualNetworkData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VirtualNetworkData(AzureLocation location) : base(location)
        {
            Statuses = new ChangeTrackingList<ResourceStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this template resides. </param>
        /// <param name="moRefId"> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual network. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the virtual network. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the virtual network. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string kind, string uuid, string vCenterId, string moRefId, string inventoryItemId, string moName, string customResourceName, IReadOnlyList<ResourceStatus> statuses, string provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            Kind = kind;
            Uuid = uuid;
            VCenterId = vCenterId;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            CustomResourceName = customResourceName;
            Statuses = statuses;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkData"/> for deserialization. </summary>
        internal VirtualNetworkData()
        {
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this template resides. </summary>
        public string VCenterId { get; set; }
        /// <summary> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual network. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the virtual network. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the virtual network. </summary>
        public string MoName { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
