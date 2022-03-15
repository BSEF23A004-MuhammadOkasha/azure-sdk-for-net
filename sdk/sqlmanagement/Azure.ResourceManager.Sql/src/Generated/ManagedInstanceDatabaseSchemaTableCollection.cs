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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstanceDatabaseSchemaTable and their operations over its parent. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableCollection : ArmCollection, IEnumerable<ManagedInstanceDatabaseSchemaTable>, IAsyncEnumerable<ManagedInstanceDatabaseSchemaTable>
    {
        private readonly ClientDiagnostics _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics;
        private readonly ManagedDatabaseTablesRestOperations _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableCollection"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceDatabaseSchemaTable.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ManagedInstanceDatabaseSchemaTable.ResourceType, out string managedInstanceDatabaseSchemaTableManagedDatabaseTablesApiVersion);
            _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient = new ManagedDatabaseTablesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseSchemaTableManagedDatabaseTablesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceDatabaseSchema.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceDatabaseSchema.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstanceDatabaseSchemaTable>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTable> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List managed database tables
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables
        /// Operation Id: ManagedDatabaseTables_ListBySchema
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceDatabaseSchemaTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceDatabaseSchemaTable> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceDatabaseSchemaTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.ListBySchemaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceDatabaseSchemaTable>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.ListBySchemaNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List managed database tables
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables
        /// Operation Id: ManagedDatabaseTables_ListBySchema
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceDatabaseSchemaTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceDatabaseSchemaTable> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceDatabaseSchemaTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.ListBySchema(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceDatabaseSchemaTable> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.ListBySchemaNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tableName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstanceDatabaseSchemaTable>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseSchemaTable>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTable> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseSchemaTable>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceDatabaseSchemaTable> IEnumerable<ManagedInstanceDatabaseSchemaTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceDatabaseSchemaTable> IAsyncEnumerable<ManagedInstanceDatabaseSchemaTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
