// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class AnswerCallRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IncomingCallContext))
            {
                writer.WritePropertyName("incomingCallContext");
                writer.WriteStringValue(IncomingCallContext);
            }
            writer.WritePropertyName("callbackUri");
            writer.WriteStringValue(CallbackUri);
            if (Optional.IsCollectionDefined(RequestedMediaTypes))
            {
                writer.WritePropertyName("requestedMediaTypes");
                writer.WriteStartArray();
                foreach (var item in RequestedMediaTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequestedCallEvents))
            {
                writer.WritePropertyName("requestedCallEvents");
                writer.WriteStartArray();
                foreach (var item in RequestedCallEvents)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
