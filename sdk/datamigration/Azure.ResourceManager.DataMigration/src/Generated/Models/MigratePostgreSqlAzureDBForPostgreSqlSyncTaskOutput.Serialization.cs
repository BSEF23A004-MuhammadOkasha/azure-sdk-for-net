// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput))]
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput : IUtf8JsonSerializable, IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(document.RootElement, options);
        }

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelErrorOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError(element);
                    case "DatabaseLevelOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(element);
                    case "MigrationLevelOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(element);
                    case "TableLevelOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel(element);
                }
            }
            return UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput.DeserializeUnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(element);
        }

        BinaryData IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
