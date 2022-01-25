// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceRunnersOperations.
    /// </summary>
    public static partial class ServiceRunnersOperationsExtensions
    {
            /// <summary>
            /// List service runners in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ServiceRunner> List(this IServiceRunnersOperations operations, string resourceGroupName, string labName, ODataQuery<ServiceRunner> odataQuery = default(ODataQuery<ServiceRunner>))
            {
                return operations.ListAsync(resourceGroupName, labName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List service runners in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceRunner>> ListAsync(this IServiceRunnersOperations operations, string resourceGroupName, string labName, ODataQuery<ServiceRunner> odataQuery = default(ODataQuery<ServiceRunner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get service runner.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            public static ServiceRunner Get(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name)
            {
                return operations.GetAsync(resourceGroupName, labName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get service runner.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceRunner> GetAsync(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Service runner. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            /// <param name='serviceRunner'>
            /// A container for a managed identity to execute DevTest lab services.
            /// </param>
            public static ServiceRunner CreateOrUpdate(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name, ServiceRunner serviceRunner)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, labName, name, serviceRunner).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Service runner. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            /// <param name='serviceRunner'>
            /// A container for a managed identity to execute DevTest lab services.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceRunner> CreateOrUpdateAsync(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name, ServiceRunner serviceRunner, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, name, serviceRunner, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete service runner. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            public static void Delete(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name)
            {
                operations.DeleteAsync(resourceGroupName, labName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete service runner. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or replace an existing Service runner. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            /// <param name='serviceRunner'>
            /// A container for a managed identity to execute DevTest lab services.
            /// </param>
            public static ServiceRunner BeginCreateOrUpdate(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name, ServiceRunner serviceRunner)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, labName, name, serviceRunner).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Service runner. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            /// <param name='serviceRunner'>
            /// A container for a managed identity to execute DevTest lab services.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceRunner> BeginCreateOrUpdateAsync(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name, ServiceRunner serviceRunner, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, name, serviceRunner, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete service runner. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            public static void BeginDelete(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name)
            {
                operations.BeginDeleteAsync(resourceGroupName, labName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete service runner. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the service runner.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServiceRunnersOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List service runners in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceRunner> ListNext(this IServiceRunnersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List service runners in a given lab.
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
            public static async Task<IPage<ServiceRunner>> ListNextAsync(this IServiceRunnersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
