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
using Azure.ResourceManager.DataLakeStore.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeStoreAccountResource" /> and their operations.
    /// Each <see cref="DataLakeStoreAccountResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DataLakeStoreAccountCollection" /> instance call the GetDataLakeStoreAccounts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DataLakeStoreAccountCollection : ArmCollection, IEnumerable<DataLakeStoreAccountBasicData>, IAsyncEnumerable<DataLakeStoreAccountBasicData>
    {
        private readonly ClientDiagnostics _dataLakeStoreAccountAccountsClientDiagnostics;
        private readonly AccountsRestOperations _dataLakeStoreAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreAccountCollection"/> class for mocking. </summary>
        protected DataLakeStoreAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeStoreAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeStoreAccountAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeStore", DataLakeStoreAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeStoreAccountResource.ResourceType, out string dataLakeStoreAccountAccountsApiVersion);
            _dataLakeStoreAccountAccountsRestClient = new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeStoreAccountAccountsApiVersion);
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
        /// Creates the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="content"> Parameters supplied to create the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeStoreAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, DataLakeStoreAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountAccountsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreAccountResource>(new DataLakeStoreAccountOperationSource(Client), _dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, _dataLakeStoreAccountAccountsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="content"> Parameters supplied to create the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataLakeStoreAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, DataLakeStoreAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountAccountsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreAccountResource>(new DataLakeStoreAccountOperationSource(Client), _dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, _dataLakeStoreAccountAccountsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Gets the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<DataLakeStoreAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<DataLakeStoreAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Data Lake Store accounts within a specific resource group. The response includes a link to the next page of results, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeStoreAccountBasicData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeStoreAccountBasicData> GetAllAsync(DataLakeStoreAccountCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeStoreAccountCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeStoreAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.OrderBy, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeStoreAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.OrderBy, options.Count);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DataLakeStoreAccountBasicData.DeserializeDataLakeStoreAccountBasicData, _dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, "DataLakeStoreAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Data Lake Store accounts within a specific resource group. The response includes a link to the next page of results, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeStoreAccountBasicData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeStoreAccountBasicData> GetAll(DataLakeStoreAccountCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeStoreAccountCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeStoreAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.OrderBy, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeStoreAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.OrderBy, options.Count);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DataLakeStoreAccountBasicData.DeserializeDataLakeStoreAccountBasicData, _dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, "DataLakeStoreAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeStoreAccountBasicData> IEnumerable<DataLakeStoreAccountBasicData>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<DataLakeStoreAccountBasicData> IAsyncEnumerable<DataLakeStoreAccountBasicData>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
