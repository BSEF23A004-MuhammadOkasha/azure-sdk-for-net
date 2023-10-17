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
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _signalRClientDiagnostics;
        private SignalRRestOperations _signalRRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

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

        private ClientDiagnostics SignalRClientDiagnostics => _signalRClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SignalR", SignalRResource.ResourceType.Namespace, Diagnostics);
        private SignalRRestOperations SignalRRestClient => _signalRRestClient ??= new SignalRRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SignalRResource.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SignalR", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SignalRNameAvailabilityResult>> CheckSignalRNameAvailabilityAsync(AzureLocation location, SignalRNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = SignalRClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckSignalRNameAvailability");
            scope.Start();
            try
            {
                var response = await SignalRRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SignalRNameAvailabilityResult> CheckSignalRNameAvailability(AzureLocation location, SignalRNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = SignalRClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckSignalRNameAvailability");
            scope.Start();
            try
            {
                var response = SignalRRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/signalR</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SignalRResource> GetSignalRsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SignalRRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SignalRRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SignalRResource(Client, SignalRData.DeserializeSignalRData(e)), SignalRClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSignalRs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/signalR</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SignalRResource> GetSignalRs(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SignalRRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SignalRRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SignalRResource(Client, SignalRData.DeserializeSignalRData(e)), SignalRClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSignalRs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List resource usage quotas by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the location like "eastus". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SignalRUsage> GetUsagesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SignalRUsage.DeserializeSignalRUsage, UsagesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List resource usage quotas by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the location like "eastus". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SignalRUsage> GetUsages(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SignalRUsage.DeserializeSignalRUsage, UsagesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUsages", "value", "nextLink", cancellationToken);
        }
    }
}
