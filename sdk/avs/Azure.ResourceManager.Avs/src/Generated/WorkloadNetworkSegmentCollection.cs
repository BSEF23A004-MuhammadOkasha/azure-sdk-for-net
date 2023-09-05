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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadNetworkSegmentResource" /> and their operations.
    /// Each <see cref="WorkloadNetworkSegmentResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="WorkloadNetworkSegmentCollection" /> instance call the GetWorkloadNetworkSegments method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class WorkloadNetworkSegmentCollection : ArmCollection, IEnumerable<WorkloadNetworkSegmentResource>, IAsyncEnumerable<WorkloadNetworkSegmentResource>
    {
        private readonly ClientDiagnostics _workloadNetworkSegmentWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkSegmentWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkSegmentCollection"/> class for mocking. </summary>
        protected WorkloadNetworkSegmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkSegmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkSegmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkSegmentWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkSegmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkSegmentResource.ResourceType, out string workloadNetworkSegmentWorkloadNetworksApiVersion);
            _workloadNetworkSegmentWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkSegmentWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a segment by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments/{segmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateSegments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="segmentId"> NSX Segment identifier. Generally the same as the Segment's display name. </param>
        /// <param name="data"> NSX Segment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="segmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="segmentId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkSegmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string segmentId, WorkloadNetworkSegmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(segmentId, nameof(segmentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkSegmentWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkSegmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadNetworkSegmentWorkloadNetworksRestClient.CreateSegmentsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkSegmentResource>(new WorkloadNetworkSegmentOperationSource(Client), _workloadNetworkSegmentWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkSegmentWorkloadNetworksRestClient.CreateCreateSegmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a segment by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments/{segmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateSegments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="segmentId"> NSX Segment identifier. Generally the same as the Segment's display name. </param>
        /// <param name="data"> NSX Segment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="segmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="segmentId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkSegmentResource> CreateOrUpdate(WaitUntil waitUntil, string segmentId, WorkloadNetworkSegmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(segmentId, nameof(segmentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkSegmentWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkSegmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadNetworkSegmentWorkloadNetworksRestClient.CreateSegments(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkSegmentResource>(new WorkloadNetworkSegmentOperationSource(Client), _workloadNetworkSegmentWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkSegmentWorkloadNetworksRestClient.CreateCreateSegmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a segment by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments/{segmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetSegment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="segmentId"> NSX Segment identifier. Generally the same as the Segment's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="segmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="segmentId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkSegmentResource>> GetAsync(string segmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(segmentId, nameof(segmentId));

            using var scope = _workloadNetworkSegmentWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkSegmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkSegmentWorkloadNetworksRestClient.GetSegmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkSegmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a segment by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments/{segmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetSegment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="segmentId"> NSX Segment identifier. Generally the same as the Segment's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="segmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="segmentId"/> is null. </exception>
        public virtual Response<WorkloadNetworkSegmentResource> Get(string segmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(segmentId, nameof(segmentId));

            using var scope = _workloadNetworkSegmentWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkSegmentCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkSegmentWorkloadNetworksRestClient.GetSegment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkSegmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of segments in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListSegments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkSegmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkSegmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkSegmentWorkloadNetworksRestClient.CreateListSegmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkSegmentWorkloadNetworksRestClient.CreateListSegmentsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkloadNetworkSegmentResource(Client, WorkloadNetworkSegmentData.DeserializeWorkloadNetworkSegmentData(e)), _workloadNetworkSegmentWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkSegmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of segments in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListSegments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkSegmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkSegmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkSegmentWorkloadNetworksRestClient.CreateListSegmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkSegmentWorkloadNetworksRestClient.CreateListSegmentsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkloadNetworkSegmentResource(Client, WorkloadNetworkSegmentData.DeserializeWorkloadNetworkSegmentData(e)), _workloadNetworkSegmentWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkSegmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments/{segmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetSegment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="segmentId"> NSX Segment identifier. Generally the same as the Segment's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="segmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="segmentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string segmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(segmentId, nameof(segmentId));

            using var scope = _workloadNetworkSegmentWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkSegmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkSegmentWorkloadNetworksRestClient.GetSegmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/segments/{segmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetSegment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="segmentId"> NSX Segment identifier. Generally the same as the Segment's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="segmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="segmentId"/> is null. </exception>
        public virtual Response<bool> Exists(string segmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(segmentId, nameof(segmentId));

            using var scope = _workloadNetworkSegmentWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkSegmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkSegmentWorkloadNetworksRestClient.GetSegment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, segmentId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkSegmentResource> IEnumerable<WorkloadNetworkSegmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkSegmentResource> IAsyncEnumerable<WorkloadNetworkSegmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
