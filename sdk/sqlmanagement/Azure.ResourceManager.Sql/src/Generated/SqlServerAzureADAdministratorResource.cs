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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerAzureADAdministrator along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SqlServerAzureADAdministratorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSqlServerAzureADAdministratorResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource"/> using the GetSqlServerAzureADAdministrator method.
    /// </summary>
    public partial class SqlServerAzureADAdministratorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerAzureADAdministratorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="administratorName"> The administratorName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, SqlAdministratorName administratorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics;
        private readonly ServerAzureADAdministratorsRestOperations _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient;
        private readonly SqlServerAzureADAdministratorData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/administrators";

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADAdministratorResource"/> class for mocking. </summary>
        protected SqlServerAzureADAdministratorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADAdministratorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerAzureADAdministratorResource(ArmClient client, SqlServerAzureADAdministratorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADAdministratorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerAzureADAdministratorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerAzureADAdministratorServerAzureADAdministratorsApiVersion);
            _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient = new ServerAzureADAdministratorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerAzureADAdministratorServerAzureADAdministratorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlServerAzureADAdministratorData Data
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
        /// Gets a Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerAzureADAdministratorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerAzureADAdministratorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the Azure Active Directory administrator with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorResource.Delete");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the Azure Active Directory administrator with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorResource.Delete");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an existing Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested Azure Active Directory administrator Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerAzureADAdministratorResource>> UpdateAsync(WaitUntil waitUntil, SqlServerAzureADAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorResource.Update");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerAzureADAdministratorResource>(new SqlServerAzureADAdministratorOperationSource(Client), _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an existing Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested Azure Active Directory administrator Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerAzureADAdministratorResource> Update(WaitUntil waitUntil, SqlServerAzureADAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorResource.Update");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerAzureADAdministratorResource>(new SqlServerAzureADAdministratorOperationSource(Client), _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
