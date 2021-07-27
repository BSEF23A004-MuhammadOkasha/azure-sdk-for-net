// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Purview
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AccountsOperations.
    /// </summary>
    public static partial class AccountsOperationsExtensions
    {
            /// <summary>
            /// Gets the accounts resources by resource group.
            /// </summary>
            /// <remarks>
            /// List accounts in ResourceGroup
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='skipToken'>
            /// The skip token.
            /// </param>
            public static IPage<Account> ListByResourceGroup(this IAccountsOperations operations, string resourceGroupName, string skipToken = default(string))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the accounts resources by resource group.
            /// </summary>
            /// <remarks>
            /// List accounts in ResourceGroup
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='skipToken'>
            /// The skip token.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Account>> ListByResourceGroupAsync(this IAccountsOperations operations, string resourceGroupName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the accounts resources by subscription.
            /// </summary>
            /// <remarks>
            /// List accounts in Subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// The skip token.
            /// </param>
            public static IPage<Account> ListBySubscription(this IAccountsOperations operations, string skipToken = default(string))
            {
                return operations.ListBySubscriptionAsync(skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the accounts resources by subscription.
            /// </summary>
            /// <remarks>
            /// List accounts in Subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// The skip token.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Account>> ListBySubscriptionAsync(this IAccountsOperations operations, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the account resource.
            /// </summary>
            /// <remarks>
            /// Get an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            public static Account Get(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the account resource.
            /// </summary>
            /// <remarks>
            /// Get an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Account> GetAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an account resource
            /// </summary>
            /// <remarks>
            /// Creates or updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='account'>
            /// The account.
            /// </param>
            public static Account CreateOrUpdate(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, account).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an account resource
            /// </summary>
            /// <remarks>
            /// Creates or updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='account'>
            /// The account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Account> CreateOrUpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, account, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the account resource.
            /// </summary>
            /// <remarks>
            /// Deletes an account resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            public static void Delete(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the account resource.
            /// </summary>
            /// <remarks>
            /// Deletes an account resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Patches the account resource.
            /// </summary>
            /// <remarks>
            /// Updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='accountUpdateParameters'>
            /// The account update parameters.
            /// </param>
            public static Account Update(this IAccountsOperations operations, string resourceGroupName, string accountName, AccountUpdateParameters accountUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, accountUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patches the account resource.
            /// </summary>
            /// <remarks>
            /// Updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='accountUpdateParameters'>
            /// The account update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Account> UpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, AccountUpdateParameters accountUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, accountUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the keys asynchronous.
            /// </summary>
            /// <remarks>
            /// List the authorization keys associated with this account.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            public static AccessKeys ListKeys(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the keys asynchronous.
            /// </summary>
            /// <remarks>
            /// List the authorization keys associated with this account.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add the administrator for root collection.
            /// </summary>
            /// <remarks>
            /// Add the administrator for root collection associated with this account.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='collectionAdminUpdate'>
            /// The collection admin update payload.
            /// </param>
            public static void AddRootCollectionAdmin(this IAccountsOperations operations, string resourceGroupName, string accountName, CollectionAdminUpdate collectionAdminUpdate)
            {
                operations.AddRootCollectionAdminAsync(resourceGroupName, accountName, collectionAdminUpdate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add the administrator for root collection.
            /// </summary>
            /// <remarks>
            /// Add the administrator for root collection associated with this account.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='collectionAdminUpdate'>
            /// The collection admin update payload.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddRootCollectionAdminAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CollectionAdminUpdate collectionAdminUpdate, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddRootCollectionAdminWithHttpMessagesAsync(resourceGroupName, accountName, collectionAdminUpdate, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks the account name availability.
            /// </summary>
            /// <remarks>
            /// Checks if account name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkNameAvailabilityRequest'>
            /// The check name availability request.
            /// </param>
            public static CheckNameAvailabilityResult CheckNameAvailability(this IAccountsOperations operations, CheckNameAvailabilityRequest checkNameAvailabilityRequest)
            {
                return operations.CheckNameAvailabilityAsync(checkNameAvailabilityRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the account name availability.
            /// </summary>
            /// <remarks>
            /// Checks if account name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkNameAvailabilityRequest'>
            /// The check name availability request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IAccountsOperations operations, CheckNameAvailabilityRequest checkNameAvailabilityRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(checkNameAvailabilityRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an account resource
            /// </summary>
            /// <remarks>
            /// Creates or updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='account'>
            /// The account.
            /// </param>
            public static Account BeginCreateOrUpdate(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, accountName, account).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an account resource
            /// </summary>
            /// <remarks>
            /// Creates or updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='account'>
            /// The account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Account> BeginCreateOrUpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, account, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the account resource.
            /// </summary>
            /// <remarks>
            /// Deletes an account resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            public static void BeginDelete(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the account resource.
            /// </summary>
            /// <remarks>
            /// Deletes an account resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Patches the account resource.
            /// </summary>
            /// <remarks>
            /// Updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='accountUpdateParameters'>
            /// The account update parameters.
            /// </param>
            public static Account BeginUpdate(this IAccountsOperations operations, string resourceGroupName, string accountName, AccountUpdateParameters accountUpdateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, accountName, accountUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patches the account resource.
            /// </summary>
            /// <remarks>
            /// Updates an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='accountUpdateParameters'>
            /// The account update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Account> BeginUpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, AccountUpdateParameters accountUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, accountName, accountUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the accounts resources by resource group.
            /// </summary>
            /// <remarks>
            /// List accounts in ResourceGroup
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Account> ListByResourceGroupNext(this IAccountsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the accounts resources by resource group.
            /// </summary>
            /// <remarks>
            /// List accounts in ResourceGroup
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Account>> ListByResourceGroupNextAsync(this IAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the accounts resources by subscription.
            /// </summary>
            /// <remarks>
            /// List accounts in Subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Account> ListBySubscriptionNext(this IAccountsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the accounts resources by subscription.
            /// </summary>
            /// <remarks>
            /// List accounts in Subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Account>> ListBySubscriptionNextAsync(this IAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
