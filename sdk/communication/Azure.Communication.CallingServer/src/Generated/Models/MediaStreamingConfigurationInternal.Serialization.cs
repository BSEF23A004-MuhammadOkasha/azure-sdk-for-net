// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class MediaStreamingConfigurationInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("transportUrl");
            writer.WriteStringValue(TransportUrl);
            writer.WritePropertyName("transportType");
            writer.WriteStringValue(TransportType.ToString());
            writer.WritePropertyName("contentType");
            writer.WriteStringValue(ContentType.ToString());
            writer.WritePropertyName("audioChannelType");
            writer.WriteStringValue(AudioChannelType.ToString());
            writer.WriteEndObject();
        }
    }
}
