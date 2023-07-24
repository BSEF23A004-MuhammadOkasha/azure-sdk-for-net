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
    /// A class representing a collection of <see cref="SiteRecoveryProtectableItemResource" /> and their operations.
    /// Each <see cref="SiteRecoveryProtectableItemResource" /> in the collection will belong to the same instance of <see cref="SiteRecoveryProtectionContainerResource" />.
    /// To get a <see cref="SiteRecoveryProtectableItemCollection" /> instance call the GetSiteRecoveryProtectableItems method from an instance of <see cref="SiteRecoveryProtectionContainerResource" />.
    /// </summary>
    public partial class SiteRecoveryProtectableItemCollection : ArmCollection, IEnumerable<SiteRecoveryProtectableItemResource>, IAsyncEnumerable<SiteRecoveryProtectableItemResource>
    {
        private readonly ClientDiagnostics _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics;
        private readonly ReplicationProtectableItemsRestOperations _siteRecoveryProtectableItemReplicationProtectableItemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryProtectableItemCollection"/> class for mocking. </summary>
        protected SiteRecoveryProtectableItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryProtectableItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteRecoveryProtectableItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryProtectableItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryProtectableItemResource.ResourceType, out string siteRecoveryProtectableItemReplicationProtectableItemsApiVersion);
            _siteRecoveryProtectableItemReplicationProtectableItemsRestClient = new ReplicationProtectableItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryProtectableItemReplicationProtectableItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteRecoveryProtectionContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteRecoveryProtectionContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to get the details of a protectable item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryProtectableItemResource>> GetAsync(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("SiteRecoveryProtectableItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the details of a protectable item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual Response<SiteRecoveryProtectableItemResource> Get(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("SiteRecoveryProtectableItemCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the protectable items in a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_ListByReplicationProtectionContainers</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryProtectableItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryProtectableItemResource> GetAllAsync(string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.CreateListByReplicationProtectionContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.CreateListByReplicationProtectionContainersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryProtectableItemResource(Client, SiteRecoveryProtectableItemData.DeserializeSiteRecoveryProtectableItemData(e)), _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics, Pipeline, "SiteRecoveryProtectableItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the protectable items in a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_ListByReplicationProtectionContainers</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryProtectableItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryProtectableItemResource> GetAll(string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.CreateListByReplicationProtectionContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.CreateListByReplicationProtectionContainersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryProtectableItemResource(Client, SiteRecoveryProtectableItemData.DeserializeSiteRecoveryProtectableItemData(e)), _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics, Pipeline, "SiteRecoveryProtectableItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("SiteRecoveryProtectableItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("SiteRecoveryProtectableItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryProtectableItemResource> IEnumerable<SiteRecoveryProtectableItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryProtectableItemResource> IAsyncEnumerable<SiteRecoveryProtectableItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
