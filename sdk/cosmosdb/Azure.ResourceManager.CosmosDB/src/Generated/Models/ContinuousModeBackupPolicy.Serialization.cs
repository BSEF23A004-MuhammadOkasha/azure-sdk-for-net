// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ContinuousModeBackupPolicy : IUtf8JsonSerializable, IJsonModel<ContinuousModeBackupPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContinuousModeBackupPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContinuousModeBackupPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousModeBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinuousModeBackupPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContinuousModeProperties))
            {
                writer.WritePropertyName("continuousModeProperties"u8);
                writer.WriteObjectValue(ContinuousModeProperties);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(BackupPolicyType.ToString());
            if (Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteObjectValue(MigrationState);
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

        ContinuousModeBackupPolicy IJsonModel<ContinuousModeBackupPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousModeBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinuousModeBackupPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContinuousModeBackupPolicy(document.RootElement, options);
        }

        internal static ContinuousModeBackupPolicy DeserializeContinuousModeBackupPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContinuousModeProperties continuousModeProperties = default;
            BackupPolicyType type = default;
            BackupPolicyMigrationState migrationState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuousModeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuousModeProperties = ContinuousModeProperties.DeserializeContinuousModeProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new BackupPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = BackupPolicyMigrationState.DeserializeBackupPolicyMigrationState(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContinuousModeBackupPolicy(type, migrationState, serializedAdditionalRawData, continuousModeProperties);
        }

        BinaryData IPersistableModel<ContinuousModeBackupPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousModeBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContinuousModeBackupPolicy)} does not support '{options.Format}' format.");
            }
        }

        ContinuousModeBackupPolicy IPersistableModel<ContinuousModeBackupPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousModeBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContinuousModeBackupPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContinuousModeBackupPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContinuousModeBackupPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
