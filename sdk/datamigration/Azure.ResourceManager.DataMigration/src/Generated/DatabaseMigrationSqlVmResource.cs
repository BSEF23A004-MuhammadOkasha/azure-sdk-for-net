// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A Class representing a DatabaseMigrationSqlVm along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DatabaseMigrationSqlVmResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDatabaseMigrationSqlVmResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetDatabaseMigrationSqlVm method.
    /// </summary>
    public partial class DatabaseMigrationSqlVmResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseMigrationSqlVmResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName, string targetDbName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics;
        private readonly DatabaseMigrationsSqlVmRestOperations _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient;
        private readonly DatabaseMigrationSqlVmData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseMigrationSqlVmResource"/> class for mocking. </summary>
        protected DatabaseMigrationSqlVmResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseMigrationSqlVmResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseMigrationSqlVmResource(ArmClient client, DatabaseMigrationSqlVmData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseMigrationSqlVmResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseMigrationSqlVmResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataMigration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string databaseMigrationSqlVmDatabaseMigrationsSqlVmApiVersion);
            _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient = new DatabaseMigrationsSqlVmRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseMigrationSqlVmDatabaseMigrationsSqlVmApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly Core.ResourceType ResourceType = "Microsoft.DataMigration/databaseMigrations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseMigrationSqlVmData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}
        /// Operation Id: DatabaseMigrationsSqlVm_Get
        /// </summary>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatabaseMigrationSqlVmResource>> GetAsync(Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Get");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, migrationOperationId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseMigrationSqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}
        /// Operation Id: DatabaseMigrationsSqlVm_Get
        /// </summary>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseMigrationSqlVmResource> Get(Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Get");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, migrationOperationId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseMigrationSqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new database migration to a given SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}
        /// Operation Id: DatabaseMigrationsSqlVm_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseMigrationSqlVmResource>> UpdateAsync(WaitUntil waitUntil, DatabaseMigrationSqlVmData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Update");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataMigrationArmOperation<DatabaseMigrationSqlVmResource>(new DatabaseMigrationSqlVmOperationSource(Client), _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a new database migration to a given SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}
        /// Operation Id: DatabaseMigrationsSqlVm_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatabaseMigrationSqlVmResource> Update(WaitUntil waitUntil, DatabaseMigrationSqlVmData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Update");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DataMigrationArmOperation<DatabaseMigrationSqlVmResource>(new DatabaseMigrationSqlVmOperationSource(Client), _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Stop in-progress database migration to SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}/cancel
        /// Operation Id: DatabaseMigrationsSqlVm_cancel
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="input"> The MigrationOperationInput to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual async Task<ArmOperation> CancelAsync(WaitUntil waitUntil, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Cancel");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, cancellationToken).ConfigureAwait(false);
                var operation = new DataMigrationArmOperation(_databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCancelRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Stop in-progress database migration to SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}/cancel
        /// Operation Id: DatabaseMigrationsSqlVm_cancel
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="input"> The MigrationOperationInput to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual ArmOperation Cancel(WaitUntil waitUntil, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Cancel");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, cancellationToken);
                var operation = new DataMigrationArmOperation(_databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCancelRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Initiate cutover for in-progress online database migration to SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}/cutover
        /// Operation Id: DatabaseMigrationsSqlVm_cutover
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="input"> The MigrationOperationInput to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual async Task<ArmOperation> CutoverAsync(WaitUntil waitUntil, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Cutover");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CutoverAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, cancellationToken).ConfigureAwait(false);
                var operation = new DataMigrationArmOperation(_databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCutoverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Initiate cutover for in-progress online database migration to SQL VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}/cutover
        /// Operation Id: DatabaseMigrationsSqlVm_cutover
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="input"> The MigrationOperationInput to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual ArmOperation Cutover(WaitUntil waitUntil, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmResource.Cutover");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.Cutover(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, cancellationToken);
                var operation = new DataMigrationArmOperation(_databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCutoverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
