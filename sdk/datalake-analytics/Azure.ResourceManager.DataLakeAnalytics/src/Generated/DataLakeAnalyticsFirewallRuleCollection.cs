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

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeAnalyticsFirewallRuleResource"/> and their operations.
    /// Each <see cref="DataLakeAnalyticsFirewallRuleResource"/> in the collection will belong to the same instance of <see cref="DataLakeAnalyticsAccountResource"/>.
    /// To get a <see cref="DataLakeAnalyticsFirewallRuleCollection"/> instance call the GetDataLakeAnalyticsFirewallRules method from an instance of <see cref="DataLakeAnalyticsAccountResource"/>.
    /// </summary>
    public partial class DataLakeAnalyticsFirewallRuleCollection : ArmCollection, IEnumerable<DataLakeAnalyticsFirewallRuleResource>, IAsyncEnumerable<DataLakeAnalyticsFirewallRuleResource>
    {
        private readonly ClientDiagnostics _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics;
        private readonly FirewallRulesRestOperations _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsFirewallRuleCollection"/> class for mocking. </summary>
        protected DataLakeAnalyticsFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeAnalyticsFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", DataLakeAnalyticsFirewallRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeAnalyticsFirewallRuleResource.ResourceType, out string dataLakeAnalyticsFirewallRuleFirewallRulesApiVersion);
            _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient = new FirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeAnalyticsFirewallRuleFirewallRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeAnalyticsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeAnalyticsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified firewall rule. During update, the firewall rule with the specified name will be replaced with this new firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the firewall rule to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeAnalyticsFirewallRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firewallRuleName, DataLakeAnalyticsFirewallRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsFirewallRuleResource>(Response.FromValue(new DataLakeAnalyticsFirewallRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the specified firewall rule. During update, the firewall rule with the specified name will be replaced with this new firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the firewall rule to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataLakeAnalyticsFirewallRuleResource> CreateOrUpdate(WaitUntil waitUntil, string firewallRuleName, DataLakeAnalyticsFirewallRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, content, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsFirewallRuleResource>(Response.FromValue(new DataLakeAnalyticsFirewallRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified Data Lake Analytics firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<DataLakeAnalyticsFirewallRuleResource>> GetAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<DataLakeAnalyticsFirewallRuleResource> Get(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Data Lake Analytics firewall rules within the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsFirewallRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeAnalyticsFirewallRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DataLakeAnalyticsFirewallRuleResource(Client, DataLakeAnalyticsFirewallRuleData.DeserializeDataLakeAnalyticsFirewallRuleData(e)), _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "DataLakeAnalyticsFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Data Lake Analytics firewall rules within the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsFirewallRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeAnalyticsFirewallRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DataLakeAnalyticsFirewallRuleResource(Client, DataLakeAnalyticsFirewallRuleData.DeserializeDataLakeAnalyticsFirewallRuleData(e)), _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "DataLakeAnalyticsFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataLakeAnalyticsFirewallRuleResource>> GetIfExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeAnalyticsFirewallRuleResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsFirewallRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual NullableResponse<DataLakeAnalyticsFirewallRuleResource> GetIfExists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeAnalyticsFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeAnalyticsFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeAnalyticsFirewallRuleResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeAnalyticsFirewallRuleResource> IEnumerable<DataLakeAnalyticsFirewallRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataLakeAnalyticsFirewallRuleResource> IAsyncEnumerable<DataLakeAnalyticsFirewallRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
