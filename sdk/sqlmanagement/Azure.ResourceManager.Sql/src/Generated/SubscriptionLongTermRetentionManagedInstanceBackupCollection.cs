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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackupResource" /> and their operations.
    /// Each <see cref="SubscriptionLongTermRetentionManagedInstanceBackupResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionLongTermRetentionManagedInstanceBackupCollection" /> instance call the GetSubscriptionLongTermRetentionManagedInstanceBackups method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionLongTermRetentionManagedInstanceBackupCollection : ArmCollection, IEnumerable<SubscriptionLongTermRetentionManagedInstanceBackupResource>, IAsyncEnumerable<SubscriptionLongTermRetentionManagedInstanceBackupResource>
    {
        private readonly ClientDiagnostics _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient;
        private readonly AzureLocation _locationName;
        private readonly string _managedInstanceName;
        private readonly string _databaseName;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionManagedInstanceBackupCollection"/> class for mocking. </summary>
        protected SubscriptionLongTermRetentionManagedInstanceBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionManagedInstanceBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SubscriptionLongTermRetentionManagedInstanceBackupCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName, string managedInstanceName, string databaseName) : base(client, id)
        {
            _locationName = locationName;
            _managedInstanceName = managedInstanceName;
            _databaseName = databaseName;
            _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SubscriptionLongTermRetentionManagedInstanceBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionLongTermRetentionManagedInstanceBackupResource.ResourceType, out string subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
            _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a long term retention backup for a managed database.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_Get
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionLongTermRetentionManagedInstanceBackupResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a long term retention backup for a managed database.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_Get
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLongTermRetentionManagedInstanceBackupResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all long term retention backups for a managed database.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// Operation Id: LongTermRetentionManagedInstanceBackups_ListByDatabase
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionLongTermRetentionManagedInstanceBackupResource> GetAllAsync(bool? onlyLatestPerDatabase = null, SqlDatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionLongTermRetentionManagedInstanceBackupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseAsync(Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionLongTermRetentionManagedInstanceBackupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all long term retention backups for a managed database.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// Operation Id: LongTermRetentionManagedInstanceBackups_ListByDatabase
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionLongTermRetentionManagedInstanceBackupResource> GetAll(bool? onlyLatestPerDatabase = null, SqlDatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Page<SubscriptionLongTermRetentionManagedInstanceBackupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByDatabase(Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionLongTermRetentionManagedInstanceBackupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_Get
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_Get
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionLongTermRetentionManagedInstanceBackupResource> IEnumerable<SubscriptionLongTermRetentionManagedInstanceBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionLongTermRetentionManagedInstanceBackupResource> IAsyncEnumerable<SubscriptionLongTermRetentionManagedInstanceBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
