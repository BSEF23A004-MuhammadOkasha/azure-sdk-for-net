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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchEndpointResource" /> and their operations.
    /// Each <see cref="BatchEndpointResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get a <see cref="BatchEndpointCollection" /> instance call the GetBatchEndpoints method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class BatchEndpointCollection : ArmCollection, IEnumerable<BatchEndpointResource>, IAsyncEnumerable<BatchEndpointResource>
    {
        private readonly ClientDiagnostics _batchEndpointClientDiagnostics;
        private readonly BatchEndpointsRestOperations _batchEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchEndpointCollection"/> class for mocking. </summary>
        protected BatchEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", BatchEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchEndpointResource.ResourceType, out string batchEndpointApiVersion);
            _batchEndpointRestClient = new BatchEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a batch inference endpoint (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Name for the Batch inference endpoint. </param>
        /// <param name="data"> Batch inference endpoint definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BatchEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string endpointName, BatchEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _batchEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<BatchEndpointResource>(new BatchEndpointOperationSource(Client), _batchEndpointClientDiagnostics, Pipeline, _batchEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a batch inference endpoint (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Name for the Batch inference endpoint. </param>
        /// <param name="data"> Batch inference endpoint definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BatchEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string endpointName, BatchEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _batchEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<BatchEndpointResource>(new BatchEndpointOperationSource(Client), _batchEndpointClientDiagnostics, Pipeline, _batchEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a batch inference endpoint by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<BatchEndpointResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a batch inference endpoint by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<BatchEndpointResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _batchEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Batch inference endpoint in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints
        /// Operation Id: BatchEndpoints_List
        /// </summary>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchEndpointResource> GetAllAsync(int? count = null, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BatchEndpointResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _batchEndpointRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BatchEndpointResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _batchEndpointRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists Batch inference endpoint in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints
        /// Operation Id: BatchEndpoints_List
        /// </summary>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchEndpointResource> GetAll(int? count = null, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<BatchEndpointResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _batchEndpointRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BatchEndpointResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _batchEndpointRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _batchEndpointClientDiagnostics.CreateScope("BatchEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchEndpointResource> IEnumerable<BatchEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchEndpointResource> IAsyncEnumerable<BatchEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
