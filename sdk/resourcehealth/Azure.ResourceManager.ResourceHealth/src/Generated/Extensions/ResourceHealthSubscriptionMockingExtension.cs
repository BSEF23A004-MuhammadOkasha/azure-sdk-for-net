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
using Azure.ResourceManager.ResourceHealth;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class ResourceHealthSubscriptionMockingExtension : ArmResource
    {
        private ClientDiagnostics _availabilityStatusesClientDiagnostics;
        private AvailabilityStatusesRestOperations _availabilityStatusesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthSubscriptionMockingExtension"/> class for mocking. </summary>
        protected ResourceHealthSubscriptionMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthSubscriptionMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceHealthSubscriptionMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AvailabilityStatusesClientDiagnostics => _availabilityStatusesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailabilityStatusesRestOperations AvailabilityStatusesRestClient => _availabilityStatusesRestClient ??= new AvailabilityStatusesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ResourceHealthEventResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of ResourceHealthEventResources and their operations over a ResourceHealthEventResource. </returns>
        public virtual ResourceHealthEventCollection GetResourceHealthEvents()
        {
            return GetCachedClient(Client => new ResourceHealthEventCollection(Client, Id));
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ResourceHealthEventResource>> GetResourceHealthEventAsync(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            return await GetResourceHealthEvents().GetAsync(eventTrackingId, filter, queryStartTime, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ResourceHealthEventResource> GetResourceHealthEvent(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            return GetResourceHealthEvents().Get(eventTrackingId, filter, queryStartTime, cancellationToken);
        }

        /// <summary>
        /// Lists the current availability status for all the resources in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/availabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesBySubscriptionAsync(string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailabilityStatusesRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailabilityStatusesRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, filter, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, AvailabilityStatusesClientDiagnostics, Pipeline, "ResourceHealthSubscriptionMockingExtension.GetAvailabilityStatusesBySubscription", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the current availability status for all the resources in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/availabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesBySubscription(string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailabilityStatusesRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailabilityStatusesRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, filter, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, AvailabilityStatusesClientDiagnostics, Pipeline, "ResourceHealthSubscriptionMockingExtension.GetAvailabilityStatusesBySubscription", "value", "nextLink", cancellationToken);
        }
    }
}
