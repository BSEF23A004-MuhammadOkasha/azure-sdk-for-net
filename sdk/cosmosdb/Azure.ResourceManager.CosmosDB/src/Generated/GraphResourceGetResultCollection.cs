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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="GraphResourceGetResultResource"/> and their operations.
    /// Each <see cref="GraphResourceGetResultResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="GraphResourceGetResultCollection"/> instance call the GetGraphResourceGetResults method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class GraphResourceGetResultCollection : ArmCollection, IEnumerable<GraphResourceGetResultResource>, IAsyncEnumerable<GraphResourceGetResultResource>
    {
        private readonly ClientDiagnostics _graphResourceGetResultGraphResourcesClientDiagnostics;
        private readonly GraphResourcesRestOperations _graphResourceGetResultGraphResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GraphResourceGetResultCollection"/> class for mocking. </summary>
        protected GraphResourceGetResultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GraphResourceGetResultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GraphResourceGetResultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _graphResourceGetResultGraphResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", GraphResourceGetResultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GraphResourceGetResultResource.ResourceType, out string graphResourceGetResultGraphResourcesApiVersion);
            _graphResourceGetResultGraphResourcesRestClient = new GraphResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, graphResourceGetResultGraphResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Graph.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_CreateUpdateGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="content"> The parameters to provide for the current graph. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<GraphResourceGetResultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string graphName, GraphResourceGetResultCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _graphResourceGetResultGraphResourcesRestClient.CreateUpdateGraphAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<GraphResourceGetResultResource>(new GraphResourceGetResultOperationSource(Client), _graphResourceGetResultGraphResourcesClientDiagnostics, Pipeline, _graphResourceGetResultGraphResourcesRestClient.CreateCreateUpdateGraphRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB Graph.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_CreateUpdateGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="content"> The parameters to provide for the current graph. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<GraphResourceGetResultResource> CreateOrUpdate(WaitUntil waitUntil, string graphName, GraphResourceGetResultCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _graphResourceGetResultGraphResourcesRestClient.CreateUpdateGraph(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<GraphResourceGetResultResource>(new GraphResourceGetResultOperationSource(Client), _graphResourceGetResultGraphResourcesClientDiagnostics, Pipeline, _graphResourceGetResultGraphResourcesRestClient.CreateCreateUpdateGraphRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the Graph resource under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_GetGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual async Task<Response<GraphResourceGetResultResource>> GetAsync(string graphName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.Get");
            scope.Start();
            try
            {
                var response = await _graphResourceGetResultGraphResourcesRestClient.GetGraphAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GraphResourceGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Graph resource under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_GetGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual Response<GraphResourceGetResultResource> Get(string graphName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.Get");
            scope.Start();
            try
            {
                var response = _graphResourceGetResultGraphResourcesRestClient.GetGraph(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GraphResourceGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the graphs under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_ListGraphs</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GraphResourceGetResultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GraphResourceGetResultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _graphResourceGetResultGraphResourcesRestClient.CreateListGraphsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new GraphResourceGetResultResource(Client, GraphResourceGetResultData.DeserializeGraphResourceGetResultData(e)), _graphResourceGetResultGraphResourcesClientDiagnostics, Pipeline, "GraphResourceGetResultCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the graphs under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_ListGraphs</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GraphResourceGetResultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GraphResourceGetResultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _graphResourceGetResultGraphResourcesRestClient.CreateListGraphsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new GraphResourceGetResultResource(Client, GraphResourceGetResultData.DeserializeGraphResourceGetResultData(e)), _graphResourceGetResultGraphResourcesClientDiagnostics, Pipeline, "GraphResourceGetResultCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_GetGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string graphName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _graphResourceGetResultGraphResourcesRestClient.GetGraphAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_GetGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual Response<bool> Exists(string graphName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.Exists");
            scope.Start();
            try
            {
                var response = _graphResourceGetResultGraphResourcesRestClient.GetGraph(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_GetGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual async Task<NullableResponse<GraphResourceGetResultResource>> GetIfExistsAsync(string graphName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _graphResourceGetResultGraphResourcesRestClient.GetGraphAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GraphResourceGetResultResource>(response.GetRawResponse());
                return Response.FromValue(new GraphResourceGetResultResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/graphs/{graphName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphResources_GetGraph</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphResourceGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="graphName"> Cosmos DB graph resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="graphName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="graphName"/> is null. </exception>
        public virtual NullableResponse<GraphResourceGetResultResource> GetIfExists(string graphName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(graphName, nameof(graphName));

            using var scope = _graphResourceGetResultGraphResourcesClientDiagnostics.CreateScope("GraphResourceGetResultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _graphResourceGetResultGraphResourcesRestClient.GetGraph(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, graphName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GraphResourceGetResultResource>(response.GetRawResponse());
                return Response.FromValue(new GraphResourceGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GraphResourceGetResultResource> IEnumerable<GraphResourceGetResultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GraphResourceGetResultResource> IAsyncEnumerable<GraphResourceGetResultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
