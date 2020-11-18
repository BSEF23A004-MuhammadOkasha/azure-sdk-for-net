// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class MediaGraphTopologyListRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion");
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static MediaGraphTopologyListRequest DeserializeMediaGraphTopologyListRequest(JsonElement element)
        {
            Optional<string> methodName = default;
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("methodName"))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphTopologyListRequest(methodName.Value, apiVersion.Value);
        }
    }
}
