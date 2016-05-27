// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NetworkSecurityGroupsOperations.
    /// </summary>
    public static partial class NetworkSecurityGroupsOperationsExtensions
    {
            /// <summary>
            /// The Delete NetworkSecurityGroup operation deletes the specifed network
            /// security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            public static void Delete(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName)
            {
                Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).DeleteAsync(resourceGroupName, networkSecurityGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete NetworkSecurityGroup operation deletes the specifed network
            /// security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Delete NetworkSecurityGroup operation deletes the specifed network
            /// security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            public static void BeginDelete(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName)
            {
                Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).BeginDeleteAsync(resourceGroupName, networkSecurityGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete NetworkSecurityGroup operation deletes the specifed network
            /// security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get NetworkSecurityGroups operation retrieves information about the
            /// specified network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static NetworkSecurityGroup Get(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).GetAsync(resourceGroupName, networkSecurityGroupName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get NetworkSecurityGroups operation retrieves information about the
            /// specified network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkSecurityGroup> GetAsync(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put NetworkSecurityGroup operation creates/updates a network security
            /// groupin the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Network Security Group operation
            /// </param>
            public static NetworkSecurityGroup CreateOrUpdate(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters)
            {
                return Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).CreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put NetworkSecurityGroup operation creates/updates a network security
            /// groupin the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Network Security Group operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkSecurityGroup> CreateOrUpdateAsync(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put NetworkSecurityGroup operation creates/updates a network security
            /// groupin the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Network Security Group operation
            /// </param>
            public static NetworkSecurityGroup BeginCreateOrUpdate(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters)
            {
                return Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put NetworkSecurityGroup operation creates/updates a network security
            /// groupin the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Network Security Group operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkSecurityGroup> BeginCreateOrUpdateAsync(this INetworkSecurityGroupsOperations operations, string resourceGroupName, string networkSecurityGroupName, NetworkSecurityGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NetworkSecurityGroup> ListAll(this INetworkSecurityGroupsOperations operations)
            {
                return Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkSecurityGroup>> ListAllAsync(this INetworkSecurityGroupsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<NetworkSecurityGroup> List(this INetworkSecurityGroupsOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkSecurityGroup>> ListAsync(this INetworkSecurityGroupsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkSecurityGroup> ListAllNext(this INetworkSecurityGroupsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// subscription
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
            public static async Task<IPage<NetworkSecurityGroup>> ListAllNextAsync(this INetworkSecurityGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkSecurityGroup> ListNext(this INetworkSecurityGroupsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkSecurityGroupsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list NetworkSecurityGroups returns all network security groups in a
            /// resource group
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
            public static async Task<IPage<NetworkSecurityGroup>> ListNextAsync(this INetworkSecurityGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
