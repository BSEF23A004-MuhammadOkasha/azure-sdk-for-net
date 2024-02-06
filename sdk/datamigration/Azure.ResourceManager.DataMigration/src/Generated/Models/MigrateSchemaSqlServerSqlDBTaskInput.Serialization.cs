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
    public partial class MigrateSchemaSqlServerSqlDBTaskInput : IUtf8JsonSerializable, IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support '{format}' format.");
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
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
            }
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn);
            }
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

        MigrateSchemaSqlServerSqlDBTaskInput IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSchemaSqlServerSqlDBTaskInput(document.RootElement, options);
        }

        internal static MigrateSchemaSqlServerSqlDBTaskInput DeserializeMigrateSchemaSqlServerSqlDBTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSchemaSqlServerSqlDBDatabaseInput> selectedDatabases = default;
            Optional<string> encryptedKeyForSecureFields = default;
            Optional<string> startedOn = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSchemaSqlServerSqlDBDatabaseInput> array = new List<MigrateSchemaSqlServerSqlDBDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSchemaSqlServerSqlDBDatabaseInput.DeserializeMigrateSchemaSqlServerSqlDBDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    startedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSchemaSqlServerSqlDBTaskInput(sourceConnectionInfo, targetConnectionInfo, serializedAdditionalRawData, selectedDatabases, encryptedKeyForSecureFields.Value, startedOn.Value);
        }

        BinaryData IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support '{options.Format}' format.");
            }
        }

        MigrateSchemaSqlServerSqlDBTaskInput IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSchemaSqlServerSqlDBTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
