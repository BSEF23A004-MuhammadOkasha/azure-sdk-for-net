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
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeAnalyticsAccountResource" /> and their operations.
    /// Each <see cref="DataLakeAnalyticsAccountResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DataLakeAnalyticsAccountCollection" /> instance call the GetDataLakeAnalyticsAccounts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DataLakeAnalyticsAccountCollection : ArmCollection, IEnumerable<DataLakeAnalyticsAccountBasic>, IAsyncEnumerable<DataLakeAnalyticsAccountBasic>
    {
        private readonly ClientDiagnostics _dataLakeAnalyticsAccountAccountsClientDiagnostics;
        private readonly AccountsRestOperations _dataLakeAnalyticsAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsAccountCollection"/> class for mocking. </summary>
        protected DataLakeAnalyticsAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeAnalyticsAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeAnalyticsAccountAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", DataLakeAnalyticsAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeAnalyticsAccountResource.ResourceType, out string dataLakeAnalyticsAccountAccountsApiVersion);
            _dataLakeAnalyticsAccountAccountsRestClient = new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeAnalyticsAccountAccountsApiVersion);
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
        /// Creates the specified Data Lake Analytics account. This supplies the user with computation services for Data Lake Analytics workloads.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="content"> Parameters supplied to create a new Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeAnalyticsAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, DataLakeAnalyticsAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsAccountAccountsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsAccountResource>(new DataLakeAnalyticsAccountOperationSource(Client), _dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, _dataLakeAnalyticsAccountAccountsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates the specified Data Lake Analytics account. This supplies the user with computation services for Data Lake Analytics workloads.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="content"> Parameters supplied to create a new Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataLakeAnalyticsAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, DataLakeAnalyticsAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsAccountAccountsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsAccountResource>(new DataLakeAnalyticsAccountOperationSource(Client), _dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, _dataLakeAnalyticsAccountAccountsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets details of the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<DataLakeAnalyticsAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<DataLakeAnalyticsAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within a specific resource group. This includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeAnalyticsAccountBasic> GetAllAsync(DataLakeAnalyticsAccountCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeAnalyticsAccountCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DataLakeAnalyticsAccountBasic.DeserializeDataLakeAnalyticsAccountBasic, _dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, "DataLakeAnalyticsAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within a specific resource group. This includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeAnalyticsAccountBasic> GetAll(DataLakeAnalyticsAccountCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeAnalyticsAccountCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DataLakeAnalyticsAccountBasic.DeserializeDataLakeAnalyticsAccountBasic, _dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, "DataLakeAnalyticsAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataLakeAnalyticsAccountResource>> GetIfExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeAnalyticsAccountResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsAccountResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual NullableResponse<DataLakeAnalyticsAccountResource> GetIfExists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeAnalyticsAccountResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeAnalyticsAccountBasic> IEnumerable<DataLakeAnalyticsAccountBasic>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<DataLakeAnalyticsAccountBasic> IAsyncEnumerable<DataLakeAnalyticsAccountBasic>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
