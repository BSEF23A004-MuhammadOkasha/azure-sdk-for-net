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
    /// A class representing a collection of <see cref="ApiManagementIdentityProviderResource" /> and their operations.
    /// Each <see cref="ApiManagementIdentityProviderResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementIdentityProviderCollection" /> instance call the GetApiManagementIdentityProviders method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementIdentityProviderCollection : ArmCollection, IEnumerable<ApiManagementIdentityProviderResource>, IAsyncEnumerable<ApiManagementIdentityProviderResource>
    {
        private readonly ClientDiagnostics _apiManagementIdentityProviderIdentityProviderClientDiagnostics;
        private readonly IdentityProviderRestOperations _apiManagementIdentityProviderIdentityProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementIdentityProviderCollection"/> class for mocking. </summary>
        protected ApiManagementIdentityProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementIdentityProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementIdentityProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementIdentityProviderIdentityProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementIdentityProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementIdentityProviderResource.ResourceType, out string apiManagementIdentityProviderIdentityProviderApiVersion);
            _apiManagementIdentityProviderIdentityProviderRestClient = new IdentityProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementIdentityProviderIdentityProviderApiVersion);
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
        /// Creates or Updates the IdentityProvider configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders/{identityProviderName}
        /// Operation Id: IdentityProvider_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="identityProviderName"> Identity Provider Type identifier. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementIdentityProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, IdentityProviderType identityProviderName, ApiManagementIdentityProviderCreateOrUpdateContent content, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementIdentityProviderIdentityProviderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, identityProviderName, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementIdentityProviderResource>(Response.FromValue(new ApiManagementIdentityProviderResource(Client, response), response.GetRawResponse()));
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
        /// Creates or Updates the IdentityProvider configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders/{identityProviderName}
        /// Operation Id: IdentityProvider_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="identityProviderName"> Identity Provider Type identifier. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementIdentityProviderResource> CreateOrUpdate(WaitUntil waitUntil, IdentityProviderType identityProviderName, ApiManagementIdentityProviderCreateOrUpdateContent content, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementIdentityProviderIdentityProviderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, identityProviderName, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementIdentityProviderResource>(Response.FromValue(new ApiManagementIdentityProviderResource(Client, response), response.GetRawResponse()));
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
        /// Gets the configuration details of the identity Provider configured in specified service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders/{identityProviderName}
        /// Operation Id: IdentityProvider_Get
        /// </summary>
        /// <param name="identityProviderName"> Identity Provider Type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementIdentityProviderResource>> GetAsync(IdentityProviderType identityProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementIdentityProviderIdentityProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, identityProviderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIdentityProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the configuration details of the identity Provider configured in specified service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders/{identityProviderName}
        /// Operation Id: IdentityProvider_Get
        /// </summary>
        /// <param name="identityProviderName"> Identity Provider Type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementIdentityProviderResource> Get(IdentityProviderType identityProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementIdentityProviderIdentityProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, identityProviderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIdentityProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of Identity Provider configured in the specified service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders
        /// Operation Id: IdentityProvider_ListByService
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementIdentityProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementIdentityProviderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementIdentityProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementIdentityProviderIdentityProviderRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementIdentityProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementIdentityProviderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementIdentityProviderIdentityProviderRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementIdentityProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists a collection of Identity Provider configured in the specified service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders
        /// Operation Id: IdentityProvider_ListByService
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementIdentityProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementIdentityProviderResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApiManagementIdentityProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementIdentityProviderIdentityProviderRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementIdentityProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementIdentityProviderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementIdentityProviderIdentityProviderRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementIdentityProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders/{identityProviderName}
        /// Operation Id: IdentityProvider_Get
        /// </summary>
        /// <param name="identityProviderName"> Identity Provider Type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(IdentityProviderType identityProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementIdentityProviderIdentityProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, identityProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/identityProviders/{identityProviderName}
        /// Operation Id: IdentityProvider_Get
        /// </summary>
        /// <param name="identityProviderName"> Identity Provider Type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(IdentityProviderType identityProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementIdentityProviderIdentityProviderClientDiagnostics.CreateScope("ApiManagementIdentityProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementIdentityProviderIdentityProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, identityProviderName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementIdentityProviderResource> IEnumerable<ApiManagementIdentityProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementIdentityProviderResource> IAsyncEnumerable<ApiManagementIdentityProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
