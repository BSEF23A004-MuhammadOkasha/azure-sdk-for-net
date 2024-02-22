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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkManagerResource"/> and their operations.
    /// Each <see cref="NetworkManagerResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkManagerCollection"/> instance call the GetNetworkManagers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkManagerCollection : ArmCollection, IEnumerable<NetworkManagerResource>, IAsyncEnumerable<NetworkManagerResource>
    {
        private readonly ClientDiagnostics _networkManagerClientDiagnostics;
        private readonly NetworkManagersRestOperations _networkManagerRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkManagerCollection"/> class for mocking. </summary>
        protected NetworkManagerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkManagerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkManagerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkManagerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkManagerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkManagerResource.ResourceType, out string networkManagerApiVersion);
            _networkManagerRestClient = new NetworkManagersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkManagerApiVersion);
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
        /// Creates or updates a Network Manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="data"> Parameters supplied to specify which network manager is. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkManagerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkManagerName, NetworkManagerData data, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkManagerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkManagerResource>(Response.FromValue(new NetworkManagerResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a Network Manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="data"> Parameters supplied to specify which network manager is. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkManagerResource> CreateOrUpdate(WaitUntil waitUntil, string networkManagerName, NetworkManagerData data, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkManagerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkManagerResource>(Response.FromValue(new NetworkManagerResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified Network Manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> is null. </exception>
        public virtual async Task<Response<NetworkManagerResource>> GetAsync(string networkManagerName, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkManagerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Network Manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> is null. </exception>
        public virtual Response<NetworkManagerResource> Get(string networkManagerName, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.Get");
            scope.Start();
            try
            {
                var response = _networkManagerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List network managers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkManagerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkManagerResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkManagerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkManagerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkManagerResource(Client, NetworkManagerData.DeserializeNetworkManagerData(e)), _networkManagerClientDiagnostics, Pipeline, "NetworkManagerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List network managers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkManagerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkManagerResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkManagerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkManagerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkManagerResource(Client, NetworkManagerData.DeserializeNetworkManagerData(e)), _networkManagerClientDiagnostics, Pipeline, "NetworkManagerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkManagerName, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkManagerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkManagerName, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkManagerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkManagerResource>> GetIfExistsAsync(string networkManagerName, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkManagerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkManagerResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkManagers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerName"/> is null. </exception>
        public virtual NullableResponse<NetworkManagerResource> GetIfExists(string networkManagerName, CancellationToken cancellationToken = default)
        {
            if (networkManagerName == null)
            {
                throw new ArgumentNullException(nameof(networkManagerName));
            }
            if (networkManagerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkManagerName));
            }

            using var scope = _networkManagerClientDiagnostics.CreateScope("NetworkManagerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkManagerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkManagerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkManagerResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkManagerResource> IEnumerable<NetworkManagerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkManagerResource> IAsyncEnumerable<NetworkManagerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
