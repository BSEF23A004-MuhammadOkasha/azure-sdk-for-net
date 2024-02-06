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
    public partial class ConnectToSourceSqlServerTaskOutputDatabaseLevel : IUtf8JsonSerializable, IJsonModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputDatabaseLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(SizeMB))
            {
                writer.WritePropertyName("sizeMB"u8);
                writer.WriteNumberValue(SizeMB.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DatabaseFiles))
            {
                writer.WritePropertyName("databaseFiles"u8);
                writer.WriteStartArray();
                foreach (var item in DatabaseFiles)
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
            if (options.Format != "W" && Optional.IsDefined(CompatibilityLevel))
            {
                writer.WritePropertyName("compatibilityLevel"u8);
                writer.WriteStringValue(CompatibilityLevel.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseState))
            {
                writer.WritePropertyName("databaseState"u8);
                writer.WriteStringValue(DatabaseState.Value.ToString());
            }
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

        ConnectToSourceSqlServerTaskOutputDatabaseLevel IJsonModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputDatabaseLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceSqlServerTaskOutputDatabaseLevel(document.RootElement, options);
        }

        internal static ConnectToSourceSqlServerTaskOutputDatabaseLevel DeserializeConnectToSourceSqlServerTaskOutputDatabaseLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<double> sizeMB = default;
            Optional<IReadOnlyList<DatabaseFileInfo>> databaseFiles = default;
            Optional<DatabaseCompatLevel> compatibilityLevel = default;
            Optional<DatabaseState> databaseState = default;
            Optional<string> id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("databaseFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatabaseFileInfo> array = new List<DatabaseFileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseFileInfo.DeserializeDatabaseFileInfo(item));
                    }
                    databaseFiles = array;
                    continue;
                }
                if (property.NameEquals("compatibilityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compatibilityLevel = new DatabaseCompatLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databaseState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseState = new DatabaseState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToSourceSqlServerTaskOutputDatabaseLevel(id.Value, resultType, serializedAdditionalRawData, name.Value, Optional.ToNullable(sizeMB), Optional.ToList(databaseFiles), Optional.ToNullable(compatibilityLevel), Optional.ToNullable(databaseState));
        }

        BinaryData IPersistableModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputDatabaseLevel)} does not support '{options.Format}' format.");
            }
        }

        ConnectToSourceSqlServerTaskOutputDatabaseLevel IPersistableModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToSourceSqlServerTaskOutputDatabaseLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputDatabaseLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToSourceSqlServerTaskOutputDatabaseLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
