// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ScriptActionsOperations.
    /// </summary>
    public static partial class ScriptActionsOperationsExtensions
    {
            /// <summary>
            /// Deletes a specified persisted script action of the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the script.
            /// </param>
            public static void Delete(this IScriptActionsOperations operations, string resourceGroupName, string clusterName, string scriptName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a specified persisted script action of the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IScriptActionsOperations operations, string resourceGroupName, string clusterName, string scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, scriptName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the persisted script actions for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            public static IPage<RuntimeScriptActionDetail> ListPersistedScripts(this IScriptActionsOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListPersistedScriptsAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the persisted script actions for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RuntimeScriptActionDetail>> ListPersistedScriptsAsync(this IScriptActionsOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPersistedScriptsWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the script execution detail for the given script execution ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution Id
            /// </param>
            public static RuntimeScriptActionDetail GetExecutionDetail(this IScriptActionsOperations operations, string resourceGroupName, string clusterName, string scriptExecutionId)
            {
                return operations.GetExecutionDetailAsync(resourceGroupName, clusterName, scriptExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the script execution detail for the given script execution ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RuntimeScriptActionDetail> GetExecutionDetailAsync(this IScriptActionsOperations operations, string resourceGroupName, string clusterName, string scriptExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetExecutionDetailWithHttpMessagesAsync(resourceGroupName, clusterName, scriptExecutionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the persisted script actions for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RuntimeScriptActionDetail> ListPersistedScriptsNext(this IScriptActionsOperations operations, string nextPageLink)
            {
                return operations.ListPersistedScriptsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the persisted script actions for the specified cluster.
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
            public static async Task<IPage<RuntimeScriptActionDetail>> ListPersistedScriptsNextAsync(this IScriptActionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPersistedScriptsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
