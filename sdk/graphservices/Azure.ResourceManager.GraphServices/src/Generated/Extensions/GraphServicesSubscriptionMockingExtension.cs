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
using Azure.ResourceManager.GraphServices;

namespace Azure.ResourceManager.GraphServices.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class GraphServicesSubscriptionMockingExtension : ArmResource
    {
        private ClientDiagnostics _graphServicesAccountResourceAccountsClientDiagnostics;
        private AccountsRestOperations _graphServicesAccountResourceAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="GraphServicesSubscriptionMockingExtension"/> class for mocking. </summary>
        protected GraphServicesSubscriptionMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GraphServicesSubscriptionMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GraphServicesSubscriptionMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics GraphServicesAccountResourceAccountsClientDiagnostics => _graphServicesAccountResourceAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.GraphServices", GraphServicesAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations GraphServicesAccountResourceAccountsRestClient => _graphServicesAccountResourceAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(GraphServicesAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns list of accounts belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.GraphServices/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GraphServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GraphServicesAccountResource> GetGraphServicesAccountResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => GraphServicesAccountResourceAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => GraphServicesAccountResourceAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GraphServicesAccountResource(Client, GraphServicesAccountResourceData.DeserializeGraphServicesAccountResourceData(e)), GraphServicesAccountResourceAccountsClientDiagnostics, Pipeline, "GraphServicesSubscriptionMockingExtension.GetGraphServicesAccountResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of accounts belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.GraphServices/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GraphServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GraphServicesAccountResource> GetGraphServicesAccountResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => GraphServicesAccountResourceAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => GraphServicesAccountResourceAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GraphServicesAccountResource(Client, GraphServicesAccountResourceData.DeserializeGraphServicesAccountResourceData(e)), GraphServicesAccountResourceAccountsClientDiagnostics, Pipeline, "GraphServicesSubscriptionMockingExtension.GetGraphServicesAccountResources", "value", "nextLink", cancellationToken);
        }
    }
}
