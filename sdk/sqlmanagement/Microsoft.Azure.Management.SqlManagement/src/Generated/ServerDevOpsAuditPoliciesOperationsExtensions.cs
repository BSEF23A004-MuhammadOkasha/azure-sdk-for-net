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
    /// Extension methods for ServerDevOpsAuditPoliciesOperations.
    /// </summary>
    public static partial class ServerDevOpsAuditPoliciesOperationsExtensions
    {
            /// <summary>
            /// Gets a server's DevOps audit policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='devOpsAuditPolicyName'>
            /// The name of the devops audit policy. This should always be 'default'.
            /// </param>
            public static ServerDevOpsAuditingPolicy Get(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName, string devOpsAuditPolicyName)
            {
                return operations.GetAsync(resourceGroupName, serverName, devOpsAuditPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a server's DevOps audit policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='devOpsAuditPolicyName'>
            /// The name of the devops audit policy. This should always be 'default'.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerDevOpsAuditingPolicy> GetAsync(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName, string devOpsAuditPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, devOpsAuditPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a server's DevOps audit policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='devOpsAuditPolicyName'>
            /// The name of the devops audit policy. This should always be 'default'.
            /// </param>
            /// <param name='parameters'>
            /// Properties of DevOps audit policy
            /// </param>
            public static ServerDevOpsAuditingPolicy CreateOrUpdate(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName, string devOpsAuditPolicyName, ServerDevOpsAuditingPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, devOpsAuditPolicyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a server's DevOps audit policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='devOpsAuditPolicyName'>
            /// The name of the devops audit policy. This should always be 'default'.
            /// </param>
            /// <param name='parameters'>
            /// Properties of DevOps audit policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerDevOpsAuditingPolicy> CreateOrUpdateAsync(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName, string devOpsAuditPolicyName, ServerDevOpsAuditingPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, devOpsAuditPolicyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists DevOps audit settings of a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IPage<ServerDevOpsAuditingPolicy> ListByServer(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DevOps audit settings of a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServerDevOpsAuditingPolicy>> ListByServerAsync(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a server's DevOps audit policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='devOpsAuditPolicyName'>
            /// The name of the devops audit policy. This should always be 'default'.
            /// </param>
            /// <param name='parameters'>
            /// Properties of DevOps audit policy
            /// </param>
            public static ServerDevOpsAuditingPolicy BeginCreateOrUpdate(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName, string devOpsAuditPolicyName, ServerDevOpsAuditingPolicy parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, devOpsAuditPolicyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a server's DevOps audit policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='devOpsAuditPolicyName'>
            /// The name of the devops audit policy. This should always be 'default'.
            /// </param>
            /// <param name='parameters'>
            /// Properties of DevOps audit policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerDevOpsAuditingPolicy> BeginCreateOrUpdateAsync(this IServerDevOpsAuditPoliciesOperations operations, string resourceGroupName, string serverName, string devOpsAuditPolicyName, ServerDevOpsAuditingPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, devOpsAuditPolicyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists DevOps audit settings of a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServerDevOpsAuditingPolicy> ListByServerNext(this IServerDevOpsAuditPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DevOps audit settings of a server.
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
            public static async Task<IPage<ServerDevOpsAuditingPolicy>> ListByServerNextAsync(this IServerDevOpsAuditPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
