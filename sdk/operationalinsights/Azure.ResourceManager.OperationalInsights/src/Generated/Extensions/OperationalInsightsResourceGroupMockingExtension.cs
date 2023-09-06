// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class OperationalInsightsResourceGroupMockingExtension : ArmResource
    {
        private ClientDiagnostics _logAnalyticsQueryPackQueryPacksClientDiagnostics;
        private QueryPacksRestOperations _logAnalyticsQueryPackQueryPacksRestClient;
        private ClientDiagnostics _deletedWorkspacesClientDiagnostics;
        private DeletedWorkspacesRestOperations _deletedWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsResourceGroupMockingExtension"/> class for mocking. </summary>
        protected OperationalInsightsResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OperationalInsightsResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LogAnalyticsQueryPackQueryPacksClientDiagnostics => _logAnalyticsQueryPackQueryPacksClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", LogAnalyticsQueryPackResource.ResourceType.Namespace, Diagnostics);
        private QueryPacksRestOperations LogAnalyticsQueryPackQueryPacksRestClient => _logAnalyticsQueryPackQueryPacksRestClient ??= new QueryPacksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LogAnalyticsQueryPackResource.ResourceType));
        private ClientDiagnostics DeletedWorkspacesClientDiagnostics => _deletedWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DeletedWorkspacesRestOperations DeletedWorkspacesRestClient => _deletedWorkspacesRestClient ??= new DeletedWorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of LogAnalyticsQueryPackResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of LogAnalyticsQueryPackResources and their operations over a LogAnalyticsQueryPackResource. </returns>
        public virtual LogAnalyticsQueryPackCollection GetLogAnalyticsQueryPacks()
        {
            return GetCachedClient(Client => new LogAnalyticsQueryPackCollection(Client, Id));
        }

        /// <summary>
        /// Returns a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QueryPacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queryPackName"> The name of the Log Analytics QueryPack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queryPackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queryPackName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogAnalyticsQueryPackResource>> GetLogAnalyticsQueryPackAsync(string queryPackName, CancellationToken cancellationToken = default)
        {
            return await GetLogAnalyticsQueryPacks().GetAsync(queryPackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QueryPacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queryPackName"> The name of the Log Analytics QueryPack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queryPackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queryPackName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogAnalyticsQueryPackResource> GetLogAnalyticsQueryPack(string queryPackName, CancellationToken cancellationToken = default)
        {
            return GetLogAnalyticsQueryPacks().Get(queryPackName, cancellationToken);
        }

        /// <summary> Gets a collection of OperationalInsightsClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of OperationalInsightsClusterResources and their operations over a OperationalInsightsClusterResource. </returns>
        public virtual OperationalInsightsClusterCollection GetOperationalInsightsClusters()
        {
            return GetCachedClient(Client => new OperationalInsightsClusterCollection(Client, Id));
        }

        /// <summary>
        /// Gets a Log Analytics cluster instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> Name of the Log Analytics Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<OperationalInsightsClusterResource>> GetOperationalInsightsClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetOperationalInsightsClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Log Analytics cluster instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> Name of the Log Analytics Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<OperationalInsightsClusterResource> GetOperationalInsightsCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetOperationalInsightsClusters().Get(clusterName, cancellationToken);
        }

        /// <summary> Gets a collection of OperationalInsightsWorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of OperationalInsightsWorkspaceResources and their operations over a OperationalInsightsWorkspaceResource. </returns>
        public virtual OperationalInsightsWorkspaceCollection GetOperationalInsightsWorkspaces()
        {
            return GetCachedClient(Client => new OperationalInsightsWorkspaceCollection(Client, Id));
        }

        /// <summary>
        /// Gets a workspace instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<OperationalInsightsWorkspaceResource>> GetOperationalInsightsWorkspaceAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            return await GetOperationalInsightsWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workspace instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<OperationalInsightsWorkspaceResource> GetOperationalInsightsWorkspace(string workspaceName, CancellationToken cancellationToken = default)
        {
            return GetOperationalInsightsWorkspaces().Get(workspaceName, cancellationToken);
        }

        /// <summary>
        /// Creates a Log Analytics QueryPack. Note: You cannot specify a different value for InstrumentationKey nor AppId in the Put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QueryPacks_CreateOrUpdateWithoutName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties that need to be specified to create or update a Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<LogAnalyticsQueryPackResource>> CreateOrUpdateWithoutNameQueryPackAsync(LogAnalyticsQueryPackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = LogAnalyticsQueryPackQueryPacksClientDiagnostics.CreateScope("OperationalInsightsResourceGroupMockingExtension.CreateOrUpdateWithoutNameQueryPack");
            scope.Start();
            try
            {
                var response = await LogAnalyticsQueryPackQueryPacksRestClient.CreateOrUpdateWithoutNameAsync(Id.SubscriptionId, Id.ResourceGroupName, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new LogAnalyticsQueryPackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a Log Analytics QueryPack. Note: You cannot specify a different value for InstrumentationKey nor AppId in the Put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QueryPacks_CreateOrUpdateWithoutName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties that need to be specified to create or update a Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<LogAnalyticsQueryPackResource> CreateOrUpdateWithoutNameQueryPack(LogAnalyticsQueryPackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = LogAnalyticsQueryPackQueryPacksClientDiagnostics.CreateScope("OperationalInsightsResourceGroupMockingExtension.CreateOrUpdateWithoutNameQueryPack");
            scope.Start();
            try
            {
                var response = LogAnalyticsQueryPackQueryPacksRestClient.CreateOrUpdateWithoutName(Id.SubscriptionId, Id.ResourceGroupName, data, cancellationToken);
                return Response.FromValue(new LogAnalyticsQueryPackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets recently deleted workspaces in a resource group, available for recovery.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/deletedWorkspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedWorkspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsWorkspaceResource> GetDeletedWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeletedWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), DeletedWorkspacesClientDiagnostics, Pipeline, "OperationalInsightsResourceGroupMockingExtension.GetDeletedWorkspaces", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets recently deleted workspaces in a resource group, available for recovery.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/deletedWorkspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedWorkspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsWorkspaceResource> GetDeletedWorkspaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeletedWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), DeletedWorkspacesClientDiagnostics, Pipeline, "OperationalInsightsResourceGroupMockingExtension.GetDeletedWorkspaces", "value", null, cancellationToken);
        }
    }
}
