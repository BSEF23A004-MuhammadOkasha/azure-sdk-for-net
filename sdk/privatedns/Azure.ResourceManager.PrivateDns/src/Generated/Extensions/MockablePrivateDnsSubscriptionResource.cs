// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockablePrivateDnsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _privateDnsZonePrivateZonesClientDiagnostics;
        private PrivateZonesRestOperations _privateDnsZonePrivateZonesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockablePrivateDnsSubscriptionResource"/> class for mocking. </summary>
        protected MockablePrivateDnsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePrivateDnsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePrivateDnsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PrivateDnsZonePrivateZonesClientDiagnostics => _privateDnsZonePrivateZonesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PrivateDns", PrivateDnsZoneResource.ResourceType.Namespace, Diagnostics);
        private PrivateZonesRestOperations PrivateDnsZonePrivateZonesRestClient => _privateDnsZonePrivateZonesRestClient ??= new PrivateZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(PrivateDnsZoneResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the Private DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of Private DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateDnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateDnsZoneResource> GetPrivateDnsZonesAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PrivateDnsZonePrivateZonesRestClient.CreateListRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PrivateDnsZonePrivateZonesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PrivateDnsZoneResource(Client, PrivateDnsZoneData.DeserializePrivateDnsZoneData(e)), PrivateDnsZonePrivateZonesClientDiagnostics, Pipeline, "MockablePrivateDnsSubscriptionResource.GetPrivateDnsZones", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Private DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of Private DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateDnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateDnsZoneResource> GetPrivateDnsZones(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PrivateDnsZonePrivateZonesRestClient.CreateListRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PrivateDnsZonePrivateZonesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PrivateDnsZoneResource(Client, PrivateDnsZoneData.DeserializePrivateDnsZoneData(e)), PrivateDnsZonePrivateZonesClientDiagnostics, Pipeline, "MockablePrivateDnsSubscriptionResource.GetPrivateDnsZones", "value", "nextLink", cancellationToken);
        }
    }
}
