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
using Azure.ResourceManager.Purview.Mocking;
using Azure.ResourceManager.Purview.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Purview
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Purview. </summary>
    public static partial class PurviewExtensions
    {
        private static MockablePurviewArmClient GetMockablePurviewArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockablePurviewArmClient(client0));
        }

        private static MockablePurviewResourceGroupResource GetMockablePurviewResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePurviewResourceGroupResource(client, resource.Id));
        }

        private static MockablePurviewSubscriptionResource GetMockablePurviewSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePurviewSubscriptionResource(client, resource.Id));
        }

        private static MockablePurviewTenantResource GetMockablePurviewTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePurviewTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="PurviewAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewAccountResource.CreateResourceIdentifier" /> to create a <see cref="PurviewAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewArmClient.GetPurviewAccountResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PurviewAccountResource"/> object. </returns>
        public static PurviewAccountResource GetPurviewAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePurviewArmClient(client).GetPurviewAccountResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PurviewPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="PurviewPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewArmClient.GetPurviewPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PurviewPrivateEndpointConnectionResource"/> object. </returns>
        public static PurviewPrivateEndpointConnectionResource GetPurviewPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePurviewArmClient(client).GetPurviewPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PurviewPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PurviewPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewArmClient.GetPurviewPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PurviewPrivateLinkResource"/> object. </returns>
        public static PurviewPrivateLinkResource GetPurviewPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePurviewArmClient(client).GetPurviewPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets a collection of PurviewAccountResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewResourceGroupResource.GetPurviewAccounts()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of PurviewAccountResources and their operations over a PurviewAccountResource. </returns>
        public static PurviewAccountCollection GetPurviewAccounts(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePurviewResourceGroupResource(resourceGroupResource).GetPurviewAccounts();
        }

        /// <summary>
        /// Get an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewResourceGroupResource.GetPurviewAccountAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PurviewAccountResource>> GetPurviewAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockablePurviewResourceGroupResource(resourceGroupResource).GetPurviewAccountAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewResourceGroupResource.GetPurviewAccount(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<PurviewAccountResource> GetPurviewAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePurviewResourceGroupResource(resourceGroupResource).GetPurviewAccount(accountName, cancellationToken);
        }

        /// <summary>
        /// List accounts in Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewSubscriptionResource.GetPurviewAccounts(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="PurviewAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PurviewAccountResource> GetPurviewAccountsAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePurviewSubscriptionResource(subscriptionResource).GetPurviewAccountsAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// List accounts in Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewSubscriptionResource.GetPurviewAccounts(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="PurviewAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PurviewAccountResource> GetPurviewAccounts(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePurviewSubscriptionResource(subscriptionResource).GetPurviewAccounts(skipToken, cancellationToken);
        }

        /// <summary>
        /// Checks if account name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewSubscriptionResource.CheckPurviewAccountNameAvailability(PurviewAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<PurviewAccountNameAvailabilityResult>> CheckPurviewAccountNameAvailabilityAsync(this SubscriptionResource subscriptionResource, PurviewAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockablePurviewSubscriptionResource(subscriptionResource).CheckPurviewAccountNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks if account name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewSubscriptionResource.CheckPurviewAccountNameAvailability(PurviewAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<PurviewAccountNameAvailabilityResult> CheckPurviewAccountNameAvailability(this SubscriptionResource subscriptionResource, PurviewAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePurviewSubscriptionResource(subscriptionResource).CheckPurviewAccountNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Get the default account for the scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Purview/getDefaultAccount</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewTenantResource.GetDefaultAccount(Guid,PurviewAccountScopeType,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        public static async Task<Response<DefaultPurviewAccountPayload>> GetDefaultAccountAsync(this TenantResource tenantResource, Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockablePurviewTenantResource(tenantResource).GetDefaultAccountAsync(scopeTenantId, scopeType, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the default account for the scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Purview/getDefaultAccount</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewTenantResource.GetDefaultAccount(Guid,PurviewAccountScopeType,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        public static Response<DefaultPurviewAccountPayload> GetDefaultAccount(this TenantResource tenantResource, Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockablePurviewTenantResource(tenantResource).GetDefaultAccount(scopeTenantId, scopeType, scope, cancellationToken);
        }

        /// <summary>
        /// Sets the default account for the scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Purview/setDefaultAccount</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultAccounts_Set</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewTenantResource.SetDefaultAccount(DefaultPurviewAccountPayload,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="defaultAccountPayload"> The payload containing the default account information and the scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="defaultAccountPayload"/> is null. </exception>
        public static async Task<Response<DefaultPurviewAccountPayload>> SetDefaultAccountAsync(this TenantResource tenantResource, DefaultPurviewAccountPayload defaultAccountPayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockablePurviewTenantResource(tenantResource).SetDefaultAccountAsync(defaultAccountPayload, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the default account for the scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Purview/setDefaultAccount</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultAccounts_Set</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewTenantResource.SetDefaultAccount(DefaultPurviewAccountPayload,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="defaultAccountPayload"> The payload containing the default account information and the scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="defaultAccountPayload"/> is null. </exception>
        public static Response<DefaultPurviewAccountPayload> SetDefaultAccount(this TenantResource tenantResource, DefaultPurviewAccountPayload defaultAccountPayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockablePurviewTenantResource(tenantResource).SetDefaultAccount(defaultAccountPayload, cancellationToken);
        }

        /// <summary>
        /// Removes the default account from the scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Purview/removeDefaultAccount</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultAccounts_Remove</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewTenantResource.RemoveDefaultAccount(Guid,PurviewAccountScopeType,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        public static async Task<Response> RemoveDefaultAccountAsync(this TenantResource tenantResource, Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockablePurviewTenantResource(tenantResource).RemoveDefaultAccountAsync(scopeTenantId, scopeType, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Removes the default account from the scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Purview/removeDefaultAccount</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultAccounts_Remove</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePurviewTenantResource.RemoveDefaultAccount(Guid,PurviewAccountScopeType,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        public static Response RemoveDefaultAccount(this TenantResource tenantResource, Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockablePurviewTenantResource(tenantResource).RemoveDefaultAccount(scopeTenantId, scopeType, scope, cancellationToken);
        }
    }
}
