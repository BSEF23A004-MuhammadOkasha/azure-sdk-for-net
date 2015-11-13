// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class DataSourcesOperationsExtensions
    {
            /// <summary>
            /// Creates a new Azure Search datasource or updates a datasource if it
            /// already exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource to create or update.
            /// </param>
            /// <param name='dataSource'>
            /// The definition of the datasource to create or update.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static DataSource CreateOrUpdate(this IDataSourcesOperations operations, string dataSourceName, DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return Task.Factory.StartNew(s => ((IDataSourcesOperations)s).CreateOrUpdateAsync(dataSourceName, dataSource, searchRequestOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure Search datasource or updates a datasource if it
            /// already exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource to create or update.
            /// </param>
            /// <param name='dataSource'>
            /// The definition of the datasource to create or update.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSource> CreateOrUpdateAsync( this IDataSourcesOperations operations, string dataSourceName, DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<DataSource> result = await operations.CreateOrUpdateWithHttpMessagesAsync(dataSourceName, dataSource, searchRequestOptions, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes an Azure Search datasource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this IDataSourcesOperations operations, string dataSourceName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                Task.Factory.StartNew(s => ((IDataSourcesOperations)s).DeleteAsync(dataSourceName, searchRequestOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Azure Search datasource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IDataSourcesOperations operations, string dataSourceName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(dataSourceName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Retrieves a datasource definition from Azure Search.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static DataSource Get(this IDataSourcesOperations operations, string dataSourceName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return Task.Factory.StartNew(s => ((IDataSourcesOperations)s).GetAsync(dataSourceName, searchRequestOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a datasource definition from Azure Search.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSource> GetAsync( this IDataSourcesOperations operations, string dataSourceName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<DataSource> result = await operations.GetWithHttpMessagesAsync(dataSourceName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists all datasources available for an Azure Search service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static DataSourceListResult List(this IDataSourcesOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return Task.Factory.StartNew(s => ((IDataSourcesOperations)s).ListAsync(searchRequestOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all datasources available for an Azure Search service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSourceListResult> ListAsync( this IDataSourcesOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<DataSourceListResult> result = await operations.ListWithHttpMessagesAsync(searchRequestOptions, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Creates a new Azure Search datasource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSource'>
            /// The definition of the datasource to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static DataSource Create(this IDataSourcesOperations operations, DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return Task.Factory.StartNew(s => ((IDataSourcesOperations)s).CreateAsync(dataSource, searchRequestOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure Search datasource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataSource'>
            /// The definition of the datasource to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSource> CreateAsync( this IDataSourcesOperations operations, DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<DataSource> result = await operations.CreateWithHttpMessagesAsync(dataSource, searchRequestOptions, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
