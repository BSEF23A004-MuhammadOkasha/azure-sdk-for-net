// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    internal partial class DeviceCapacityCheckRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DeviceCapacityCheckRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DeviceCapacityCheckRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCheckResourceCreationFeasibilityRequestUri(string subscriptionId, string resourceGroupName, string deviceName, DeviceCapacityRequestContent content, string capacityName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/deviceCapacityCheck", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (capacityName != null)
            {
                uri.AppendQuery("capacityName", capacityName, true);
            }
            return uri;
        }

        internal HttpMessage CreateCheckResourceCreationFeasibilityRequest(string subscriptionId, string resourceGroupName, string deviceName, DeviceCapacityRequestContent content, string capacityName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/", false);
            uri.AppendPath(deviceName, true);
            uri.AppendPath("/deviceCapacityCheck", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (capacityName != null)
            {
                uri.AppendQuery("capacityName", capacityName, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Posts the device capacity request info to check feasibility. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="content"> The device capacity request info. </param>
        /// <param name="capacityName"> The capacity name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CheckResourceCreationFeasibilityAsync(string subscriptionId, string resourceGroupName, string deviceName, DeviceCapacityRequestContent content, string capacityName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckResourceCreationFeasibilityRequest(subscriptionId, resourceGroupName, deviceName, content, capacityName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Posts the device capacity request info to check feasibility. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="content"> The device capacity request info. </param>
        /// <param name="capacityName"> The capacity name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="deviceName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CheckResourceCreationFeasibility(string subscriptionId, string resourceGroupName, string deviceName, DeviceCapacityRequestContent content, string capacityName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckResourceCreationFeasibilityRequest(subscriptionId, resourceGroupName, deviceName, content, capacityName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
