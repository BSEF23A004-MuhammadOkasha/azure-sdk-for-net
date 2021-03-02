// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.ResourceManager.DeviceUpdate
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InstancesOperations.
    /// </summary>
    public static partial class InstancesOperationsExtensions
    {
            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            public static IPage<Instance> ListBySubscription(this IInstancesOperations operations, string accountName)
            {
                return operations.ListBySubscriptionAsync(accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Instance>> ListBySubscriptionAsync(this IInstancesOperations operations, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            public static IPage<Instance> ListByAccount(this IInstancesOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListByAccountAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Instance>> ListByAccountAsync(this IInstancesOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns instances for the given account and instance name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            public static Instance Get(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName)
            {
                return operations.GetAsync(resourceGroupName, accountName, instanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns instances for the given account and instance name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Instance> GetAsync(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, instanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='instance'>
            /// Instance details.
            /// </param>
            public static Instance Create(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, Instance instance)
            {
                return operations.CreateAsync(resourceGroupName, accountName, instanceName, instance).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='instance'>
            /// Instance details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Instance> CreateAsync(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, Instance instance, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, instanceName, instance, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            public static void Delete(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, instanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, instanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates instance's tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='tags'>
            /// List of key value pairs that describe the resource. This will overwrite the
            /// existing tags.
            /// </param>
            public static Instance Update(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, accountName, instanceName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates instance's tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='tags'>
            /// List of key value pairs that describe the resource. This will overwrite the
            /// existing tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Instance> UpdateAsync(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, instanceName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='instance'>
            /// Instance details.
            /// </param>
            public static Instance BeginCreate(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, Instance instance)
            {
                return operations.BeginCreateAsync(resourceGroupName, accountName, instanceName, instance).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='instance'>
            /// Instance details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Instance> BeginCreateAsync(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, Instance instance, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, instanceName, instance, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            public static void BeginDelete(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName, instanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='instanceName'>
            /// Instance name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IInstancesOperations operations, string resourceGroupName, string accountName, string instanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, instanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Instance> ListBySubscriptionNext(this IInstancesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Instance>> ListBySubscriptionNextAsync(this IInstancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Instance> ListByAccountNext(this IInstancesOperations operations, string nextPageLink)
            {
                return operations.ListByAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns instances for the given account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Instance>> ListByAccountNextAsync(this IInstancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
