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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageClassificationResource" /> and their operations.
    /// Each <see cref="StorageClassificationResource" /> in the collection will belong to the same instance of <see cref="SiteRecoveryFabricResource" />.
    /// To get a <see cref="StorageClassificationCollection" /> instance call the GetStorageClassifications method from an instance of <see cref="SiteRecoveryFabricResource" />.
    /// </summary>
    public partial class StorageClassificationCollection : ArmCollection, IEnumerable<StorageClassificationResource>, IAsyncEnumerable<StorageClassificationResource>
    {
        private readonly ClientDiagnostics _storageClassificationReplicationStorageClassificationsClientDiagnostics;
        private readonly ReplicationStorageClassificationsRestOperations _storageClassificationReplicationStorageClassificationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageClassificationCollection"/> class for mocking. </summary>
        protected StorageClassificationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageClassificationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageClassificationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageClassificationReplicationStorageClassificationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", StorageClassificationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageClassificationResource.ResourceType, out string storageClassificationReplicationStorageClassificationsApiVersion);
            _storageClassificationReplicationStorageClassificationsRestClient = new ReplicationStorageClassificationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageClassificationReplicationStorageClassificationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteRecoveryFabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteRecoveryFabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of the specified storage classification.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassifications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationName"> Storage classification name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationName"/> is null. </exception>
        public virtual async Task<Response<StorageClassificationResource>> GetAsync(string storageClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationName, nameof(storageClassificationName));

            using var scope = _storageClassificationReplicationStorageClassificationsClientDiagnostics.CreateScope("StorageClassificationCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageClassificationReplicationStorageClassificationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, storageClassificationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageClassificationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the specified storage classification.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassifications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationName"> Storage classification name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationName"/> is null. </exception>
        public virtual Response<StorageClassificationResource> Get(string storageClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationName, nameof(storageClassificationName));

            using var scope = _storageClassificationReplicationStorageClassificationsClientDiagnostics.CreateScope("StorageClassificationCollection.Get");
            scope.Start();
            try
            {
                var response = _storageClassificationReplicationStorageClassificationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, storageClassificationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageClassificationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the storage classifications available in the specified fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassifications_ListByReplicationFabrics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageClassificationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageClassificationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageClassificationReplicationStorageClassificationsRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageClassificationReplicationStorageClassificationsRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageClassificationResource(Client, StorageClassificationData.DeserializeStorageClassificationData(e)), _storageClassificationReplicationStorageClassificationsClientDiagnostics, Pipeline, "StorageClassificationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the storage classifications available in the specified fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassifications_ListByReplicationFabrics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageClassificationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageClassificationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageClassificationReplicationStorageClassificationsRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageClassificationReplicationStorageClassificationsRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageClassificationResource(Client, StorageClassificationData.DeserializeStorageClassificationData(e)), _storageClassificationReplicationStorageClassificationsClientDiagnostics, Pipeline, "StorageClassificationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassifications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationName"> Storage classification name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationName, nameof(storageClassificationName));

            using var scope = _storageClassificationReplicationStorageClassificationsClientDiagnostics.CreateScope("StorageClassificationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageClassificationReplicationStorageClassificationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, storageClassificationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassifications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationName"> Storage classification name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageClassificationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationName, nameof(storageClassificationName));

            using var scope = _storageClassificationReplicationStorageClassificationsClientDiagnostics.CreateScope("StorageClassificationCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageClassificationReplicationStorageClassificationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, storageClassificationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageClassificationResource> IEnumerable<StorageClassificationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageClassificationResource> IAsyncEnumerable<StorageClassificationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
