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
    /// <summary> A class representing collection of BgpConnection and their operations over its parent. </summary>
    public partial class BgpConnectionCollection : ArmCollection, IEnumerable<BgpConnectionResource>, IAsyncEnumerable<BgpConnectionResource>
    {
        private readonly ClientDiagnostics _bgpConnectionVirtualHubBgpConnectionClientDiagnostics;
        private readonly VirtualHubBgpConnectionRestOperations _bgpConnectionVirtualHubBgpConnectionRestClient;
        private readonly ClientDiagnostics _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics;
        private readonly VirtualHubBgpConnectionsRestOperations _bgpConnectionVirtualHubBgpConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BgpConnectionCollection"/> class for mocking. </summary>
        protected BgpConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BgpConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BgpConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bgpConnectionVirtualHubBgpConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BgpConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BgpConnectionResource.ResourceType, out string bgpConnectionVirtualHubBgpConnectionApiVersion);
            _bgpConnectionVirtualHubBgpConnectionRestClient = new VirtualHubBgpConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bgpConnectionVirtualHubBgpConnectionApiVersion);
            _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BgpConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BgpConnectionResource.ResourceType, out string bgpConnectionVirtualHubBgpConnectionsApiVersion);
            _bgpConnectionVirtualHubBgpConnectionsRestClient = new VirtualHubBgpConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bgpConnectionVirtualHubBgpConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a VirtualHubBgpConnection resource if it doesn&apos;t exist else updates the existing VirtualHubBgpConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="parameters"> Parameters of Bgp connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<BgpConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, BgpConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BgpConnectionResource>(new BgpConnectionOperationSource(Client), _bgpConnectionVirtualHubBgpConnectionClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VirtualHubBgpConnection resource if it doesn&apos;t exist else updates the existing VirtualHubBgpConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="parameters"> Parameters of Bgp connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<BgpConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, BgpConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<BgpConnectionResource>(new BgpConnectionOperationSource(Client), _bgpConnectionVirtualHubBgpConnectionClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a Virtual Hub Bgp Connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<BgpConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Bgp Connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<BgpConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all VirtualHubBgpConnections.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections
        /// Operation Id: VirtualHubBgpConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BgpConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BgpConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BgpConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bgpConnectionVirtualHubBgpConnectionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BgpConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BgpConnectionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bgpConnectionVirtualHubBgpConnectionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BgpConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieves the details of all VirtualHubBgpConnections.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections
        /// Operation Id: VirtualHubBgpConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BgpConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BgpConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BgpConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bgpConnectionVirtualHubBgpConnectionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BgpConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BgpConnectionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bgpConnectionVirtualHubBgpConnectionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BgpConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<BgpConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BgpConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<BgpConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BgpConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BgpConnectionResource> IEnumerable<BgpConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BgpConnectionResource> IAsyncEnumerable<BgpConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
