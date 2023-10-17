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
    /// A class representing a collection of <see cref="DataShareSynchronizationSettingResource" /> and their operations.
    /// Each <see cref="DataShareSynchronizationSettingResource" /> in the collection will belong to the same instance of <see cref="DataShareResource" />.
    /// To get a <see cref="DataShareSynchronizationSettingCollection" /> instance call the GetDataShareSynchronizationSettings method from an instance of <see cref="DataShareResource" />.
    /// </summary>
    public partial class DataShareSynchronizationSettingCollection : ArmCollection, IEnumerable<DataShareSynchronizationSettingResource>, IAsyncEnumerable<DataShareSynchronizationSettingResource>
    {
        private readonly ClientDiagnostics _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics;
        private readonly SynchronizationSettingsRestOperations _dataShareSynchronizationSettingSynchronizationSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataShareSynchronizationSettingCollection"/> class for mocking. </summary>
        protected DataShareSynchronizationSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareSynchronizationSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataShareSynchronizationSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", DataShareSynchronizationSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataShareSynchronizationSettingResource.ResourceType, out string dataShareSynchronizationSettingSynchronizationSettingsApiVersion);
            _dataShareSynchronizationSettingSynchronizationSettingsRestClient = new SynchronizationSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataShareSynchronizationSettingSynchronizationSettingsApiVersion);
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
        /// Create a synchronizationSetting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="data"> The new synchronization setting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataShareSynchronizationSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string synchronizationSettingName, DataShareSynchronizationSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataShareSynchronizationSettingSynchronizationSettingsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<DataShareSynchronizationSettingResource>(Response.FromValue(new DataShareSynchronizationSettingResource(Client, response), response.GetRawResponse()));
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
        /// Create a synchronizationSetting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="data"> The new synchronization setting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataShareSynchronizationSettingResource> CreateOrUpdate(WaitUntil waitUntil, string synchronizationSettingName, DataShareSynchronizationSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataShareSynchronizationSettingSynchronizationSettingsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, data, cancellationToken);
                var operation = new DataShareArmOperation<DataShareSynchronizationSettingResource>(Response.FromValue(new DataShareSynchronizationSettingResource(Client, response), response.GetRawResponse()));
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
        /// Get a synchronizationSetting in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual async Task<Response<DataShareSynchronizationSettingResource>> GetAsync(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataShareSynchronizationSettingSynchronizationSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareSynchronizationSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a synchronizationSetting in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual Response<DataShareSynchronizationSettingResource> Get(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _dataShareSynchronizationSettingSynchronizationSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareSynchronizationSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List synchronizationSettings in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_ListByShare</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataShareSynchronizationSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataShareSynchronizationSettingResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSynchronizationSettingSynchronizationSettingsRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSynchronizationSettingSynchronizationSettingsRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataShareSynchronizationSettingResource(Client, DataShareSynchronizationSettingData.DeserializeDataShareSynchronizationSettingData(e)), _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics, Pipeline, "DataShareSynchronizationSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List synchronizationSettings in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_ListByShare</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataShareSynchronizationSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataShareSynchronizationSettingResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSynchronizationSettingSynchronizationSettingsRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSynchronizationSettingSynchronizationSettingsRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataShareSynchronizationSettingResource(Client, DataShareSynchronizationSettingData.DeserializeDataShareSynchronizationSettingData(e)), _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics, Pipeline, "DataShareSynchronizationSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataShareSynchronizationSettingSynchronizationSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataShareSynchronizationSettingSynchronizationSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataShareSynchronizationSettingResource>> GetIfExistsAsync(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataShareSynchronizationSettingSynchronizationSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataShareSynchronizationSettingResource>(response.GetRawResponse());
                return Response.FromValue(new DataShareSynchronizationSettingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual NullableResponse<DataShareSynchronizationSettingResource> GetIfExists(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _dataShareSynchronizationSettingSynchronizationSettingsClientDiagnostics.CreateScope("DataShareSynchronizationSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataShareSynchronizationSettingSynchronizationSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataShareSynchronizationSettingResource>(response.GetRawResponse());
                return Response.FromValue(new DataShareSynchronizationSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataShareSynchronizationSettingResource> IEnumerable<DataShareSynchronizationSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataShareSynchronizationSettingResource> IAsyncEnumerable<DataShareSynchronizationSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
