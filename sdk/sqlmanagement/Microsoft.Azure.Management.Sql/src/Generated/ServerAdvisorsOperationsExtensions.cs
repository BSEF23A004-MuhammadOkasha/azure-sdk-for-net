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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServerAdvisorsOperations.
    /// </summary>
    public static partial class ServerAdvisorsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of server advisors.
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
            /// <param name='expand'>
            /// The child resources to include in the response.
            /// </param>
            public static IList<Advisor> ListByServer(this IServerAdvisorsOperations operations, string resourceGroupName, string serverName, string expand = default(string))
            {
                return operations.ListByServerAsync(resourceGroupName, serverName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of server advisors.
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
            /// <param name='expand'>
            /// The child resources to include in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Advisor>> ListByServerAsync(this IServerAdvisorsOperations operations, string resourceGroupName, string serverName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a server advisor.
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
            /// <param name='advisorName'>
            /// The name of the Server Advisor.
            /// </param>
            public static Advisor Get(this IServerAdvisorsOperations operations, string resourceGroupName, string serverName, string advisorName)
            {
                return operations.GetAsync(resourceGroupName, serverName, advisorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a server advisor.
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
            /// <param name='advisorName'>
            /// The name of the Server Advisor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Advisor> GetAsync(this IServerAdvisorsOperations operations, string resourceGroupName, string serverName, string advisorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, advisorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a server advisor.
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
            /// <param name='advisorName'>
            /// The name of the Server Advisor.
            /// </param>
            /// <param name='parameters'>
            /// The requested advisor resource state.
            /// </param>
            public static Advisor Update(this IServerAdvisorsOperations operations, string resourceGroupName, string serverName, string advisorName, Advisor parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serverName, advisorName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a server advisor.
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
            /// <param name='advisorName'>
            /// The name of the Server Advisor.
            /// </param>
            /// <param name='parameters'>
            /// The requested advisor resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Advisor> UpdateAsync(this IServerAdvisorsOperations operations, string resourceGroupName, string serverName, string advisorName, Advisor parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, advisorName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
