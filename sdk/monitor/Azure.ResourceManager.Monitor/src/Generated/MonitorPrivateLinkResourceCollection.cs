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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="MonitorPrivateLinkResource" /> and their operations.
    /// Each <see cref="MonitorPrivateLinkResource" /> in the collection will belong to the same instance of <see cref="PrivateLinkScopeResource" />.
    /// To get a <see cref="MonitorPrivateLinkResourceCollection" /> instance call the GetMonitorPrivateLinkResources method from an instance of <see cref="PrivateLinkScopeResource" />.
    /// </summary>
    public partial class MonitorPrivateLinkResourceCollection : ArmCollection, IEnumerable<MonitorPrivateLinkResource>, IAsyncEnumerable<MonitorPrivateLinkResource>
    {
        private readonly ClientDiagnostics _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _monitorPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MonitorPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected MonitorPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MonitorPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MonitorPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", MonitorPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MonitorPrivateLinkResource.ResourceType, out string monitorPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _monitorPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, monitorPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateLinkScopeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateLinkScopeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<MonitorPrivateLinkResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<MonitorPrivateLinkResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_ListByPrivateLinkScope
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MonitorPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MonitorPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MonitorPrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _monitorPrivateLinkResourcePrivateLinkResourcesRestClient.ListByPrivateLinkScopeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MonitorPrivateLinkResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_ListByPrivateLinkScope
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MonitorPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MonitorPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MonitorPrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _monitorPrivateLinkResourcePrivateLinkResourcesRestClient.ListByPrivateLinkScope(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MonitorPrivateLinkResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _monitorPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MonitorPrivateLinkResource> IEnumerable<MonitorPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MonitorPrivateLinkResource> IAsyncEnumerable<MonitorPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
