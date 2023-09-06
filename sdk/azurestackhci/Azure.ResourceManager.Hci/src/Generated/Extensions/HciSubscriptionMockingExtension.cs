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
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class HciSubscriptionMockingExtension : ArmResource
    {
        private ClientDiagnostics _hciClusterClustersClientDiagnostics;
        private ClustersRestOperations _hciClusterClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="HciSubscriptionMockingExtension"/> class for mocking. </summary>
        protected HciSubscriptionMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HciSubscriptionMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HciSubscriptionMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics HciClusterClustersClientDiagnostics => _hciClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Hci", HciClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations HciClusterClustersRestClient => _hciClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HciClusterResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all HCI clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HciClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HciClusterResource> GetHciClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HciClusterClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HciClusterClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HciClusterResource(Client, HciClusterData.DeserializeHciClusterData(e)), HciClusterClustersClientDiagnostics, Pipeline, "HciSubscriptionMockingExtension.GetHciClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all HCI clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HciClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HciClusterResource> GetHciClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HciClusterClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HciClusterClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HciClusterResource(Client, HciClusterData.DeserializeHciClusterData(e)), HciClusterClustersClientDiagnostics, Pipeline, "HciSubscriptionMockingExtension.GetHciClusters", "value", "nextLink", cancellationToken);
        }
    }
}
