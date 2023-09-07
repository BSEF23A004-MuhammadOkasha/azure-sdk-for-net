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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="EventGridNamespacePermissionBindingResource" /> and their operations.
    /// Each <see cref="EventGridNamespacePermissionBindingResource" /> in the collection will belong to the same instance of <see cref="EventGridNamespaceResource" />.
    /// To get an <see cref="EventGridNamespacePermissionBindingCollection" /> instance call the GetEventGridNamespacePermissionBindings method from an instance of <see cref="EventGridNamespaceResource" />.
    /// </summary>
    public partial class EventGridNamespacePermissionBindingCollection : ArmCollection, IEnumerable<EventGridNamespacePermissionBindingResource>, IAsyncEnumerable<EventGridNamespacePermissionBindingResource>
    {
        private readonly ClientDiagnostics _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics;
        private readonly PermissionBindingsRestOperations _eventGridNamespacePermissionBindingPermissionBindingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespacePermissionBindingCollection"/> class for mocking. </summary>
        protected EventGridNamespacePermissionBindingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespacePermissionBindingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventGridNamespacePermissionBindingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", EventGridNamespacePermissionBindingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventGridNamespacePermissionBindingResource.ResourceType, out string eventGridNamespacePermissionBindingPermissionBindingsApiVersion);
            _eventGridNamespacePermissionBindingPermissionBindingsRestClient = new PermissionBindingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventGridNamespacePermissionBindingPermissionBindingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventGridNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventGridNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a permission binding with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="permissionBindingName"> The permission binding name. </param>
        /// <param name="data"> Permission binding information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="permissionBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="permissionBindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventGridNamespacePermissionBindingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string permissionBindingName, EventGridNamespacePermissionBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(permissionBindingName, nameof(permissionBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<EventGridNamespacePermissionBindingResource>(new EventGridNamespacePermissionBindingOperationSource(Client), _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a permission binding with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="permissionBindingName"> The permission binding name. </param>
        /// <param name="data"> Permission binding information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="permissionBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="permissionBindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventGridNamespacePermissionBindingResource> CreateOrUpdate(WaitUntil waitUntil, string permissionBindingName, EventGridNamespacePermissionBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(permissionBindingName, nameof(permissionBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, data, cancellationToken);
                var operation = new EventGridArmOperation<EventGridNamespacePermissionBindingResource>(new EventGridNamespacePermissionBindingOperationSource(Client), _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of a permission binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="permissionBindingName"> Name of the permission binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="permissionBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="permissionBindingName"/> is null. </exception>
        public virtual async Task<Response<EventGridNamespacePermissionBindingResource>> GetAsync(string permissionBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(permissionBindingName, nameof(permissionBindingName));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventGridNamespacePermissionBindingPermissionBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespacePermissionBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a permission binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="permissionBindingName"> Name of the permission binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="permissionBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="permissionBindingName"/> is null. </exception>
        public virtual Response<EventGridNamespacePermissionBindingResource> Get(string permissionBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(permissionBindingName, nameof(permissionBindingName));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingCollection.Get");
            scope.Start();
            try
            {
                var response = _eventGridNamespacePermissionBindingPermissionBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespacePermissionBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the permission bindings under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventGridNamespacePermissionBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventGridNamespacePermissionBindingResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventGridNamespacePermissionBindingResource(Client, EventGridNamespacePermissionBindingData.DeserializeEventGridNamespacePermissionBindingData(e)), _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, "EventGridNamespacePermissionBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the permission bindings under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventGridNamespacePermissionBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventGridNamespacePermissionBindingResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventGridNamespacePermissionBindingResource(Client, EventGridNamespacePermissionBindingData.DeserializeEventGridNamespacePermissionBindingData(e)), _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, "EventGridNamespacePermissionBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="permissionBindingName"> Name of the permission binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="permissionBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="permissionBindingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string permissionBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(permissionBindingName, nameof(permissionBindingName));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventGridNamespacePermissionBindingPermissionBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="permissionBindingName"> Name of the permission binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="permissionBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="permissionBindingName"/> is null. </exception>
        public virtual Response<bool> Exists(string permissionBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(permissionBindingName, nameof(permissionBindingName));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventGridNamespacePermissionBindingPermissionBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, permissionBindingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventGridNamespacePermissionBindingResource> IEnumerable<EventGridNamespacePermissionBindingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventGridNamespacePermissionBindingResource> IAsyncEnumerable<EventGridNamespacePermissionBindingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
