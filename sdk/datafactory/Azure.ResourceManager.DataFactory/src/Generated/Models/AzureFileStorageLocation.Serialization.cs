// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureFileStorageLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(DatasetLocationType);
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FolderPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FolderPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FileName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FileName.ToString()).RootElement);
#endif
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static AzureFileStorageLocation DeserializeAzureFileStorageLocation(JsonElement element)
        {
            string type = default;
            Optional<BinaryData> folderPath = default;
            Optional<BinaryData> fileName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("folderPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folderPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureFileStorageLocation(type, folderPath.Value, fileName.Value, additionalProperties);
        }
    }
}
