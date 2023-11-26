// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="DomainTopicResource"/> and their operations.
    /// Each <see cref="DomainTopicResource"/> in the collection will belong to the same instance of <see cref="EventGridDomainResource"/>.
    /// To get a <see cref="DomainTopicCollection"/> instance call the GetDomainTopics method from an instance of <see cref="EventGridDomainResource"/>.
    /// </summary>
    public partial class DomainTopicCollection : ArmCollection, IEnumerable<DomainTopicResource>, IAsyncEnumerable<DomainTopicResource>
    {
        private readonly ClientDiagnostics _domainTopicClientDiagnostics;
        private readonly DomainTopicsRestOperations _domainTopicRestClient;

        /// <summary> Initializes a new instance of the <see cref="DomainTopicCollection"/> class for mocking. </summary>
        protected DomainTopicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DomainTopicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DomainTopicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _domainTopicClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", DomainTopicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DomainTopicResource.ResourceType, out string domainTopicApiVersion);
            _domainTopicRestClient = new DomainTopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, domainTopicApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventGridDomainResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventGridDomainResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Asynchronously creates or updates a new domain topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainTopicName"> Name of the domain topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual async Task<ArmOperation<DomainTopicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _domainTopicRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<DomainTopicResource>(new DomainTopicOperationSource(Client), _domainTopicClientDiagnostics, Pipeline, _domainTopicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName).Request, response, OperationFinalStateVia.Location);
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
        /// Asynchronously creates or updates a new domain topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainTopicName"> Name of the domain topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual ArmOperation<DomainTopicResource> CreateOrUpdate(WaitUntil waitUntil, string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _domainTopicRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken);
                var operation = new EventGridArmOperation<DomainTopicResource>(new DomainTopicOperationSource(Client), _domainTopicClientDiagnostics, Pipeline, _domainTopicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName).Request, response, OperationFinalStateVia.Location);
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
        /// Get properties of a domain topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainTopicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual async Task<Response<DomainTopicResource>> GetAsync(string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.Get");
            scope.Start();
            try
            {
                var response = await _domainTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a domain topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainTopicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual Response<DomainTopicResource> Get(string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.Get");
            scope.Start();
            try
            {
                var response = _domainTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the topics in a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_ListByDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DomainTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DomainTopicResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainTopicRestClient.CreateListByDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainTopicRestClient.CreateListByDomainNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DomainTopicResource(Client, DomainTopicData.DeserializeDomainTopicData(e)), _domainTopicClientDiagnostics, Pipeline, "DomainTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the topics in a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_ListByDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DomainTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DomainTopicResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainTopicRestClient.CreateListByDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainTopicRestClient.CreateListByDomainNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DomainTopicResource(Client, DomainTopicData.DeserializeDomainTopicData(e)), _domainTopicClientDiagnostics, Pipeline, "DomainTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainTopicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _domainTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainTopicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = _domainTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainTopicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual async Task<NullableResponse<DomainTopicResource>> GetIfExistsAsync(string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _domainTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DomainTopicResource>(response.GetRawResponse());
                return Response.FromValue(new DomainTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{domainTopicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainTopicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainTopicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainTopicName"/> is null. </exception>
        public virtual NullableResponse<DomainTopicResource> GetIfExists(string domainTopicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainTopicName, nameof(domainTopicName));

            using var scope = _domainTopicClientDiagnostics.CreateScope("DomainTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _domainTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainTopicName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DomainTopicResource>(response.GetRawResponse());
                return Response.FromValue(new DomainTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DomainTopicResource> IEnumerable<DomainTopicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DomainTopicResource> IAsyncEnumerable<DomainTopicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
