// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkedServiceDebugResourceConverter))]
    public partial class LinkedServiceDebugResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static LinkedServiceDebugResource DeserializeLinkedServiceDebugResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedService properties = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = LinkedService.DeserializeLinkedService(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedServiceDebugResource(name, properties);
        }

        internal partial class LinkedServiceDebugResourceConverter : JsonConverter<LinkedServiceDebugResource>
        {
            public override void Write(Utf8JsonWriter writer, LinkedServiceDebugResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkedServiceDebugResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedServiceDebugResource(document.RootElement);
            }
        }
    }
}
