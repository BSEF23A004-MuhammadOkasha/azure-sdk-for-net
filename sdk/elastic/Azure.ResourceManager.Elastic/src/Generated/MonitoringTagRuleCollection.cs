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

namespace Azure.ResourceManager.Elastic
{
    /// <summary>
    /// A class representing a collection of <see cref="MonitoringTagRuleResource" /> and their operations.
    /// Each <see cref="MonitoringTagRuleResource" /> in the collection will belong to the same instance of <see cref="ElasticMonitorResource" />.
    /// To get a <see cref="MonitoringTagRuleCollection" /> instance call the GetMonitoringTagRules method from an instance of <see cref="ElasticMonitorResource" />.
    /// </summary>
    public partial class MonitoringTagRuleCollection : ArmCollection, IEnumerable<MonitoringTagRuleResource>, IAsyncEnumerable<MonitoringTagRuleResource>
    {
        private readonly ClientDiagnostics _monitoringTagRuleTagRulesClientDiagnostics;
        private readonly TagRulesRestOperations _monitoringTagRuleTagRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MonitoringTagRuleCollection"/> class for mocking. </summary>
        protected MonitoringTagRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MonitoringTagRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MonitoringTagRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _monitoringTagRuleTagRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Elastic", MonitoringTagRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MonitoringTagRuleResource.ResourceType, out string monitoringTagRuleTagRulesApiVersion);
            _monitoringTagRuleTagRulesRestClient = new TagRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, monitoringTagRuleTagRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ElasticMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ElasticMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a tag rule set for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Tag Rule Set resource name. </param>
        /// <param name="data"> request body of MonitoringTagRules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MonitoringTagRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleSetName, MonitoringTagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitoringTagRuleTagRulesClientDiagnostics.CreateScope("MonitoringTagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _monitoringTagRuleTagRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticArmOperation<MonitoringTagRuleResource>(Response.FromValue(new MonitoringTagRuleResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a tag rule set for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Tag Rule Set resource name. </param>
        /// <param name="data"> request body of MonitoringTagRules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MonitoringTagRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleSetName, MonitoringTagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitoringTagRuleTagRulesClientDiagnostics.CreateScope("MonitoringTagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _monitoringTagRuleTagRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken);
                var operation = new ElasticArmOperation<MonitoringTagRuleResource>(Response.FromValue(new MonitoringTagRuleResource(Client, response), response.GetRawResponse()));
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
        /// Get a tag rule set for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Tag Rule Set resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<MonitoringTagRuleResource>> GetAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _monitoringTagRuleTagRulesClientDiagnostics.CreateScope("MonitoringTagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _monitoringTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitoringTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a tag rule set for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Tag Rule Set resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<MonitoringTagRuleResource> Get(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _monitoringTagRuleTagRulesClientDiagnostics.CreateScope("MonitoringTagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _monitoringTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitoringTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the tag rules for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MonitoringTagRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MonitoringTagRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _monitoringTagRuleTagRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _monitoringTagRuleTagRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MonitoringTagRuleResource(Client, MonitoringTagRuleData.DeserializeMonitoringTagRuleData(e)), _monitoringTagRuleTagRulesClientDiagnostics, Pipeline, "MonitoringTagRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the tag rules for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MonitoringTagRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MonitoringTagRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _monitoringTagRuleTagRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _monitoringTagRuleTagRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MonitoringTagRuleResource(Client, MonitoringTagRuleData.DeserializeMonitoringTagRuleData(e)), _monitoringTagRuleTagRulesClientDiagnostics, Pipeline, "MonitoringTagRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Tag Rule Set resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _monitoringTagRuleTagRulesClientDiagnostics.CreateScope("MonitoringTagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _monitoringTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Tag Rule Set resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _monitoringTagRuleTagRulesClientDiagnostics.CreateScope("MonitoringTagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _monitoringTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MonitoringTagRuleResource> IEnumerable<MonitoringTagRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MonitoringTagRuleResource> IAsyncEnumerable<MonitoringTagRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
