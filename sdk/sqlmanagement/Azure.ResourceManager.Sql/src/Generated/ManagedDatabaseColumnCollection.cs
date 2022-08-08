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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedDatabaseColumnResource" /> and their operations.
    /// Each <see cref="ManagedDatabaseColumnResource" /> in the collection will belong to the same instance of <see cref="ManagedDatabaseTableResource" />.
    /// To get a <see cref="ManagedDatabaseColumnCollection" /> instance call the GetManagedDatabaseColumns method from an instance of <see cref="ManagedDatabaseTableResource" />.
    /// </summary>
    public partial class ManagedDatabaseColumnCollection : ArmCollection, IEnumerable<ManagedDatabaseColumnResource>, IAsyncEnumerable<ManagedDatabaseColumnResource>
    {
        private readonly ClientDiagnostics _managedDatabaseColumnClientDiagnostics;
        private readonly ManagedDatabaseColumnsRestOperations _managedDatabaseColumnRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseColumnCollection"/> class for mocking. </summary>
        protected ManagedDatabaseColumnCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseColumnCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedDatabaseColumnCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseColumnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedDatabaseColumnResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedDatabaseColumnResource.ResourceType, out string managedDatabaseColumnApiVersion);
            _managedDatabaseColumnRestClient = new ManagedDatabaseColumnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseColumnApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabaseTableResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabaseTableResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get managed database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: ManagedDatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual async Task<Response<ManagedDatabaseColumnResource>> GetAsync(string columnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(columnName, nameof(columnName));

            using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseColumnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseColumnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get managed database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: ManagedDatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<ManagedDatabaseColumnResource> Get(string columnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(columnName, nameof(columnName));

            using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseColumnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseColumnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List managed database columns
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns
        /// Operation Id: ManagedDatabaseColumns_ListByTable
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedDatabaseColumnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedDatabaseColumnResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedDatabaseColumnResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseColumnRestClient.ListByTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseColumnResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedDatabaseColumnResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseColumnRestClient.ListByTableNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseColumnResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List managed database columns
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns
        /// Operation Id: ManagedDatabaseColumns_ListByTable
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedDatabaseColumnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedDatabaseColumnResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedDatabaseColumnResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseColumnRestClient.ListByTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseColumnResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedDatabaseColumnResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseColumnRestClient.ListByTableNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseColumnResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: ManagedDatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string columnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(columnName, nameof(columnName));

            using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseColumnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: ManagedDatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<bool> Exists(string columnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(columnName, nameof(columnName));

            using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedDatabaseColumnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedDatabaseColumnResource> IEnumerable<ManagedDatabaseColumnResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedDatabaseColumnResource> IAsyncEnumerable<ManagedDatabaseColumnResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
