// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MobileNetworkTenantMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MobileNetworkTenantMockingExtension"/> class for mocking. </summary>
        protected MobileNetworkTenantMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkTenantMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MobileNetworkTenantMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of TenantPacketCoreControlPlaneVersionResources in the TenantResource. </summary>
        /// <returns> An object representing collection of TenantPacketCoreControlPlaneVersionResources and their operations over a TenantPacketCoreControlPlaneVersionResource. </returns>
        public virtual TenantPacketCoreControlPlaneVersionCollection GetTenantPacketCoreControlPlaneVersions()
        {
            return GetCachedClient(Client => new TenantPacketCoreControlPlaneVersionCollection(Client, Id));
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantPacketCoreControlPlaneVersionResource>> GetTenantPacketCoreControlPlaneVersionAsync(string versionName, CancellationToken cancellationToken = default)
        {
            return await GetTenantPacketCoreControlPlaneVersions().GetAsync(versionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantPacketCoreControlPlaneVersionResource> GetTenantPacketCoreControlPlaneVersion(string versionName, CancellationToken cancellationToken = default)
        {
            return GetTenantPacketCoreControlPlaneVersions().Get(versionName, cancellationToken);
        }
    }
}
