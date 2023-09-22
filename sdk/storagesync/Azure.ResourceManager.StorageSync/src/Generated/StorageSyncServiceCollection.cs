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
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageSyncServiceResource" /> and their operations.
    /// Each <see cref="StorageSyncServiceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="StorageSyncServiceCollection" /> instance call the GetStorageSyncServices method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class StorageSyncServiceCollection : ArmCollection, IEnumerable<StorageSyncServiceResource>, IAsyncEnumerable<StorageSyncServiceResource>
    {
        private readonly ClientDiagnostics _storageSyncServiceClientDiagnostics;
        private readonly StorageSyncServicesRestOperations _storageSyncServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncServiceCollection"/> class for mocking. </summary>
        protected StorageSyncServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageSyncServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", StorageSyncServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageSyncServiceResource.ResourceType, out string storageSyncServiceApiVersion);
            _storageSyncServiceRestClient = new StorageSyncServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncServiceApiVersion);
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
        /// Create a new StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="content"> Storage Sync Service resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSyncServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageSyncServiceName, StorageSyncServiceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageSyncServiceRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<StorageSyncServiceResource>(new StorageSyncServiceOperationSource(Client), _storageSyncServiceClientDiagnostics, Pipeline, _storageSyncServiceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create a new StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="content"> Storage Sync Service resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<StorageSyncServiceResource> CreateOrUpdate(WaitUntil waitUntil, string storageSyncServiceName, StorageSyncServiceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageSyncServiceRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, content, cancellationToken);
                var operation = new StorageSyncArmOperation<StorageSyncServiceResource>(new StorageSyncServiceOperationSource(Client), _storageSyncServiceClientDiagnostics, Pipeline, _storageSyncServiceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Get a given StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        public virtual async Task<Response<StorageSyncServiceResource>> GetAsync(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        public virtual Response<StorageSyncServiceResource> Get(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _storageSyncServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StorageSyncService list by Resource group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSyncServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSyncServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new StorageSyncServiceResource(Client, StorageSyncServiceData.DeserializeStorageSyncServiceData(e)), _storageSyncServiceClientDiagnostics, Pipeline, "StorageSyncServiceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a StorageSyncService list by Resource group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSyncServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSyncServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new StorageSyncServiceResource(Client, StorageSyncServiceData.DeserializeStorageSyncServiceData(e)), _storageSyncServiceClientDiagnostics, Pipeline, "StorageSyncServiceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageSyncServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageSyncServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageSyncServiceResource>> GetIfExistsAsync(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageSyncServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageSyncServiceResource>(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        public virtual NullableResponse<StorageSyncServiceResource> GetIfExists(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var scope = _storageSyncServiceClientDiagnostics.CreateScope("StorageSyncServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageSyncServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageSyncServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageSyncServiceResource>(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageSyncServiceResource> IEnumerable<StorageSyncServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageSyncServiceResource> IAsyncEnumerable<StorageSyncServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
