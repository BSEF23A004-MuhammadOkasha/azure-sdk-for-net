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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricL2IsolationDomainResource" /> and their operations.
    /// Each <see cref="NetworkFabricL2IsolationDomainResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkFabricL2IsolationDomainCollection" /> instance call the GetNetworkFabricL2IsolationDomains method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkFabricL2IsolationDomainCollection : ArmCollection, IEnumerable<NetworkFabricL2IsolationDomainResource>, IAsyncEnumerable<NetworkFabricL2IsolationDomainResource>
    {
        private readonly ClientDiagnostics _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics;
        private readonly L2IsolationDomainsRestOperations _networkFabricL2IsolationDomainL2IsolationDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricL2IsolationDomainCollection"/> class for mocking. </summary>
        protected NetworkFabricL2IsolationDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricL2IsolationDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricL2IsolationDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricL2IsolationDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricL2IsolationDomainResource.ResourceType, out string networkFabricL2IsolationDomainL2IsolationDomainsApiVersion);
            _networkFabricL2IsolationDomainL2IsolationDomainsRestClient = new L2IsolationDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricL2IsolationDomainL2IsolationDomainsApiVersion);
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
        /// Creates layer 2 network connectivity between compute nodes within a rack and across racks.The configuration is applied on the devices only after the isolation domain is enabled.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricL2IsolationDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string l2IsolationDomainName, NetworkFabricL2IsolationDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricL2IsolationDomainResource>(new NetworkFabricL2IsolationDomainOperationSource(Client), _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics, Pipeline, _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates layer 2 network connectivity between compute nodes within a rack and across racks.The configuration is applied on the devices only after the isolation domain is enabled.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricL2IsolationDomainResource> CreateOrUpdate(WaitUntil waitUntil, string l2IsolationDomainName, NetworkFabricL2IsolationDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricL2IsolationDomainResource>(new NetworkFabricL2IsolationDomainOperationSource(Client), _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics, Pipeline, _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements L2 Isolation Domain GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricL2IsolationDomainResource>> GetAsync(string l2IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricL2IsolationDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements L2 Isolation Domain GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> is null. </exception>
        public virtual Response<NetworkFabricL2IsolationDomainResource> Get(string l2IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricL2IsolationDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Displays L2IsolationDomains list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricL2IsolationDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricL2IsolationDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricL2IsolationDomainResource(Client, NetworkFabricL2IsolationDomainData.DeserializeNetworkFabricL2IsolationDomainData(e)), _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics, Pipeline, "NetworkFabricL2IsolationDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Displays L2IsolationDomains list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricL2IsolationDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricL2IsolationDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricL2IsolationDomainResource(Client, NetworkFabricL2IsolationDomainData.DeserializeNetworkFabricL2IsolationDomainData(e)), _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics, Pipeline, "NetworkFabricL2IsolationDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string l2IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> is null. </exception>
        public virtual Response<bool> Exists(string l2IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFabricL2IsolationDomainResource>> GetIfExistsAsync(string l2IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricL2IsolationDomainResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricL2IsolationDomainResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l2IsolationDomains/{l2IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2IsolationDomainName"> Name of the L2 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2IsolationDomainName"/> is null. </exception>
        public virtual NullableResponse<NetworkFabricL2IsolationDomainResource> GetIfExists(string l2IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2IsolationDomainName, nameof(l2IsolationDomainName));

            using var scope = _networkFabricL2IsolationDomainL2IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL2IsolationDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFabricL2IsolationDomainL2IsolationDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l2IsolationDomainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricL2IsolationDomainResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricL2IsolationDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricL2IsolationDomainResource> IEnumerable<NetworkFabricL2IsolationDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricL2IsolationDomainResource> IAsyncEnumerable<NetworkFabricL2IsolationDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
