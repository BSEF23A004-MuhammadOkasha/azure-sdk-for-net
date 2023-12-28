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

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudBareMetalMachineKeySetResource"/> and their operations.
    /// Each <see cref="NetworkCloudBareMetalMachineKeySetResource"/> in the collection will belong to the same instance of <see cref="NetworkCloudClusterResource"/>.
    /// To get a <see cref="NetworkCloudBareMetalMachineKeySetCollection"/> instance call the GetNetworkCloudBareMetalMachineKeySets method from an instance of <see cref="NetworkCloudClusterResource"/>.
    /// </summary>
    public partial class NetworkCloudBareMetalMachineKeySetCollection : ArmCollection, IEnumerable<NetworkCloudBareMetalMachineKeySetResource>, IAsyncEnumerable<NetworkCloudBareMetalMachineKeySetResource>
    {
        private readonly ClientDiagnostics _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics;
        private readonly BareMetalMachineKeySetsRestOperations _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudBareMetalMachineKeySetCollection"/> class for mocking. </summary>
        protected NetworkCloudBareMetalMachineKeySetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudBareMetalMachineKeySetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudBareMetalMachineKeySetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudBareMetalMachineKeySetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudBareMetalMachineKeySetResource.ResourceType, out string networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsApiVersion);
            _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient = new BareMetalMachineKeySetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkCloudClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkCloudClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new bare metal machine key set or update the existing one for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudBareMetalMachineKeySetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string bareMetalMachineKeySetName, NetworkCloudBareMetalMachineKeySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudBareMetalMachineKeySetResource>(new NetworkCloudBareMetalMachineKeySetOperationSource(Client), _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics, Pipeline, _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new bare metal machine key set or update the existing one for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudBareMetalMachineKeySetResource> CreateOrUpdate(WaitUntil waitUntil, string bareMetalMachineKeySetName, NetworkCloudBareMetalMachineKeySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudBareMetalMachineKeySetResource>(new NetworkCloudBareMetalMachineKeySetOperationSource(Client), _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics, Pipeline, _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get bare metal machine key set of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudBareMetalMachineKeySetResource>> GetAsync(string bareMetalMachineKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBareMetalMachineKeySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get bare metal machine key set of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> is null. </exception>
        public virtual Response<NetworkCloudBareMetalMachineKeySetResource> Get(string bareMetalMachineKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBareMetalMachineKeySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of bare metal machine key sets for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudBareMetalMachineKeySetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudBareMetalMachineKeySetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudBareMetalMachineKeySetResource(Client, NetworkCloudBareMetalMachineKeySetData.DeserializeNetworkCloudBareMetalMachineKeySetData(e)), _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics, Pipeline, "NetworkCloudBareMetalMachineKeySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of bare metal machine key sets for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudBareMetalMachineKeySetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudBareMetalMachineKeySetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudBareMetalMachineKeySetResource(Client, NetworkCloudBareMetalMachineKeySetData.DeserializeNetworkCloudBareMetalMachineKeySetData(e)), _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics, Pipeline, "NetworkCloudBareMetalMachineKeySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bareMetalMachineKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> is null. </exception>
        public virtual Response<bool> Exists(string bareMetalMachineKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudBareMetalMachineKeySetResource>> GetIfExistsAsync(string bareMetalMachineKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudBareMetalMachineKeySetResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBareMetalMachineKeySetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bareMetalMachineKeySets/{bareMetalMachineKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachineKeySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetworkCloud/clusters/bareMetalMachineKeySets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineKeySetName"> The name of the bare metal machine key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineKeySetName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudBareMetalMachineKeySetResource> GetIfExists(string bareMetalMachineKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineKeySetName, nameof(bareMetalMachineKeySetName));

            using var scope = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineKeySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudBareMetalMachineKeySetBareMetalMachineKeySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bareMetalMachineKeySetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudBareMetalMachineKeySetResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBareMetalMachineKeySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudBareMetalMachineKeySetResource> IEnumerable<NetworkCloudBareMetalMachineKeySetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudBareMetalMachineKeySetResource> IAsyncEnumerable<NetworkCloudBareMetalMachineKeySetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
