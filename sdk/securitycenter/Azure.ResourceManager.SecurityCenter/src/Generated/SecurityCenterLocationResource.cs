// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecurityCenterLocation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecurityCenterLocationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecurityCenterLocationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSecurityCenterLocation method.
    /// </summary>
    public partial class SecurityCenterLocationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityCenterLocationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="ascLocation"> The ascLocation. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation ascLocation)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityCenterLocationLocationsClientDiagnostics;
        private readonly LocationsRestOperations _securityCenterLocationLocationsRestClient;
        private readonly ClientDiagnostics _allowedConnectionsClientDiagnostics;
        private readonly AllowedConnectionsRestOperations _allowedConnectionsRestClient;
        private readonly ClientDiagnostics _topologyClientDiagnostics;
        private readonly TopologyRestOperations _topologyRestClient;
        private readonly ClientDiagnostics _jitNetworkAccessPolicyClientDiagnostics;
        private readonly JitNetworkAccessPoliciesRestOperations _jitNetworkAccessPolicyRestClient;
        private readonly ClientDiagnostics _discoveredSecuritySolutionsClientDiagnostics;
        private readonly DiscoveredSecuritySolutionsRestOperations _discoveredSecuritySolutionsRestClient;
        private readonly ClientDiagnostics _securitySolutionsReferenceDataClientDiagnostics;
        private readonly SecuritySolutionsReferenceDataRestOperations _securitySolutionsReferenceDataRestClient;
        private readonly ClientDiagnostics _externalSecuritySolutionsClientDiagnostics;
        private readonly ExternalSecuritySolutionsRestOperations _externalSecuritySolutionsRestClient;
        private readonly SecurityCenterLocationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations";

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterLocationResource"/> class for mocking. </summary>
        protected SecurityCenterLocationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterLocationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityCenterLocationResource(ArmClient client, SecurityCenterLocationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterLocationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityCenterLocationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityCenterLocationLocationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityCenterLocationLocationsApiVersion);
            _securityCenterLocationLocationsRestClient = new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityCenterLocationLocationsApiVersion);
            _allowedConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _allowedConnectionsRestClient = new AllowedConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _topologyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _topologyRestClient = new TopologyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _jitNetworkAccessPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", JitNetworkAccessPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(JitNetworkAccessPolicyResource.ResourceType, out string jitNetworkAccessPolicyApiVersion);
            _jitNetworkAccessPolicyRestClient = new JitNetworkAccessPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jitNetworkAccessPolicyApiVersion);
            _discoveredSecuritySolutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _discoveredSecuritySolutionsRestClient = new DiscoveredSecuritySolutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _securitySolutionsReferenceDataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _securitySolutionsReferenceDataRestClient = new SecuritySolutionsReferenceDataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _externalSecuritySolutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _externalSecuritySolutionsRestClient = new ExternalSecuritySolutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityCenterLocationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SubscriptionSecurityTaskResources in the SecurityCenterLocation. </summary>
        /// <returns> An object representing collection of SubscriptionSecurityTaskResources and their operations over a SubscriptionSecurityTaskResource. </returns>
        public virtual SubscriptionSecurityTaskCollection GetSubscriptionSecurityTasks()
        {
            return GetCachedClient(client => new SubscriptionSecurityTaskCollection(client, Id));
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetSubscriptionLevelTask</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SubscriptionSecurityTaskResource>> GetSubscriptionSecurityTaskAsync(string taskName, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionSecurityTasks().GetAsync(taskName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetSubscriptionLevelTask</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SubscriptionSecurityTaskResource> GetSubscriptionSecurityTask(string taskName, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionSecurityTasks().Get(taskName, cancellationToken);
        }

        /// <summary> Gets a collection of AdaptiveApplicationControlGroupResources in the SecurityCenterLocation. </summary>
        /// <returns> An object representing collection of AdaptiveApplicationControlGroupResources and their operations over a AdaptiveApplicationControlGroupResource. </returns>
        public virtual AdaptiveApplicationControlGroupCollection GetAdaptiveApplicationControlGroups()
        {
            return GetCachedClient(client => new AdaptiveApplicationControlGroupCollection(client, Id));
        }

        /// <summary>
        /// Gets an application control VM/server group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AdaptiveApplicationControlGroupResource>> GetAdaptiveApplicationControlGroupAsync(string groupName, CancellationToken cancellationToken = default)
        {
            return await GetAdaptiveApplicationControlGroups().GetAsync(groupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an application control VM/server group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AdaptiveApplicationControlGroupResource> GetAdaptiveApplicationControlGroup(string groupName, CancellationToken cancellationToken = default)
        {
            return GetAdaptiveApplicationControlGroups().Get(groupName, cancellationToken);
        }

        /// <summary> Gets a collection of SubscriptionSecurityAlertResources in the SecurityCenterLocation. </summary>
        /// <returns> An object representing collection of SubscriptionSecurityAlertResources and their operations over a SubscriptionSecurityAlertResource. </returns>
        public virtual SubscriptionSecurityAlertCollection GetSubscriptionSecurityAlerts()
        {
            return GetCachedClient(client => new SubscriptionSecurityAlertCollection(client, Id));
        }

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SubscriptionSecurityAlertResource>> GetSubscriptionSecurityAlertAsync(string alertName, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionSecurityAlerts().GetAsync(alertName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SubscriptionSecurityAlertResource> GetSubscriptionSecurityAlert(string alertName, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionSecurityAlerts().Get(alertName, cancellationToken);
        }

        /// <summary>
        /// Details of a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityCenterLocationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationResource.Get");
            scope.Start();
            try
            {
                var response = await _securityCenterLocationLocationsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Details of a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityCenterLocationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationResource.Get");
            scope.Start();
            try
            {
                var response = _securityCenterLocationLocationsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of all possible traffic between resources for the subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/allowedConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AllowedConnections_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityCenterAllowedConnection"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityCenterAllowedConnection> GetAllowedConnectionsByHomeRegionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _allowedConnectionsRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _allowedConnectionsRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => SecurityCenterAllowedConnection.DeserializeSecurityCenterAllowedConnection(e), _allowedConnectionsClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetAllowedConnectionsByHomeRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of all possible traffic between resources for the subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/allowedConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AllowedConnections_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityCenterAllowedConnection"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityCenterAllowedConnection> GetAllowedConnectionsByHomeRegion(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _allowedConnectionsRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _allowedConnectionsRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => SecurityCenterAllowedConnection.DeserializeSecurityCenterAllowedConnection(e), _allowedConnectionsClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetAllowedConnectionsByHomeRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list that allows to build a topology view of a subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/topologies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topology_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityTopologyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityTopologyResource> GetTopologiesByHomeRegionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topologyRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topologyRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => SecurityTopologyResource.DeserializeSecurityTopologyResource(e), _topologyClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetTopologiesByHomeRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list that allows to build a topology view of a subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/topologies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topology_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityTopologyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityTopologyResource> GetTopologiesByHomeRegion(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topologyRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topologyRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => SecurityTopologyResource.DeserializeSecurityTopologyResource(e), _topologyClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetTopologiesByHomeRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Policies for protecting resources using Just-in-Time access control for the subscription, location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/jitNetworkAccessPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitNetworkAccessPolicies_ListByRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JitNetworkAccessPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JitNetworkAccessPolicyResource> GetJitNetworkAccessPoliciesByRegionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jitNetworkAccessPolicyRestClient.CreateListByRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _jitNetworkAccessPolicyRestClient.CreateListByRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new JitNetworkAccessPolicyResource(Client, JitNetworkAccessPolicyData.DeserializeJitNetworkAccessPolicyData(e)), _jitNetworkAccessPolicyClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetJitNetworkAccessPoliciesByRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Policies for protecting resources using Just-in-Time access control for the subscription, location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/jitNetworkAccessPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitNetworkAccessPolicies_ListByRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JitNetworkAccessPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JitNetworkAccessPolicyResource> GetJitNetworkAccessPoliciesByRegion(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jitNetworkAccessPolicyRestClient.CreateListByRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _jitNetworkAccessPolicyRestClient.CreateListByRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new JitNetworkAccessPolicyResource(Client, JitNetworkAccessPolicyData.DeserializeJitNetworkAccessPolicyData(e)), _jitNetworkAccessPolicyClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetJitNetworkAccessPoliciesByRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of discovered Security Solutions for the subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/discoveredSecuritySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoveredSecuritySolutions_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiscoveredSecuritySolution"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiscoveredSecuritySolution> GetDiscoveredSecuritySolutionsByHomeRegionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _discoveredSecuritySolutionsRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _discoveredSecuritySolutionsRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => DiscoveredSecuritySolution.DeserializeDiscoveredSecuritySolution(e), _discoveredSecuritySolutionsClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetDiscoveredSecuritySolutionsByHomeRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of discovered Security Solutions for the subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/discoveredSecuritySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoveredSecuritySolutions_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiscoveredSecuritySolution"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiscoveredSecuritySolution> GetDiscoveredSecuritySolutionsByHomeRegion(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _discoveredSecuritySolutionsRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _discoveredSecuritySolutionsRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => DiscoveredSecuritySolution.DeserializeDiscoveredSecuritySolution(e), _discoveredSecuritySolutionsClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetDiscoveredSecuritySolutionsByHomeRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets list of all supported Security Solutions for subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/securitySolutionsReferenceData</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecuritySolutionsReferenceData_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecuritySolutionsReferenceData"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecuritySolutionsReferenceData> GetAllSecuritySolutionsReferenceDataByHomeRegionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securitySolutionsReferenceDataRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => SecuritySolutionsReferenceData.DeserializeSecuritySolutionsReferenceData(e), _securitySolutionsReferenceDataClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetAllSecuritySolutionsReferenceDataByHomeRegion", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets list of all supported Security Solutions for subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/securitySolutionsReferenceData</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecuritySolutionsReferenceData_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecuritySolutionsReferenceData"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecuritySolutionsReferenceData> GetAllSecuritySolutionsReferenceDataByHomeRegion(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securitySolutionsReferenceDataRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => SecuritySolutionsReferenceData.DeserializeSecuritySolutionsReferenceData(e), _securitySolutionsReferenceDataClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetAllSecuritySolutionsReferenceDataByHomeRegion", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of external Security Solutions for the subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/ExternalSecuritySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalSecuritySolutions_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExternalSecuritySolution"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExternalSecuritySolution> GetExternalSecuritySolutionsByHomeRegionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _externalSecuritySolutionsRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _externalSecuritySolutionsRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ExternalSecuritySolution.DeserializeExternalSecuritySolution(e), _externalSecuritySolutionsClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetExternalSecuritySolutionsByHomeRegion", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of external Security Solutions for the subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/ExternalSecuritySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalSecuritySolutions_ListByHomeRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExternalSecuritySolution"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExternalSecuritySolution> GetExternalSecuritySolutionsByHomeRegion(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _externalSecuritySolutionsRestClient.CreateListByHomeRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _externalSecuritySolutionsRestClient.CreateListByHomeRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ExternalSecuritySolution.DeserializeExternalSecuritySolution(e), _externalSecuritySolutionsClientDiagnostics, Pipeline, "SecurityCenterLocationResource.GetExternalSecuritySolutionsByHomeRegion", "value", "nextLink", cancellationToken);
        }
    }
}
