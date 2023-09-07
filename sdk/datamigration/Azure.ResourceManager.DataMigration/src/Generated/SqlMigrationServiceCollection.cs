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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlMigrationServiceResource" /> and their operations.
    /// Each <see cref="SqlMigrationServiceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SqlMigrationServiceCollection" /> instance call the GetSqlMigrationServices method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SqlMigrationServiceCollection : ArmCollection, IEnumerable<SqlMigrationServiceResource>, IAsyncEnumerable<SqlMigrationServiceResource>
    {
        private readonly ClientDiagnostics _sqlMigrationServiceClientDiagnostics;
        private readonly SqlMigrationServicesRestOperations _sqlMigrationServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlMigrationServiceCollection"/> class for mocking. </summary>
        protected SqlMigrationServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlMigrationServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlMigrationServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlMigrationServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataMigration", SqlMigrationServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlMigrationServiceResource.ResourceType, out string sqlMigrationServiceApiVersion);
            _sqlMigrationServiceRestClient = new SqlMigrationServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlMigrationServiceApiVersion);
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
        /// Create or Update Database Migration Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlMigrationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlMigrationServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlMigrationServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sqlMigrationServiceName, SqlMigrationServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlMigrationServiceName, nameof(sqlMigrationServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlMigrationServiceClientDiagnostics.CreateScope("SqlMigrationServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlMigrationServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataMigrationArmOperation<SqlMigrationServiceResource>(new SqlMigrationServiceOperationSource(Client), _sqlMigrationServiceClientDiagnostics, Pipeline, _sqlMigrationServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create or Update Database Migration Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlMigrationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlMigrationServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlMigrationServiceResource> CreateOrUpdate(WaitUntil waitUntil, string sqlMigrationServiceName, SqlMigrationServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlMigrationServiceName, nameof(sqlMigrationServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlMigrationServiceClientDiagnostics.CreateScope("SqlMigrationServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlMigrationServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, data, cancellationToken);
                var operation = new DataMigrationArmOperation<SqlMigrationServiceResource>(new SqlMigrationServiceOperationSource(Client), _sqlMigrationServiceClientDiagnostics, Pipeline, _sqlMigrationServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Retrieve the Database Migration Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlMigrationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlMigrationServiceName"/> is null. </exception>
        public virtual async Task<Response<SqlMigrationServiceResource>> GetAsync(string sqlMigrationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlMigrationServiceName, nameof(sqlMigrationServiceName));

            using var scope = _sqlMigrationServiceClientDiagnostics.CreateScope("SqlMigrationServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlMigrationServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlMigrationServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the Database Migration Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlMigrationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlMigrationServiceName"/> is null. </exception>
        public virtual Response<SqlMigrationServiceResource> Get(string sqlMigrationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlMigrationServiceName, nameof(sqlMigrationServiceName));

            using var scope = _sqlMigrationServiceClientDiagnostics.CreateScope("SqlMigrationServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlMigrationServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlMigrationServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve all SQL migration services in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlMigrationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlMigrationServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlMigrationServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlMigrationServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlMigrationServiceResource(Client, SqlMigrationServiceData.DeserializeSqlMigrationServiceData(e)), _sqlMigrationServiceClientDiagnostics, Pipeline, "SqlMigrationServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve all SQL migration services in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlMigrationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlMigrationServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlMigrationServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlMigrationServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlMigrationServiceResource(Client, SqlMigrationServiceData.DeserializeSqlMigrationServiceData(e)), _sqlMigrationServiceClientDiagnostics, Pipeline, "SqlMigrationServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlMigrationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlMigrationServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sqlMigrationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlMigrationServiceName, nameof(sqlMigrationServiceName));

            using var scope = _sqlMigrationServiceClientDiagnostics.CreateScope("SqlMigrationServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlMigrationServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlMigrationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlMigrationServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string sqlMigrationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlMigrationServiceName, nameof(sqlMigrationServiceName));

            using var scope = _sqlMigrationServiceClientDiagnostics.CreateScope("SqlMigrationServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlMigrationServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlMigrationServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlMigrationServiceResource> IEnumerable<SqlMigrationServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlMigrationServiceResource> IAsyncEnumerable<SqlMigrationServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
