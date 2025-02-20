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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBThroughputPoolResource"/> and their operations.
    /// Each <see cref="CosmosDBThroughputPoolResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="CosmosDBThroughputPoolCollection"/> instance call the GetCosmosDBThroughputPools method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class CosmosDBThroughputPoolCollection : ArmCollection, IEnumerable<CosmosDBThroughputPoolResource>, IAsyncEnumerable<CosmosDBThroughputPoolResource>
    {
        private readonly ClientDiagnostics _cosmosDBThroughputPoolThroughputPoolClientDiagnostics;
        private readonly ThroughputPoolRestOperations _cosmosDBThroughputPoolThroughputPoolRestClient;
        private readonly ClientDiagnostics _cosmosDBThroughputPoolThroughputPoolsClientDiagnostics;
        private readonly ThroughputPoolsRestOperations _cosmosDBThroughputPoolThroughputPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBThroughputPoolCollection"/> class for mocking. </summary>
        protected CosmosDBThroughputPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBThroughputPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBThroughputPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBThroughputPoolThroughputPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBThroughputPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBThroughputPoolResource.ResourceType, out string cosmosDBThroughputPoolThroughputPoolApiVersion);
            _cosmosDBThroughputPoolThroughputPoolRestClient = new ThroughputPoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBThroughputPoolThroughputPoolApiVersion);
            _cosmosDBThroughputPoolThroughputPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBThroughputPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBThroughputPoolResource.ResourceType, out string cosmosDBThroughputPoolThroughputPoolsApiVersion);
            _cosmosDBThroughputPoolThroughputPoolsRestClient = new ThroughputPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBThroughputPoolThroughputPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB ThroughputPool account. The "Update" method is preferred when performing updates on an account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="data"> The parameters to provide for the current ThroughputPool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBThroughputPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string throughputPoolName, CosmosDBThroughputPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBThroughputPoolThroughputPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBThroughputPoolResource>(new CosmosDBThroughputPoolOperationSource(Client), _cosmosDBThroughputPoolThroughputPoolClientDiagnostics, Pipeline, _cosmosDBThroughputPoolThroughputPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an Azure Cosmos DB ThroughputPool account. The "Update" method is preferred when performing updates on an account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="data"> The parameters to provide for the current ThroughputPool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBThroughputPoolResource> CreateOrUpdate(WaitUntil waitUntil, string throughputPoolName, CosmosDBThroughputPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBThroughputPoolThroughputPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, data, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBThroughputPoolResource>(new CosmosDBThroughputPoolOperationSource(Client), _cosmosDBThroughputPoolThroughputPoolClientDiagnostics, Pipeline, _cosmosDBThroughputPoolThroughputPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the properties of an existing Azure Cosmos DB Throughput Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBThroughputPoolResource>> GetAsync(string throughputPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBThroughputPoolThroughputPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBThroughputPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB Throughput Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> is null. </exception>
        public virtual Response<CosmosDBThroughputPoolResource> Get(string throughputPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBThroughputPoolThroughputPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBThroughputPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the ThroughputPools in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPools_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBThroughputPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBThroughputPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBThroughputPoolThroughputPoolsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBThroughputPoolThroughputPoolsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CosmosDBThroughputPoolResource(Client, CosmosDBThroughputPoolData.DeserializeCosmosDBThroughputPoolData(e)), _cosmosDBThroughputPoolThroughputPoolsClientDiagnostics, Pipeline, "CosmosDBThroughputPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the ThroughputPools in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPools_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBThroughputPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBThroughputPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBThroughputPoolThroughputPoolsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBThroughputPoolThroughputPoolsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CosmosDBThroughputPoolResource(Client, CosmosDBThroughputPoolData.DeserializeCosmosDBThroughputPoolData(e)), _cosmosDBThroughputPoolThroughputPoolsClientDiagnostics, Pipeline, "CosmosDBThroughputPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string throughputPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBThroughputPoolThroughputPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string throughputPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBThroughputPoolThroughputPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBThroughputPoolResource>> GetIfExistsAsync(string throughputPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBThroughputPoolThroughputPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBThroughputPoolResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBThroughputPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputPools/{throughputPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThroughputPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBThroughputPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="throughputPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="throughputPoolName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBThroughputPoolResource> GetIfExists(string throughputPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(throughputPoolName, nameof(throughputPoolName));

            using var scope = _cosmosDBThroughputPoolThroughputPoolClientDiagnostics.CreateScope("CosmosDBThroughputPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBThroughputPoolThroughputPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, throughputPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBThroughputPoolResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBThroughputPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBThroughputPoolResource> IEnumerable<CosmosDBThroughputPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBThroughputPoolResource> IAsyncEnumerable<CosmosDBThroughputPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
