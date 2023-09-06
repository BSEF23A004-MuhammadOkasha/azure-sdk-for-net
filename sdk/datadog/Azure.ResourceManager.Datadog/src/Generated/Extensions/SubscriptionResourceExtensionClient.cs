// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Datadog.Models;

namespace Azure.ResourceManager.Datadog
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _marketplaceAgreementsClientDiagnostics;
        private MarketplaceAgreementsRestOperations _marketplaceAgreementsRestClient;
        private ClientDiagnostics _datadogMonitorResourceMonitorsClientDiagnostics;
        private MonitorsRestOperations _datadogMonitorResourceMonitorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MarketplaceAgreementsClientDiagnostics => _marketplaceAgreementsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Datadog", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private MarketplaceAgreementsRestOperations MarketplaceAgreementsRestClient => _marketplaceAgreementsRestClient ??= new MarketplaceAgreementsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DatadogMonitorResourceMonitorsClientDiagnostics => _datadogMonitorResourceMonitorsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Datadog", DatadogMonitorResource.ResourceType.Namespace, Diagnostics);
        private MonitorsRestOperations DatadogMonitorResourceMonitorsRestClient => _datadogMonitorResourceMonitorsRestClient ??= new MonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DatadogMonitorResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List Datadog marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatadogAgreementResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatadogAgreementResource> GetMarketplaceAgreementsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplaceAgreementsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplaceAgreementsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DatadogAgreementResource.DeserializeDatadogAgreementResource, MarketplaceAgreementsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetMarketplaceAgreements", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Datadog marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatadogAgreementResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatadogAgreementResource> GetMarketplaceAgreements(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplaceAgreementsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplaceAgreementsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DatadogAgreementResource.DeserializeDatadogAgreementResource, MarketplaceAgreementsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetMarketplaceAgreements", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Create Datadog marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> The DatadogAgreementResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatadogAgreementResource>> CreateOrUpdateMarketplaceAgreementAsync(DatadogAgreementResource body = null, CancellationToken cancellationToken = default)
        {
            using var scope = MarketplaceAgreementsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CreateOrUpdateMarketplaceAgreement");
            scope.Start();
            try
            {
                var response = await MarketplaceAgreementsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, body, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Datadog marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> The DatadogAgreementResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatadogAgreementResource> CreateOrUpdateMarketplaceAgreement(DatadogAgreementResource body = null, CancellationToken cancellationToken = default)
        {
            using var scope = MarketplaceAgreementsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CreateOrUpdateMarketplaceAgreement");
            scope.Start();
            try
            {
                var response = MarketplaceAgreementsRestClient.CreateOrUpdate(Id.SubscriptionId, body, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatadogMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatadogMonitorResource> GetDatadogMonitorResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DatadogMonitorResourceMonitorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DatadogMonitorResourceMonitorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DatadogMonitorResource(Client, DatadogMonitorResourceData.DeserializeDatadogMonitorResourceData(e)), DatadogMonitorResourceMonitorsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDatadogMonitorResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatadogMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatadogMonitorResource> GetDatadogMonitorResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DatadogMonitorResourceMonitorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DatadogMonitorResourceMonitorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DatadogMonitorResource(Client, DatadogMonitorResourceData.DeserializeDatadogMonitorResourceData(e)), DatadogMonitorResourceMonitorsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDatadogMonitorResources", "value", "nextLink", cancellationToken);
        }
    }
}
