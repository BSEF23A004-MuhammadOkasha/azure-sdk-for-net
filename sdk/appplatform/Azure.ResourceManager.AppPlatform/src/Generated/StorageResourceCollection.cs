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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageResource" /> and their operations.
    /// Each <see cref="StorageResource" /> in the collection will belong to the same instance of <see cref="AppPlatformServiceResource" />.
    /// To get a <see cref="StorageResourceCollection" /> instance call the GetStorageResources method from an instance of <see cref="AppPlatformServiceResource" />.
    /// </summary>
    public partial class StorageResourceCollection : ArmCollection, IEnumerable<StorageResource>, IAsyncEnumerable<StorageResource>
    {
        private readonly ClientDiagnostics _storageResourceStoragesClientDiagnostics;
        private readonly StoragesRestOperations _storageResourceStoragesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageResourceCollection"/> class for mocking. </summary>
        protected StorageResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageResourceStoragesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", StorageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageResource.ResourceType, out string storageResourceStoragesApiVersion);
            _storageResourceStoragesRestClient = new StoragesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageResourceStoragesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update storage resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages/{storageName}
        /// Operation Id: Storages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> The name of the storage resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageName, StorageResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageResourceStoragesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<StorageResource>(new StorageResourceOperationSource(Client), _storageResourceStoragesClientDiagnostics, Pipeline, _storageResourceStoragesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update storage resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages/{storageName}
        /// Operation Id: Storages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> The name of the storage resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageResource> CreateOrUpdate(WaitUntil waitUntil, string storageName, StorageResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageResourceStoragesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<StorageResource>(new StorageResourceOperationSource(Client), _storageResourceStoragesClientDiagnostics, Pipeline, _storageResourceStoragesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the storage resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages/{storageName}
        /// Operation Id: Storages_Get
        /// </summary>
        /// <param name="storageName"> The name of the storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<StorageResource>> GetAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageResourceStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the storage resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages/{storageName}
        /// Operation Id: Storages_Get
        /// </summary>
        /// <param name="storageName"> The name of the storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<StorageResource> Get(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _storageResourceStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the storages of one Azure Spring Cloud instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages
        /// Operation Id: Storages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StorageResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageResourceStoragesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StorageResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageResourceStoragesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all the storages of one Azure Spring Cloud instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages
        /// Operation Id: Storages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StorageResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageResourceStoragesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StorageResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageResourceStoragesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages/{storageName}
        /// Operation Id: Storages_Get
        /// </summary>
        /// <param name="storageName"> The name of the storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageResourceStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/storages/{storageName}
        /// Operation Id: Storages_Get
        /// </summary>
        /// <param name="storageName"> The name of the storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _storageResourceStoragesClientDiagnostics.CreateScope("StorageResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageResourceStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageResource> IEnumerable<StorageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageResource> IAsyncEnumerable<StorageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
