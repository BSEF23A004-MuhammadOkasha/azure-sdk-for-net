// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PlatformImagesOperations operations.
    /// </summary>
    public partial interface IPlatformImagesOperations
    {
        /// <summary>
        /// Returns all platform images.
        /// </summary>
        /// <remarks>
        /// Returns a list of all platform images.
        /// </remarks>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<PlatformImage>>> ListWithHttpMessagesAsync(string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the requested platform image.
        /// </summary>
        /// <remarks>
        /// Returns the specific platform image matching publisher, offer, skus
        /// and version.
        /// </remarks>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='publisher'>
        /// Name of the publisher.
        /// </param>
        /// <param name='offer'>
        /// Name of the offer.
        /// </param>
        /// <param name='sku'>
        /// Name of the SKU.
        /// </param>
        /// <param name='version'>
        /// The version of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlatformImage>> GetWithHttpMessagesAsync(string location, string publisher, string offer, string sku, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a platform image.
        /// </summary>
        /// <remarks>
        /// Creates a new platform image with given publisher, offer, skus and
        /// version.
        /// </remarks>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='publisher'>
        /// Name of the publisher.
        /// </param>
        /// <param name='offer'>
        /// Name of the offer.
        /// </param>
        /// <param name='sku'>
        /// Name of the SKU.
        /// </param>
        /// <param name='version'>
        /// The version of the resource.
        /// </param>
        /// <param name='newImage'>
        /// New platform image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlatformImage>> CreateWithHttpMessagesAsync(string location, string publisher, string offer, string sku, string version, PlatformImageParameters newImage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a platform image matching publisher, offer, skus and
        /// version
        /// </summary>
        /// <remarks>
        /// Delete a platform image
        /// </remarks>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='publisher'>
        /// Name of the publisher.
        /// </param>
        /// <param name='offer'>
        /// Name of the offer.
        /// </param>
        /// <param name='sku'>
        /// Name of the SKU.
        /// </param>
        /// <param name='version'>
        /// The version of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string location, string publisher, string offer, string sku, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a platform image.
        /// </summary>
        /// <remarks>
        /// Creates a new platform image with given publisher, offer, skus and
        /// version.
        /// </remarks>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='publisher'>
        /// Name of the publisher.
        /// </param>
        /// <param name='offer'>
        /// Name of the offer.
        /// </param>
        /// <param name='sku'>
        /// Name of the SKU.
        /// </param>
        /// <param name='version'>
        /// The version of the resource.
        /// </param>
        /// <param name='newImage'>
        /// New platform image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlatformImage>> BeginCreateWithHttpMessagesAsync(string location, string publisher, string offer, string sku, string version, PlatformImageParameters newImage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
