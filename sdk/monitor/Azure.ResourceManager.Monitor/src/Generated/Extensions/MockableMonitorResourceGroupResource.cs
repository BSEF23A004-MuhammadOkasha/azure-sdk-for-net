// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Monitor;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMonitorResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _privateLinkScopeOperationStatusClientDiagnostics;
        private PrivateLinkScopeOperationStatusRestOperations _privateLinkScopeOperationStatusRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableMonitorResourceGroupResource"/> class for mocking. </summary>
        protected MockableMonitorResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMonitorResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMonitorResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PrivateLinkScopeOperationStatusClientDiagnostics => _privateLinkScopeOperationStatusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Monitor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PrivateLinkScopeOperationStatusRestOperations PrivateLinkScopeOperationStatusRestClient => _privateLinkScopeOperationStatusRestClient ??= new PrivateLinkScopeOperationStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AutoscaleSettingResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AutoscaleSettingResources and their operations over a AutoscaleSettingResource. </returns>
        public virtual AutoscaleSettingCollection GetAutoscaleSettings()
        {
            return GetCachedClient(client => new AutoscaleSettingCollection(client, Id));
        }

        /// <summary>
        /// Gets an autoscale setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/autoscalesettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AutoscaleSettingResource>> GetAutoscaleSettingAsync(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            return await GetAutoscaleSettings().GetAsync(autoscaleSettingName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an autoscale setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/autoscalesettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AutoscaleSettingResource> GetAutoscaleSetting(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            return GetAutoscaleSettings().Get(autoscaleSettingName, cancellationToken);
        }

        /// <summary> Gets a collection of AlertRuleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AlertRuleResources and their operations over a AlertRuleResource. </returns>
        public virtual AlertRuleCollection GetAlertRules()
        {
            return GetCachedClient(client => new AlertRuleCollection(client, Id));
        }

        /// <summary>
        /// Gets a classic metric alert rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/alertrules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/alertrules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AlertRuleResource>> GetAlertRuleAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            return await GetAlertRules().GetAsync(ruleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a classic metric alert rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/alertrules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/alertrules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AlertRuleResource> GetAlertRule(string ruleName, CancellationToken cancellationToken = default)
        {
            return GetAlertRules().Get(ruleName, cancellationToken);
        }

        /// <summary> Gets a collection of ActionGroupResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ActionGroupResources and their operations over a ActionGroupResource. </returns>
        public virtual ActionGroupCollection GetActionGroups()
        {
            return GetCachedClient(client => new ActionGroupCollection(client, Id));
        }

        /// <summary>
        /// Get an action group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/actionGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ActionGroupResource>> GetActionGroupAsync(string actionGroupName, CancellationToken cancellationToken = default)
        {
            return await GetActionGroups().GetAsync(actionGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an action group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/actionGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ActionGroupResource> GetActionGroup(string actionGroupName, CancellationToken cancellationToken = default)
        {
            return GetActionGroups().Get(actionGroupName, cancellationToken);
        }

        /// <summary> Gets a collection of MetricAlertResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MetricAlertResources and their operations over a MetricAlertResource. </returns>
        public virtual MetricAlertCollection GetMetricAlerts()
        {
            return GetCachedClient(client => new MetricAlertCollection(client, Id));
        }

        /// <summary>
        /// Retrieve an alert rule definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/metricAlerts/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/metricAlerts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MetricAlertResource>> GetMetricAlertAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            return await GetMetricAlerts().GetAsync(ruleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve an alert rule definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/metricAlerts/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/metricAlerts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MetricAlertResource> GetMetricAlert(string ruleName, CancellationToken cancellationToken = default)
        {
            return GetMetricAlerts().Get(ruleName, cancellationToken);
        }

        /// <summary> Gets a collection of ScheduledQueryRuleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScheduledQueryRuleResources and their operations over a ScheduledQueryRuleResource. </returns>
        public virtual ScheduledQueryRuleCollection GetScheduledQueryRules()
        {
            return GetCachedClient(client => new ScheduledQueryRuleCollection(client, Id));
        }

        /// <summary>
        /// Retrieve an scheduled query rule definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/scheduledQueryRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScheduledQueryRuleResource>> GetScheduledQueryRuleAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            return await GetScheduledQueryRules().GetAsync(ruleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve an scheduled query rule definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/scheduledQueryRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScheduledQueryRuleResource> GetScheduledQueryRule(string ruleName, CancellationToken cancellationToken = default)
        {
            return GetScheduledQueryRules().Get(ruleName, cancellationToken);
        }

        /// <summary> Gets a collection of MonitorPrivateLinkScopeResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MonitorPrivateLinkScopeResources and their operations over a MonitorPrivateLinkScopeResource. </returns>
        public virtual MonitorPrivateLinkScopeCollection GetMonitorPrivateLinkScopes()
        {
            return GetCachedClient(client => new MonitorPrivateLinkScopeCollection(client, Id));
        }

        /// <summary>
        /// Returns a Azure Monitor PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>microsoft.insights/privateLinkScopes</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Monitor PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MonitorPrivateLinkScopeResource>> GetMonitorPrivateLinkScopeAsync(string scopeName, CancellationToken cancellationToken = default)
        {
            return await GetMonitorPrivateLinkScopes().GetAsync(scopeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Azure Monitor PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>microsoft.insights/privateLinkScopes</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Monitor PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MonitorPrivateLinkScopeResource> GetMonitorPrivateLinkScope(string scopeName, CancellationToken cancellationToken = default)
        {
            return GetMonitorPrivateLinkScopes().Get(scopeName, cancellationToken);
        }

        /// <summary> Gets a collection of ActivityLogAlertResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ActivityLogAlertResources and their operations over a ActivityLogAlertResource. </returns>
        public virtual ActivityLogAlertCollection GetActivityLogAlerts()
        {
            return GetCachedClient(client => new ActivityLogAlertCollection(client, Id));
        }

        /// <summary>
        /// Get an Activity Log Alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/activityLogAlerts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ActivityLogAlertResource>> GetActivityLogAlertAsync(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            return await GetActivityLogAlerts().GetAsync(activityLogAlertName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an Activity Log Alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/activityLogAlerts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ActivityLogAlertResource> GetActivityLogAlert(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            return GetActivityLogAlerts().Get(activityLogAlertName, cancellationToken);
        }

        /// <summary> Gets a collection of DataCollectionEndpointResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataCollectionEndpointResources and their operations over a DataCollectionEndpointResource. </returns>
        public virtual DataCollectionEndpointCollection GetDataCollectionEndpoints()
        {
            return GetCachedClient(client => new DataCollectionEndpointCollection(client, Id));
        }

        /// <summary>
        /// Returns the specified data collection endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/dataCollectionEndpoints</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataCollectionEndpointResource>> GetDataCollectionEndpointAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            return await GetDataCollectionEndpoints().GetAsync(dataCollectionEndpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the specified data collection endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/dataCollectionEndpoints</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataCollectionEndpointResource> GetDataCollectionEndpoint(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            return GetDataCollectionEndpoints().Get(dataCollectionEndpointName, cancellationToken);
        }

        /// <summary> Gets a collection of DataCollectionRuleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataCollectionRuleResources and their operations over a DataCollectionRuleResource. </returns>
        public virtual DataCollectionRuleCollection GetDataCollectionRules()
        {
            return GetCachedClient(client => new DataCollectionRuleCollection(client, Id));
        }

        /// <summary>
        /// Returns the specified data collection rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/dataCollectionRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataCollectionRuleResource>> GetDataCollectionRuleAsync(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            return await GetDataCollectionRules().GetAsync(dataCollectionRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the specified data collection rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/dataCollectionRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataCollectionRuleResource> GetDataCollectionRule(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            return GetDataCollectionRules().Get(dataCollectionRuleName, cancellationToken);
        }

        /// <summary> Gets a collection of MonitorWorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MonitorWorkspaceResources and their operations over a MonitorWorkspaceResource. </returns>
        public virtual MonitorWorkspaceResourceCollection GetMonitorWorkspaceResources()
        {
            return GetCachedClient(client => new MonitorWorkspaceResourceCollection(client, Id));
        }

        /// <summary>
        /// Returns the specific Azure Monitor workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Monitor/accounts/{azureMonitorWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureMonitorWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Monitor/accounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureMonitorWorkspaceName"> The name of the Azure Monitor workspace.  The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureMonitorWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureMonitorWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MonitorWorkspaceResource>> GetMonitorWorkspaceResourceAsync(string azureMonitorWorkspaceName, CancellationToken cancellationToken = default)
        {
            return await GetMonitorWorkspaceResources().GetAsync(azureMonitorWorkspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the specific Azure Monitor workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Monitor/accounts/{azureMonitorWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureMonitorWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Monitor/accounts</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureMonitorWorkspaceName"> The name of the Azure Monitor workspace.  The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureMonitorWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureMonitorWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MonitorWorkspaceResource> GetMonitorWorkspaceResource(string azureMonitorWorkspaceName, CancellationToken cancellationToken = default)
        {
            return GetMonitorWorkspaceResources().Get(azureMonitorWorkspaceName, cancellationToken);
        }

        /// <summary>
        /// Get the status of an azure asynchronous operation associated with a private link scope operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopeOperationStatuses/{asyncOperationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopeOperationStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="asyncOperationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="asyncOperationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="asyncOperationId"/> is null. </exception>
        public virtual async Task<Response<MonitorPrivateLinkScopeOperationStatus>> GetPrivateLinkScopeOperationStatusAsync(string asyncOperationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(asyncOperationId, nameof(asyncOperationId));

            using var scope = PrivateLinkScopeOperationStatusClientDiagnostics.CreateScope("MockableMonitorResourceGroupResource.GetPrivateLinkScopeOperationStatus");
            scope.Start();
            try
            {
                var response = await PrivateLinkScopeOperationStatusRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, asyncOperationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the status of an azure asynchronous operation associated with a private link scope operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopeOperationStatuses/{asyncOperationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopeOperationStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="asyncOperationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="asyncOperationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="asyncOperationId"/> is null. </exception>
        public virtual Response<MonitorPrivateLinkScopeOperationStatus> GetPrivateLinkScopeOperationStatus(string asyncOperationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(asyncOperationId, nameof(asyncOperationId));

            using var scope = PrivateLinkScopeOperationStatusClientDiagnostics.CreateScope("MockableMonitorResourceGroupResource.GetPrivateLinkScopeOperationStatus");
            scope.Start();
            try
            {
                var response = PrivateLinkScopeOperationStatusRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, asyncOperationId, cancellationToken);
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
