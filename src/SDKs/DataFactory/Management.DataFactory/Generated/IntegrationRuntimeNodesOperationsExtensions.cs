// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationRuntimeNodesOperations.
    /// </summary>
    public static partial class IntegrationRuntimeNodesOperationsExtensions
    {
            /// <summary>
            /// Deletes a self-hosted integration runtime node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// The integration runtime name.
            /// </param>
            /// <param name='nodeName'>
            /// The integration runtime node name.
            /// </param>
            public static void Delete(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string factoryName, string integrationRuntimeName, string nodeName)
            {
                operations.DeleteAsync(resourceGroupName, factoryName, integrationRuntimeName, nodeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a self-hosted integration runtime node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// The integration runtime name.
            /// </param>
            /// <param name='nodeName'>
            /// The integration runtime node name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string factoryName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, factoryName, integrationRuntimeName, nodeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a self-hosted integration runtime node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// The integration runtime name.
            /// </param>
            /// <param name='nodeName'>
            /// The integration runtime node name.
            /// </param>
            /// <param name='updateIntegrationRuntimeNodeRequest'>
            /// The parameters for updating an integration runtime node.
            /// </param>
            public static SelfHostedIntegrationRuntimeNode Update(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string factoryName, string integrationRuntimeName, string nodeName, UpdateIntegrationRuntimeNodeRequest updateIntegrationRuntimeNodeRequest)
            {
                return operations.UpdateAsync(resourceGroupName, factoryName, integrationRuntimeName, nodeName, updateIntegrationRuntimeNodeRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a self-hosted integration runtime node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// The integration runtime name.
            /// </param>
            /// <param name='nodeName'>
            /// The integration runtime node name.
            /// </param>
            /// <param name='updateIntegrationRuntimeNodeRequest'>
            /// The parameters for updating an integration runtime node.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SelfHostedIntegrationRuntimeNode> UpdateAsync(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string factoryName, string integrationRuntimeName, string nodeName, UpdateIntegrationRuntimeNodeRequest updateIntegrationRuntimeNodeRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, factoryName, integrationRuntimeName, nodeName, updateIntegrationRuntimeNodeRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the IP address of self-hosted integration runtime node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// The integration runtime name.
            /// </param>
            /// <param name='nodeName'>
            /// The integration runtime node name.
            /// </param>
            public static IntegrationRuntimeNodeIpAddress GetIpAddress(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string factoryName, string integrationRuntimeName, string nodeName)
            {
                return operations.GetIpAddressAsync(resourceGroupName, factoryName, integrationRuntimeName, nodeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the IP address of self-hosted integration runtime node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// The integration runtime name.
            /// </param>
            /// <param name='nodeName'>
            /// The integration runtime node name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationRuntimeNodeIpAddress> GetIpAddressAsync(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string factoryName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetIpAddressWithHttpMessagesAsync(resourceGroupName, factoryName, integrationRuntimeName, nodeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
