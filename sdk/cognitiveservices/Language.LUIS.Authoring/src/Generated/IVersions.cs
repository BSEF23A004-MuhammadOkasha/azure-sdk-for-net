// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Versions operations.
    /// </summary>
    public partial interface IVersions
    {
        /// <summary>
        /// Creates a new version from the selected version.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='versionCloneObject'>
        /// A model containing the new version ID.
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
        Task<HttpOperationResponse<string>> CloneWithHttpMessagesAsync(System.Guid appId, string versionId, TaskUpdateObject versionCloneObject, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of versions for this application ID.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='skip'>
        /// The number of entries to skip. Default value is 0.
        /// </param>
        /// <param name='take'>
        /// The number of entries to return. Maximum page size is 500. Default
        /// is 100.
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
        Task<HttpOperationResponse<IList<VersionInfo>>> ListWithHttpMessagesAsync(System.Guid appId, int? skip = 0, int? take = 100, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the version information such as date created, last modified
        /// date, endpoint URL, count of intents and entities, training and
        /// publishing status.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
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
        Task<HttpOperationResponse<VersionInfo>> GetWithHttpMessagesAsync(System.Guid appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the name or description of the application version.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='versionUpdateObject'>
        /// A model containing Name and Description of the application.
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
        Task<HttpOperationResponse<OperationStatus>> UpdateWithHttpMessagesAsync(System.Guid appId, string versionId, TaskUpdateObject versionUpdateObject, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an application version.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
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
        Task<HttpOperationResponse<OperationStatus>> DeleteWithHttpMessagesAsync(System.Guid appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports a LUIS application to JSON format.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
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
        Task<HttpOperationResponse<LuisApp>> ExportWithHttpMessagesAsync(System.Guid appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Imports a new version into a LUIS application.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='luisApp'>
        /// A LUIS application structure.
        /// </param>
        /// <param name='versionId'>
        /// The new versionId to import. If not specified, the versionId will
        /// be read from the imported object.
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
        Task<HttpOperationResponse<string>> ImportWithHttpMessagesAsync(System.Guid appId, LuisApp luisApp, string versionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deleted an unlabelled utterance in a version of the application.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='utterance'>
        /// The utterance text to delete.
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
        Task<HttpOperationResponse<OperationStatus>> DeleteUnlabelledUtteranceWithHttpMessagesAsync(System.Guid appId, string versionId, string utterance, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Imports a new version into a LUIS application.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='luisAppV2'>
        /// A LUIS application structure.
        /// </param>
        /// <param name='versionId'>
        /// The new versionId to import. If not specified, the versionId will
        /// be read from the imported object.
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
        Task<HttpOperationResponse<string>> ImportV2AppWithHttpMessagesAsync(System.Guid appId, LuisAppV2 luisAppV2, string versionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Imports a new version into a LUIS application.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='luisAppLu'>
        /// An LU representing the LUIS application structure.
        /// </param>
        /// <param name='versionId'>
        /// The new versionId to import. If not specified, the versionId will
        /// be read from the imported object.
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
        Task<HttpOperationResponse<string>> ImportLuFormatWithHttpMessagesAsync(System.Guid appId, string luisAppLu, string versionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports a LUIS application to text format.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='format'>
        /// Lu format extension. Possible values include: 'lu'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<string>> ExportLuFormatWithHttpMessagesAsync(System.Guid appId, string versionId, string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
