// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PublishedBlueprintsOperations.
    /// </summary>
    public static partial class PublishedBlueprintsOperationsExtensions
    {
            /// <summary>
            /// Publish a new version of the Blueprint with the latest artifacts. Published
            /// Blueprints are immutable.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            public static PublishedBlueprint Create(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName, string versionId)
            {
                return operations.CreateAsync(managementGroupName, blueprintName, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Publish a new version of the Blueprint with the latest artifacts. Published
            /// Blueprints are immutable.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublishedBlueprint> CreateAsync(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(managementGroupName, blueprintName, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            public static PublishedBlueprint Get(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName, string versionId)
            {
                return operations.GetAsync(managementGroupName, blueprintName, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublishedBlueprint> GetAsync(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(managementGroupName, blueprintName, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            public static PublishedBlueprint Delete(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName, string versionId)
            {
                return operations.DeleteAsync(managementGroupName, blueprintName, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublishedBlueprint> DeleteAsync(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(managementGroupName, blueprintName, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List published versions of given Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            public static IPage<PublishedBlueprint> List(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName)
            {
                return operations.ListAsync(managementGroupName, blueprintName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List published versions of given Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// ManagementGroup where blueprint stores.
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PublishedBlueprint>> ListAsync(this IPublishedBlueprintsOperations operations, string managementGroupName, string blueprintName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(managementGroupName, blueprintName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List published versions of given Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PublishedBlueprint> ListNext(this IPublishedBlueprintsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List published versions of given Blueprint.
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
            public static async Task<IPage<PublishedBlueprint>> ListNextAsync(this IPublishedBlueprintsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
