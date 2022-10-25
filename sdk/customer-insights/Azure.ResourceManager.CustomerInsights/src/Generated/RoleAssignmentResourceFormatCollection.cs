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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleAssignmentResourceFormatResource" /> and their operations.
    /// Each <see cref="RoleAssignmentResourceFormatResource" /> in the collection will belong to the same instance of <see cref="HubResource" />.
    /// To get a <see cref="RoleAssignmentResourceFormatCollection" /> instance call the GetRoleAssignmentResourceFormats method from an instance of <see cref="HubResource" />.
    /// </summary>
    public partial class RoleAssignmentResourceFormatCollection : ArmCollection, IEnumerable<RoleAssignmentResourceFormatResource>, IAsyncEnumerable<RoleAssignmentResourceFormatResource>
    {
        private readonly ClientDiagnostics _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics;
        private readonly RoleAssignmentsRestOperations _roleAssignmentResourceFormatRoleAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentResourceFormatCollection"/> class for mocking. </summary>
        protected RoleAssignmentResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleAssignmentResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", RoleAssignmentResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleAssignmentResourceFormatResource.ResourceType, out string roleAssignmentResourceFormatRoleAssignmentsApiVersion);
            _roleAssignmentResourceFormatRoleAssignmentsRestClient = new RoleAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentResourceFormatRoleAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a role assignment in the hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments/{assignmentName}
        /// Operation Id: RoleAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assignmentName"> The assignment name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate RoleAssignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleAssignmentResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string assignmentName, RoleAssignmentResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _roleAssignmentResourceFormatRoleAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<RoleAssignmentResourceFormatResource>(new RoleAssignmentResourceFormatOperationSource(Client), _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics, Pipeline, _roleAssignmentResourceFormatRoleAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a role assignment in the hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments/{assignmentName}
        /// Operation Id: RoleAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assignmentName"> The assignment name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate RoleAssignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoleAssignmentResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string assignmentName, RoleAssignmentResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _roleAssignmentResourceFormatRoleAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<RoleAssignmentResourceFormatResource>(new RoleAssignmentResourceFormatOperationSource(Client), _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics, Pipeline, _roleAssignmentResourceFormatRoleAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the role assignment in the hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments/{assignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="assignmentName"> The name of the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> is null. </exception>
        public virtual async Task<Response<RoleAssignmentResourceFormatResource>> GetAsync(string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentResourceFormatRoleAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the role assignment in the hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments/{assignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="assignmentName"> The name of the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> is null. </exception>
        public virtual Response<RoleAssignmentResourceFormatResource> Get(string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentResourceFormatRoleAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the role assignments for the specified hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments
        /// Operation Id: RoleAssignments_ListByHub
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleAssignmentResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleAssignmentResourceFormatResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RoleAssignmentResourceFormatResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleAssignmentResourceFormatRoleAssignmentsRestClient.ListByHubAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RoleAssignmentResourceFormatResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleAssignmentResourceFormatRoleAssignmentsRestClient.ListByHubNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all the role assignments for the specified hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments
        /// Operation Id: RoleAssignments_ListByHub
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleAssignmentResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleAssignmentResourceFormatResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RoleAssignmentResourceFormatResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleAssignmentResourceFormatRoleAssignmentsRestClient.ListByHub(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RoleAssignmentResourceFormatResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleAssignmentResourceFormatRoleAssignmentsRestClient.ListByHubNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments/{assignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="assignmentName"> The name of the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleAssignmentResourceFormatRoleAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/roleAssignments/{assignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="assignmentName"> The name of the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var scope = _roleAssignmentResourceFormatRoleAssignmentsClientDiagnostics.CreateScope("RoleAssignmentResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleAssignmentResourceFormatRoleAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleAssignmentResourceFormatResource> IEnumerable<RoleAssignmentResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleAssignmentResourceFormatResource> IAsyncEnumerable<RoleAssignmentResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
