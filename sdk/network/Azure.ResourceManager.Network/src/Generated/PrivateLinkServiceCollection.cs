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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of PrivateLinkService and their operations over its parent. </summary>
    public partial class PrivateLinkServiceCollection : ArmCollection, IEnumerable<PrivateLinkService>, IAsyncEnumerable<PrivateLinkService>
    {
        private readonly ClientDiagnostics _privateLinkServiceClientDiagnostics;
        private readonly PrivateLinkServicesRestOperations _privateLinkServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class for mocking. </summary>
        protected PrivateLinkServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateLinkServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateLinkServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PrivateLinkService.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(PrivateLinkService.ResourceType, out string privateLinkServiceApiVersion);
            _privateLinkServiceRestClient = new PrivateLinkServicesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, privateLinkServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an private link service in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateLinkService>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceName, PrivateLinkServiceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PrivateLinkService>(new PrivateLinkServiceOperationSource(Client), _privateLinkServiceClientDiagnostics, Pipeline, _privateLinkServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an private link service in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<PrivateLinkService> CreateOrUpdate(WaitUntil waitUntil, string serviceName, PrivateLinkServiceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<PrivateLinkService>(new PrivateLinkServiceOperationSource(Client), _privateLinkServiceClientDiagnostics, Pipeline, _privateLinkServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified private link service by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_Get
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<PrivateLinkService>> GetAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private link service by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_Get
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<PrivateLinkService> Get(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all private link services in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices
        /// Operation Id: PrivateLinkServices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateLinkService> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateLinkService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkServiceRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateLinkService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkServiceRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all private link services in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices
        /// Operation Id: PrivateLinkServices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateLinkService> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateLinkService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkServiceRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateLinkService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkServiceRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_Get
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serviceName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_Get
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serviceName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_Get
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<PrivateLinkService>> GetIfExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PrivateLinkService>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}
        /// Operation Id: PrivateLinkServices_Get
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<PrivateLinkService> GetIfExists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PrivateLinkService>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateLinkService> IEnumerable<PrivateLinkService>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateLinkService> IAsyncEnumerable<PrivateLinkService>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
