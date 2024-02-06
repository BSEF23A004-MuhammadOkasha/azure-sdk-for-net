// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput : IUtf8JsonSerializable, IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetConnectionInfo"u8);
            BinaryData data = ModelReaderWriter.Write(TargetConnectionInfo, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
            using (JsonDocument document = JsonDocument.Parse(data))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
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

        ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput(document.RootElement, options);
        }

        internal static ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlConnectionInfo targetConnectionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = PostgreSqlConnectionInfo.DeserializePostgreSqlConnectionInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput(targetConnectionInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput)} does not support '{options.Format}' format.");
            }
        }

        ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
