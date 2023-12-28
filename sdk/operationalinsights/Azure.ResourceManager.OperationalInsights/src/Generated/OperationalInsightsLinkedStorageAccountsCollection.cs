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
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="OperationalInsightsLinkedStorageAccountsResource"/> and their operations.
    /// Each <see cref="OperationalInsightsLinkedStorageAccountsResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceResource"/>.
    /// To get an <see cref="OperationalInsightsLinkedStorageAccountsCollection"/> instance call the GetOperationalInsightsLinkedStorageAccounts method from an instance of <see cref="OperationalInsightsWorkspaceResource"/>.
    /// </summary>
    public partial class OperationalInsightsLinkedStorageAccountsCollection : ArmCollection, IEnumerable<OperationalInsightsLinkedStorageAccountsResource>, IAsyncEnumerable<OperationalInsightsLinkedStorageAccountsResource>
    {
        private readonly ClientDiagnostics _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics;
        private readonly LinkedStorageAccountsRestOperations _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsLinkedStorageAccountsCollection"/> class for mocking. </summary>
        protected OperationalInsightsLinkedStorageAccountsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsLinkedStorageAccountsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OperationalInsightsLinkedStorageAccountsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsLinkedStorageAccountsResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OperationalInsightsLinkedStorageAccountsResource.ResourceType, out string operationalInsightsLinkedStorageAccountsLinkedStorageAccountsApiVersion);
            _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient = new LinkedStorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, operationalInsightsLinkedStorageAccountsLinkedStorageAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a link relation between current workspace and a group of storage accounts of a specific data source type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="data"> The parameters required to create or update linked storage accounts. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OperationalInsightsLinkedStorageAccountsResource>> CreateOrUpdateAsync(WaitUntil waitUntil, OperationalInsightsDataSourceType dataSourceType, OperationalInsightsLinkedStorageAccountsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, data, cancellationToken).ConfigureAwait(false);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsLinkedStorageAccountsResource>(Response.FromValue(new OperationalInsightsLinkedStorageAccountsResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update a link relation between current workspace and a group of storage accounts of a specific data source type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="data"> The parameters required to create or update linked storage accounts. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OperationalInsightsLinkedStorageAccountsResource> CreateOrUpdate(WaitUntil waitUntil, OperationalInsightsDataSourceType dataSourceType, OperationalInsightsLinkedStorageAccountsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, data, cancellationToken);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsLinkedStorageAccountsResource>(Response.FromValue(new OperationalInsightsLinkedStorageAccountsResource(Client, response), response.GetRawResponse()));
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
        /// Gets all linked storage account of a specific data source type associated with the specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OperationalInsightsLinkedStorageAccountsResource>> GetAsync(OperationalInsightsDataSourceType dataSourceType, CancellationToken cancellationToken = default)
        {
            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.Get");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedStorageAccountsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all linked storage account of a specific data source type associated with the specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OperationalInsightsLinkedStorageAccountsResource> Get(OperationalInsightsDataSourceType dataSourceType, CancellationToken cancellationToken = default)
        {
            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.Get");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedStorageAccountsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all linked storage accounts associated with the specified workspace, storage accounts will be sorted by their data source type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsLinkedStorageAccountsResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsLinkedStorageAccountsResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new OperationalInsightsLinkedStorageAccountsResource(Client, OperationalInsightsLinkedStorageAccountsData.DeserializeOperationalInsightsLinkedStorageAccountsData(e)), _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics, Pipeline, "OperationalInsightsLinkedStorageAccountsCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all linked storage accounts associated with the specified workspace, storage accounts will be sorted by their data source type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsLinkedStorageAccountsResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsLinkedStorageAccountsResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new OperationalInsightsLinkedStorageAccountsResource(Client, OperationalInsightsLinkedStorageAccountsData.DeserializeOperationalInsightsLinkedStorageAccountsData(e)), _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics, Pipeline, "OperationalInsightsLinkedStorageAccountsCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(OperationalInsightsDataSourceType dataSourceType, CancellationToken cancellationToken = default)
        {
            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.Exists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(OperationalInsightsDataSourceType dataSourceType, CancellationToken cancellationToken = default)
        {
            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.Exists");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<OperationalInsightsLinkedStorageAccountsResource>> GetIfExistsAsync(OperationalInsightsDataSourceType dataSourceType, CancellationToken cancellationToken = default)
        {
            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<OperationalInsightsLinkedStorageAccountsResource>(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedStorageAccountsResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedStorageAccounts/{dataSourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedStorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.OperationalInsights/workspaces/linkedStorageAccounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<OperationalInsightsLinkedStorageAccountsResource> GetIfExists(OperationalInsightsDataSourceType dataSourceType, CancellationToken cancellationToken = default)
        {
            using var scope = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsClientDiagnostics.CreateScope("OperationalInsightsLinkedStorageAccountsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedStorageAccountsLinkedStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceType, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<OperationalInsightsLinkedStorageAccountsResource>(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedStorageAccountsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OperationalInsightsLinkedStorageAccountsResource> IEnumerable<OperationalInsightsLinkedStorageAccountsResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OperationalInsightsLinkedStorageAccountsResource> IAsyncEnumerable<OperationalInsightsLinkedStorageAccountsResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
