// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Conversion operations.
    /// </summary>
    public partial interface IConversion
    {
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// Creator makes it possible to develop applications based on your
        /// private indoor map data using Azure Maps API and SDK.
        /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
        /// article introduces concepts and tools that apply to Azure Maps
        /// Creator.
        ///
        /// The Conversion API lets the caller import a set of DWG design files
        /// as a zipped [Drawing Package](https://aka.ms/am-drawing-package)
        /// into Azure Maps. The [Drawing
        /// Package](https://aka.ms/am-drawing-package) should first be
        /// uploaded using the [Azure Maps Data
        /// Service](https://docs.microsoft.com/rest/api/maps/data). Once
        /// uploaded, use the `udid` returned by the [Data Upload
        /// API](https://docs.microsoft.com/rest/api/maps/data/uploadpreview)
        /// to call this Conversion API.
        ///
        /// ## Convert DWG package
        ///
        /// The Conversion API performs a [long-running
        /// request](https://aka.ms/am-creator-lrt-v2).
        ///
        /// ## Debug DWG package issues
        ///
        ///
        /// During the Conversion process, if there are any issues with the DWG
        /// package [errors and warnings](https://aka.ms/am-conversion-errors)
        /// are provided in the response along with a *diagnostic package* to
        /// visualize and diagnose these issues. In case any issues are
        /// encountered with your DWG package, the Conversion operation status
        /// process as detailed [here](https://aka.ms/am-creator-lrt-v2)
        /// returns the location of the *diagnostic package* that can be
        /// downloaded by the caller to help them visualize and diagnose these
        /// issues. The *diagnostic package* location can be found in the
        /// properties section of the conversion operation status response and
        /// looks like the following:
        ///
        /// ```json
        /// {
        /// "properties": {
        /// "diagnosticPackageLocation":
        /// "https://us.atlas.microsoft.com/mapdata/{DiagnosticPackageId}?api-version=1.0"
        /// }
        /// }
        /// ```
        ///
        /// The *diagnostic package* can be downloaded by executing a `HTTP
        /// GET` request on the `diagnosticPackageLocation`.
        /// For more details on how to use the tool to visualize and diagnose
        /// all the errors and warnings see [Drawing Error
        /// Visualizer](https://aka.ms/am-drawing-errors-visualizer).
        /// &lt;br&gt;
        ///
        /// A conversion operation will be marked as *success* if there are
        /// zero or more warnings but will be marked as *failed* if any errors
        /// are encountered.
        /// </summary>
        /// <param name='udid'>
        /// The unique data id for the content. The `udid` must have been
        /// obtained from a successful [Data Upload
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/data%20v2/uploadpreview)
        /// call.
        /// </param>
        /// <param name='outputOntology'>
        /// Output ontology version. "facility-2.0" is the only supported value
        /// at this time. Please refer to this
        /// [article](https://docs.microsoft.com/en-us/azure/azure-maps/creator-facility-ontology)
        /// for more information about Azure Maps Creator ontologies.
        /// </param>
        /// <param name='description'>
        /// User provided description of the content being converted.
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
        Task<HttpOperationResponse<LongRunningOperationResult,ConversionConvertHeaders>> ConvertWithHttpMessagesAsync(string udid, string outputOntology, string description = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// Creator makes it possible to develop applications based on your
        /// private indoor map data using Azure Maps API and SDK.
        /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
        /// article introduces concepts and tools that apply to Azure Maps
        /// Creator.
        ///
        /// This API allows the caller to fetch a list of all successful data
        /// conversions submitted previously using the [Conversion
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/conversion/convertpreview).
        ///
        /// ### Submit List Request
        ///
        /// To list all successful conversions you will issue a `GET` request
        /// with no additional parameters.
        ///
        /// ### List Data Response
        ///
        /// The Conversion List API returns the complete list of all conversion
        /// details in `json` format.&lt;br&gt;
        ///
        /// Here is a sample response returning the details of two successful
        /// conversion requests:
        ///
        /// &lt;br&gt;
        ///
        /// ```json
        /// {
        /// "conversions":
        /// [
        /// {
        /// "conversionId": "54398242-ea6c-1f31-4fa6-79b1ae0fc24d",
        /// "udid": "31838736-8b84-11ea-bc55-0242ac130003",
        /// "created": "5/19/2020 9:00:00 AM +00:00",
        /// "description": "User provided description.",
        /// "featureCounts": {
        /// "DIR": 1,
        /// "LVL": 3,
        /// "FCL": 1,
        /// "UNIT": 150,
        /// "CTG": 8,
        /// "AEL": 0,
        /// "OPN": 10
        /// }
        /// },
        /// {
        /// "conversionId": "2acf7d32-8b84-11ea-bc55-0242ac130003",
        /// "udid": "1214bc58-8b84-11ea-bc55-0242ac1300039",
        /// "created": "5/19/2020 9:00:00 AM +00:00",
        /// "description": "User provided description.",
        /// "featureCounts": {
        /// "DIR": 1,
        /// "LVL": 3,
        /// "FCL": 1,
        /// "UNIT": 150,
        /// "CTG": 8,
        /// "AEL": 0,
        /// "OPN": 10
        /// }
        /// }
        /// ]
        /// }
        /// ```
        ///
        /// &lt;br&gt;
        /// </summary>
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
        Task<HttpOperationResponse<ConversionListResponse>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// Creator makes it possible to develop applications based on your
        /// private indoor map data using Azure Maps API and SDK.
        /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
        /// article introduces concepts and tools that apply to Azure Maps
        /// Creator.
        ///
        /// This API allows the caller to fetch a successful data conversion
        /// submitted previously using the [Conversion
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/conversion/convertpreview).
        /// </summary>
        /// <param name='conversionId'>
        /// The conversion id for the content. The `conversionId` must have
        /// been obtained from a successful [Conversion
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/v2/conversion/convert)
        /// call.
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
        Task<HttpOperationResponse<ConversionListDetailInfo>> GetWithHttpMessagesAsync(string conversionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// **Applies to:** see pricing
        /// [tiers](https://aka.ms/AzureMapsPricingTier).
        ///
        /// Creator makes it possible to develop applications based on your
        /// private indoor map data using Azure Maps API and SDK.
        /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
        /// article introduces concepts and tools that apply to Azure Maps
        /// Creator.
        ///
        /// This API allows the caller to delete any data conversions created
        /// previously using the [Conversion
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/conversion/convertpreview).
        ///
        /// ### Submit Delete Request
        ///
        /// To delete your conversion data you will issue a `DELETE` request
        /// where the path will contain the `conversionId` of the data to
        /// delete.
        ///
        /// ### Conversion Delete Response
        ///
        /// The Conversion Delete API returns a HTTP `204 No Content` response
        /// with an empty body, if the converted data resources were deleted
        /// successfully.&lt;br&gt;
        /// A HTTP `400 Bad Request` error response will be returned if no
        /// resource associated with the passed-in `conversionId` is found.
        /// </summary>
        /// <param name='conversionId'>
        /// The conversion id for the content. The `conversionId` must have
        /// been obtained from a successful [Conversion
        /// API](https://docs.microsoft.com/en-us/rest/api/maps/v2/conversion/convert)
        /// call.
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
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string conversionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This path will be obtained from a call to POST /conversions.  While
        /// in progress, an http200 will be returned with no extra headers -
        /// followed by an http200 with Resource-Location header once
        /// successfully completed.
        /// </summary>
        /// <param name='operationId'>
        /// The ID to query the status for the dataset create/import request.
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
        Task<HttpOperationResponse<LongRunningOperationResult,ConversionGetOperationHeaders>> GetOperationWithHttpMessagesAsync(string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
