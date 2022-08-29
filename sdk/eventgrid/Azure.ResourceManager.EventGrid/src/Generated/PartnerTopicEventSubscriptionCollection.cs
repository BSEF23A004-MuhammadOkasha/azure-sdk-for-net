// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="PartnerTopicEventSubscriptionResource" /> and their operations.
    /// Each <see cref="PartnerTopicEventSubscriptionResource" /> in the collection will belong to the same instance of <see cref="PartnerTopicResource" />.
    /// To get a <see cref="PartnerTopicEventSubscriptionCollection" /> instance call the GetPartnerTopicEventSubscriptions method from an instance of <see cref="PartnerTopicResource" />.
    /// </summary>
    public partial class PartnerTopicEventSubscriptionCollection : ArmCollection, IEnumerable<PartnerTopicEventSubscriptionResource>, IAsyncEnumerable<PartnerTopicEventSubscriptionResource>
    {
        private readonly ClientDiagnostics _partnerTopicEventSubscriptionClientDiagnostics;
        private readonly PartnerTopicEventSubscriptionsRestOperations _partnerTopicEventSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="PartnerTopicEventSubscriptionCollection"/> class for mocking. </summary>
        protected PartnerTopicEventSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerTopicEventSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PartnerTopicEventSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _partnerTopicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", PartnerTopicEventSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PartnerTopicEventSubscriptionResource.ResourceType, out string partnerTopicEventSubscriptionApiVersion);
            _partnerTopicEventSubscriptionRestClient = new PartnerTopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, partnerTopicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PartnerTopicResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PartnerTopicResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Asynchronously creates or updates an event subscription of a partner topic with the specified parameters. Existing event subscriptions will be updated with this API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: PartnerTopicEventSubscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PartnerTopicEventSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string eventSubscriptionName, EventSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _partnerTopicEventSubscriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<PartnerTopicEventSubscriptionResource>(new PartnerTopicEventSubscriptionOperationSource(Client), _partnerTopicEventSubscriptionClientDiagnostics, Pipeline, _partnerTopicEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Asynchronously creates or updates an event subscription of a partner topic with the specified parameters. Existing event subscriptions will be updated with this API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: PartnerTopicEventSubscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PartnerTopicEventSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string eventSubscriptionName, EventSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _partnerTopicEventSubscriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data, cancellationToken);
                var operation = new EventGridArmOperation<PartnerTopicEventSubscriptionResource>(new PartnerTopicEventSubscriptionOperationSource(Client), _partnerTopicEventSubscriptionClientDiagnostics, Pipeline, _partnerTopicEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of an event subscription of a partner topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: PartnerTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<PartnerTopicEventSubscriptionResource>> GetAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _partnerTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of an event subscription of a partner topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: PartnerTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<PartnerTopicEventSubscriptionResource> Get(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _partnerTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List event subscriptions that belong to a specific partner topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions
        /// Operation Id: PartnerTopicEventSubscriptions_ListByPartnerTopic
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the &apos;name&apos; property only and with limited number of OData operations. These operations are: the &apos;contains&apos; function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, &apos;PATTERN&apos;) and name ne &apos;PATTERN-1&apos;. The following is not a valid filter example: $filter=location eq &apos;westus&apos;. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PartnerTopicEventSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PartnerTopicEventSubscriptionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PartnerTopicEventSubscriptionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _partnerTopicEventSubscriptionRestClient.ListByPartnerTopicAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PartnerTopicEventSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PartnerTopicEventSubscriptionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _partnerTopicEventSubscriptionRestClient.ListByPartnerTopicNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PartnerTopicEventSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List event subscriptions that belong to a specific partner topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions
        /// Operation Id: PartnerTopicEventSubscriptions_ListByPartnerTopic
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the &apos;name&apos; property only and with limited number of OData operations. These operations are: the &apos;contains&apos; function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, &apos;PATTERN&apos;) and name ne &apos;PATTERN-1&apos;. The following is not a valid filter example: $filter=location eq &apos;westus&apos;. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PartnerTopicEventSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PartnerTopicEventSubscriptionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<PartnerTopicEventSubscriptionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _partnerTopicEventSubscriptionRestClient.ListByPartnerTopic(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PartnerTopicEventSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PartnerTopicEventSubscriptionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _partnerTopicEventSubscriptionRestClient.ListByPartnerTopicNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PartnerTopicEventSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: PartnerTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _partnerTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerTopics/{partnerTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: PartnerTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _partnerTopicEventSubscriptionClientDiagnostics.CreateScope("PartnerTopicEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _partnerTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PartnerTopicEventSubscriptionResource> IEnumerable<PartnerTopicEventSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PartnerTopicEventSubscriptionResource> IAsyncEnumerable<PartnerTopicEventSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
