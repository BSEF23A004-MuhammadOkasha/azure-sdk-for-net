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

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="DataProtectionBackupRecoveryPointResource" /> and their operations.
    /// Each <see cref="DataProtectionBackupRecoveryPointResource" /> in the collection will belong to the same instance of <see cref="DataProtectionBackupInstanceResource" />.
    /// To get a <see cref="DataProtectionBackupRecoveryPointCollection" /> instance call the GetDataProtectionBackupRecoveryPoints method from an instance of <see cref="DataProtectionBackupInstanceResource" />.
    /// </summary>
    public partial class DataProtectionBackupRecoveryPointCollection : ArmCollection, IEnumerable<DataProtectionBackupRecoveryPointResource>, IAsyncEnumerable<DataProtectionBackupRecoveryPointResource>
    {
        private readonly ClientDiagnostics _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics;
        private readonly RecoveryPointsRestOperations _dataProtectionBackupRecoveryPointRecoveryPointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupRecoveryPointCollection"/> class for mocking. </summary>
        protected DataProtectionBackupRecoveryPointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupRecoveryPointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataProtectionBackupRecoveryPointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", DataProtectionBackupRecoveryPointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataProtectionBackupRecoveryPointResource.ResourceType, out string dataProtectionBackupRecoveryPointRecoveryPointsApiVersion);
            _dataProtectionBackupRecoveryPointRecoveryPointsRestClient = new RecoveryPointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataProtectionBackupRecoveryPointRecoveryPointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataProtectionBackupInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataProtectionBackupInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a Recovery Point using recoveryPointId for a Datasource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual async Task<Response<DataProtectionBackupRecoveryPointResource>> GetAsync(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Recovery Point using recoveryPointId for a Datasource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual Response<DataProtectionBackupRecoveryPointResource> Get(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointCollection.Get");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of Recovery Points for a DataSource in a vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProtectionBackupRecoveryPointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProtectionBackupRecoveryPointResource> GetAllAsync(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupRecoveryPointResource(Client, DataProtectionBackupRecoveryPointData.DeserializeDataProtectionBackupRecoveryPointData(e)), _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics, Pipeline, "DataProtectionBackupRecoveryPointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of Recovery Points for a DataSource in a vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProtectionBackupRecoveryPointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProtectionBackupRecoveryPointResource> GetAll(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupRecoveryPointResource(Client, DataProtectionBackupRecoveryPointData.DeserializeDataProtectionBackupRecoveryPointData(e)), _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics, Pipeline, "DataProtectionBackupRecoveryPointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual Response<bool> Exists(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual async Task<NullableResponse<DataProtectionBackupRecoveryPointResource>> GetIfExistsAsync(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataProtectionBackupRecoveryPointResource>(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual NullableResponse<DataProtectionBackupRecoveryPointResource> GetIfExists(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _dataProtectionBackupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataProtectionBackupRecoveryPointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataProtectionBackupRecoveryPointResource>(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataProtectionBackupRecoveryPointResource> IEnumerable<DataProtectionBackupRecoveryPointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataProtectionBackupRecoveryPointResource> IAsyncEnumerable<DataProtectionBackupRecoveryPointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
