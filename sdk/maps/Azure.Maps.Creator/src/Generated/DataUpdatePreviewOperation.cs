// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Maps.Creator.Models;

namespace Azure.Maps.Creator
{
    /// <summary>
    /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
    /// 
    /// The Data Update API allows the caller to update a previously uploaded data content.
    /// 
    /// You can use this API in a scenario like adding or removing geofences to or from an existing collection of geofences.
    /// Geofences are uploaded using the [Data Upload API](https://docs.microsoft.com/rest/api/maps/data%20v2/uploadpreview), for
    /// use in the [Azure Maps Geofencing Service](https://docs.microsoft.com/rest/api/maps/spatial).
    /// 
    /// Please note that the Update API will *replace* and *override* the existing data content.
    /// 
    /// ## Submit Update Request
    /// 
    /// To update your content you will use a `PUT` request. The request body will contain the new data that will replace
    /// the existing data. The `Content-Type` header will be set to the content type of the data, and the path will contain
    /// the `udid` of the data to be update.
    /// 
    /// For example, to update a collection of geofences that were previously uploaded using the Upload API, place the new
    /// geofence content in the request body. Set the `udid` parameter in the path to the `udid` of the data received
    /// previously in the upload API response. And set the `Content-Type` header to one of the following media types:
    /// 
    /// - `application/json`
    /// - `application/vnd.geo+json`
    /// - `application/octet-stream`
    /// 
    /// Here&apos;s a sample request body for updating a simple Geofence. It&apos;s represented as a circle geometry using a center
    /// point and a radius. The sample below is in `GeoJSON`:
    /// 
    /// ```json
    /// {
    ///     &quot;type&quot;: &quot;FeatureCollection&quot;,
    ///     &quot;features&quot;: [{
    ///         &quot;type&quot;: &quot;Feature&quot;,
    ///         &quot;geometry&quot;: {
    ///             &quot;type&quot;: &quot;Point&quot;,
    ///             &quot;coordinates&quot;: [-122.126986, 47.639754]
    ///         },
    ///         &quot;properties&quot;: {
    ///             &quot;geometryId&quot;: &quot;001&quot;,
    ///             &quot;radius&quot;: 500
    ///         }
    ///     }]
    /// }
    /// ```
    /// 
    /// The previously uploaded geofence had a radius of 100m. The above request will update it to 500m.
    /// 
    /// The Data Update API performs a
    /// [long-running request](https://aka.ms/am-creator-lrt-v2).
    /// 
    /// ## Data Update Limits
    /// 
    /// Please, be aware that currently every Azure Maps account has a [data storage limit](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/azure-subscription-service-limits#azure-maps-limits).
    /// Once the storage limit is reached, all the new upload API calls will return a `409 Conflict` http error response.
    /// You can always use the [Data Delete API](https://docs.microsoft.com/rest/api/maps/data%20v2/deletepreview) to
    /// delete old/unused content and create space for new uploads.
    /// </summary>
    public partial class DataUpdatePreviewOperation : Operation<LongRunningOperationResult>, IOperationSource<LongRunningOperationResult>
    {
        private readonly OperationInternals<LongRunningOperationResult> _operation;

        /// <summary> Initializes a new instance of DataUpdatePreviewOperation for mocking. </summary>
        protected DataUpdatePreviewOperation()
        {
        }

        internal DataUpdatePreviewOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<LongRunningOperationResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DataUpdatePreviewOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LongRunningOperationResult Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LongRunningOperationResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LongRunningOperationResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        LongRunningOperationResult IOperationSource<LongRunningOperationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return LongRunningOperationResult.DeserializeLongRunningOperationResult(document.RootElement);
        }

        async ValueTask<LongRunningOperationResult> IOperationSource<LongRunningOperationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return LongRunningOperationResult.DeserializeLongRunningOperationResult(document.RootElement);
        }
    }
}
