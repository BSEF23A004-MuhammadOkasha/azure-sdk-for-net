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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiResource" /> and their operations.
    /// Each <see cref="ApiResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiCollection" /> instance call the GetApis method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiCollection : ArmCollection, IEnumerable<ApiResource>, IAsyncEnumerable<ApiResource>
    {
        private readonly ClientDiagnostics _apiClientDiagnostics;
        private readonly ApiRestOperations _apiRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiCollection"/> class for mocking. </summary>
        protected ApiCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiResource.ResourceType, out string apiApiVersion);
            _apiRestClient = new ApiRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates new or updates existing specified API of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
        /// Operation Id: Api_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="content"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string apiId, ApiCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiResource>(new ApiOperationSource(Client), _apiClientDiagnostics, Pipeline, _apiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates new or updates existing specified API of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
        /// Operation Id: Api_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="content"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiResource> CreateOrUpdate(WaitUntil waitUntil, string apiId, ApiCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiResource>(new ApiOperationSource(Client), _apiClientDiagnostics, Pipeline, _apiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, content, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
        /// Operation Id: Api_Get
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<Response<ApiResource>> GetAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
        /// Operation Id: Api_Get
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual Response<ApiResource> Get(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Get");
            scope.Start();
            try
            {
                var response = _apiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all APIs of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis
        /// Operation Id: Api_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| serviceUrl | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| path | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| isCurrent | filter | eq, ne |  |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="tags"> Include tags in the response. </param>
        /// <param name="expandApiVersionSet"> Include full ApiVersionSet resource in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, string tags = null, bool? expandApiVersionSet = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all APIs of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis
        /// Operation Id: Api_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| serviceUrl | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| path | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| isCurrent | filter | eq, ne |  |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="tags"> Include tags in the response. </param>
        /// <param name="expandApiVersionSet"> Include full ApiVersionSet resource in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiResource> GetAll(string filter = null, int? top = null, int? skip = null, string tags = null, bool? expandApiVersionSet = null, CancellationToken cancellationToken = default)
        {
            Page<ApiResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, tags, expandApiVersionSet, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
        /// Operation Id: Api_Get
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
        /// Operation Id: Api_Get
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual Response<bool> Exists(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiClientDiagnostics.CreateScope("ApiCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiResource> IEnumerable<ApiResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiResource> IAsyncEnumerable<ApiResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
