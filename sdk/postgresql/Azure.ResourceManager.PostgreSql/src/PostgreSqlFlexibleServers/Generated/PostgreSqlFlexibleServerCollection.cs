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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlFlexibleServerResource" /> and their operations.
    /// Each <see cref="PostgreSqlFlexibleServerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PostgreSqlFlexibleServerCollection" /> instance call the GetPostgreSqlFlexibleServers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PostgreSqlFlexibleServerCollection : ArmCollection, IEnumerable<PostgreSqlFlexibleServerResource>, IAsyncEnumerable<PostgreSqlFlexibleServerResource>
    {
        private readonly ClientDiagnostics _postgreSqlFlexibleServerServersClientDiagnostics;
        private readonly ServersRestOperations _postgreSqlFlexibleServerServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerCollection"/> class for mocking. </summary>
        protected PostgreSqlFlexibleServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlFlexibleServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlFlexibleServerServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlFlexibleServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlFlexibleServerResource.ResourceType, out string postgreSqlFlexibleServerServersApiVersion);
            _postgreSqlFlexibleServerServersRestClient = new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlFlexibleServerServersApiVersion);
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
        /// Creates a new server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="data"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlFlexibleServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverName, PostgreSqlFlexibleServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerServersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerResource>(new PostgreSqlFlexibleServerOperationSource(Client), _postgreSqlFlexibleServerServersClientDiagnostics, Pipeline, _postgreSqlFlexibleServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="data"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlFlexibleServerResource> CreateOrUpdate(WaitUntil waitUntil, string serverName, PostgreSqlFlexibleServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerServersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, serverName, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerResource>(new PostgreSqlFlexibleServerOperationSource(Client), _postgreSqlFlexibleServerServersClientDiagnostics, Pipeline, _postgreSqlFlexibleServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerResource>> GetAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerResource> Get(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the servers in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers
        /// Operation Id: Servers_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PostgreSqlFlexibleServerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _postgreSqlFlexibleServerServersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PostgreSqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PostgreSqlFlexibleServerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _postgreSqlFlexibleServerServersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PostgreSqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all the servers in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers
        /// Operation Id: Servers_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PostgreSqlFlexibleServerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _postgreSqlFlexibleServerServersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PostgreSqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PostgreSqlFlexibleServerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _postgreSqlFlexibleServerServersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PostgreSqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlFlexibleServerServersClientDiagnostics.CreateScope("PostgreSqlFlexibleServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlFlexibleServerResource> IEnumerable<PostgreSqlFlexibleServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlFlexibleServerResource> IAsyncEnumerable<PostgreSqlFlexibleServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
