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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ServerDatabaseSchemaTableColumn along with the instance operations that can be performed on it. </summary>
    public partial class ServerDatabaseSchemaTableColumn : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerDatabaseSchemaTableColumn"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverDatabaseSchemaTableColumnDatabaseColumnsClientDiagnostics;
        private readonly DatabaseColumnsRestOperations _serverDatabaseSchemaTableColumnDatabaseColumnsRestClient;
        private readonly ClientDiagnostics _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics;
        private readonly SensitivityLabelsRestOperations _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient;
        private readonly DatabaseColumnData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaTableColumn"/> class for mocking. </summary>
        protected ServerDatabaseSchemaTableColumn()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerDatabaseSchemaTableColumn"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerDatabaseSchemaTableColumn(ArmClient client, DatabaseColumnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaTableColumn"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerDatabaseSchemaTableColumn(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDatabaseSchemaTableColumnDatabaseColumnsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string serverDatabaseSchemaTableColumnDatabaseColumnsApiVersion);
            _serverDatabaseSchemaTableColumnDatabaseColumnsRestClient = new DatabaseColumnsRestOperations(_serverDatabaseSchemaTableColumnDatabaseColumnsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverDatabaseSchemaTableColumnDatabaseColumnsApiVersion);
            _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerDatabaseSchemaTableColumnSensitivityLabel.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ServerDatabaseSchemaTableColumnSensitivityLabel.ResourceType, out string serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsApiVersion);
            _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient = new SensitivityLabelsRestOperations(_serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/schemas/tables/columns";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseColumnData Data
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

        /// <summary> Gets a collection of ServerDatabaseSchemaTableColumnSensitivityLabels in the ServerDatabaseSchemaTableColumnSensitivityLabel. </summary>
        /// <returns> An object representing collection of ServerDatabaseSchemaTableColumnSensitivityLabels and their operations over a ServerDatabaseSchemaTableColumnSensitivityLabel. </returns>
        public virtual ServerDatabaseSchemaTableColumnSensitivityLabelCollection GetServerDatabaseSchemaTableColumnSensitivityLabels()
        {
            return new ServerDatabaseSchemaTableColumnSensitivityLabelCollection(Client, Id);
        }

        /// <summary>
        /// Get database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: DatabaseColumns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerDatabaseSchemaTableColumn>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnDatabaseColumnsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumn.Get");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaTableColumnDatabaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverDatabaseSchemaTableColumnDatabaseColumnsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDatabaseSchemaTableColumn(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: DatabaseColumns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerDatabaseSchemaTableColumn> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnDatabaseColumnsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumn.Get");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaTableColumnDatabaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _serverDatabaseSchemaTableColumnDatabaseColumnsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchemaTableColumn(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/enable
        /// Operation Id: SensitivityLabels_EnableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> EnableRecommendationSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumn.EnableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.EnableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/enable
        /// Operation Id: SensitivityLabels_EnableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableRecommendationSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumn.EnableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.EnableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/disable
        /// Operation Id: SensitivityLabels_DisableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DisableRecommendationSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumn.DisableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.DisableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/disable
        /// Operation Id: SensitivityLabels_DisableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DisableRecommendationSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumn.DisableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.DisableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
