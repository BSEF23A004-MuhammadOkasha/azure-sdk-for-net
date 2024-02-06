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
    [JsonConverter(typeof(DWCopyCommandDefaultValueConverter))]
    public partial class DWCopyCommandDefaultValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName"u8);
                writer.WriteObjectValue(ColumnName);
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteObjectValue(DefaultValue);
            }
            writer.WriteEndObject();
        }

        internal static DWCopyCommandDefaultValue DeserializeDWCopyCommandDefaultValue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> columnName = default;
            Optional<object> defaultValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultValue = property.Value.GetObject();
                    continue;
                }
            }
            return new DWCopyCommandDefaultValue(columnName.Value, defaultValue.Value);
        }

        internal partial class DWCopyCommandDefaultValueConverter : JsonConverter<DWCopyCommandDefaultValue>
        {
            public override void Write(Utf8JsonWriter writer, DWCopyCommandDefaultValue model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override DWCopyCommandDefaultValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDWCopyCommandDefaultValue(document.RootElement);
            }
        }
    }
}
