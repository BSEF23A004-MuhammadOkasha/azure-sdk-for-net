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

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="CapacityPoolResource"/> and their operations.
    /// Each <see cref="CapacityPoolResource"/> in the collection will belong to the same instance of <see cref="NetAppAccountResource"/>.
    /// To get a <see cref="CapacityPoolCollection"/> instance call the GetCapacityPools method from an instance of <see cref="NetAppAccountResource"/>.
    /// </summary>
    public partial class CapacityPoolCollection : ArmCollection, IEnumerable<CapacityPoolResource>, IAsyncEnumerable<CapacityPoolResource>
    {
        private readonly ClientDiagnostics _capacityPoolPoolsClientDiagnostics;
        private readonly PoolsRestOperations _capacityPoolPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CapacityPoolCollection"/> class for mocking. </summary>
        protected CapacityPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CapacityPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CapacityPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _capacityPoolPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", CapacityPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CapacityPoolResource.ResourceType, out string capacityPoolPoolsApiVersion);
            _capacityPoolPoolsRestClient = new PoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, capacityPoolPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="data"> Capacity pool object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CapacityPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string poolName, CapacityPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _capacityPoolPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<CapacityPoolResource>(new CapacityPoolOperationSource(Client), _capacityPoolPoolsClientDiagnostics, Pipeline, _capacityPoolPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or Update a capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="data"> Capacity pool object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CapacityPoolResource> CreateOrUpdate(WaitUntil waitUntil, string poolName, CapacityPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _capacityPoolPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken);
                var operation = new NetAppArmOperation<CapacityPoolResource>(new CapacityPoolOperationSource(Client), _capacityPoolPoolsClientDiagnostics, Pipeline, _capacityPoolPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get details of the specified capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<CapacityPoolResource>> GetAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _capacityPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of the specified capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<CapacityPoolResource> Get(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _capacityPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all capacity pools in the NetApp Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CapacityPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CapacityPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _capacityPoolPoolsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _capacityPoolPoolsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CapacityPoolResource(Client, CapacityPoolData.DeserializeCapacityPoolData(e)), _capacityPoolPoolsClientDiagnostics, Pipeline, "CapacityPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all capacity pools in the NetApp Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CapacityPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CapacityPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _capacityPoolPoolsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _capacityPoolPoolsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CapacityPoolResource(Client, CapacityPoolData.DeserializeCapacityPoolData(e)), _capacityPoolPoolsClientDiagnostics, Pipeline, "CapacityPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _capacityPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<bool> Exists(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _capacityPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<NullableResponse<CapacityPoolResource>> GetIfExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _capacityPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CapacityPoolResource>(response.GetRawResponse());
                return Response.FromValue(new CapacityPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual NullableResponse<CapacityPoolResource> GetIfExists(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _capacityPoolPoolsClientDiagnostics.CreateScope("CapacityPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _capacityPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CapacityPoolResource>(response.GetRawResponse());
                return Response.FromValue(new CapacityPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CapacityPoolResource> IEnumerable<CapacityPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CapacityPoolResource> IAsyncEnumerable<CapacityPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
