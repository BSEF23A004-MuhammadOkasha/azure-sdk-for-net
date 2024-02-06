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
    public partial class ValidateMigrationInputSqlServerSqlMISyncTaskInput : IUtf8JsonSerializable, IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
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
            if (Optional.IsDefined(BackupFileShare))
            {
                writer.WritePropertyName("backupFileShare"u8);
                BinaryData data = ModelReaderWriter.Write(BackupFileShare, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WritePropertyName("storageResourceId"u8);
            writer.WriteStringValue(StorageResourceId);
            writer.WritePropertyName("sourceConnectionInfo"u8);
            BinaryData data0 = ModelReaderWriter.Write(SourceConnectionInfo, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data0);
#else
            using (JsonDocument document = JsonDocument.Parse(data0))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("targetConnectionInfo"u8);
            BinaryData data1 = ModelReaderWriter.Write(TargetConnectionInfo, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data1);
#else
            using (JsonDocument document = JsonDocument.Parse(data1))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("azureApp"u8);
            BinaryData data2 = ModelReaderWriter.Write(AzureApp, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data2);
#else
            using (JsonDocument document = JsonDocument.Parse(data2))
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

        ValidateMigrationInputSqlServerSqlMISyncTaskInput IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateMigrationInputSqlServerSqlMISyncTaskInput(document.RootElement, options);
        }

        internal static ValidateMigrationInputSqlServerSqlMISyncTaskInput DeserializeValidateMigrationInputSqlServerSqlMISyncTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases = default;
            Optional<FileShare> backupFileShare = default;
            string storageResourceId = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            MISqlConnectionInfo targetConnectionInfo = default;
            AzureActiveDirectoryApp azureApp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlMIDatabaseInput> array = new List<MigrateSqlServerSqlMIDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlMIDatabaseInput.DeserializeMigrateSqlServerSqlMIDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFileShare = FileShare.DeserializeFileShare(property.Value);
                    continue;
                }
                if (property.NameEquals("storageResourceId"u8))
                {
                    storageResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = MISqlConnectionInfo.DeserializeMISqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("azureApp"u8))
                {
                    azureApp = AzureActiveDirectoryApp.DeserializeAzureActiveDirectoryApp(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ValidateMigrationInputSqlServerSqlMISyncTaskInput(selectedDatabases, backupFileShare.Value, storageResourceId, sourceConnectionInfo, targetConnectionInfo, azureApp, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support '{options.Format}' format.");
            }
        }

        ValidateMigrationInputSqlServerSqlMISyncTaskInput IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeValidateMigrationInputSqlServerSqlMISyncTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
