// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NewRelicObservability.Mocking;
using Azure.ResourceManager.NewRelicObservability.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.NewRelicObservability. </summary>
    public static partial class NewRelicObservabilityExtensions
    {
        private static MockableNewRelicObservabilityArmClient GetMockableNewRelicObservabilityArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableNewRelicObservabilityArmClient(client0));
        }

        private static MockableNewRelicObservabilityResourceGroupResource GetMockableNewRelicObservabilityResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableNewRelicObservabilityResourceGroupResource(client, resource.Id));
        }

        private static MockableNewRelicObservabilitySubscriptionResource GetMockableNewRelicObservabilitySubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableNewRelicObservabilitySubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="NewRelicMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NewRelicMonitorResource.CreateResourceIdentifier" /> to create a <see cref="NewRelicMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilityArmClient.GetNewRelicMonitorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="NewRelicMonitorResource"/> object. </returns>
        public static NewRelicMonitorResource GetNewRelicMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableNewRelicObservabilityArmClient(client).GetNewRelicMonitorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NewRelicObservabilityTagRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NewRelicObservabilityTagRuleResource.CreateResourceIdentifier" /> to create a <see cref="NewRelicObservabilityTagRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilityArmClient.GetNewRelicObservabilityTagRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="NewRelicObservabilityTagRuleResource"/> object. </returns>
        public static NewRelicObservabilityTagRuleResource GetNewRelicObservabilityTagRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableNewRelicObservabilityArmClient(client).GetNewRelicObservabilityTagRuleResource(id);
        }

        /// <summary>
        /// Gets a collection of NewRelicMonitorResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilityResourceGroupResource.GetNewRelicMonitorResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of NewRelicMonitorResources and their operations over a NewRelicMonitorResource. </returns>
        public static NewRelicMonitorResourceCollection GetNewRelicMonitorResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableNewRelicObservabilityResourceGroupResource(resourceGroupResource).GetNewRelicMonitorResources();
        }

        /// <summary>
        /// Get a NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>NewRelic.Observability/monitors</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilityResourceGroupResource.GetNewRelicMonitorResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Name of the Monitors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<NewRelicMonitorResource>> GetNewRelicMonitorResourceAsync(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableNewRelicObservabilityResourceGroupResource(resourceGroupResource).GetNewRelicMonitorResourceAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>NewRelic.Observability/monitors</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilityResourceGroupResource.GetNewRelicMonitorResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Name of the Monitors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<NewRelicMonitorResource> GetNewRelicMonitorResource(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableNewRelicObservabilityResourceGroupResource(resourceGroupResource).GetNewRelicMonitorResource(monitorName, cancellationToken);
        }

        /// <summary>
        /// List all the existing accounts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicAccounts(string,AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="userEmail"/> is null. </exception>
        /// <returns> An async collection of <see cref="NewRelicAccountResourceData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicAccountResourceData> GetNewRelicAccountsAsync(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicAccountsAsync(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List all the existing accounts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicAccounts(string,AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="userEmail"/> is null. </exception>
        /// <returns> A collection of <see cref="NewRelicAccountResourceData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicAccountResourceData> GetNewRelicAccounts(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicAccounts(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List NewRelicMonitorResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>NewRelic.Observability/monitors</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicMonitorResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="NewRelicMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicMonitorResource> GetNewRelicMonitorResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicMonitorResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List NewRelicMonitorResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>NewRelic.Observability/monitors</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicMonitorResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="NewRelicMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicMonitorResource> GetNewRelicMonitorResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicMonitorResources(cancellationToken);
        }

        /// <summary>
        /// List all the existing organizations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicOrganizations(string,AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="userEmail"/> is null. </exception>
        /// <returns> An async collection of <see cref="NewRelicOrganizationResourceData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicOrganizationResourceData> GetNewRelicOrganizationsAsync(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicOrganizationsAsync(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List all the existing organizations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicOrganizations(string,AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="userEmail"/> is null. </exception>
        /// <returns> A collection of <see cref="NewRelicOrganizationResourceData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicOrganizationResourceData> GetNewRelicOrganizations(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicOrganizations(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List plans data
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/plans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Plans_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicPlans(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="accountId"> Account Id. </param>
        /// <param name="organizationId"> Organization Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="NewRelicPlanData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicPlanData> GetNewRelicPlansAsync(this SubscriptionResource subscriptionResource, string accountId = null, string organizationId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicPlansAsync(accountId, organizationId, cancellationToken);
        }

        /// <summary>
        /// List plans data
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/plans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Plans_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableNewRelicObservabilitySubscriptionResource.GetNewRelicPlans(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="accountId"> Account Id. </param>
        /// <param name="organizationId"> Organization Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="NewRelicPlanData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicPlanData> GetNewRelicPlans(this SubscriptionResource subscriptionResource, string accountId = null, string organizationId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableNewRelicObservabilitySubscriptionResource(subscriptionResource).GetNewRelicPlans(accountId, organizationId, cancellationToken);
        }
    }
}
