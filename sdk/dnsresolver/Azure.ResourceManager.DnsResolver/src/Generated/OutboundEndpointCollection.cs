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

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing a collection of <see cref="OutboundEndpointResource" /> and their operations.
    /// Each <see cref="OutboundEndpointResource" /> in the collection will belong to the same instance of <see cref="DnsResolverResource" />.
    /// To get an <see cref="OutboundEndpointCollection" /> instance call the GetOutboundEndpoints method from an instance of <see cref="DnsResolverResource" />.
    /// </summary>
    public partial class OutboundEndpointCollection : ArmCollection, IEnumerable<OutboundEndpointResource>, IAsyncEnumerable<OutboundEndpointResource>
    {
        private readonly ClientDiagnostics _outboundEndpointClientDiagnostics;
        private readonly OutboundEndpointsRestOperations _outboundEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="OutboundEndpointCollection"/> class for mocking. </summary>
        protected OutboundEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OutboundEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _outboundEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", OutboundEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OutboundEndpointResource.ResourceType, out string outboundEndpointApiVersion);
            _outboundEndpointRestClient = new OutboundEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, outboundEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DnsResolverResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DnsResolverResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an outbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}
        /// Operation Id: OutboundEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OutboundEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string outboundEndpointName, OutboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _outboundEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<OutboundEndpointResource>(new OutboundEndpointOperationSource(Client), _outboundEndpointClientDiagnostics, Pipeline, _outboundEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an outbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}
        /// Operation Id: OutboundEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OutboundEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string outboundEndpointName, OutboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _outboundEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<OutboundEndpointResource>(new OutboundEndpointOperationSource(Client), _outboundEndpointClientDiagnostics, Pipeline, _outboundEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets properties of an outbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}
        /// Operation Id: OutboundEndpoints_Get
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<OutboundEndpointResource>> GetAsync(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _outboundEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of an outbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}
        /// Operation Id: OutboundEndpoints_Get
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual Response<OutboundEndpointResource> Get(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _outboundEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists outbound endpoints for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints
        /// Operation Id: OutboundEndpoints_List
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OutboundEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OutboundEndpointResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OutboundEndpointResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _outboundEndpointRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OutboundEndpointResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _outboundEndpointRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists outbound endpoints for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints
        /// Operation Id: OutboundEndpoints_List
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OutboundEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OutboundEndpointResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<OutboundEndpointResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _outboundEndpointRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OutboundEndpointResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _outboundEndpointRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}
        /// Operation Id: OutboundEndpoints_Get
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _outboundEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}
        /// Operation Id: OutboundEndpoints_Get
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _outboundEndpointClientDiagnostics.CreateScope("OutboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _outboundEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OutboundEndpointResource> IEnumerable<OutboundEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OutboundEndpointResource> IAsyncEnumerable<OutboundEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
