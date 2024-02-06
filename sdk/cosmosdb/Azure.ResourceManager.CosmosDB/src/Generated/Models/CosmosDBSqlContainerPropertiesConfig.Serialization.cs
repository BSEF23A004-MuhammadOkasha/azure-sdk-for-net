// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlContainerPropertiesConfig : IUtf8JsonSerializable, IJsonModel<CosmosDBSqlContainerPropertiesConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBSqlContainerPropertiesConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBSqlContainerPropertiesConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlContainerPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlContainerPropertiesConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Throughput))
            {
                writer.WritePropertyName("throughput"u8);
                writer.WriteNumberValue(Throughput.Value);
            }
            if (Optional.IsDefined(AutoscaleSettings))
            {
                writer.WritePropertyName("autoscaleSettings"u8);
                BinaryData data = ModelReaderWriter.Write(AutoscaleSettings, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        CosmosDBSqlContainerPropertiesConfig IJsonModel<CosmosDBSqlContainerPropertiesConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlContainerPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlContainerPropertiesConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBSqlContainerPropertiesConfig(document.RootElement, options);
        }

        internal static CosmosDBSqlContainerPropertiesConfig DeserializeCosmosDBSqlContainerPropertiesConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> throughput = default;
            Optional<AutoscaleSettings> autoscaleSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleSettings = AutoscaleSettings.DeserializeAutoscaleSettings(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBSqlContainerPropertiesConfig(Optional.ToNullable(throughput), autoscaleSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBSqlContainerPropertiesConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlContainerPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlContainerPropertiesConfig)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBSqlContainerPropertiesConfig IPersistableModel<CosmosDBSqlContainerPropertiesConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlContainerPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBSqlContainerPropertiesConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlContainerPropertiesConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBSqlContainerPropertiesConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
