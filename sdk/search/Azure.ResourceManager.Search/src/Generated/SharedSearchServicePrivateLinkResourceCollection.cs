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
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    /// <summary>
    /// A class representing a collection of <see cref="SharedSearchServicePrivateLinkResource"/> and their operations.
    /// Each <see cref="SharedSearchServicePrivateLinkResource"/> in the collection will belong to the same instance of <see cref="SearchServiceResource"/>.
    /// To get a <see cref="SharedSearchServicePrivateLinkResourceCollection"/> instance call the GetSharedSearchServicePrivateLinkResources method from an instance of <see cref="SearchServiceResource"/>.
    /// </summary>
    public partial class SharedSearchServicePrivateLinkResourceCollection : ArmCollection, IEnumerable<SharedSearchServicePrivateLinkResource>, IAsyncEnumerable<SharedSearchServicePrivateLinkResource>
    {
        private readonly ClientDiagnostics _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics;
        private readonly SharedPrivateLinkResourcesRestOperations _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedSearchServicePrivateLinkResourceCollection"/> class for mocking. </summary>
        protected SharedSearchServicePrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedSearchServicePrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SharedSearchServicePrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Search", SharedSearchServicePrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SharedSearchServicePrivateLinkResource.ResourceType, out string sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesApiVersion);
            _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient = new SharedPrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SearchServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SearchServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Initiates the creation or update of a shared private link resource managed by the search service in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="data"> The definition of the shared private link resource to create or update. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SharedSearchServicePrivateLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SharedSearchServicePrivateLinkResourceData data, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
                var operation = new SearchArmOperation<SharedSearchServicePrivateLinkResource>(new SharedSearchServicePrivateLinkResourceOperationSource(Client), _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, searchManagementRequestOptions).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Initiates the creation or update of a shared private link resource managed by the search service in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="data"> The definition of the shared private link resource to create or update. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SharedSearchServicePrivateLinkResource> CreateOrUpdate(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SharedSearchServicePrivateLinkResourceData data, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, searchManagementRequestOptions, cancellationToken);
                var operation = new SearchArmOperation<SharedSearchServicePrivateLinkResource>(new SharedSearchServicePrivateLinkResourceOperationSource(Client), _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, searchManagementRequestOptions).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the details of the shared private link resource managed by the search service in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<SharedSearchServicePrivateLinkResource>> GetAsync(string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedSearchServicePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the shared private link resource managed by the search service in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<SharedSearchServicePrivateLinkResource> Get(string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, searchManagementRequestOptions, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedSearchServicePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all shared private link resources managed by the given service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedSearchServicePrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedSearchServicePrivateLinkResource> GetAllAsync(SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SharedSearchServicePrivateLinkResource(Client, SharedSearchServicePrivateLinkResourceData.DeserializeSharedSearchServicePrivateLinkResourceData(e)), _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, "SharedSearchServicePrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all shared private link resources managed by the given service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedSearchServicePrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedSearchServicePrivateLinkResource> GetAll(SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, searchManagementRequestOptions);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, searchManagementRequestOptions);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SharedSearchServicePrivateLinkResource(Client, SharedSearchServicePrivateLinkResourceData.DeserializeSharedSearchServicePrivateLinkResourceData(e)), _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, "SharedSearchServicePrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, searchManagementRequestOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, searchManagementRequestOptions, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<SharedSearchServicePrivateLinkResource>> GetIfExistsAsync(string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, searchManagementRequestOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SharedSearchServicePrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SharedSearchServicePrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual NullableResponse<SharedSearchServicePrivateLinkResource> GetIfExists(string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedSearchServicePrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sharedSearchServicePrivateLinkResourceSharedPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, searchManagementRequestOptions, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SharedSearchServicePrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SharedSearchServicePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedSearchServicePrivateLinkResource> IEnumerable<SharedSearchServicePrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedSearchServicePrivateLinkResource> IAsyncEnumerable<SharedSearchServicePrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
