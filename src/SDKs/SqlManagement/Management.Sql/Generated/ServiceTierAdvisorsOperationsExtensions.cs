// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceTierAdvisorsOperations.
    /// </summary>
    public static partial class ServiceTierAdvisorsOperationsExtensions
    {
            /// <summary>
            /// Gets a service tier advisor.
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
            /// <param name='databaseName'>
            /// The name of database.
            /// </param>
            /// <param name='serviceTierAdvisorName'>
            /// The name of service tier advisor.
            /// </param>
            public static ServiceTierAdvisor Get(this IServiceTierAdvisorsOperations operations, string resourceGroupName, string serverName, string databaseName, string serviceTierAdvisorName)
            {
                return operations.GetAsync(resourceGroupName, serverName, databaseName, serviceTierAdvisorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a service tier advisor.
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
            /// <param name='databaseName'>
            /// The name of database.
            /// </param>
            /// <param name='serviceTierAdvisorName'>
            /// The name of service tier advisor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceTierAdvisor> GetAsync(this IServiceTierAdvisorsOperations operations, string resourceGroupName, string serverName, string databaseName, string serviceTierAdvisorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, serviceTierAdvisorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns service tier advisors for specified database.
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
            /// <param name='databaseName'>
            /// The name of database.
            /// </param>
            public static IEnumerable<ServiceTierAdvisor> ListByDatabase(this IServiceTierAdvisorsOperations operations, string resourceGroupName, string serverName, string databaseName)
            {
                return operations.ListByDatabaseAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns service tier advisors for specified database.
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
            /// <param name='databaseName'>
            /// The name of database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ServiceTierAdvisor>> ListByDatabaseAsync(this IServiceTierAdvisorsOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
