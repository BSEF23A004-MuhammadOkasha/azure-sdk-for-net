// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class DscNodeConfigurationListResult : IUtf8JsonSerializable, IJsonModel<DscNodeConfigurationListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscNodeConfigurationListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscNodeConfigurationListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeConfigurationListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsDefined(TotalCount))
            {
                writer.WritePropertyName("totalCount"u8);
                writer.WriteNumberValue(TotalCount.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DscNodeConfigurationListResult IJsonModel<DscNodeConfigurationListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeConfigurationListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscNodeConfigurationListResult(document.RootElement, options);
        }

        internal static DscNodeConfigurationListResult DeserializeDscNodeConfigurationListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DscNodeConfigurationData>> value = default;
            Optional<string> nextLink = default;
            Optional<int> totalCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscNodeConfigurationData> array = new List<DscNodeConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscNodeConfigurationData.DeserializeDscNodeConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DscNodeConfigurationListResult(Optional.ToList(value), nextLink.Value, Optional.ToNullable(totalCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscNodeConfigurationListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscNodeConfigurationListResult)} does not support '{options.Format}' format.");
            }
        }

        DscNodeConfigurationListResult IPersistableModel<DscNodeConfigurationListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscNodeConfigurationListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscNodeConfigurationListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscNodeConfigurationListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
