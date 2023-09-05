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
    /// A class representing a collection of <see cref="IPGroupResource" /> and their operations.
    /// Each <see cref="IPGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="IPGroupCollection" /> instance call the GetIPGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class IPGroupCollection : ArmCollection, IEnumerable<IPGroupResource>, IAsyncEnumerable<IPGroupResource>
    {
        private readonly ClientDiagnostics _ipGroupIPGroupsClientDiagnostics;
        private readonly IpGroupsRestOperations _ipGroupIPGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IPGroupCollection"/> class for mocking. </summary>
        protected IPGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IPGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IPGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ipGroupIPGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", IPGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IPGroupResource.ResourceType, out string ipGroupIPGroupsApiVersion);
            _ipGroupIPGroupsRestClient = new IpGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ipGroupIPGroupsApiVersion);
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
        /// Creates or updates an ipGroups in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="data"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IPGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ipGroupsName, IPGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipGroupIPGroupsClientDiagnostics.CreateScope("IPGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipGroupIPGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<IPGroupResource>(new IPGroupOperationSource(Client), _ipGroupIPGroupsClientDiagnostics, Pipeline, _ipGroupIPGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an ipGroups in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="data"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IPGroupResource> CreateOrUpdate(WaitUntil waitUntil, string ipGroupsName, IPGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipGroupIPGroupsClientDiagnostics.CreateScope("IPGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipGroupIPGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data, cancellationToken);
                var operation = new NetworkArmOperation<IPGroupResource>(new IPGroupOperationSource(Client), _ipGroupIPGroupsClientDiagnostics, Pipeline, _ipGroupIPGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified ipGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual async Task<Response<IPGroupResource>> GetAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIPGroupsClientDiagnostics.CreateScope("IPGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _ipGroupIPGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified ipGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<IPGroupResource> Get(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIPGroupsClientDiagnostics.CreateScope("IPGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _ipGroupIPGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all IpGroups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IPGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IPGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ipGroupIPGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ipGroupIPGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IPGroupResource(Client, IPGroupData.DeserializeIPGroupData(e)), _ipGroupIPGroupsClientDiagnostics, Pipeline, "IPGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all IpGroups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IPGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IPGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ipGroupIPGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ipGroupIPGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IPGroupResource(Client, IPGroupData.DeserializeIPGroupData(e)), _ipGroupIPGroupsClientDiagnostics, Pipeline, "IPGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIPGroupsClientDiagnostics.CreateScope("IPGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ipGroupIPGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIPGroupsClientDiagnostics.CreateScope("IPGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _ipGroupIPGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IPGroupResource> IEnumerable<IPGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IPGroupResource> IAsyncEnumerable<IPGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
