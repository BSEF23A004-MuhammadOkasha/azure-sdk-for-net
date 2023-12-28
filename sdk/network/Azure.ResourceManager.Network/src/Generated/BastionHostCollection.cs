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
    /// A class representing a collection of <see cref="BastionHostResource"/> and their operations.
    /// Each <see cref="BastionHostResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="BastionHostCollection"/> instance call the GetBastionHosts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class BastionHostCollection : ArmCollection, IEnumerable<BastionHostResource>, IAsyncEnumerable<BastionHostResource>
    {
        private readonly ClientDiagnostics _bastionHostClientDiagnostics;
        private readonly BastionHostsRestOperations _bastionHostRestClient;

        /// <summary> Initializes a new instance of the <see cref="BastionHostCollection"/> class for mocking. </summary>
        protected BastionHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BastionHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BastionHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bastionHostClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BastionHostResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BastionHostResource.ResourceType, out string bastionHostApiVersion);
            _bastionHostRestClient = new BastionHostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bastionHostApiVersion);
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
        /// Creates or updates the specified Bastion Host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="data"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BastionHostResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string bastionHostName, BastionHostData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bastionHostRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BastionHostResource>(new BastionHostOperationSource(Client), _bastionHostClientDiagnostics, Pipeline, _bastionHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the specified Bastion Host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="data"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BastionHostResource> CreateOrUpdate(WaitUntil waitUntil, string bastionHostName, BastionHostData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bastionHostRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, data, cancellationToken);
                var operation = new NetworkArmOperation<BastionHostResource>(new BastionHostOperationSource(Client), _bastionHostClientDiagnostics, Pipeline, _bastionHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified Bastion Host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual async Task<Response<BastionHostResource>> GetAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _bastionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BastionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Bastion Host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<BastionHostResource> Get(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Get");
            scope.Start();
            try
            {
                var response = _bastionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BastionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Bastion Hosts in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BastionHostResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BastionHostResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _bastionHostRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _bastionHostRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BastionHostResource(Client, BastionHostData.DeserializeBastionHostData(e)), _bastionHostClientDiagnostics, Pipeline, "BastionHostCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Bastion Hosts in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BastionHostResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BastionHostResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _bastionHostRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _bastionHostRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BastionHostResource(Client, BastionHostData.DeserializeBastionHostData(e)), _bastionHostClientDiagnostics, Pipeline, "BastionHostCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await _bastionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<bool> Exists(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = _bastionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual async Task<NullableResponse<BastionHostResource>> GetIfExistsAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _bastionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BastionHostResource>(response.GetRawResponse());
                return Response.FromValue(new BastionHostResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BastionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/bastionHosts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual NullableResponse<BastionHostResource> GetIfExists(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _bastionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BastionHostResource>(response.GetRawResponse());
                return Response.FromValue(new BastionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BastionHostResource> IEnumerable<BastionHostResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BastionHostResource> IAsyncEnumerable<BastionHostResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
