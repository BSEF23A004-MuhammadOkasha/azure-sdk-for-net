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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    /// <summary>
    /// A class representing a collection of <see cref="SearchServiceResource"/> and their operations.
    /// Each <see cref="SearchServiceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SearchServiceCollection"/> instance call the GetSearchServices method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SearchServiceCollection : ArmCollection, IEnumerable<SearchServiceResource>, IAsyncEnumerable<SearchServiceResource>
    {
        private readonly ClientDiagnostics _searchServiceServicesClientDiagnostics;
        private readonly ServicesRestOperations _searchServiceServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SearchServiceCollection"/> class for mocking. </summary>
        protected SearchServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SearchServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SearchServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _searchServiceServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Search", SearchServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SearchServiceResource.ResourceType, out string searchServiceServicesApiVersion);
            _searchServiceServicesRestClient = new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, searchServiceServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a search service in the given resource group. If the search service already exists, all properties will be updated with the given values.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service to create or update. Search service names must only contain lowercase letters, digits or dashes, cannot use dash as the first two or last one characters, cannot contain consecutive dashes, and must be between 2 and 60 characters in length. Search service names must be globally unique since they are part of the service URI (https://&lt;name&gt;.search.windows.net). You cannot change the service name after the service is created. </param>
        /// <param name="data"> The definition of the search service to create or update. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SearchServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string searchServiceName, SearchServiceData data, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _searchServiceServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, data, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
                var operation = new SearchArmOperation<SearchServiceResource>(new SearchServiceOperationSource(Client), _searchServiceServicesClientDiagnostics, Pipeline, _searchServiceServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, data, searchManagementRequestOptions).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a search service in the given resource group. If the search service already exists, all properties will be updated with the given values.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service to create or update. Search service names must only contain lowercase letters, digits or dashes, cannot use dash as the first two or last one characters, cannot contain consecutive dashes, and must be between 2 and 60 characters in length. Search service names must be globally unique since they are part of the service URI (https://&lt;name&gt;.search.windows.net). You cannot change the service name after the service is created. </param>
        /// <param name="data"> The definition of the search service to create or update. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SearchServiceResource> CreateOrUpdate(WaitUntil waitUntil, string searchServiceName, SearchServiceData data, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _searchServiceServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, data, searchManagementRequestOptions, cancellationToken);
                var operation = new SearchArmOperation<SearchServiceResource>(new SearchServiceOperationSource(Client), _searchServiceServicesClientDiagnostics, Pipeline, _searchServiceServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, data, searchManagementRequestOptions).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the search service with the given name in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        public virtual async Task<Response<SearchServiceResource>> GetAsync(string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _searchServiceServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SearchServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the search service with the given name in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        public virtual Response<SearchServiceResource> Get(string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _searchServiceServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, searchManagementRequestOptions, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SearchServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all Search services in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SearchServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SearchServiceResource> GetAllAsync(SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _searchServiceServicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _searchServiceServicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SearchServiceResource(Client, SearchServiceData.DeserializeSearchServiceData(e)), _searchServiceServicesClientDiagnostics, Pipeline, "SearchServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Search services in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SearchServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SearchServiceResource> GetAll(SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _searchServiceServicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _searchServiceServicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SearchServiceResource(Client, SearchServiceData.DeserializeSearchServiceData(e)), _searchServiceServicesClientDiagnostics, Pipeline, "SearchServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _searchServiceServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, searchManagementRequestOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _searchServiceServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, searchManagementRequestOptions, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<SearchServiceResource>> GetIfExistsAsync(string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _searchServiceServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, searchManagementRequestOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SearchServiceResource>(response.GetRawResponse());
                return Response.FromValue(new SearchServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        public virtual NullableResponse<SearchServiceResource> GetIfExists(string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var scope = _searchServiceServicesClientDiagnostics.CreateScope("SearchServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _searchServiceServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, searchServiceName, searchManagementRequestOptions, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SearchServiceResource>(response.GetRawResponse());
                return Response.FromValue(new SearchServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SearchServiceResource> IEnumerable<SearchServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SearchServiceResource> IAsyncEnumerable<SearchServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
