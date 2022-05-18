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

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="InventoryItemResource" /> and their operations.
    /// Each <see cref="InventoryItemResource" /> in the collection will belong to the same instance of <see cref="ScVmmServerResource" />.
    /// To get an <see cref="InventoryItemCollection" /> instance call the GetInventoryItems method from an instance of <see cref="ScVmmServerResource" />.
    /// </summary>
    public partial class InventoryItemCollection : ArmCollection, IEnumerable<InventoryItemResource>, IAsyncEnumerable<InventoryItemResource>
    {
        private readonly ClientDiagnostics _inventoryItemClientDiagnostics;
        private readonly InventoryItemsRestOperations _inventoryItemRestClient;

        /// <summary> Initializes a new instance of the <see cref="InventoryItemCollection"/> class for mocking. </summary>
        protected InventoryItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InventoryItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal InventoryItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _inventoryItemClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ArcScVmm", InventoryItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(InventoryItemResource.ResourceType, out string inventoryItemApiVersion);
            _inventoryItemRestClient = new InventoryItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, inventoryItemApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ScVmmServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ScVmmServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update InventoryItem.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}
        /// Operation Id: InventoryItems_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual async Task<ArmOperation<InventoryItemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string inventoryItemName, InventoryItemData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemName, nameof(inventoryItemName));

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _inventoryItemRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ArcScVmmArmOperation<InventoryItemResource>(Response.FromValue(new InventoryItemResource(Client, response), response.GetRawResponse()));
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
        /// Create Or Update InventoryItem.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}
        /// Operation Id: InventoryItems_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual ArmOperation<InventoryItemResource> CreateOrUpdate(WaitUntil waitUntil, string inventoryItemName, InventoryItemData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemName, nameof(inventoryItemName));

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _inventoryItemRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, data, cancellationToken);
                var operation = new ArcScVmmArmOperation<InventoryItemResource>(Response.FromValue(new InventoryItemResource(Client, response), response.GetRawResponse()));
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
        /// Shows an inventory item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}
        /// Operation Id: InventoryItems_Get
        /// </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual async Task<Response<InventoryItemResource>> GetAsync(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemName, nameof(inventoryItemName));

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _inventoryItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Shows an inventory item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}
        /// Operation Id: InventoryItems_Get
        /// </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual Response<InventoryItemResource> Get(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemName, nameof(inventoryItemName));

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.Get");
            scope.Start();
            try
            {
                var response = _inventoryItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of inventoryItems in the given VMMServer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems
        /// Operation Id: InventoryItems_ListByVmmServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InventoryItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InventoryItemResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<InventoryItemResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inventoryItemRestClient.ListByVmmServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InventoryItemResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inventoryItemRestClient.ListByVmmServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns the list of inventoryItems in the given VMMServer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems
        /// Operation Id: InventoryItems_ListByVmmServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InventoryItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InventoryItemResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<InventoryItemResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inventoryItemRestClient.ListByVmmServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InventoryItemResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inventoryItemRestClient.ListByVmmServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}
        /// Operation Id: InventoryItems_Get
        /// </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemName, nameof(inventoryItemName));

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _inventoryItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemName}
        /// Operation Id: InventoryItems_Get
        /// </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemName, nameof(inventoryItemName));

            using var scope = _inventoryItemClientDiagnostics.CreateScope("InventoryItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _inventoryItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InventoryItemResource> IEnumerable<InventoryItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InventoryItemResource> IAsyncEnumerable<InventoryItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
