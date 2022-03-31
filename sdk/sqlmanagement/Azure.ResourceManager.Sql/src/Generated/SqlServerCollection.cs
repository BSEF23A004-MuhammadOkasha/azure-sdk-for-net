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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerResource" /> and their operations.
    /// Each <see cref="SqlServerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SqlServerCollection" /> instance call the GetSqlServers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SqlServerCollection : ArmCollection, IEnumerable<SqlServerResource>, IAsyncEnumerable<SqlServerResource>
    {
        private readonly ClientDiagnostics _sqlServerServersClientDiagnostics;
        private readonly ServersRestOperations _sqlServerServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerCollection"/> class for mocking. </summary>
        protected SqlServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerResource.ResourceType, out string sqlServerServersApiVersion);
            _sqlServerServersRestClient = new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerServersApiVersion);
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
        /// Creates or updates a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="data"> The requested server resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverName, SqlServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerServersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerResource>(new SqlServerOperationSource(Client), _sqlServerServersClientDiagnostics, Pipeline, _sqlServerServersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="data"> The requested server resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerResource> CreateOrUpdate(WaitUntil waitUntil, string serverName, SqlServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerServersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serverName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerResource>(new SqlServerOperationSource(Client), _sqlServerServersClientDiagnostics, Pipeline, _sqlServerServersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<SqlServerResource>> GetAsync(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<SqlServerResource> Get(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of servers in a resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers
        /// Operation Id: Servers_ListByResourceGroup
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlServerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerServersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlServerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerServersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of servers in a resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers
        /// Operation Id: Servers_ListByResourceGroup
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<SqlServerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerServersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlServerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerServersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerResource> IEnumerable<SqlServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerResource> IAsyncEnumerable<SqlServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
