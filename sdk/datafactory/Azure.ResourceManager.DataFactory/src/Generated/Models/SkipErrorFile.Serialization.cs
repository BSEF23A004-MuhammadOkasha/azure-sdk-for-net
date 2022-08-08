// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SkipErrorFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FileMissing))
            {
                writer.WritePropertyName("fileMissing");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FileMissing);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FileMissing.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DataInconsistency))
            {
                writer.WritePropertyName("dataInconsistency");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DataInconsistency);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DataInconsistency.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SkipErrorFile DeserializeSkipErrorFile(JsonElement element)
        {
            Optional<BinaryData> fileMissing = default;
            Optional<BinaryData> dataInconsistency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileMissing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileMissing = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("dataInconsistency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataInconsistency = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new SkipErrorFile(fileMissing.Value, dataInconsistency.Value);
        }
    }
}
