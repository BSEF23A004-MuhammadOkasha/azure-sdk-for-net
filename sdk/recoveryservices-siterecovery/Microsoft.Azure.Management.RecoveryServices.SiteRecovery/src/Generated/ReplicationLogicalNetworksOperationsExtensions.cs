// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationLogicalNetworksOperations.
    /// </summary>
    public static partial class ReplicationLogicalNetworksOperationsExtensions
    {
            /// <summary>
            /// Gets the list of logical networks under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists all the logical networks of the Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Server Id.
            /// </param>
            public static IPage<LogicalNetwork> ListByReplicationFabrics(this IReplicationLogicalNetworksOperations operations, string fabricName)
            {
                return operations.ListByReplicationFabricsAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of logical networks under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists all the logical networks of the Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Server Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LogicalNetwork>> ListByReplicationFabricsAsync(this IReplicationLogicalNetworksOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a logical network with specified server id and logical network name.
            /// </summary>
            /// <remarks>
            /// Gets the details of a logical network.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Server Id.
            /// </param>
            /// <param name='logicalNetworkName'>
            /// Logical network name.
            /// </param>
            public static LogicalNetwork Get(this IReplicationLogicalNetworksOperations operations, string fabricName, string logicalNetworkName)
            {
                return operations.GetAsync(fabricName, logicalNetworkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a logical network with specified server id and logical network name.
            /// </summary>
            /// <remarks>
            /// Gets the details of a logical network.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Server Id.
            /// </param>
            /// <param name='logicalNetworkName'>
            /// Logical network name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogicalNetwork> GetAsync(this IReplicationLogicalNetworksOperations operations, string fabricName, string logicalNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, logicalNetworkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of logical networks under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists all the logical networks of the Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LogicalNetwork> ListByReplicationFabricsNext(this IReplicationLogicalNetworksOperations operations, string nextPageLink)
            {
                return operations.ListByReplicationFabricsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of logical networks under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists all the logical networks of the Azure Site Recovery fabric.
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
            public static async Task<IPage<LogicalNetwork>> ListByReplicationFabricsNextAsync(this IReplicationLogicalNetworksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
