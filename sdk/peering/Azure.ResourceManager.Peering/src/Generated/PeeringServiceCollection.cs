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

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing a collection of <see cref="PeeringServiceResource"/> and their operations.
    /// Each <see cref="PeeringServiceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PeeringServiceCollection"/> instance call the GetPeeringServices method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PeeringServiceCollection : ArmCollection, IEnumerable<PeeringServiceResource>, IAsyncEnumerable<PeeringServiceResource>
    {
        private readonly ClientDiagnostics _peeringServiceClientDiagnostics;
        private readonly PeeringServicesRestOperations _peeringServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="PeeringServiceCollection"/> class for mocking. </summary>
        protected PeeringServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeeringServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PeeringServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peeringServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Peering", PeeringServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PeeringServiceResource.ResourceType, out string peeringServiceApiVersion);
            _peeringServiceRestClient = new PeeringServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peeringServiceApiVersion);
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
        /// Creates a new peering service or updates an existing peering with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="data"> The properties needed to create or update a peering service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PeeringServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string peeringServiceName, PeeringServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _peeringServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation<PeeringServiceResource>(Response.FromValue(new PeeringServiceResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new peering service or updates an existing peering with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="data"> The properties needed to create or update a peering service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PeeringServiceResource> CreateOrUpdate(WaitUntil waitUntil, string peeringServiceName, PeeringServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _peeringServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, data, cancellationToken);
                var operation = new PeeringArmOperation<PeeringServiceResource>(Response.FromValue(new PeeringServiceResource(Client, response), response.GetRawResponse()));
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
        /// Gets an existing peering service with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        public virtual async Task<Response<PeeringServiceResource>> GetAsync(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _peeringServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing peering service with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        public virtual Response<PeeringServiceResource> Get(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _peeringServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the peering services under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeeringServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PeeringServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PeeringServiceResource(Client, PeeringServiceData.DeserializePeeringServiceData(e)), _peeringServiceClientDiagnostics, Pipeline, "PeeringServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the peering services under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeeringServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PeeringServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PeeringServiceResource(Client, PeeringServiceData.DeserializePeeringServiceData(e)), _peeringServiceClientDiagnostics, Pipeline, "PeeringServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _peeringServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _peeringServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<PeeringServiceResource>> GetIfExistsAsync(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _peeringServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PeeringServiceResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Peering/peeringServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        public virtual NullableResponse<PeeringServiceResource> GetIfExists(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var scope = _peeringServiceClientDiagnostics.CreateScope("PeeringServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _peeringServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, peeringServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PeeringServiceResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PeeringServiceResource> IEnumerable<PeeringServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PeeringServiceResource> IAsyncEnumerable<PeeringServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
