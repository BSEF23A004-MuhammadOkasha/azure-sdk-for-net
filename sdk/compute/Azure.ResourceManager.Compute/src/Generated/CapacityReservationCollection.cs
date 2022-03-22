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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of CapacityReservation and their operations over its parent. </summary>
    public partial class CapacityReservationCollection : ArmCollection, IEnumerable<CapacityReservationResource>, IAsyncEnumerable<CapacityReservationResource>
    {
        private readonly ClientDiagnostics _capacityReservationClientDiagnostics;
        private readonly CapacityReservationsRestOperations _capacityReservationRestClient;

        /// <summary> Initializes a new instance of the <see cref="CapacityReservationCollection"/> class for mocking. </summary>
        protected CapacityReservationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CapacityReservationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CapacityReservationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _capacityReservationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CapacityReservationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CapacityReservationResource.ResourceType, out string capacityReservationApiVersion);
            _capacityReservationRestClient = new CapacityReservationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, capacityReservationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CapacityReservationGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CapacityReservationGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a capacity reservation. Please note some properties can be set only during capacity reservation creation. Please refer to https://aka.ms/CapacityReservation for more details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="parameters"> Parameters supplied to the Create capacity reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<CapacityReservationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string capacityReservationName, CapacityReservationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _capacityReservationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<CapacityReservationResource>(new CapacityReservationOperationSource(Client), _capacityReservationClientDiagnostics, Pipeline, _capacityReservationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update a capacity reservation. Please note some properties can be set only during capacity reservation creation. Please refer to https://aka.ms/CapacityReservation for more details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="parameters"> Parameters supplied to the Create capacity reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<CapacityReservationResource> CreateOrUpdate(WaitUntil waitUntil, string capacityReservationName, CapacityReservationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _capacityReservationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, parameters, cancellationToken);
                var operation = new ComputeArmOperation<CapacityReservationResource>(new CapacityReservationOperationSource(Client), _capacityReservationClientDiagnostics, Pipeline, _capacityReservationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// The operation that retrieves information about the capacity reservation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationResource>> GetAsync(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Get");
            scope.Start();
            try
            {
                var response = await _capacityReservationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation that retrieves information about the capacity reservation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual Response<CapacityReservationResource> Get(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Get");
            scope.Start();
            try
            {
                var response = _capacityReservationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the capacity reservations in the specified capacity reservation group. Use the nextLink property in the response to get the next page of capacity reservations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations
        /// Operation Id: CapacityReservations_ListByCapacityReservationGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CapacityReservationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CapacityReservationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CapacityReservationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _capacityReservationRestClient.ListByCapacityReservationGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CapacityReservationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CapacityReservationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _capacityReservationRestClient.ListByCapacityReservationGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CapacityReservationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all of the capacity reservations in the specified capacity reservation group. Use the nextLink property in the response to get the next page of capacity reservations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations
        /// Operation Id: CapacityReservations_ListByCapacityReservationGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CapacityReservationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CapacityReservationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CapacityReservationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _capacityReservationRestClient.ListByCapacityReservationGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CapacityReservationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CapacityReservationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _capacityReservationRestClient.ListByCapacityReservationGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CapacityReservationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(capacityReservationName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual Response<bool> Exists(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(capacityReservationName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationResource>> GetIfExistsAsync(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _capacityReservationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CapacityReservationResource>(null, response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual Response<CapacityReservationResource> GetIfExists(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capacityReservationName, nameof(capacityReservationName));

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _capacityReservationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CapacityReservationResource>(null, response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CapacityReservationResource> IEnumerable<CapacityReservationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CapacityReservationResource> IAsyncEnumerable<CapacityReservationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
