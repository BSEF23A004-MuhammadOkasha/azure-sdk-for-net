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
    /// Extension methods for ArtifactsOperations.
    /// </summary>
    public static partial class ArtifactsOperationsExtensions
    {
            /// <summary>
            /// List artifacts in a given artifact source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Artifact> List(this IArtifactsOperations operations, string resourceGroupName, string labName, string artifactSourceName, ODataQuery<Artifact> odataQuery = default(ODataQuery<Artifact>))
            {
                return operations.ListAsync(resourceGroupName, labName, artifactSourceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List artifacts in a given artifact source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Artifact>> ListAsync(this IArtifactsOperations operations, string resourceGroupName, string labName, string artifactSourceName, ODataQuery<Artifact> odataQuery = default(ODataQuery<Artifact>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, artifactSourceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='name'>
            /// The name of the artifact.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=title)'
            /// </param>
            public static Artifact Get(this IArtifactsOperations operations, string resourceGroupName, string labName, string artifactSourceName, string name, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, labName, artifactSourceName, name, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='name'>
            /// The name of the artifact.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=title)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Artifact> GetAsync(this IArtifactsOperations operations, string resourceGroupName, string labName, string artifactSourceName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, artifactSourceName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates an ARM template for the given artifact, uploads the required
            /// files to a storage account, and validates the generated artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='name'>
            /// The name of the artifact.
            /// </param>
            /// <param name='generateArmTemplateRequest'>
            /// Parameters for generating an ARM template for deploying artifacts.
            /// </param>
            public static ArmTemplateInfo GenerateArmTemplate(this IArtifactsOperations operations, string resourceGroupName, string labName, string artifactSourceName, string name, GenerateArmTemplateRequest generateArmTemplateRequest)
            {
                return operations.GenerateArmTemplateAsync(resourceGroupName, labName, artifactSourceName, name, generateArmTemplateRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates an ARM template for the given artifact, uploads the required
            /// files to a storage account, and validates the generated artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='artifactSourceName'>
            /// The name of the artifact source.
            /// </param>
            /// <param name='name'>
            /// The name of the artifact.
            /// </param>
            /// <param name='generateArmTemplateRequest'>
            /// Parameters for generating an ARM template for deploying artifacts.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArmTemplateInfo> GenerateArmTemplateAsync(this IArtifactsOperations operations, string resourceGroupName, string labName, string artifactSourceName, string name, GenerateArmTemplateRequest generateArmTemplateRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateArmTemplateWithHttpMessagesAsync(resourceGroupName, labName, artifactSourceName, name, generateArmTemplateRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List artifacts in a given artifact source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Artifact> ListNext(this IArtifactsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List artifacts in a given artifact source.
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
            public static async Task<IPage<Artifact>> ListNextAsync(this IArtifactsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
