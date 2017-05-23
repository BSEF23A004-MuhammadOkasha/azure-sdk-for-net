// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DocumentDB.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DocumentDB;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DatabaseAccountsOperations.
    /// </summary>
    public static partial class DatabaseAccountsOperationsExtensions
    {
            /// <summary>
            /// Retrieves the properties of an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            public static DatabaseAccountInner Get(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the properties of an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountInner> GetAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patches the properties of an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='tags'>
            /// </param>
            public static DatabaseAccountInner Patch(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IDictionary<string, string> tags)
            {
                return operations.PatchAsync(resourceGroupName, accountName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patches the properties of an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='tags'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountInner> PatchAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IDictionary<string, string> tags, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, accountName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The parameters to provide for the current database account.
            /// </param>
            public static DatabaseAccountInner CreateOrUpdate(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, DatabaseAccountCreateUpdateParametersInner createUpdateParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, createUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The parameters to provide for the current database account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountInner> CreateOrUpdateAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, DatabaseAccountCreateUpdateParametersInner createUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, createUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            public static void Delete(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Changes the failover priority for the Azure DocumentDB database account. A
            /// failover priority of 0 indicates a write region. The maximum value for a
            /// failover priority = (total number of regions - 1). Failover priority values
            /// must be unique for each of the regions in which the database account
            /// exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='failoverPoliciesProperty'>
            /// List of failover policies.
            /// </param>
            public static void FailoverPriorityChange(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IList<FailoverPolicyInner> failoverPoliciesProperty = default(IList<FailoverPolicyInner>))
            {
                operations.FailoverPriorityChangeAsync(resourceGroupName, accountName, failoverPoliciesProperty).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the failover priority for the Azure DocumentDB database account. A
            /// failover priority of 0 indicates a write region. The maximum value for a
            /// failover priority = (total number of regions - 1). Failover priority values
            /// must be unique for each of the regions in which the database account
            /// exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='failoverPoliciesProperty'>
            /// List of failover policies.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FailoverPriorityChangeAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IList<FailoverPolicyInner> failoverPoliciesProperty = default(IList<FailoverPolicyInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.FailoverPriorityChangeWithHttpMessagesAsync(resourceGroupName, accountName, failoverPoliciesProperty, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the Azure DocumentDB database accounts available under the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<DatabaseAccountInner> List(this IDatabaseAccountsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the Azure DocumentDB database accounts available under the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DatabaseAccountInner>> ListAsync(this IDatabaseAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the Azure DocumentDB database accounts available under the given
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            public static IEnumerable<DatabaseAccountInner> ListByResourceGroup(this IDatabaseAccountsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the Azure DocumentDB database accounts available under the given
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DatabaseAccountInner>> ListByResourceGroupAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the access keys for the specified Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            public static DatabaseAccountListKeysResultInner ListKeys(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the access keys for the specified Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountListKeysResultInner> ListKeysAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the connection strings for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            public static DatabaseAccountListConnectionStringsResultInner ListConnectionStrings(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListConnectionStringsAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the connection strings for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountListConnectionStringsResultInner> ListConnectionStringsAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListConnectionStringsWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the read-only access keys for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            public static DatabaseAccountListReadOnlyKeysResultInner ListReadOnlyKeys(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListReadOnlyKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the read-only access keys for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountListReadOnlyKeysResultInner> ListReadOnlyKeysAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListReadOnlyKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates an access key for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='keyKind'>
            /// The access key to regenerate. Possible values include: 'primary',
            /// 'secondary', 'primaryReadonly', 'secondaryReadonly'
            /// </param>
            public static void RegenerateKey(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, string keyKind)
            {
                operations.RegenerateKeyAsync(resourceGroupName, accountName, keyKind).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates an access key for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='keyKind'>
            /// The access key to regenerate. Possible values include: 'primary',
            /// 'secondary', 'primaryReadonly', 'secondaryReadonly'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegenerateKeyAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, string keyKind, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, accountName, keyKind, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks that the Azure DocumentDB account name already exists. A valid
            /// account name may contain only lowercase letters, numbers, and the '-'
            /// character, and must be between 3 and 50 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            public static bool CheckNameExists(this IDatabaseAccountsOperations operations, string accountName)
            {
                return operations.CheckNameExistsAsync(accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that the Azure DocumentDB account name already exists. A valid
            /// account name may contain only lowercase letters, numbers, and the '-'
            /// character, and must be between 3 and 50 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool> CheckNameExistsAsync(this IDatabaseAccountsOperations operations, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameExistsWithHttpMessagesAsync(accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patches the properties of an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='tags'>
            /// </param>
            public static DatabaseAccountInner BeginPatch(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IDictionary<string, string> tags)
            {
                return operations.BeginPatchAsync(resourceGroupName, accountName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patches the properties of an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='tags'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountInner> BeginPatchAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IDictionary<string, string> tags, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPatchWithHttpMessagesAsync(resourceGroupName, accountName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The parameters to provide for the current database account.
            /// </param>
            public static DatabaseAccountInner BeginCreateOrUpdate(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, DatabaseAccountCreateUpdateParametersInner createUpdateParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, accountName, createUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The parameters to provide for the current database account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseAccountInner> BeginCreateOrUpdateAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, DatabaseAccountCreateUpdateParametersInner createUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, createUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            public static void BeginDelete(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Azure DocumentDB database account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Changes the failover priority for the Azure DocumentDB database account. A
            /// failover priority of 0 indicates a write region. The maximum value for a
            /// failover priority = (total number of regions - 1). Failover priority values
            /// must be unique for each of the regions in which the database account
            /// exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='failoverPoliciesProperty'>
            /// List of failover policies.
            /// </param>
            public static void BeginFailoverPriorityChange(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IList<FailoverPolicyInner> failoverPoliciesProperty = default(IList<FailoverPolicyInner>))
            {
                operations.BeginFailoverPriorityChangeAsync(resourceGroupName, accountName, failoverPoliciesProperty).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the failover priority for the Azure DocumentDB database account. A
            /// failover priority of 0 indicates a write region. The maximum value for a
            /// failover priority = (total number of regions - 1). Failover priority values
            /// must be unique for each of the regions in which the database account
            /// exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='failoverPoliciesProperty'>
            /// List of failover policies.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginFailoverPriorityChangeAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, IList<FailoverPolicyInner> failoverPoliciesProperty = default(IList<FailoverPolicyInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginFailoverPriorityChangeWithHttpMessagesAsync(resourceGroupName, accountName, failoverPoliciesProperty, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Regenerates an access key for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='keyKind'>
            /// The access key to regenerate. Possible values include: 'primary',
            /// 'secondary', 'primaryReadonly', 'secondaryReadonly'
            /// </param>
            public static void BeginRegenerateKey(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, string keyKind)
            {
                operations.BeginRegenerateKeyAsync(resourceGroupName, accountName, keyKind).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates an access key for the specified Azure DocumentDB database
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// DocumentDB database account name.
            /// </param>
            /// <param name='keyKind'>
            /// The access key to regenerate. Possible values include: 'primary',
            /// 'secondary', 'primaryReadonly', 'secondaryReadonly'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRegenerateKeyAsync(this IDatabaseAccountsOperations operations, string resourceGroupName, string accountName, string keyKind, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRegenerateKeyWithHttpMessagesAsync(resourceGroupName, accountName, keyKind, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
