// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedInstancesOperations.
    /// </summary>
    public static partial class ManagedInstancesOperationsExtensions
    {
            /// <summary>
            /// Failovers a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance to failover.
            /// </param>
            /// <param name='replicaType'>
            /// The type of replica to be failed over. Possible values include: 'Primary',
            /// 'ReadableSecondary'
            /// </param>
            public static void Failover(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, string replicaType = default(string))
            {
                operations.FailoverAsync(resourceGroupName, managedInstanceName, replicaType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Failovers a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance to failover.
            /// </param>
            /// <param name='replicaType'>
            /// The type of replica to be failed over. Possible values include: 'Primary',
            /// 'ReadableSecondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FailoverAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, string replicaType = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.FailoverWithHttpMessagesAsync(resourceGroupName, managedInstanceName, replicaType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of managed instances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static IPage<ManagedInstance> ListByResourceGroup(this IManagedInstancesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed instances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedInstance>> ListByResourceGroupAsync(this IManagedInstancesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static ManagedInstance Get(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstance> GetAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            public static ManagedInstance CreateOrUpdate(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstance parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstance> CreateOrUpdateAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstance parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static void Delete(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName)
            {
                operations.DeleteAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            public static ManagedInstance Update(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstance> UpdateAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all managed instances in an instance pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='instancePoolName'>
            /// The instance pool name.
            /// </param>
            public static IPage<ManagedInstance> ListByInstancePool(this IManagedInstancesOperations operations, string resourceGroupName, string instancePoolName)
            {
                return operations.ListByInstancePoolAsync(resourceGroupName, instancePoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all managed instances in an instance pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='instancePoolName'>
            /// The instance pool name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedInstance>> ListByInstancePoolAsync(this IManagedInstancesOperations operations, string resourceGroupName, string instancePoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstancePoolWithHttpMessagesAsync(resourceGroupName, instancePoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all managed instances in the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ManagedInstance> List(this IManagedInstancesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all managed instances in the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedInstance>> ListAsync(this IManagedInstancesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Failovers a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance to failover.
            /// </param>
            /// <param name='replicaType'>
            /// The type of replica to be failed over. Possible values include: 'Primary',
            /// 'ReadableSecondary'
            /// </param>
            public static void BeginFailover(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, string replicaType = default(string))
            {
                operations.BeginFailoverAsync(resourceGroupName, managedInstanceName, replicaType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Failovers a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance to failover.
            /// </param>
            /// <param name='replicaType'>
            /// The type of replica to be failed over. Possible values include: 'Primary',
            /// 'ReadableSecondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginFailoverAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, string replicaType = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginFailoverWithHttpMessagesAsync(resourceGroupName, managedInstanceName, replicaType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            public static ManagedInstance BeginCreateOrUpdate(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstance parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstance> BeginCreateOrUpdateAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstance parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static void BeginDelete(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            public static ManagedInstance BeginUpdate(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a managed instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstance> BeginUpdateAsync(this IManagedInstancesOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of managed instances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedInstance> ListByResourceGroupNext(this IManagedInstancesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed instances in a resource group.
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
            public static async Task<IPage<ManagedInstance>> ListByResourceGroupNextAsync(this IManagedInstancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all managed instances in an instance pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedInstance> ListByInstancePoolNext(this IManagedInstancesOperations operations, string nextPageLink)
            {
                return operations.ListByInstancePoolNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all managed instances in an instance pool.
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
            public static async Task<IPage<ManagedInstance>> ListByInstancePoolNextAsync(this IManagedInstancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstancePoolNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all managed instances in the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedInstance> ListNext(this IManagedInstancesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all managed instances in the subscription.
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
            public static async Task<IPage<ManagedInstance>> ListNextAsync(this IManagedInstancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
