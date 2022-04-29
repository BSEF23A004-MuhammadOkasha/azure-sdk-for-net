// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotCentral;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> The description of the IoT Central application. </summary>
    public partial class IotCentralAppPatch
    {
        /// <summary> Initializes a new instance of IotCentralAppPatch. </summary>
        public IotCentralAppPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<IotCentralPrivateEndpointConnectionData>();
        }

        /// <summary> Instance tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> A valid instance SKU. </summary>
        internal AppSkuInfo Sku { get; set; }
        /// <summary> The name of the SKU. </summary>
        public AppSku SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new AppSkuInfo(value);
        }

        /// <summary> The managed identities for the IoT Central application. </summary>
        public SystemAssignedServiceIdentity Identity { get; set; }
        /// <summary> The provisioning state of the application. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The ID of the application. </summary>
        public string ApplicationId { get; }
        /// <summary> The display name of the application. </summary>
        public string DisplayName { get; set; }
        /// <summary> The subdomain of the application. </summary>
        public string Subdomain { get; set; }
        /// <summary> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </summary>
        public string Template { get; set; }
        /// <summary> The current state of the application. </summary>
        public AppState? State { get; }
        /// <summary> Whether requests from the public network are allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Network Rule Set Properties of this IoT Central application. </summary>
        public NetworkRuleSets NetworkRuleSets { get; set; }
        /// <summary> Private endpoint connections created on this IoT Central application. </summary>
        public IReadOnlyList<IotCentralPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
