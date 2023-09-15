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
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary> A class to add extension methods to ManagementGroupResource. </summary>
    internal partial class ManagementGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _policyTrackedResourcesClientDiagnostics;
        private PolicyTrackedResourcesRestOperations _policyTrackedResourcesRestClient;
        private ClientDiagnostics _policyEventsClientDiagnostics;
        private PolicyEventsRestOperations _policyEventsRestClient;
        private ClientDiagnostics _policyStatesClientDiagnostics;
        private PolicyStatesRestOperations _policyStatesRestClient;
        private ClientDiagnostics _policyRestrictionsClientDiagnostics;
        private PolicyRestrictionsRestOperations _policyRestrictionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ManagementGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PolicyTrackedResourcesClientDiagnostics => _policyTrackedResourcesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyTrackedResourcesRestOperations PolicyTrackedResourcesRestClient => _policyTrackedResourcesRestClient ??= new PolicyTrackedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyEventsClientDiagnostics => _policyEventsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyEventsRestOperations PolicyEventsRestClient => _policyEventsRestClient ??= new PolicyEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyStatesClientDiagnostics => _policyStatesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyStatesRestOperations PolicyStatesRestClient => _policyStatesRestClient ??= new PolicyStatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyRestrictionsClientDiagnostics => _policyRestrictionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyRestrictionsRestOperations PolicyRestrictionsRestClient => _policyRestrictionsRestClient ??= new PolicyRestrictionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Queries policy tracked resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyTrackedResources_ListQueryResultsForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyTrackedResourceType"> The name of the virtual resource under PolicyTrackedResources resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResultsAsync(PolicyTrackedResourceType policyTrackedResourceType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForManagementGroupRequest(Id.Name, policyTrackedResourceType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForManagementGroupNextPageRequest(nextLink, Id.Name, policyTrackedResourceType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyTrackedResourceRecord.DeserializePolicyTrackedResourceRecord, PolicyTrackedResourcesClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy tracked resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyTrackedResources_ListQueryResultsForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyTrackedResourceType"> The name of the virtual resource under PolicyTrackedResources resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResults(PolicyTrackedResourceType policyTrackedResourceType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForManagementGroupRequest(Id.Name, policyTrackedResourceType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForManagementGroupNextPageRequest(nextLink, Id.Name, policyTrackedResourceType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyTrackedResourceRecord.DeserializePolicyTrackedResourceRecord, PolicyTrackedResourcesClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy events for the resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyEvents_ListQueryResultsForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyEventType"> The name of the virtual resource under PolicyEvents resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyEvent> GetPolicyEventQueryResultsAsync(PolicyEventType policyEventType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyEventsRestClient.CreateListQueryResultsForManagementGroupRequest(Id.Name, policyEventType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyEventsRestClient.CreateListQueryResultsForManagementGroupNextPageRequest(nextLink, Id.Name, policyEventType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyEvent.DeserializePolicyEvent, PolicyEventsClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.GetPolicyEventQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy events for the resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyEvents_ListQueryResultsForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyEventType"> The name of the virtual resource under PolicyEvents resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyEvent> GetPolicyEventQueryResults(PolicyEventType policyEventType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyEventsRestClient.CreateListQueryResultsForManagementGroupRequest(Id.Name, policyEventType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyEventsRestClient.CreateListQueryResultsForManagementGroupNextPageRequest(nextLink, Id.Name, policyEventType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyEvent.DeserializePolicyEvent, PolicyEventsClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.GetPolicyEventQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy states for the resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_ListQueryResultsForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateType"> The virtual resource under PolicyStates resource type. In a given time range, 'latest' represents the latest policy state(s), whereas 'default' represents all policy state(s). </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyState> GetPolicyStateQueryResultsAsync(PolicyStateType policyStateType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateListQueryResultsForManagementGroupRequest(Id.Name, policyStateType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyStatesRestClient.CreateListQueryResultsForManagementGroupNextPageRequest(nextLink, Id.Name, policyStateType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyState.DeserializePolicyState, PolicyStatesClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.GetPolicyStateQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy states for the resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_ListQueryResultsForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateType"> The virtual resource under PolicyStates resource type. In a given time range, 'latest' represents the latest policy state(s), whereas 'default' represents all policy state(s). </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyState> GetPolicyStateQueryResults(PolicyStateType policyStateType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateListQueryResultsForManagementGroupRequest(Id.Name, policyStateType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyStatesRestClient.CreateListQueryResultsForManagementGroupNextPageRequest(nextLink, Id.Name, policyStateType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyState.DeserializePolicyState, PolicyStatesClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.GetPolicyStateQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Summarizes policy states for the resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_SummarizeForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateSummaryType"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, 'latest' represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicySummary> SummarizePolicyStatesAsync(PolicyStateSummaryType policyStateSummaryType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateSummarizeForManagementGroupRequest(Id.Name, policyStateSummaryType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, PolicySummary.DeserializePolicySummary, PolicyStatesClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.SummarizePolicyStates", "value", null, cancellationToken);
        }

        /// <summary>
        /// Summarizes policy states for the resources under the management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_SummarizeForManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateSummaryType"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, 'latest' represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicySummary> SummarizePolicyStates(PolicyStateSummaryType policyStateSummaryType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateSummarizeForManagementGroupRequest(Id.Name, policyStateSummaryType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, PolicySummary.DeserializePolicySummary, PolicyStatesClientDiagnostics, Pipeline, "ManagementGroupResourceExtensionClient.SummarizePolicyStates", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks what restrictions Azure Policy will place on resources within a management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupId}/providers/Microsoft.PolicyInsights/checkPolicyRestrictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestrictions_CheckAtManagementGroupScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The check policy restrictions parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckPolicyRestrictionsResult>> CheckPolicyRestrictionsAsync(CheckManagementGroupPolicyRestrictionsContent content, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyRestrictionsClientDiagnostics.CreateScope("ManagementGroupResourceExtensionClient.CheckPolicyRestrictions");
            scope.Start();
            try
            {
                var response = await PolicyRestrictionsRestClient.CheckAtManagementGroupScopeAsync(Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks what restrictions Azure Policy will place on resources within a management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/{managementGroupsNamespace}/managementGroups/{managementGroupId}/providers/Microsoft.PolicyInsights/checkPolicyRestrictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestrictions_CheckAtManagementGroupScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The check policy restrictions parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckPolicyRestrictionsResult> CheckPolicyRestrictions(CheckManagementGroupPolicyRestrictionsContent content, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyRestrictionsClientDiagnostics.CreateScope("ManagementGroupResourceExtensionClient.CheckPolicyRestrictions");
            scope.Start();
            try
            {
                var response = PolicyRestrictionsRestClient.CheckAtManagementGroupScope(Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
