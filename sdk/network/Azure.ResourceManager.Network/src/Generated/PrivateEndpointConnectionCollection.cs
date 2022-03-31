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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="PrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="PrivateLinkServiceResource" />.
    /// To get a <see cref="PrivateEndpointConnectionCollection" /> instance call the GetPrivateEndpointConnections method from an instance of <see cref="PrivateLinkServiceResource" />.
    /// </summary>
    public partial class PrivateEndpointConnectionCollection : ArmCollection, IEnumerable<PrivateEndpointConnectionResource>, IAsyncEnumerable<PrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _privateEndpointConnectionPrivateLinkServicesClientDiagnostics;
        private readonly PrivateLinkServicesRestOperations _privateEndpointConnectionPrivateLinkServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected PrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionPrivateLinkServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateEndpointConnectionResource.ResourceType, out string privateEndpointConnectionPrivateLinkServicesApiVersion);
            _privateEndpointConnectionPrivateLinkServicesRestClient = new PrivateLinkServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateEndpointConnectionPrivateLinkServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateLinkServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateLinkServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approve or reject private end point connection for a private link service in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}
        /// Operation Id: PrivateLinkServices_UpdatePrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="data"> Parameters supplied to approve or reject the private end point connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string peConnectionName, PrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionPrivateLinkServicesRestClient.UpdatePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PrivateEndpointConnectionResource>(Response.FromValue(new PrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Approve or reject private end point connection for a private link service in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}
        /// Operation Id: PrivateLinkServices_UpdatePrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="data"> Parameters supplied to approve or reject the private end point connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string peConnectionName, PrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionPrivateLinkServicesRestClient.UpdatePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<PrivateEndpointConnectionResource>(Response.FromValue(new PrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Get the specific private end point connection by specific private link service in the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}
        /// Operation Id: PrivateLinkServices_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual async Task<Response<PrivateEndpointConnectionResource>> GetAsync(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specific private end point connection by specific private link service in the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}
        /// Operation Id: PrivateLinkServices_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual Response<PrivateEndpointConnectionResource> Get(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all private end point connections for a specific private link service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections
        /// Operation Id: PrivateLinkServices_ListPrivateEndpointConnections
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateEndpointConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionPrivateLinkServicesRestClient.ListPrivateEndpointConnectionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateEndpointConnectionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionPrivateLinkServicesRestClient.ListPrivateEndpointConnectionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all private end point connections for a specific private link service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections
        /// Operation Id: PrivateLinkServices_ListPrivateEndpointConnections
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateEndpointConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionPrivateLinkServicesRestClient.ListPrivateEndpointConnections(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateEndpointConnectionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionPrivateLinkServicesRestClient.ListPrivateEndpointConnectionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}
        /// Operation Id: PrivateLinkServices_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}
        /// Operation Id: PrivateLinkServices_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _privateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateEndpointConnectionResource> IEnumerable<PrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateEndpointConnectionResource> IAsyncEnumerable<PrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
