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
    public partial class ValidateMigrationInputSqlServerSqlMITaskOutput : IUtf8JsonSerializable, IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RestoreDatabaseNameErrors))
            {
                writer.WritePropertyName("restoreDatabaseNameErrors"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreDatabaseNameErrors)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BackupFolderErrors))
            {
                writer.WritePropertyName("backupFolderErrors"u8);
                writer.WriteStartArray();
                foreach (var item in BackupFolderErrors)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BackupShareCredentialsErrors))
            {
                writer.WritePropertyName("backupShareCredentialsErrors"u8);
                writer.WriteStartArray();
                foreach (var item in BackupShareCredentialsErrors)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BackupStorageAccountErrors))
            {
                writer.WritePropertyName("backupStorageAccountErrors"u8);
                writer.WriteStartArray();
                foreach (var item in BackupStorageAccountErrors)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExistingBackupErrors))
            {
                writer.WritePropertyName("existingBackupErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ExistingBackupErrors)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DatabaseBackupInfo))
            {
                writer.WritePropertyName("databaseBackupInfo"u8);
                BinaryData data = ModelReaderWriter.Write(DatabaseBackupInfo, options);
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

        ValidateMigrationInputSqlServerSqlMITaskOutput IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateMigrationInputSqlServerSqlMITaskOutput(document.RootElement, options);
        }

        internal static ValidateMigrationInputSqlServerSqlMITaskOutput DeserializeValidateMigrationInputSqlServerSqlMITaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<ReportableException>> restoreDatabaseNameErrors = default;
            Optional<IReadOnlyList<ReportableException>> backupFolderErrors = default;
            Optional<IReadOnlyList<ReportableException>> backupShareCredentialsErrors = default;
            Optional<IReadOnlyList<ReportableException>> backupStorageAccountErrors = default;
            Optional<IReadOnlyList<ReportableException>> existingBackupErrors = default;
            Optional<DatabaseBackupInfo> databaseBackupInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreDatabaseNameErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    restoreDatabaseNameErrors = array;
                    continue;
                }
                if (property.NameEquals("backupFolderErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    backupFolderErrors = array;
                    continue;
                }
                if (property.NameEquals("backupShareCredentialsErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    backupShareCredentialsErrors = array;
                    continue;
                }
                if (property.NameEquals("backupStorageAccountErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    backupStorageAccountErrors = array;
                    continue;
                }
                if (property.NameEquals("existingBackupErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    existingBackupErrors = array;
                    continue;
                }
                if (property.NameEquals("databaseBackupInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseBackupInfo = DatabaseBackupInfo.DeserializeDatabaseBackupInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ValidateMigrationInputSqlServerSqlMITaskOutput(id.Value, name.Value, Optional.ToList(restoreDatabaseNameErrors), Optional.ToList(backupFolderErrors), Optional.ToList(backupShareCredentialsErrors), Optional.ToList(backupStorageAccountErrors), Optional.ToList(existingBackupErrors), databaseBackupInfo.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support '{options.Format}' format.");
            }
        }

        ValidateMigrationInputSqlServerSqlMITaskOutput IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeValidateMigrationInputSqlServerSqlMITaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
