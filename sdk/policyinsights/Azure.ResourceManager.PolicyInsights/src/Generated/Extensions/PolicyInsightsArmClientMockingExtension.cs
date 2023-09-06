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
using Azure.ResourceManager.PolicyInsights;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class PolicyInsightsArmClientMockingExtension : ArmResource
    {
        private ClientDiagnostics _policyTrackedResourcesClientDiagnostics;
        private PolicyTrackedResourcesRestOperations _policyTrackedResourcesRestClient;
        private ClientDiagnostics _policyEventsClientDiagnostics;
        private PolicyEventsRestOperations _policyEventsRestClient;
        private ClientDiagnostics _policyStatesClientDiagnostics;
        private PolicyStatesRestOperations _policyStatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyInsightsArmClientMockingExtension"/> class for mocking. </summary>
        protected PolicyInsightsArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyInsightsArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyInsightsArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal PolicyInsightsArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private ClientDiagnostics PolicyTrackedResourcesClientDiagnostics => _policyTrackedResourcesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyTrackedResourcesRestOperations PolicyTrackedResourcesRestClient => _policyTrackedResourcesRestClient ??= new PolicyTrackedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyEventsClientDiagnostics => _policyEventsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyEventsRestOperations PolicyEventsRestClient => _policyEventsRestClient ??= new PolicyEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyStatesClientDiagnostics => _policyStatesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyStatesRestOperations PolicyStatesRestClient => _policyStatesRestClient ??= new PolicyStatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PolicyRemediationResources in the ArmClient. </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <returns> An object representing collection of PolicyRemediationResources and their operations over a PolicyRemediationResource. </returns>
        public virtual PolicyRemediationCollection GetPolicyRemediations(ResourceIdentifier scope)
        {
            return new PolicyRemediationCollection(Client, scope);
        }

        /// <summary>
        /// Gets an existing remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_GetAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PolicyRemediationResource>> GetPolicyRemediationAsync(ResourceIdentifier scope, string remediationName, CancellationToken cancellationToken = default)
        {
            return await GetPolicyRemediations(scope).GetAsync(remediationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an existing remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_GetAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<PolicyRemediationResource> GetPolicyRemediation(ResourceIdentifier scope, string remediationName, CancellationToken cancellationToken = default)
        {
            return GetPolicyRemediations(scope).Get(remediationName, cancellationToken);
        }

        /// <summary> Gets a collection of PolicyAttestationResources in the ArmClient. </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <returns> An object representing collection of PolicyAttestationResources and their operations over a PolicyAttestationResource. </returns>
        public virtual PolicyAttestationCollection GetPolicyAttestations(ResourceIdentifier scope)
        {
            return new PolicyAttestationCollection(Client, scope);
        }

        /// <summary>
        /// Gets an existing attestation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_GetAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PolicyAttestationResource>> GetPolicyAttestationAsync(ResourceIdentifier scope, string attestationName, CancellationToken cancellationToken = default)
        {
            return await GetPolicyAttestations(scope).GetAsync(attestationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an existing attestation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_GetAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<PolicyAttestationResource> GetPolicyAttestation(ResourceIdentifier scope, string attestationName, CancellationToken cancellationToken = default)
        {
            return GetPolicyAttestations(scope).Get(attestationName, cancellationToken);
        }

        /// <summary>
        /// Queries policy tracked resources under the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyTrackedResources_ListQueryResultsForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyTrackedResourceType"> The name of the virtual resource under PolicyTrackedResources resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResultsAsync(ResourceIdentifier scope, PolicyTrackedResourceType policyTrackedResourceType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceRequest(scope, policyTrackedResourceType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceNextPageRequest(nextLink, scope, policyTrackedResourceType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyTrackedResourceRecord.DeserializePolicyTrackedResourceRecord, PolicyTrackedResourcesClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.GetPolicyTrackedResourceQueryResults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy tracked resources under the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyTrackedResources_ListQueryResultsForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyTrackedResourceType"> The name of the virtual resource under PolicyTrackedResources resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResults(ResourceIdentifier scope, PolicyTrackedResourceType policyTrackedResourceType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceRequest(scope, policyTrackedResourceType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceNextPageRequest(nextLink, scope, policyTrackedResourceType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyTrackedResourceRecord.DeserializePolicyTrackedResourceRecord, PolicyTrackedResourcesClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.GetPolicyTrackedResourceQueryResults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy events for the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyEvents_ListQueryResultsForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyEventType"> The name of the virtual resource under PolicyEvents resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyEvent> GetPolicyEventQueryResultsAsync(ResourceIdentifier scope, PolicyEventType policyEventType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyEventsRestClient.CreateListQueryResultsForResourceRequest(scope, policyEventType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyEventsRestClient.CreateListQueryResultsForResourceNextPageRequest(nextLink, scope, policyEventType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyEvent.DeserializePolicyEvent, PolicyEventsClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.GetPolicyEventQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy events for the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyEvents_ListQueryResultsForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyEventType"> The name of the virtual resource under PolicyEvents resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyEvent> GetPolicyEventQueryResults(ResourceIdentifier scope, PolicyEventType policyEventType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyEventsRestClient.CreateListQueryResultsForResourceRequest(scope, policyEventType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyEventsRestClient.CreateListQueryResultsForResourceNextPageRequest(nextLink, scope, policyEventType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyEvent.DeserializePolicyEvent, PolicyEventsClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.GetPolicyEventQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy states for the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_ListQueryResultsForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyStateType"> The virtual resource under PolicyStates resource type. In a given time range, 'latest' represents the latest policy state(s), whereas 'default' represents all policy state(s). </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyState> GetPolicyStateQueryResultsAsync(ResourceIdentifier scope, PolicyStateType policyStateType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateListQueryResultsForResourceRequest(scope, policyStateType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyStatesRestClient.CreateListQueryResultsForResourceNextPageRequest(nextLink, scope, policyStateType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyState.DeserializePolicyState, PolicyStatesClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.GetPolicyStateQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy states for the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_ListQueryResultsForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyStateType"> The virtual resource under PolicyStates resource type. In a given time range, 'latest' represents the latest policy state(s), whereas 'default' represents all policy state(s). </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyState> GetPolicyStateQueryResults(ResourceIdentifier scope, PolicyStateType policyStateType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateListQueryResultsForResourceRequest(scope, policyStateType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyStatesRestClient.CreateListQueryResultsForResourceNextPageRequest(nextLink, scope, policyStateType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyState.DeserializePolicyState, PolicyStatesClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.GetPolicyStateQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Summarizes policy states for the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_SummarizeForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyStateSummaryType"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, 'latest' represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicySummary> SummarizePolicyStatesAsync(ResourceIdentifier scope, PolicyStateSummaryType policyStateSummaryType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateSummarizeForResourceRequest(scope, policyStateSummaryType, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, PolicySummary.DeserializePolicySummary, PolicyStatesClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.SummarizePolicyStates", "value", null, cancellationToken);
        }

        /// <summary>
        /// Summarizes policy states for the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_SummarizeForResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="policyStateSummaryType"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, 'latest' represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicySummary> SummarizePolicyStates(ResourceIdentifier scope, PolicyStateSummaryType policyStateSummaryType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateSummarizeForResourceRequest(scope, policyStateSummaryType, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, PolicySummary.DeserializePolicySummary, PolicyStatesClientDiagnostics, Pipeline, "PolicyInsightsArmClientMockingExtension.SummarizePolicyStates", "value", null, cancellationToken);
        }
        /// <summary>
        /// Gets an object representing a <see cref="PolicyRemediationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PolicyRemediationResource.CreateResourceIdentifier" /> to create a <see cref="PolicyRemediationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyRemediationResource" /> object. </returns>
        public virtual PolicyRemediationResource GetPolicyRemediationResource(ResourceIdentifier id)
        {
            PolicyRemediationResource.ValidateResourceId(id);
            return new PolicyRemediationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PolicyMetadataResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PolicyMetadataResource.CreateResourceIdentifier" /> to create a <see cref="PolicyMetadataResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyMetadataResource" /> object. </returns>
        public virtual PolicyMetadataResource GetPolicyMetadataResource(ResourceIdentifier id)
        {
            PolicyMetadataResource.ValidateResourceId(id);
            return new PolicyMetadataResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PolicyAttestationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PolicyAttestationResource.CreateResourceIdentifier" /> to create a <see cref="PolicyAttestationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyAttestationResource" /> object. </returns>
        public virtual PolicyAttestationResource GetPolicyAttestationResource(ResourceIdentifier id)
        {
            PolicyAttestationResource.ValidateResourceId(id);
            return new PolicyAttestationResource(Client, id);
        }
    }
}
