// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlStorageProfile : IUtf8JsonSerializable, IJsonModel<PostgreSqlStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlStorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlStorageProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupRetentionDays))
            {
                writer.WritePropertyName("backupRetentionDays"u8);
                writer.WriteNumberValue(BackupRetentionDays.Value);
            }
            if (Optional.IsDefined(GeoRedundantBackup))
            {
                writer.WritePropertyName("geoRedundantBackup"u8);
                writer.WriteStringValue(GeoRedundantBackup.Value.ToString());
            }
            if (Optional.IsDefined(StorageInMB))
            {
                writer.WritePropertyName("storageMB"u8);
                writer.WriteNumberValue(StorageInMB.Value);
            }
            if (Optional.IsDefined(StorageAutogrow))
            {
                writer.WritePropertyName("storageAutogrow"u8);
                writer.WriteStringValue(StorageAutogrow.Value.ToString());
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

        PostgreSqlStorageProfile IJsonModel<PostgreSqlStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlStorageProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlStorageProfile(document.RootElement, options);
        }

        internal static PostgreSqlStorageProfile DeserializePostgreSqlStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> backupRetentionDays = default;
            Optional<PostgreSqlGeoRedundantBackup> geoRedundantBackup = default;
            Optional<int> storageMB = default;
            Optional<PostgreSqlStorageAutogrow> storageAutogrow = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("geoRedundantBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoRedundantBackup = new PostgreSqlGeoRedundantBackup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAutogrow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAutogrow = new PostgreSqlStorageAutogrow(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlStorageProfile(Optional.ToNullable(backupRetentionDays), Optional.ToNullable(geoRedundantBackup), Optional.ToNullable(storageMB), Optional.ToNullable(storageAutogrow), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlStorageProfile IPersistableModel<PostgreSqlStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
