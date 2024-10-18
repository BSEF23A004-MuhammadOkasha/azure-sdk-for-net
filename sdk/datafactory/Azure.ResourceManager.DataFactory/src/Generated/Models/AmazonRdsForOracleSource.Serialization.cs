// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AmazonRdsForOracleSource : IUtf8JsonSerializable, IJsonModel<AmazonRdsForOracleSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmazonRdsForOracleSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AmazonRdsForOracleSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonRdsForOracleSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmazonRdsForOracleSource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(OracleReaderQuery))
            {
                writer.WritePropertyName("oracleReaderQuery"u8);
                JsonSerializer.Serialize(writer, OracleReaderQuery);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout"u8);
                JsonSerializer.Serialize(writer, QueryTimeout);
            }
            if (Optional.IsDefined(PartitionOption))
            {
                writer.WritePropertyName("partitionOption"u8);
                JsonSerializer.Serialize(writer, PartitionOption);
            }
            if (Optional.IsDefined(PartitionSettings))
            {
                writer.WritePropertyName("partitionSettings"u8);
                writer.WriteObjectValue(PartitionSettings, options);
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalColumns);
#else
                using (JsonDocument document = JsonDocument.Parse(AdditionalColumns))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            foreach (var item in AdditionalProperties)
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

        AmazonRdsForOracleSource IJsonModel<AmazonRdsForOracleSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonRdsForOracleSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmazonRdsForOracleSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmazonRdsForOracleSource(document.RootElement, options);
        }

        internal static AmazonRdsForOracleSource DeserializeAmazonRdsForOracleSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> oracleReaderQuery = default;
            DataFactoryElement<string> queryTimeout = default;
            DataFactoryElement<string> partitionOption = default;
            AmazonRdsForOraclePartitionSettings partitionSettings = default;
            BinaryData additionalColumns = default;
            string type = default;
            DataFactoryElement<int> sourceRetryCount = default;
            DataFactoryElement<string> sourceRetryWait = default;
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oracleReaderQuery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oracleReaderQuery = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionOption = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionSettings = AmazonRdsForOraclePartitionSettings.DeserializeAmazonRdsForOraclePartitionSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AmazonRdsForOracleSource(
                type,
                sourceRetryCount,
                sourceRetryWait,
                maxConcurrentConnections,
                disableMetricsCollection,
                additionalProperties,
                oracleReaderQuery,
                queryTimeout,
                partitionOption,
                partitionSettings,
                additionalColumns);
        }

        BinaryData IPersistableModel<AmazonRdsForOracleSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonRdsForOracleSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmazonRdsForOracleSource)} does not support writing '{options.Format}' format.");
            }
        }

        AmazonRdsForOracleSource IPersistableModel<AmazonRdsForOracleSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonRdsForOracleSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmazonRdsForOracleSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmazonRdsForOracleSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmazonRdsForOracleSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
