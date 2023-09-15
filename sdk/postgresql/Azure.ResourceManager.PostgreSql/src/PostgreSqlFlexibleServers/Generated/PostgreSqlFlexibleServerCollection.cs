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
        private readonly ClientDiagnostics _replicasClientDiagnostics;
        private readonly ReplicasRestOperations _replicasRestClient;

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
            _replicasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _replicasRestClient = new ReplicasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Create</description>
        /// </item>
        /// </list>
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
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerResource>(new PostgreSqlFlexibleServerOperationSource(Client), _postgreSqlFlexibleServerServersClientDiagnostics, Pipeline, _postgreSqlFlexibleServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Create</description>
        /// </item>
        /// </list>
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
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerResource>(new PostgreSqlFlexibleServerOperationSource(Client), _postgreSqlFlexibleServerServersClientDiagnostics, Pipeline, _postgreSqlFlexibleServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerServersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerServersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerResource(Client, PostgreSqlFlexibleServerData.DeserializePostgreSqlFlexibleServerData(e)), _postgreSqlFlexibleServerServersClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerServersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerServersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerResource(Client, PostgreSqlFlexibleServerData.DeserializePostgreSqlFlexibleServerData(e)), _postgreSqlFlexibleServerServersClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the replicas for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerResource> GetReplicasAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicasRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new PostgreSqlFlexibleServerResource(Client, PostgreSqlFlexibleServerData.DeserializePostgreSqlFlexibleServerData(e)), _replicasClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerCollection.GetReplicas", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the replicas for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerResource> GetReplicas(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicasRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new PostgreSqlFlexibleServerResource(Client, PostgreSqlFlexibleServerData.DeserializePostgreSqlFlexibleServerData(e)), _replicasClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerCollection.GetReplicas", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
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
