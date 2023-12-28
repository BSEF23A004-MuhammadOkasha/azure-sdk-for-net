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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="AlertRuleResource"/> and their operations.
    /// Each <see cref="AlertRuleResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AlertRuleCollection"/> instance call the GetAlertRules method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AlertRuleCollection : ArmCollection, IEnumerable<AlertRuleResource>, IAsyncEnumerable<AlertRuleResource>
    {
        private readonly ClientDiagnostics _alertRuleClientDiagnostics;
        private readonly AlertRulesRestOperations _alertRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AlertRuleCollection"/> class for mocking. </summary>
        protected AlertRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AlertRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AlertRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _alertRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", AlertRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AlertRuleResource.ResourceType, out string alertRuleApiVersion);
            _alertRuleRestClient = new AlertRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, alertRuleApiVersion);
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
        /// Creates or updates a classic metric alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/alertrules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/alertrules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="data"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AlertRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleName, AlertRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _alertRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<AlertRuleResource>(Response.FromValue(new AlertRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a classic metric alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/alertrules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/alertrules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="data"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AlertRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleName, AlertRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _alertRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ruleName, data, cancellationToken);
                var operation = new MonitorArmOperation<AlertRuleResource>(Response.FromValue(new AlertRuleResource(Client, response), response.GetRawResponse()));
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
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<AlertRuleResource>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _alertRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<AlertRuleResource> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _alertRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the classic metric alert rules within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/alertrules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/alertrules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AlertRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AlertRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AlertRuleResource(Client, AlertRuleData.DeserializeAlertRuleData(e)), _alertRuleClientDiagnostics, Pipeline, "AlertRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List the classic metric alert rules within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/alertrules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/alertrules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AlertRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AlertRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AlertRuleResource(Client, AlertRuleData.DeserializeAlertRuleData(e)), _alertRuleClientDiagnostics, Pipeline, "AlertRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _alertRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _alertRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken);
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
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<NullableResponse<AlertRuleResource>> GetIfExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _alertRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AlertRuleResource>(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual NullableResponse<AlertRuleResource> GetIfExists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _alertRuleClientDiagnostics.CreateScope("AlertRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _alertRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AlertRuleResource>(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AlertRuleResource> IEnumerable<AlertRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AlertRuleResource> IAsyncEnumerable<AlertRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
