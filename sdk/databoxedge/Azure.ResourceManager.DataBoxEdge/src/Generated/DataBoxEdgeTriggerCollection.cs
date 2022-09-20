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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeTriggerResource" /> and their operations.
    /// Each <see cref="DataBoxEdgeTriggerResource" /> in the collection will belong to the same instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// To get a <see cref="DataBoxEdgeTriggerCollection" /> instance call the GetDataBoxEdgeTriggers method from an instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// </summary>
    public partial class DataBoxEdgeTriggerCollection : ArmCollection, IEnumerable<DataBoxEdgeTriggerResource>, IAsyncEnumerable<DataBoxEdgeTriggerResource>
    {
        private readonly ClientDiagnostics _dataBoxEdgeTriggerTriggersClientDiagnostics;
        private readonly TriggersRestOperations _dataBoxEdgeTriggerTriggersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeTriggerCollection"/> class for mocking. </summary>
        protected DataBoxEdgeTriggerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeTriggerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeTriggerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeTriggerTriggersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeTriggerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeTriggerResource.ResourceType, out string dataBoxEdgeTriggerTriggersApiVersion);
            _dataBoxEdgeTriggerTriggersRestClient = new TriggersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeTriggerTriggersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeDeviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers/{name}
        /// Operation Id: Triggers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The trigger name. </param>
        /// <param name="data"> The trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeTriggerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DataBoxEdgeTriggerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeTriggerTriggersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeTriggerResource>(new DataBoxEdgeTriggerOperationSource(Client), _dataBoxEdgeTriggerTriggersClientDiagnostics, Pipeline, _dataBoxEdgeTriggerTriggersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers/{name}
        /// Operation Id: Triggers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The trigger name. </param>
        /// <param name="data"> The trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeTriggerResource> CreateOrUpdate(WaitUntil waitUntil, string name, DataBoxEdgeTriggerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeTriggerTriggersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeTriggerResource>(new DataBoxEdgeTriggerOperationSource(Client), _dataBoxEdgeTriggerTriggersClientDiagnostics, Pipeline, _dataBoxEdgeTriggerTriggersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a specific trigger by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers/{name}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="name"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeTriggerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeTriggerTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific trigger by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers/{name}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="name"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DataBoxEdgeTriggerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeTriggerTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the triggers configured in the device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers
        /// Operation Id: Triggers_ListByDataBoxEdgeDevice
        /// </summary>
        /// <param name="filter"> Specify $filter=&apos;CustomContextTag eq &lt;tag&gt;&apos; to filter on custom context tag property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeTriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxEdgeTriggerResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DataBoxEdgeTriggerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataBoxEdgeTriggerTriggersRestClient.ListByDataBoxEdgeDeviceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeTriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataBoxEdgeTriggerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataBoxEdgeTriggerTriggersRestClient.ListByDataBoxEdgeDeviceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeTriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the triggers configured in the device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers
        /// Operation Id: Triggers_ListByDataBoxEdgeDevice
        /// </summary>
        /// <param name="filter"> Specify $filter=&apos;CustomContextTag eq &lt;tag&gt;&apos; to filter on custom context tag property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeTriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxEdgeTriggerResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<DataBoxEdgeTriggerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataBoxEdgeTriggerTriggersRestClient.ListByDataBoxEdgeDevice(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeTriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataBoxEdgeTriggerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataBoxEdgeTriggerTriggersRestClient.ListByDataBoxEdgeDeviceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeTriggerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers/{name}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="name"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeTriggerTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/triggers/{name}
        /// Operation Id: Triggers_Get
        /// </summary>
        /// <param name="name"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeTriggerTriggersClientDiagnostics.CreateScope("DataBoxEdgeTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeTriggerTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataBoxEdgeTriggerResource> IEnumerable<DataBoxEdgeTriggerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataBoxEdgeTriggerResource> IAsyncEnumerable<DataBoxEdgeTriggerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
