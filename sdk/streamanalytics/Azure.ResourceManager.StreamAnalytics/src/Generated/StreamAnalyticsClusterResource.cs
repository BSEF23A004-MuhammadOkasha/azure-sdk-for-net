// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A Class representing a StreamAnalyticsCluster along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StreamAnalyticsClusterResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStreamAnalyticsClusterResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetStreamAnalyticsCluster method.
    /// </summary>
    public partial class StreamAnalyticsClusterResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StreamAnalyticsClusterResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _streamAnalyticsClusterClustersClientDiagnostics;
        private readonly ClustersRestOperations _streamAnalyticsClusterClustersRestClient;
        private readonly StreamAnalyticsClusterData _data;

        /// <summary> Initializes a new instance of the <see cref="StreamAnalyticsClusterResource"/> class for mocking. </summary>
        protected StreamAnalyticsClusterResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StreamAnalyticsClusterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StreamAnalyticsClusterResource(ArmClient client, StreamAnalyticsClusterData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StreamAnalyticsClusterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StreamAnalyticsClusterResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamAnalyticsClusterClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string streamAnalyticsClusterClustersApiVersion);
            _streamAnalyticsClusterClustersRestClient = new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamAnalyticsClusterClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StreamAnalytics/clusters";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StreamAnalyticsClusterData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of StreamAnalyticsPrivateEndpointResources in the StreamAnalyticsCluster. </summary>
        /// <returns> An object representing collection of StreamAnalyticsPrivateEndpointResources and their operations over a StreamAnalyticsPrivateEndpointResource. </returns>
        public virtual StreamAnalyticsPrivateEndpointCollection GetStreamAnalyticsPrivateEndpoints()
        {
            return GetCachedClient(Client => new StreamAnalyticsPrivateEndpointCollection(Client, Id));
        }

        /// <summary>
        /// Gets information about the specified Private Endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}
        /// Operation Id: PrivateEndpoints_Get
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StreamAnalyticsPrivateEndpointResource>> GetStreamAnalyticsPrivateEndpointAsync(string privateEndpointName, CancellationToken cancellationToken = default)
        {
            return await GetStreamAnalyticsPrivateEndpoints().GetAsync(privateEndpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified Private Endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}
        /// Operation Id: PrivateEndpoints_Get
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<StreamAnalyticsPrivateEndpointResource> GetStreamAnalyticsPrivateEndpoint(string privateEndpointName, CancellationToken cancellationToken = default)
        {
            return GetStreamAnalyticsPrivateEndpoints().Get(privateEndpointName, cancellationToken);
        }

        /// <summary>
        /// Gets information about the specified cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StreamAnalyticsClusterResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.Get");
            scope.Start();
            try
            {
                var response = await _streamAnalyticsClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamAnalyticsClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StreamAnalyticsClusterResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.Get");
            scope.Start();
            try
            {
                var response = _streamAnalyticsClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamAnalyticsClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.Delete");
            scope.Start();
            try
            {
                var response = await _streamAnalyticsClusterClustersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation(_streamAnalyticsClusterClustersClientDiagnostics, Pipeline, _streamAnalyticsClusterClustersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.Delete");
            scope.Start();
            try
            {
                var response = _streamAnalyticsClusterClustersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new StreamAnalyticsArmOperation(_streamAnalyticsClusterClustersClientDiagnostics, Pipeline, _streamAnalyticsClusterClustersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing cluster. This can be used to partially update (ie. update one or two properties) a cluster without affecting the rest of the cluster definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The properties specified here will overwrite the corresponding properties in the existing cluster (ie. Those properties will be updated). </param>
        /// <param name="ifMatch"> The ETag of the resource. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamAnalyticsClusterResource>> UpdateAsync(WaitUntil waitUntil, StreamAnalyticsClusterData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.Update");
            scope.Start();
            try
            {
                var response = await _streamAnalyticsClusterClustersRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsClusterResource>(new StreamAnalyticsClusterOperationSource(Client), _streamAnalyticsClusterClustersClientDiagnostics, Pipeline, _streamAnalyticsClusterClustersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing cluster. This can be used to partially update (ie. update one or two properties) a cluster without affecting the rest of the cluster definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The properties specified here will overwrite the corresponding properties in the existing cluster (ie. Those properties will be updated). </param>
        /// <param name="ifMatch"> The ETag of the resource. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamAnalyticsClusterResource> Update(WaitUntil waitUntil, StreamAnalyticsClusterData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.Update");
            scope.Start();
            try
            {
                var response = _streamAnalyticsClusterClustersRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, ifMatch, cancellationToken);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsClusterResource>(new StreamAnalyticsClusterOperationSource(Client), _streamAnalyticsClusterClustersClientDiagnostics, Pipeline, _streamAnalyticsClusterClustersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Lists all of the streaming jobs in the given cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/listStreamingJobs
        /// Operation Id: Clusters_ListStreamingJobs
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamAnalyticsClusterJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamAnalyticsClusterJob> GetStreamingJobsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StreamAnalyticsClusterJob>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.GetStreamingJobs");
                scope.Start();
                try
                {
                    var response = await _streamAnalyticsClusterClustersRestClient.ListStreamingJobsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StreamAnalyticsClusterJob>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.GetStreamingJobs");
                scope.Start();
                try
                {
                    var response = await _streamAnalyticsClusterClustersRestClient.ListStreamingJobsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all of the streaming jobs in the given cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/listStreamingJobs
        /// Operation Id: Clusters_ListStreamingJobs
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamAnalyticsClusterJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamAnalyticsClusterJob> GetStreamingJobs(CancellationToken cancellationToken = default)
        {
            Page<StreamAnalyticsClusterJob> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.GetStreamingJobs");
                scope.Start();
                try
                {
                    var response = _streamAnalyticsClusterClustersRestClient.ListStreamingJobs(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StreamAnalyticsClusterJob> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.GetStreamingJobs");
                scope.Start();
                try
                {
                    var response = _streamAnalyticsClusterClustersRestClient.ListStreamingJobsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<StreamAnalyticsClusterResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _streamAnalyticsClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new StreamAnalyticsClusterResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new StreamAnalyticsClusterData(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<StreamAnalyticsClusterResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _streamAnalyticsClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new StreamAnalyticsClusterResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new StreamAnalyticsClusterData(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<StreamAnalyticsClusterResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _streamAnalyticsClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new StreamAnalyticsClusterResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new StreamAnalyticsClusterData(current.Location);
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<StreamAnalyticsClusterResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _streamAnalyticsClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new StreamAnalyticsClusterResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new StreamAnalyticsClusterData(current.Location);
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<StreamAnalyticsClusterResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _streamAnalyticsClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new StreamAnalyticsClusterResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new StreamAnalyticsClusterData(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<StreamAnalyticsClusterResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _streamAnalyticsClusterClustersClientDiagnostics.CreateScope("StreamAnalyticsClusterResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _streamAnalyticsClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new StreamAnalyticsClusterResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new StreamAnalyticsClusterData(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
