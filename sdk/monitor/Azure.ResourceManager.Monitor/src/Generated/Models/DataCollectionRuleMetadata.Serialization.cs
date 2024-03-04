// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleMetadata : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionRuleMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisionedBy))
            {
                writer.WritePropertyName("provisionedBy"u8);
                writer.WriteStringValue(ProvisionedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisionedByResourceId))
            {
                writer.WritePropertyName("provisionedByResourceId"u8);
                writer.WriteStringValue(ProvisionedByResourceId);
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

        DataCollectionRuleMetadata IJsonModel<DataCollectionRuleMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleMetadata(document.RootElement, options);
        }

        internal static DataCollectionRuleMetadata DeserializeDataCollectionRuleMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisionedBy = default;
            string provisionedByResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisionedBy"u8))
                {
                    provisionedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisionedByResourceId"u8))
                {
                    provisionedByResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionRuleMetadata(provisionedBy, provisionedByResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support '{options.Format}' format.");
            }
        }

        DataCollectionRuleMetadata IPersistableModel<DataCollectionRuleMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionRuleMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRuleMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
