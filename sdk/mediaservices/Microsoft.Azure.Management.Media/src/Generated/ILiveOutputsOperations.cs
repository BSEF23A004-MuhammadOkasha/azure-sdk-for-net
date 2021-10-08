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
    /// LiveOutputsOperations operations.
    /// </summary>
    public partial interface ILiveOutputsOperations
    {
        /// <summary>
        /// List Live Outputs
        /// </summary>
        /// <remarks>
        /// Lists the live outputs of a live event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the live event, maximum length is 32.
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
        Task<AzureOperationResponse<IPage<LiveOutput>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Live Output
        /// </summary>
        /// <remarks>
        /// Gets a live output.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the live event, maximum length is 32.
        /// </param>
        /// <param name='liveOutputName'>
        /// The name of the live output.
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
        Task<AzureOperationResponse<LiveOutput>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, string liveOutputName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create Live Output
        /// </summary>
        /// <remarks>
        /// Creates a new live output.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the live event, maximum length is 32.
        /// </param>
        /// <param name='liveOutputName'>
        /// The name of the live output.
        /// </param>
        /// <param name='parameters'>
        /// Live Output properties needed for creation.
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
        Task<AzureOperationResponse<LiveOutput>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, string liveOutputName, LiveOutput parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Live Output
        /// </summary>
        /// <remarks>
        /// Deletes a live output. Deleting a live output does not delete the
        /// asset the live output is writing to.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the live event, maximum length is 32.
        /// </param>
        /// <param name='liveOutputName'>
        /// The name of the live output.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, string liveOutputName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create Live Output
        /// </summary>
        /// <remarks>
        /// Creates a new live output.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the live event, maximum length is 32.
        /// </param>
        /// <param name='liveOutputName'>
        /// The name of the live output.
        /// </param>
        /// <param name='parameters'>
        /// Live Output properties needed for creation.
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
        Task<AzureOperationResponse<LiveOutput>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, string liveOutputName, LiveOutput parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Live Output
        /// </summary>
        /// <remarks>
        /// Deletes a live output. Deleting a live output does not delete the
        /// asset the live output is writing to.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the live event, maximum length is 32.
        /// </param>
        /// <param name='liveOutputName'>
        /// The name of the live output.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, string liveOutputName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Live Outputs
        /// </summary>
        /// <remarks>
        /// Lists the live outputs of a live event.
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
        Task<AzureOperationResponse<IPage<LiveOutput>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
