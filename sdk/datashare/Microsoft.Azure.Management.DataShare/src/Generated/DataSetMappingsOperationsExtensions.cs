// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataSetMappingsOperations.
    /// </summary>
    public static partial class DataSetMappingsOperationsExtensions
    {
            /// <summary>
            /// Get DataSetMapping in a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Get a DataSetMapping in a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the shareSubscription.
            /// </param>
            /// <param name='dataSetMappingName'>
            /// The name of the dataSetMapping.
            /// </param>
            public static DataSetMapping Get(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName)
            {
                return operations.GetAsync(resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get DataSetMapping in a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Get a DataSetMapping in a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the shareSubscription.
            /// </param>
            /// <param name='dataSetMappingName'>
            /// The name of the dataSetMapping.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSetMapping> GetAsync(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Maps a source data set in the source share to a sink data set in the share
            /// subscription.
            /// Enables copying the data set from source to destination.
            /// </summary>
            /// <remarks>
            /// Create a DataSetMapping
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the share subscription which will hold the data set sink.
            /// </param>
            /// <param name='dataSetMappingName'>
            /// The name of the data set mapping to be created.
            /// </param>
            /// <param name='dataSetMapping'>
            /// Destination data set configuration details.
            /// </param>
            public static DataSetMapping Create(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, DataSetMapping dataSetMapping)
            {
                return operations.CreateAsync(resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName, dataSetMapping).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Maps a source data set in the source share to a sink data set in the share
            /// subscription.
            /// Enables copying the data set from source to destination.
            /// </summary>
            /// <remarks>
            /// Create a DataSetMapping
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the share subscription which will hold the data set sink.
            /// </param>
            /// <param name='dataSetMappingName'>
            /// The name of the data set mapping to be created.
            /// </param>
            /// <param name='dataSetMapping'>
            /// Destination data set configuration details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSetMapping> CreateAsync(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, DataSetMapping dataSetMapping, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName, dataSetMapping, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete DataSetMapping in a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Delete a DataSetMapping in a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the shareSubscription.
            /// </param>
            /// <param name='dataSetMappingName'>
            /// The name of the dataSetMapping.
            /// </param>
            public static void Delete(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete DataSetMapping in a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Delete a DataSetMapping in a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the shareSubscription.
            /// </param>
            /// <param name='dataSetMappingName'>
            /// The name of the dataSetMapping.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List DataSetMappings in a share subscription.
            /// </summary>
            /// <remarks>
            /// List DataSetMappings in a share subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the share subscription.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            public static IPage<DataSetMapping> ListByShareSubscription(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = default(string))
            {
                return operations.ListByShareSubscriptionAsync(resourceGroupName, accountName, shareSubscriptionName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List DataSetMappings in a share subscription.
            /// </summary>
            /// <remarks>
            /// List DataSetMappings in a share subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the share subscription.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataSetMapping>> ListByShareSubscriptionAsync(this IDataSetMappingsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareSubscriptionWithHttpMessagesAsync(resourceGroupName, accountName, shareSubscriptionName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List DataSetMappings in a share subscription.
            /// </summary>
            /// <remarks>
            /// List DataSetMappings in a share subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataSetMapping> ListByShareSubscriptionNext(this IDataSetMappingsOperations operations, string nextPageLink)
            {
                return operations.ListByShareSubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List DataSetMappings in a share subscription.
            /// </summary>
            /// <remarks>
            /// List DataSetMappings in a share subscription
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
            public static async Task<IPage<DataSetMapping>> ListByShareSubscriptionNextAsync(this IDataSetMappingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
