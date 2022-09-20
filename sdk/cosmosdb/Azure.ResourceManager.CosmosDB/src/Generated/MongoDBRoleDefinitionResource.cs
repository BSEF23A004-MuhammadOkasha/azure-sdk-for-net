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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a MongoDBRoleDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MongoDBRoleDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMongoDBRoleDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBAccountResource" /> using the GetMongoDBRoleDefinition method.
    /// </summary>
    public partial class MongoDBRoleDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MongoDBRoleDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string mongoRoleDefinitionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _mongoDBRoleDefinitionMongoDBResourcesRestClient;
        private readonly MongoDBRoleDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="MongoDBRoleDefinitionResource"/> class for mocking. </summary>
        protected MongoDBRoleDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MongoDBRoleDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MongoDBRoleDefinitionResource(ArmClient client, MongoDBRoleDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MongoDBRoleDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MongoDBRoleDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mongoDBRoleDefinitionMongoDBResourcesApiVersion);
            _mongoDBRoleDefinitionMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mongoDBRoleDefinitionMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/mongodbRoleDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MongoDBRoleDefinitionData Data
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
        /// Retrieves the properties of an existing Azure Cosmos DB Mongo Role Definition with the given Id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
        /// Operation Id: MongoDBResources_GetMongoRoleDefinition
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MongoDBRoleDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB Mongo Role Definition with the given Id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
        /// Operation Id: MongoDBResources_GetMongoRoleDefinition
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MongoDBRoleDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing Azure Cosmos DB Mongo Role Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
        /// Operation Id: MongoDBResources_DeleteMongoRoleDefinition
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = await _mongoDBRoleDefinitionMongoDBResourcesRestClient.DeleteMongoRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation(_mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateDeleteMongoRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes an existing Azure Cosmos DB Mongo Role Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
        /// Operation Id: MongoDBResources_DeleteMongoRoleDefinition
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = _mongoDBRoleDefinitionMongoDBResourcesRestClient.DeleteMongoRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CosmosDBArmOperation(_mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateDeleteMongoRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB Mongo Role Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
        /// Operation Id: MongoDBResources_CreateUpdateMongoRoleDefinition
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<MongoDBRoleDefinitionResource>> UpdateAsync(WaitUntil waitUntil, MongoDBRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = await _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateUpdateMongoRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<MongoDBRoleDefinitionResource>(new MongoDBRoleDefinitionOperationSource(Client), _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateCreateUpdateMongoRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB Mongo Role Definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
        /// Operation Id: MongoDBResources_CreateUpdateMongoRoleDefinition
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<MongoDBRoleDefinitionResource> Update(WaitUntil waitUntil, MongoDBRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateUpdateMongoRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new CosmosDBArmOperation<MongoDBRoleDefinitionResource>(new MongoDBRoleDefinitionOperationSource(Client), _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateCreateUpdateMongoRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
