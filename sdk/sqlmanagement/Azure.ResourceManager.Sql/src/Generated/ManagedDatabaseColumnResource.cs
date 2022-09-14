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
    /// A Class representing a ManagedDatabaseColumn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedDatabaseColumnResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedDatabaseColumnResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedDatabaseTableResource" /> using the GetManagedDatabaseColumn method.
    /// </summary>
    public partial class ManagedDatabaseColumnResource : DatabaseColumnResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedDatabaseColumnResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedDatabaseColumnClientDiagnostics;
        private readonly ManagedDatabaseColumnsRestOperations _managedDatabaseColumnRestClient;
        private readonly ClientDiagnostics _managedDatabaseSensitivityLabelClientDiagnostics;
        private readonly ManagedDatabaseSensitivityLabelsRestOperations _managedDatabaseSensitivityLabelRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseColumnResource"/> class for mocking. </summary>
        protected ManagedDatabaseColumnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedDatabaseColumnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedDatabaseColumnResource(ArmClient client, DatabaseColumnData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseColumnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedDatabaseColumnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseColumnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedDatabaseColumnApiVersion);
            _managedDatabaseColumnRestClient = new ManagedDatabaseColumnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseColumnApiVersion);
            _managedDatabaseSensitivityLabelClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedDatabaseSensitivityLabelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedDatabaseSensitivityLabelResource.ResourceType, out string managedDatabaseSensitivityLabelApiVersion);
            _managedDatabaseSensitivityLabelRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseSensitivityLabelApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas/tables/columns";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ManagedDatabaseSensitivityLabelResources in the ManagedDatabaseColumn. </summary>
        /// <returns> An object representing collection of ManagedDatabaseSensitivityLabelResources and their operations over a ManagedDatabaseSensitivityLabelResource. </returns>
        public virtual ManagedDatabaseSensitivityLabelCollection GetManagedDatabaseSensitivityLabels()
        {
            return GetCachedClient(Client => new ManagedDatabaseSensitivityLabelCollection(Client, Id));
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: ManagedDatabaseSensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedDatabaseSensitivityLabelResource>> GetManagedDatabaseSensitivityLabelAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            return await GetManagedDatabaseSensitivityLabels().GetAsync(sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: ManagedDatabaseSensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ManagedDatabaseSensitivityLabelResource> GetManagedDatabaseSensitivityLabel(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            return GetManagedDatabaseSensitivityLabels().Get(sensitivityLabelSource, cancellationToken);
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<DatabaseColumnResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnResource.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseColumnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<ManagedDatabaseColumnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken);
            return Response.FromValue((ManagedDatabaseColumnResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<DatabaseColumnResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseColumnClientDiagnostics.CreateScope("ManagedDatabaseColumnResource.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseColumnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<ManagedDatabaseColumnResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((ManagedDatabaseColumnResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable
        /// Operation Id: ManagedDatabaseSensitivityLabels_DisableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DisableRecommendationManagedDatabaseSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseSensitivityLabelClientDiagnostics.CreateScope("ManagedDatabaseColumnResource.DisableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelRestClient.DisableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable
        /// Operation Id: ManagedDatabaseSensitivityLabels_DisableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DisableRecommendationManagedDatabaseSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseSensitivityLabelClientDiagnostics.CreateScope("ManagedDatabaseColumnResource.DisableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelRestClient.DisableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable
        /// Operation Id: ManagedDatabaseSensitivityLabels_EnableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnableRecommendationManagedDatabaseSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseSensitivityLabelClientDiagnostics.CreateScope("ManagedDatabaseColumnResource.EnableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelRestClient.EnableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable
        /// Operation Id: ManagedDatabaseSensitivityLabels_EnableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableRecommendationManagedDatabaseSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseSensitivityLabelClientDiagnostics.CreateScope("ManagedDatabaseColumnResource.EnableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelRestClient.EnableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
