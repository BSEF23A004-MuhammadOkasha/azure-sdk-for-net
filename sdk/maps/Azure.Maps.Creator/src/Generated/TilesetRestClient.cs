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
    internal partial class TilesetRestClient
    {
        private Geography? geography;
        private string xMsClientId;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of TilesetRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="geography"> This parameter specifies where the Azure Maps Creator resource is located.  Valid values are us and eu. </param>
        /// <param name="xMsClientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following [articles](https://aka.ms/amauthdetails) for guidance. </param>
        public TilesetRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Geography? geography = default, string xMsClientId = null)
        {
            geography ??= Geography.Us;

            this.geography = geography;
            this.xMsClientId = xMsClientId;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateRequest(string datasetId, string description)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(geography.Value, true);
            uri.AppendRaw(".atlas.microsoft.com", false);
            uri.AppendPath("/tilesets", false);
            uri.AppendQuery("api-version", "2.0", true);
            uri.AppendQuery("datasetId", datasetId, true);
            if (description != null)
            {
                uri.AppendQuery("description", description, true);
            }
            request.Uri = uri;
            if (xMsClientId != null)
            {
                request.Headers.Add("x-ms-client-id", xMsClientId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        ///  [This](https://docs.microsoft.com/en-us/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// The Tileset Create API allows the caller to create a tileset from a dataset. A tileset contains a set of tiles that can be consumed
        /// from the [Get Map Tile](/rest/api/maps/render/getmaptile) to retrieve custom tiles. To make a dataset, use the
        /// [DataSet Create API](/rest/api/maps/dataset/createpreview).
        /// 
        /// ## Submit Create Request
        /// 
        /// To create your tileset you will make a `POST` request with an empty body. The `datasetId` query parameter will be
        /// used as the source of the tileset data.
        /// 
        /// The Create Tileset API is a
        /// [long-running request](https://aka.ms/am-creator-lrt-v2).
        /// </summary>
        /// <param name="datasetId"> The unique `datasetId` that the tileset create API uses to retrieve features to generate tiles. The `datasetId` must have been obtained from a successful [Dataset Create API](/en-us/rest/api/maps/dataset/createpreview) call. </param>
        /// <param name="description"> User provided description of the tileset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetId"/> is null. </exception>
        public async Task<ResponseWithHeaders<TilesetCreateHeaders>> CreateAsync(string datasetId, string description = null, CancellationToken cancellationToken = default)
        {
            if (datasetId == null)
            {
                throw new ArgumentNullException(nameof(datasetId));
            }

            using var message = CreateCreateRequest(datasetId, description);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new TilesetCreateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        ///  [This](https://docs.microsoft.com/en-us/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// The Tileset Create API allows the caller to create a tileset from a dataset. A tileset contains a set of tiles that can be consumed
        /// from the [Get Map Tile](/rest/api/maps/render/getmaptile) to retrieve custom tiles. To make a dataset, use the
        /// [DataSet Create API](/rest/api/maps/dataset/createpreview).
        /// 
        /// ## Submit Create Request
        /// 
        /// To create your tileset you will make a `POST` request with an empty body. The `datasetId` query parameter will be
        /// used as the source of the tileset data.
        /// 
        /// The Create Tileset API is a
        /// [long-running request](https://aka.ms/am-creator-lrt-v2).
        /// </summary>
        /// <param name="datasetId"> The unique `datasetId` that the tileset create API uses to retrieve features to generate tiles. The `datasetId` must have been obtained from a successful [Dataset Create API](/en-us/rest/api/maps/dataset/createpreview) call. </param>
        /// <param name="description"> User provided description of the tileset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetId"/> is null. </exception>
        public ResponseWithHeaders<TilesetCreateHeaders> Create(string datasetId, string description = null, CancellationToken cancellationToken = default)
        {
            if (datasetId == null)
            {
                throw new ArgumentNullException(nameof(datasetId));
            }

            using var message = CreateCreateRequest(datasetId, description);
            _pipeline.Send(message, cancellationToken);
            var headers = new TilesetCreateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(geography.Value, true);
            uri.AppendRaw(".atlas.microsoft.com", false);
            uri.AppendPath("/tilesets", false);
            uri.AppendQuery("api-version", "2.0", true);
            request.Uri = uri;
            if (xMsClientId != null)
            {
                request.Headers.Add("x-ms-client-id", xMsClientId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to fetch a list of all tilesets created.
        /// &lt;br&gt;.
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<TilesetListResponse>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TilesetListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TilesetListResponse.DeserializeTilesetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to fetch a list of all tilesets created.
        /// &lt;br&gt;.
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<TilesetListResponse> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TilesetListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TilesetListResponse.DeserializeTilesetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string tilesetId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(geography.Value, true);
            uri.AppendRaw(".atlas.microsoft.com", false);
            uri.AppendPath("/tilesets/", false);
            uri.AppendPath(tilesetId, true);
            uri.AppendQuery("api-version", "2.0", true);
            request.Uri = uri;
            if (xMsClientId != null)
            {
                request.Headers.Add("x-ms-client-id", xMsClientId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to fetch a tileset.
        /// </summary>
        /// <param name="tilesetId"> The Tileset Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tilesetId"/> is null. </exception>
        public async Task<Response<TilesetDetailInfo>> GetAsync(string tilesetId, CancellationToken cancellationToken = default)
        {
            if (tilesetId == null)
            {
                throw new ArgumentNullException(nameof(tilesetId));
            }

            using var message = CreateGetRequest(tilesetId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TilesetDetailInfo value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TilesetDetailInfo.DeserializeTilesetDetailInfo(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to fetch a tileset.
        /// </summary>
        /// <param name="tilesetId"> The Tileset Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tilesetId"/> is null. </exception>
        public Response<TilesetDetailInfo> Get(string tilesetId, CancellationToken cancellationToken = default)
        {
            if (tilesetId == null)
            {
                throw new ArgumentNullException(nameof(tilesetId));
            }

            using var message = CreateGetRequest(tilesetId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TilesetDetailInfo value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TilesetDetailInfo.DeserializeTilesetDetailInfo(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string tilesetId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(geography.Value, true);
            uri.AppendRaw(".atlas.microsoft.com", false);
            uri.AppendPath("/tilesets/", false);
            uri.AppendPath(tilesetId, true);
            uri.AppendQuery("api-version", "2.0", true);
            request.Uri = uri;
            if (xMsClientId != null)
            {
                request.Headers.Add("x-ms-client-id", xMsClientId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to delete a created tileset.&lt;br&gt;
        /// You can use this API if a tileset is no longer needed.
        /// 
        /// ### Submit Delete Request
        /// 
        /// To delete your content you will issue a `DELETE` request where the path will contain the `tilesetId` of the tileset to delete.&lt;br&gt;
        /// 
        /// #### Delete request &quot;Successful&quot;
        /// 
        /// The Tileset Delete API returns a HTTP `204 No Content` response with an empty body, if the tileset was deleted successfully.&lt;br&gt;
        /// 
        /// #### Delete request &quot;Failed&quot;
        /// 
        /// A HTTP `400 Bad Request` error response will be returned if the tileset with the passed-in `tilesetId` is not found.
        /// 
        /// Here is a sample error response:
        /// 
        /// &lt;br&gt;
        /// 
        /// ```json
        /// {
        ///   &quot;error&quot;: {
        ///       &quot;code&quot;: &quot;400 BadRequest&quot;,
        ///       &quot;message&quot;: &quot;Bad request - Tileset Id: d85b5b27-5fc4-4599-8b50-47160e90f8ce does not exist.&quot;
        ///   }
        /// }
        /// ```.
        /// </summary>
        /// <param name="tilesetId"> The Tileset Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tilesetId"/> is null. </exception>
        public async Task<Response> DeleteAsync(string tilesetId, CancellationToken cancellationToken = default)
        {
            if (tilesetId == null)
            {
                throw new ArgumentNullException(nameof(tilesetId));
            }

            using var message = CreateDeleteRequest(tilesetId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to delete a created tileset.&lt;br&gt;
        /// You can use this API if a tileset is no longer needed.
        /// 
        /// ### Submit Delete Request
        /// 
        /// To delete your content you will issue a `DELETE` request where the path will contain the `tilesetId` of the tileset to delete.&lt;br&gt;
        /// 
        /// #### Delete request &quot;Successful&quot;
        /// 
        /// The Tileset Delete API returns a HTTP `204 No Content` response with an empty body, if the tileset was deleted successfully.&lt;br&gt;
        /// 
        /// #### Delete request &quot;Failed&quot;
        /// 
        /// A HTTP `400 Bad Request` error response will be returned if the tileset with the passed-in `tilesetId` is not found.
        /// 
        /// Here is a sample error response:
        /// 
        /// &lt;br&gt;
        /// 
        /// ```json
        /// {
        ///   &quot;error&quot;: {
        ///       &quot;code&quot;: &quot;400 BadRequest&quot;,
        ///       &quot;message&quot;: &quot;Bad request - Tileset Id: d85b5b27-5fc4-4599-8b50-47160e90f8ce does not exist.&quot;
        ///   }
        /// }
        /// ```.
        /// </summary>
        /// <param name="tilesetId"> The Tileset Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tilesetId"/> is null. </exception>
        public Response Delete(string tilesetId, CancellationToken cancellationToken = default)
        {
            if (tilesetId == null)
            {
                throw new ArgumentNullException(nameof(tilesetId));
            }

            using var message = CreateDeleteRequest(tilesetId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOperationRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(geography.Value, true);
            uri.AppendRaw(".atlas.microsoft.com", false);
            uri.AppendPath("/tilesets/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", "2.0", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> This path will be obtained from a call to /tilesets/create.  While in progress, an http200 will be returned with no extra headers -  followed by an http200 with Resource-Location header once successfully completed. </summary>
        /// <param name="operationId"> The ID to query the status for the dataset create/import request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<ResponseWithHeaders<LongRunningOperationResult, TilesetGetOperationHeaders>> GetOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new TilesetGetOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LongRunningOperationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LongRunningOperationResult.DeserializeLongRunningOperationResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This path will be obtained from a call to /tilesets/create.  While in progress, an http200 will be returned with no extra headers -  followed by an http200 with Resource-Location header once successfully completed. </summary>
        /// <param name="operationId"> The ID to query the status for the dataset create/import request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public ResponseWithHeaders<LongRunningOperationResult, TilesetGetOperationHeaders> GetOperation(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            var headers = new TilesetGetOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LongRunningOperationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LongRunningOperationResult.DeserializeLongRunningOperationResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(geography.Value, true);
            uri.AppendRaw(".atlas.microsoft.com", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (xMsClientId != null)
            {
                request.Headers.Add("x-ms-client-id", xMsClientId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to fetch a list of all tilesets created.
        /// &lt;br&gt;.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<TilesetListResponse>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TilesetListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TilesetListResponse.DeserializeTilesetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
        /// 
        /// Creator makes it possible to develop applications based on your private indoor map data using Azure Maps API and SDK. [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps) article introduces concepts and tools that apply to Azure Maps Creator.
        /// 
        /// This API allows the caller to fetch a list of all tilesets created.
        /// &lt;br&gt;.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<TilesetListResponse> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TilesetListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TilesetListResponse.DeserializeTilesetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
