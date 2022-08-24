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
using Azure.Template.Models;

namespace Azure.Template
{
    internal partial class BasicPolymorphicModelsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of BasicPolymorphicModelsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public BasicPolymorphicModelsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("http://localhost:3000");
        }

        internal HttpMessage CreateSetValueRequest(BaseClass input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/model", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(input);
            request.Content = content;
            return message;
        }

        // Note: To make BaseClass abstract, we need to implement the InternalUknown pattern, because we
        // Cannot Deserialize the abstract class (b/c can't create an instance of it)

        ///// <param name="input"> The BaseClass to use. </param>
        ///// <param name="cancellationToken"> The cancellation token to use. </param>
        ///// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        //public async Task<Response<BaseClass>> SetValueAsync(BaseClass input, CancellationToken cancellationToken = default)
        //{
        //    if (input == null)
        //    {
        //        throw new ArgumentNullException(nameof(input));
        //    }

        //    using var message = CreateSetValueRequest(input);
        //    await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
        //    switch (message.Response.Status)
        //    {
        //        case 200:
        //            {
        //                BaseClass value = default;
        //                using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
        //                value = BaseClass.DeserializeBaseClass(document.RootElement);
        //                return Response.FromValue(value, message.Response);
        //            }
        //        default:
        //            throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
        //    }
        //}

        ///// <param name="input"> The BaseClass to use. </param>
        ///// <param name="cancellationToken"> The cancellation token to use. </param>
        ///// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        //public Response<BaseClass> SetValue(BaseClass input, CancellationToken cancellationToken = default)
        //{
        //    if (input == null)
        //    {
        //        throw new ArgumentNullException(nameof(input));
        //    }

        //    using var message = CreateSetValueRequest(input);
        //    _pipeline.Send(message, cancellationToken);
        //    switch (message.Response.Status)
        //    {
        //        case 200:
        //            {
        //                BaseClass value = default;
        //                using var document = JsonDocument.Parse(message.Response.ContentStream);
        //                value = BaseClass.DeserializeBaseClass(document.RootElement);
        //                return Response.FromValue(value, message.Response);
        //            }
        //        default:
        //            throw ClientDiagnostics.CreateRequestFailedException(message.Response);
        //    }
        //}

        internal HttpMessage CreateSetValueWithPolymorphicPropertyRequest(ModelWithPolymorphicProperty input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/property", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(input);
            request.Content = content;
            return message;
        }

        /// <param name="input"> The ModelWithPolymorphicProperty to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public async Task<Response<ModelWithPolymorphicProperty>> SetValueWithPolymorphicPropertyAsync(ModelWithPolymorphicProperty input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var message = CreateSetValueWithPolymorphicPropertyRequest(input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelWithPolymorphicProperty value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ModelWithPolymorphicProperty.DeserializeModelWithPolymorphicProperty(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="input"> The ModelWithPolymorphicProperty to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public Response<ModelWithPolymorphicProperty> SetValueWithPolymorphicProperty(ModelWithPolymorphicProperty input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var message = CreateSetValueWithPolymorphicPropertyRequest(input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelWithPolymorphicProperty value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ModelWithPolymorphicProperty.DeserializeModelWithPolymorphicProperty(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
