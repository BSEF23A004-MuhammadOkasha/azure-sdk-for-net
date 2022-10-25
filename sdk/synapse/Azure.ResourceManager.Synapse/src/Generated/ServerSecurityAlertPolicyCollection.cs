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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerSecurityAlertPolicyResource" /> and their operations.
    /// Each <see cref="ServerSecurityAlertPolicyResource" /> in the collection will belong to the same instance of <see cref="WorkspaceResource" />.
    /// To get a <see cref="ServerSecurityAlertPolicyCollection" /> instance call the GetServerSecurityAlertPolicies method from an instance of <see cref="WorkspaceResource" />.
    /// </summary>
    public partial class ServerSecurityAlertPolicyCollection : ArmCollection, IEnumerable<ServerSecurityAlertPolicyResource>, IAsyncEnumerable<ServerSecurityAlertPolicyResource>
    {
        private readonly ClientDiagnostics _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics;
        private readonly WorkspaceManagedSqlServerSecurityAlertPolicyRestOperations _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected ServerSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerSecurityAlertPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerSecurityAlertPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ServerSecurityAlertPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerSecurityAlertPolicyResource.ResourceType, out string serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyApiVersion);
            _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient = new WorkspaceManagedSqlServerSecurityAlertPolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a workspace managed sql server&apos;s threat detection policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The workspace managed sql server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerSecurityAlertPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SqlServerSecurityAlertPolicyName securityAlertPolicyName, ServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<ServerSecurityAlertPolicyResource>(new ServerSecurityAlertPolicyOperationSource(Client), _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics, Pipeline, _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or Update a workspace managed sql server&apos;s threat detection policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The workspace managed sql server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerSecurityAlertPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SqlServerSecurityAlertPolicyName securityAlertPolicyName, ServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken);
                var operation = new SynapseArmOperation<ServerSecurityAlertPolicyResource>(new ServerSecurityAlertPolicyOperationSource(Client), _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics, Pipeline, _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a workspace managed sql server&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerSecurityAlertPolicyResource>> GetAsync(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workspace managed sql server&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerSecurityAlertPolicyResource> Get(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get workspace managed sql server&apos;s threat detection policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerSecurityAlertPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerSecurityAlertPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerSecurityAlertPolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get workspace managed sql server&apos;s threat detection policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerSecurityAlertPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerSecurityAlertPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerSecurityAlertPolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerSecurityAlertPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerSecurityAlertPolicy_Get
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _serverSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerSecurityAlertPolicyResource> IEnumerable<ServerSecurityAlertPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerSecurityAlertPolicyResource> IAsyncEnumerable<ServerSecurityAlertPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
