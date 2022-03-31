// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StreamingEndpointsOperations operations.
    /// </summary>
    public partial interface IStreamingEndpointsOperations
    {
        /// <summary>
        /// List StreamingEndpoints
        /// </summary>
        /// <remarks>
        /// Lists the streaming endpoints in the account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StreamingEndpoint>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Gets a streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingEndpoint>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Creates a streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='parameters'>
        /// Streaming endpoint properties needed for creation.
        /// </param>
        /// <param name='autoStart'>
        /// The flag indicates if the resource should be automatically started
        /// on creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingEndpoint>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, bool? autoStart = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Updates a existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='parameters'>
        /// Streaming endpoint properties needed for creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingEndpoint>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Deletes a streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List StreamingEndpoint skus
        /// </summary>
        /// <remarks>
        /// List streaming endpoint supported skus.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingEndpointSkuInfoListResult>> SkusWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Starts an existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Stops an existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StopWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Scale StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Scales an existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='scaleUnit'>
        /// The scale unit number of the streaming endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ScaleWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, int? scaleUnit = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Creates a streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='parameters'>
        /// Streaming endpoint properties needed for creation.
        /// </param>
        /// <param name='autoStart'>
        /// The flag indicates if the resource should be automatically started
        /// on creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingEndpoint>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, bool? autoStart = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Updates a existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='parameters'>
        /// Streaming endpoint properties needed for creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingEndpoint>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Deletes a streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Starts an existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Stops an existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStopWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Scale StreamingEndpoint
        /// </summary>
        /// <remarks>
        /// Scales an existing streaming endpoint.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingEndpointName'>
        /// The name of the streaming endpoint, maximum length is 24.
        /// </param>
        /// <param name='scaleUnit'>
        /// The scale unit number of the streaming endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginScaleWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, int? scaleUnit = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List StreamingEndpoints
        /// </summary>
        /// <remarks>
        /// Lists the streaming endpoints in the account.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StreamingEndpoint>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
