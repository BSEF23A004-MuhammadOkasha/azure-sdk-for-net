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
    [JsonConverter(typeof(SapHanaPartitionSettingsConverter))]
    public partial class SapHanaPartitionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName");
                writer.WriteObjectValue(PartitionColumnName);
            }
            writer.WriteEndObject();
        }

        internal static SapHanaPartitionSettings DeserializeSapHanaPartitionSettings(JsonElement element)
        {
            Optional<object> partitionColumnName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionColumnName = property.Value.GetObject();
                    continue;
                }
            }
            return new SapHanaPartitionSettings(partitionColumnName.Value);
        }

        internal partial class SapHanaPartitionSettingsConverter : JsonConverter<SapHanaPartitionSettings>
        {
            public override void Write(Utf8JsonWriter writer, SapHanaPartitionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SapHanaPartitionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSapHanaPartitionSettings(document.RootElement);
            }
        }
    }
}
