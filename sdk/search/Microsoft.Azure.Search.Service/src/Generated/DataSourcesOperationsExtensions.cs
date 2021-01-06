// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataSourcesOperations.
    /// </summary>
    public static partial class DataSourcesOperationsExtensions
    {
        /// <summary>
        /// Creates a new datasource or updates a datasource if it already exists.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Update-Data-Source">
        /// Update Data Source</see>.
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
        /// <param name='accessCondition'>
        /// Additional parameters for the operation
        /// </param>
        public static DataSource CreateOrUpdate(this IDataSourcesOperations operations, string dataSourceName, DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
        {
            return operations.CreateOrUpdateAsync(dataSourceName, dataSource, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a new datasource or updates a datasource if it already exists.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Update-Data-Source">
        /// Update Data Source</see>.
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
        /// <param name='accessCondition'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<DataSource> CreateOrUpdateAsync(this IDataSourcesOperations operations, string dataSourceName, DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(dataSourceName, dataSource, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a datasource.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Data-Source" />
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
        /// <param name='accessCondition'>
        /// Additional parameters for the operation
        /// </param>
        public static void Delete(this IDataSourcesOperations operations, string dataSourceName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
            {
                operations.DeleteAsync(dataSourceName, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a datasource.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Data-Source" />
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
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDataSourcesOperations operations, string dataSourceName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(dataSourceName, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves a datasource definition.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Data-Source" />
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
                return operations.GetAsync(dataSourceName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a datasource definition.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Data-Source" />
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
            public static async Task<DataSource> GetAsync(this IDataSourcesOperations operations, string dataSourceName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(dataSourceName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all datasources available for a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Data-Sources" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static DataSourceListResult List(this IDataSourcesOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.ListAsync(searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all datasources available for a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Data-Sources" />
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
            public static async Task<DataSourceListResult> ListAsync(this IDataSourcesOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new datasource.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Data-Source" />
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
                return operations.CreateAsync(dataSource, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new datasource.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Data-Source" />
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
            public static async Task<DataSource> CreateAsync(this IDataSourcesOperations operations, DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(dataSource, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
