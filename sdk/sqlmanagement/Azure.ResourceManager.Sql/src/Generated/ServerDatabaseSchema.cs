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
    /// <summary> A Class representing a ServerDatabaseSchema along with the instance operations that can be performed on it. </summary>
    public partial class ServerDatabaseSchema : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerDatabaseSchema"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverDatabaseSchemaDatabaseSchemasClientDiagnostics;
        private readonly DatabaseSchemasRestOperations _serverDatabaseSchemaDatabaseSchemasRestClient;
        private readonly DatabaseSchemaData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchema"/> class for mocking. </summary>
        protected ServerDatabaseSchema()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerDatabaseSchema"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerDatabaseSchema(ArmClient client, DatabaseSchemaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchema"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerDatabaseSchema(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDatabaseSchemaDatabaseSchemasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string serverDatabaseSchemaDatabaseSchemasApiVersion);
            _serverDatabaseSchemaDatabaseSchemasRestClient = new DatabaseSchemasRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverDatabaseSchemaDatabaseSchemasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/schemas";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseSchemaData Data
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

        /// <summary> Gets a collection of ServerDatabaseSchemaTables in the ServerDatabaseSchemaTable. </summary>
        /// <returns> An object representing collection of ServerDatabaseSchemaTables and their operations over a ServerDatabaseSchemaTable. </returns>
        public virtual ServerDatabaseSchemaTableCollection GetServerDatabaseSchemaTables()
        {
            return new ServerDatabaseSchemaTableCollection(Client, Id);
        }

        /// <summary>
        /// Get database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: DatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<ServerDatabaseSchemaTable>> GetServerDatabaseSchemaTableAsync(string tableName, CancellationToken cancellationToken = default)
        {
            return await GetServerDatabaseSchemaTables().GetAsync(tableName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: DatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<ServerDatabaseSchemaTable> GetServerDatabaseSchemaTable(string tableName, CancellationToken cancellationToken = default)
        {
            return GetServerDatabaseSchemaTables().Get(tableName, cancellationToken);
        }

        /// <summary>
        /// Get database schema
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// Operation Id: DatabaseSchemas_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerDatabaseSchema>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchema.Get");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaDatabaseSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get database schema
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// Operation Id: DatabaseSchemas_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerDatabaseSchema> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchema.Get");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaDatabaseSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
