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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevCenterCatalogResource" /> and their operations.
    /// Each <see cref="DevCenterCatalogResource" /> in the collection will belong to the same instance of <see cref="DevCenterResource" />.
    /// To get a <see cref="DevCenterCatalogCollection" /> instance call the GetDevCenterCatalogs method from an instance of <see cref="DevCenterResource" />.
    /// </summary>
    public partial class DevCenterCatalogCollection : ArmCollection, IEnumerable<DevCenterCatalogResource>, IAsyncEnumerable<DevCenterCatalogResource>
    {
        private readonly ClientDiagnostics _devCenterCatalogCatalogsClientDiagnostics;
        private readonly CatalogsRestOperations _devCenterCatalogCatalogsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevCenterCatalogCollection"/> class for mocking. </summary>
        protected DevCenterCatalogCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterCatalogCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevCenterCatalogCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterCatalogCatalogsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterCatalogResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevCenterCatalogResource.ResourceType, out string devCenterCatalogCatalogsApiVersion);
            _devCenterCatalogCatalogsRestClient = new CatalogsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterCatalogCatalogsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a catalog.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="catalogName"> The name of the Catalog. </param>
        /// <param name="data"> Represents a catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevCenterCatalogResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string catalogName, DevCenterCatalogData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterCatalogCatalogsClientDiagnostics.CreateScope("DevCenterCatalogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devCenterCatalogCatalogsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<DevCenterCatalogResource>(new DevCenterCatalogOperationSource(Client), _devCenterCatalogCatalogsClientDiagnostics, Pipeline, _devCenterCatalogCatalogsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a catalog.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="catalogName"> The name of the Catalog. </param>
        /// <param name="data"> Represents a catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevCenterCatalogResource> CreateOrUpdate(WaitUntil waitUntil, string catalogName, DevCenterCatalogData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterCatalogCatalogsClientDiagnostics.CreateScope("DevCenterCatalogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devCenterCatalogCatalogsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, data, cancellationToken);
                var operation = new DevCenterArmOperation<DevCenterCatalogResource>(new DevCenterCatalogOperationSource(Client), _devCenterCatalogCatalogsClientDiagnostics, Pipeline, _devCenterCatalogCatalogsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> The name of the Catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual async Task<Response<DevCenterCatalogResource>> GetAsync(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _devCenterCatalogCatalogsClientDiagnostics.CreateScope("DevCenterCatalogCollection.Get");
            scope.Start();
            try
            {
                var response = await _devCenterCatalogCatalogsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterCatalogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> The name of the Catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual Response<DevCenterCatalogResource> Get(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _devCenterCatalogCatalogsClientDiagnostics.CreateScope("DevCenterCatalogCollection.Get");
            scope.Start();
            try
            {
                var response = _devCenterCatalogCatalogsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterCatalogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists catalogs for a devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterCatalogResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterCatalogCatalogsRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterCatalogCatalogsRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevCenterCatalogResource(Client, DevCenterCatalogData.DeserializeDevCenterCatalogData(e)), _devCenterCatalogCatalogsClientDiagnostics, Pipeline, "DevCenterCatalogCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists catalogs for a devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterCatalogResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterCatalogCatalogsRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterCatalogCatalogsRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevCenterCatalogResource(Client, DevCenterCatalogData.DeserializeDevCenterCatalogData(e)), _devCenterCatalogCatalogsClientDiagnostics, Pipeline, "DevCenterCatalogCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> The name of the Catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _devCenterCatalogCatalogsClientDiagnostics.CreateScope("DevCenterCatalogCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devCenterCatalogCatalogsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> The name of the Catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual Response<bool> Exists(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _devCenterCatalogCatalogsClientDiagnostics.CreateScope("DevCenterCatalogCollection.Exists");
            scope.Start();
            try
            {
                var response = _devCenterCatalogCatalogsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, catalogName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevCenterCatalogResource> IEnumerable<DevCenterCatalogResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevCenterCatalogResource> IAsyncEnumerable<DevCenterCatalogResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
