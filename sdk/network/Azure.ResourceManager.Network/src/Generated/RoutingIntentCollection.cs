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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="RoutingIntentResource" /> and their operations.
    /// Each <see cref="RoutingIntentResource" /> in the collection will belong to the same instance of <see cref="VirtualHubResource" />.
    /// To get a <see cref="RoutingIntentCollection" /> instance call the GetRoutingIntents method from an instance of <see cref="VirtualHubResource" />.
    /// </summary>
    public partial class RoutingIntentCollection : ArmCollection, IEnumerable<RoutingIntentResource>, IAsyncEnumerable<RoutingIntentResource>
    {
        private readonly ClientDiagnostics _routingIntentClientDiagnostics;
        private readonly RoutingIntentRestOperations _routingIntentRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoutingIntentCollection"/> class for mocking. </summary>
        protected RoutingIntentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoutingIntentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoutingIntentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _routingIntentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", RoutingIntentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoutingIntentResource.ResourceType, out string routingIntentApiVersion);
            _routingIntentRestClient = new RoutingIntentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, routingIntentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a RoutingIntent resource if it doesn't exist else updates the existing RoutingIntent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routingIntentName"> The name of the per VirtualHub singleton Routing Intent resource. </param>
        /// <param name="data"> Parameters supplied to create or update RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoutingIntentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string routingIntentName, RoutingIntentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routingIntentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<RoutingIntentResource>(new RoutingIntentOperationSource(Client), _routingIntentClientDiagnostics, Pipeline, _routingIntentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a RoutingIntent resource if it doesn't exist else updates the existing RoutingIntent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routingIntentName"> The name of the per VirtualHub singleton Routing Intent resource. </param>
        /// <param name="data"> Parameters supplied to create or update RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoutingIntentResource> CreateOrUpdate(WaitUntil waitUntil, string routingIntentName, RoutingIntentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routingIntentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, data, cancellationToken);
                var operation = new NetworkArmOperation<RoutingIntentResource>(new RoutingIntentOperationSource(Client), _routingIntentClientDiagnostics, Pipeline, _routingIntentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a RoutingIntent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routingIntentName"> The name of the RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> is null. </exception>
        public virtual async Task<Response<RoutingIntentResource>> GetAsync(string routingIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.Get");
            scope.Start();
            try
            {
                var response = await _routingIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoutingIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a RoutingIntent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routingIntentName"> The name of the RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> is null. </exception>
        public virtual Response<RoutingIntentResource> Get(string routingIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.Get");
            scope.Start();
            try
            {
                var response = _routingIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoutingIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all RoutingIntent child resources of the VirtualHub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoutingIntentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoutingIntentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routingIntentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routingIntentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoutingIntentResource(Client, RoutingIntentData.DeserializeRoutingIntentData(e)), _routingIntentClientDiagnostics, Pipeline, "RoutingIntentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of all RoutingIntent child resources of the VirtualHub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoutingIntentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoutingIntentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routingIntentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routingIntentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoutingIntentResource(Client, RoutingIntentData.DeserializeRoutingIntentData(e)), _routingIntentClientDiagnostics, Pipeline, "RoutingIntentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routingIntentName"> The name of the RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string routingIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _routingIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routingIntentName"> The name of the RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> is null. </exception>
        public virtual Response<bool> Exists(string routingIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = _routingIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routingIntentName"> The name of the RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> is null. </exception>
        public virtual async Task<NullableResponse<RoutingIntentResource>> GetIfExistsAsync(string routingIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _routingIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RoutingIntentResource>(response.GetRawResponse());
                return Response.FromValue(new RoutingIntentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routingIntent/{routingIntentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingIntent_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routingIntentName"> The name of the RoutingIntent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routingIntentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routingIntentName"/> is null. </exception>
        public virtual NullableResponse<RoutingIntentResource> GetIfExists(string routingIntentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routingIntentName, nameof(routingIntentName));

            using var scope = _routingIntentClientDiagnostics.CreateScope("RoutingIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routingIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routingIntentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RoutingIntentResource>(response.GetRawResponse());
                return Response.FromValue(new RoutingIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoutingIntentResource> IEnumerable<RoutingIntentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoutingIntentResource> IAsyncEnumerable<RoutingIntentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
