// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A Class representing a TenantPacketCoreControlPlaneVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="TenantPacketCoreControlPlaneVersionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetTenantPacketCoreControlPlaneVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetTenantPacketCoreControlPlaneVersion method.
    /// </summary>
    public partial class TenantPacketCoreControlPlaneVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantPacketCoreControlPlaneVersionResource"/> instance. </summary>
        /// <param name="versionName"> The versionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string versionName)
        {
            var resourceId = $"/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics;
        private readonly PacketCoreControlPlaneVersionsRestOperations _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient;
        private readonly PacketCoreControlPlaneVersionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MobileNetwork/packetCoreControlPlaneVersions";

        /// <summary> Initializes a new instance of the <see cref="TenantPacketCoreControlPlaneVersionResource"/> class for mocking. </summary>
        protected TenantPacketCoreControlPlaneVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPacketCoreControlPlaneVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantPacketCoreControlPlaneVersionResource(ArmClient client, PacketCoreControlPlaneVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPacketCoreControlPlaneVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantPacketCoreControlPlaneVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
            _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient = new PacketCoreControlPlaneVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PacketCoreControlPlaneVersionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
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
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.MobileNetwork/packetCoreControlPlaneVersions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantPacketCoreControlPlaneVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.MobileNetwork/packetCoreControlPlaneVersions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantPacketCoreControlPlaneVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionResource.Get");
            scope.Start();
            try
            {
                var response = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
