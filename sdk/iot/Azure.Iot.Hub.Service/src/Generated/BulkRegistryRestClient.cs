// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    internal partial class BulkRegistryRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of BulkRegistryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public BulkRegistryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-03-13")
        {
            endpoint ??= new Uri("https://fully-qualified-iothubname.azure-devices.net");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateUpdateRegistryRequest(IEnumerable<ExportImportDevice> devices)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/devices", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartArray();
            foreach (var item in devices)
            {
                content.JsonWriter.WriteObjectValue(item);
            }
            content.JsonWriter.WriteEndArray();
            request.Content = content;
            return message;
        }

        /// <summary> Creates, updates, or deletes the identities of multiple devices from the IoT Hub identity registry. A device identity can be specified only once in the list. Different operations (create, update, delete) on different devices are allowed. A maximum of 100 devices can be specified per invocation. For large scale operations, use the import feature using blob storage (https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities). </summary>
        /// <param name="devices"> The registry operations to perform. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devices"/> is null. </exception>
        public async Task<Response<BulkRegistryOperationResponse>> UpdateRegistryAsync(IEnumerable<ExportImportDevice> devices, CancellationToken cancellationToken = default)
        {
            if (devices == null)
            {
                throw new ArgumentNullException(nameof(devices));
            }

            using var message = CreateUpdateRegistryRequest(devices);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 400:
                    {
                        BulkRegistryOperationResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BulkRegistryOperationResponse.DeserializeBulkRegistryOperationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates, updates, or deletes the identities of multiple devices from the IoT Hub identity registry. A device identity can be specified only once in the list. Different operations (create, update, delete) on different devices are allowed. A maximum of 100 devices can be specified per invocation. For large scale operations, use the import feature using blob storage (https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities). </summary>
        /// <param name="devices"> The registry operations to perform. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devices"/> is null. </exception>
        public Response<BulkRegistryOperationResponse> UpdateRegistry(IEnumerable<ExportImportDevice> devices, CancellationToken cancellationToken = default)
        {
            if (devices == null)
            {
                throw new ArgumentNullException(nameof(devices));
            }

            using var message = CreateUpdateRegistryRequest(devices);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 400:
                    {
                        BulkRegistryOperationResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BulkRegistryOperationResponse.DeserializeBulkRegistryOperationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
