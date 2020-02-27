// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolOperationResults.
    /// </summary>
    public static partial class SqlPoolOperationResultsExtensions
    {
            /// <summary>
            /// Get SQL pool operation status
            /// </summary>
            /// <remarks>
            /// Get the status of a SQL pool operation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='operationId'>
            /// Operation ID
            /// </param>
            public static object GetLocationHeaderResult(this ISqlPoolOperationResults operations, string resourceGroupName, string workspaceName, string sqlPoolName, string operationId)
            {
                return operations.GetLocationHeaderResultAsync(resourceGroupName, workspaceName, sqlPoolName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get SQL pool operation status
            /// </summary>
            /// <remarks>
            /// Get the status of a SQL pool operation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='operationId'>
            /// Operation ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetLocationHeaderResultAsync(this ISqlPoolOperationResults operations, string resourceGroupName, string workspaceName, string sqlPoolName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLocationHeaderResultWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
