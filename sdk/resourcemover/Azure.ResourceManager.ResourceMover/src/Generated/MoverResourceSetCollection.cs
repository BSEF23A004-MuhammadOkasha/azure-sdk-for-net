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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceMover
{
    /// <summary>
    /// A class representing a collection of <see cref="MoverResourceSetResource" /> and their operations.
    /// Each <see cref="MoverResourceSetResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="MoverResourceSetCollection" /> instance call the GetMoverResourceSets method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class MoverResourceSetCollection : ArmCollection, IEnumerable<MoverResourceSetResource>, IAsyncEnumerable<MoverResourceSetResource>
    {
        private readonly ClientDiagnostics _moverResourceSetMoveCollectionsClientDiagnostics;
        private readonly MoveCollectionsRestOperations _moverResourceSetMoveCollectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MoverResourceSetCollection"/> class for mocking. </summary>
        protected MoverResourceSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MoverResourceSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MoverResourceSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _moverResourceSetMoveCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceMover", MoverResourceSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MoverResourceSetResource.ResourceType, out string moverResourceSetMoveCollectionsApiVersion);
            _moverResourceSetMoveCollectionsRestClient = new MoveCollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, moverResourceSetMoveCollectionsApiVersion);
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
        /// Creates or updates a move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}
        /// Operation Id: MoveCollections_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="data"> The MoverResourceSet to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MoverResourceSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string moverResourceSetName, MoverResourceSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _moverResourceSetMoveCollectionsRestClient.CreateAsync(moverResourceSetName, Id.SubscriptionId, Id.ResourceGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceMoverArmOperation<MoverResourceSetResource>(Response.FromValue(new MoverResourceSetResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}
        /// Operation Id: MoveCollections_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="data"> The MoverResourceSet to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MoverResourceSetResource> CreateOrUpdate(WaitUntil waitUntil, string moverResourceSetName, MoverResourceSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _moverResourceSetMoveCollectionsRestClient.Create(moverResourceSetName, Id.SubscriptionId, Id.ResourceGroupName, data, cancellationToken);
                var operation = new ResourceMoverArmOperation<MoverResourceSetResource>(Response.FromValue(new MoverResourceSetResource(Client, response), response.GetRawResponse()));
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
        /// Gets the move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}
        /// Operation Id: MoveCollections_Get
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual async Task<Response<MoverResourceSetResource>> GetAsync(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _moverResourceSetMoveCollectionsRestClient.GetAsync(moverResourceSetName, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoverResourceSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}
        /// Operation Id: MoveCollections_Get
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual Response<MoverResourceSetResource> Get(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Get");
            scope.Start();
            try
            {
                var response = _moverResourceSetMoveCollectionsRestClient.Get(moverResourceSetName, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoverResourceSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the Move Collections in the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections
        /// Operation Id: MoveCollections_ListMoveCollectionsByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MoverResourceSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MoverResourceSetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MoverResourceSetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _moverResourceSetMoveCollectionsRestClient.ListMoveCollectionsByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MoverResourceSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MoverResourceSetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _moverResourceSetMoveCollectionsRestClient.ListMoveCollectionsByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MoverResourceSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get all the Move Collections in the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections
        /// Operation Id: MoveCollections_ListMoveCollectionsByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MoverResourceSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MoverResourceSetResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MoverResourceSetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _moverResourceSetMoveCollectionsRestClient.ListMoveCollectionsByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MoverResourceSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MoverResourceSetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _moverResourceSetMoveCollectionsRestClient.ListMoveCollectionsByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MoverResourceSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}
        /// Operation Id: MoveCollections_Get
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _moverResourceSetMoveCollectionsRestClient.GetAsync(moverResourceSetName, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}
        /// Operation Id: MoveCollections_Get
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _moverResourceSetMoveCollectionsRestClient.Get(moverResourceSetName, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MoverResourceSetResource> IEnumerable<MoverResourceSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MoverResourceSetResource> IAsyncEnumerable<MoverResourceSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
