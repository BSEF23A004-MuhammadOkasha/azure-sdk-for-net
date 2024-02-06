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
    [JsonConverter(typeof(SsisLogLocationConverter))]
    public partial class SsisLogLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("logPath"u8);
            writer.WriteObjectValue(LogPath);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessCredential))
            {
                writer.WritePropertyName("accessCredential"u8);
                writer.WriteObjectValue(AccessCredential);
            }
            if (Optional.IsDefined(LogRefreshInterval))
            {
                writer.WritePropertyName("logRefreshInterval"u8);
                writer.WriteObjectValue(LogRefreshInterval);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SsisLogLocation DeserializeSsisLogLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object logPath = default;
            SsisLogLocationType type = default;
            Optional<SsisAccessCredential> accessCredential = default;
            Optional<object> logRefreshInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logPath"u8))
                {
                    logPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SsisLogLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logRefreshInterval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logRefreshInterval = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SsisLogLocation(logPath, type, accessCredential.Value, logRefreshInterval.Value);
        }

        internal partial class SsisLogLocationConverter : JsonConverter<SsisLogLocation>
        {
            public override void Write(Utf8JsonWriter writer, SsisLogLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SsisLogLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisLogLocation(document.RootElement);
            }
        }
    }
}
