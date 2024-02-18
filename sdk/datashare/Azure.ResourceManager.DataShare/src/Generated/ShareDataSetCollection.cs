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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="ShareDataSetResource"/> and their operations.
    /// Each <see cref="ShareDataSetResource"/> in the collection will belong to the same instance of <see cref="DataShareResource"/>.
    /// To get a <see cref="ShareDataSetCollection"/> instance call the GetShareDataSets method from an instance of <see cref="DataShareResource"/>.
    /// </summary>
    public partial class ShareDataSetCollection : ArmCollection, IEnumerable<ShareDataSetResource>, IAsyncEnumerable<ShareDataSetResource>
    {
        private readonly ClientDiagnostics _shareDataSetDataSetsClientDiagnostics;
        private readonly DataSetsRestOperations _shareDataSetDataSetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ShareDataSetCollection"/> class for mocking. </summary>
        protected ShareDataSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ShareDataSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ShareDataSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _shareDataSetDataSetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", ShareDataSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ShareDataSetResource.ResourceType, out string shareDataSetDataSetsApiVersion);
            _shareDataSetDataSetsRestClient = new DataSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, shareDataSetDataSetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataShareResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataShareResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DataSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="data"> The new data set information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ShareDataSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataSetName, ShareDataSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _shareDataSetDataSetsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, data, cancellationToken).ConfigureAwait(false);
                var uri = _shareDataSetDataSetsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DataShareArmOperation<ShareDataSetResource>(Response.FromValue(new ShareDataSetResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a DataSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="data"> The new data set information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ShareDataSetResource> CreateOrUpdate(WaitUntil waitUntil, string dataSetName, ShareDataSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _shareDataSetDataSetsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, data, cancellationToken);
                var uri = _shareDataSetDataSetsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DataShareArmOperation<ShareDataSetResource>(Response.FromValue(new ShareDataSetResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get a DataSet in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        public virtual async Task<Response<ShareDataSetResource>> GetAsync(string dataSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _shareDataSetDataSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DataSet in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        public virtual Response<ShareDataSetResource> Get(string dataSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.Get");
            scope.Start();
            try
            {
                var response = _shareDataSetDataSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DataSets in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_ListByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ShareDataSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ShareDataSetResource> GetAllAsync(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _shareDataSetDataSetsRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _shareDataSetDataSetsRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ShareDataSetResource(Client, ShareDataSetData.DeserializeShareDataSetData(e)), _shareDataSetDataSetsClientDiagnostics, Pipeline, "ShareDataSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DataSets in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_ListByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ShareDataSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ShareDataSetResource> GetAll(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _shareDataSetDataSetsRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _shareDataSetDataSetsRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ShareDataSetResource(Client, ShareDataSetData.DeserializeShareDataSetData(e)), _shareDataSetDataSetsClientDiagnostics, Pipeline, "ShareDataSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _shareDataSetDataSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _shareDataSetDataSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        public virtual async Task<NullableResponse<ShareDataSetResource>> GetIfExistsAsync(string dataSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _shareDataSetDataSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ShareDataSetResource>(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ShareDataSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        public virtual NullableResponse<ShareDataSetResource> GetIfExists(string dataSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSetName, nameof(dataSetName));

            using var scope = _shareDataSetDataSetsClientDiagnostics.CreateScope("ShareDataSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _shareDataSetDataSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ShareDataSetResource>(response.GetRawResponse());
                return Response.FromValue(new ShareDataSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ShareDataSetResource> IEnumerable<ShareDataSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ShareDataSetResource> IAsyncEnumerable<ShareDataSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
