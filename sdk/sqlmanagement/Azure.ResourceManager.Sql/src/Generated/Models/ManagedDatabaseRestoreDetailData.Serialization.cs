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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedDatabaseRestoreDetailData : IUtf8JsonSerializable, IJsonModel<ManagedDatabaseRestoreDetailData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedDatabaseRestoreDetailData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedDatabaseRestoreDetailData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseRestoreDetailData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedDatabaseRestoreDetailData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RestoreType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RestoreType);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(BlockReason))
            {
                writer.WritePropertyName("blockReason"u8);
                writer.WriteStringValue(BlockReason);
            }
            if (options.Format != "W" && Optional.IsDefined(LastUploadedFileName))
            {
                writer.WritePropertyName("lastUploadedFileName"u8);
                writer.WriteStringValue(LastUploadedFileName);
            }
            if (options.Format != "W" && Optional.IsDefined(LastUploadedFileOn))
            {
                writer.WritePropertyName("lastUploadedFileTime"u8);
                writer.WriteStringValue(LastUploadedFileOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastRestoredFileName))
            {
                writer.WritePropertyName("lastRestoredFileName"u8);
                writer.WriteStringValue(LastRestoredFileName);
            }
            if (options.Format != "W" && Optional.IsDefined(LastRestoredFileOn))
            {
                writer.WritePropertyName("lastRestoredFileTime"u8);
                writer.WriteStringValue(LastRestoredFileOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CompletedPercent))
            {
                writer.WritePropertyName("percentCompleted"u8);
                writer.WriteNumberValue(CompletedPercent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentRestoredSizeInMB))
            {
                writer.WritePropertyName("currentRestoredSizeMB"u8);
                writer.WriteNumberValue(CurrentRestoredSizeInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentRestorePlanSizeInMB))
            {
                writer.WritePropertyName("currentRestorePlanSizeMB"u8);
                writer.WriteNumberValue(CurrentRestorePlanSizeInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentBackupType))
            {
                writer.WritePropertyName("currentBackupType"u8);
                writer.WriteStringValue(CurrentBackupType);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentRestoringFileName))
            {
                writer.WritePropertyName("currentRestoringFileName"u8);
                writer.WriteStringValue(CurrentRestoringFileName);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfFilesFound))
            {
                writer.WritePropertyName("numberOfFilesDetected"u8);
                writer.WriteNumberValue(NumberOfFilesFound.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfFilesQueued))
            {
                writer.WritePropertyName("numberOfFilesQueued"u8);
                writer.WriteNumberValue(NumberOfFilesQueued.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfFilesSkipped))
            {
                writer.WritePropertyName("numberOfFilesSkipped"u8);
                writer.WriteNumberValue(NumberOfFilesSkipped.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfFilesRestoring))
            {
                writer.WritePropertyName("numberOfFilesRestoring"u8);
                writer.WriteNumberValue(NumberOfFilesRestoring.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfFilesRestored))
            {
                writer.WritePropertyName("numberOfFilesRestored"u8);
                writer.WriteNumberValue(NumberOfFilesRestored.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfFilesUnrestorable))
            {
                writer.WritePropertyName("numberOfFilesUnrestorable"u8);
                writer.WriteNumberValue(NumberOfFilesUnrestorable.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FullBackupSets))
            {
                writer.WritePropertyName("fullBackupSets"u8);
                writer.WriteStartArray();
                foreach (var item in FullBackupSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DiffBackupSets))
            {
                writer.WritePropertyName("diffBackupSets"u8);
                writer.WriteStartArray();
                foreach (var item in DiffBackupSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(LogBackupSets))
            {
                writer.WritePropertyName("logBackupSets"u8);
                writer.WriteStartArray();
                foreach (var item in LogBackupSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(UnrestorableFileList))
            {
                writer.WritePropertyName("unrestorableFiles"u8);
                writer.WriteStartArray();
                foreach (var item in UnrestorableFileList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        ManagedDatabaseRestoreDetailData IJsonModel<ManagedDatabaseRestoreDetailData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseRestoreDetailData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedDatabaseRestoreDetailData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedDatabaseRestoreDetailData(document.RootElement, options);
        }

        internal static ManagedDatabaseRestoreDetailData DeserializeManagedDatabaseRestoreDetailData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> type0 = default;
            Optional<string> status = default;
            Optional<string> blockReason = default;
            Optional<string> lastUploadedFileName = default;
            Optional<DateTimeOffset> lastUploadedFileTime = default;
            Optional<string> lastRestoredFileName = default;
            Optional<DateTimeOffset> lastRestoredFileTime = default;
            Optional<int> percentCompleted = default;
            Optional<int> currentRestoredSizeMB = default;
            Optional<int> currentRestorePlanSizeMB = default;
            Optional<string> currentBackupType = default;
            Optional<string> currentRestoringFileName = default;
            Optional<int> numberOfFilesDetected = default;
            Optional<int> numberOfFilesQueued = default;
            Optional<int> numberOfFilesSkipped = default;
            Optional<int> numberOfFilesRestoring = default;
            Optional<int> numberOfFilesRestored = default;
            Optional<int> numberOfFilesUnrestorable = default;
            Optional<IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties>> fullBackupSets = default;
            Optional<IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties>> diffBackupSets = default;
            Optional<IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties>> logBackupSets = default;
            Optional<IReadOnlyList<ManagedDatabaseRestoreDetailUnrestorableFileProperties>> unrestorableFiles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("type"u8))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blockReason"u8))
                        {
                            blockReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUploadedFileName"u8))
                        {
                            lastUploadedFileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUploadedFileTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUploadedFileTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastRestoredFileName"u8))
                        {
                            lastRestoredFileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastRestoredFileTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastRestoredFileTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("percentCompleted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentCompleted = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentRestoredSizeMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentRestoredSizeMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentRestorePlanSizeMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentRestorePlanSizeMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentBackupType"u8))
                        {
                            currentBackupType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentRestoringFileName"u8))
                        {
                            currentRestoringFileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("numberOfFilesDetected"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfFilesDetected = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfFilesQueued"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfFilesQueued = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfFilesSkipped"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfFilesSkipped = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfFilesRestoring"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfFilesRestoring = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfFilesRestored"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfFilesRestored = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfFilesUnrestorable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfFilesUnrestorable = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("fullBackupSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedDatabaseRestoreDetailBackupSetProperties> array = new List<ManagedDatabaseRestoreDetailBackupSetProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedDatabaseRestoreDetailBackupSetProperties.DeserializeManagedDatabaseRestoreDetailBackupSetProperties(item));
                            }
                            fullBackupSets = array;
                            continue;
                        }
                        if (property0.NameEquals("diffBackupSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedDatabaseRestoreDetailBackupSetProperties> array = new List<ManagedDatabaseRestoreDetailBackupSetProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedDatabaseRestoreDetailBackupSetProperties.DeserializeManagedDatabaseRestoreDetailBackupSetProperties(item));
                            }
                            diffBackupSets = array;
                            continue;
                        }
                        if (property0.NameEquals("logBackupSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedDatabaseRestoreDetailBackupSetProperties> array = new List<ManagedDatabaseRestoreDetailBackupSetProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedDatabaseRestoreDetailBackupSetProperties.DeserializeManagedDatabaseRestoreDetailBackupSetProperties(item));
                            }
                            logBackupSets = array;
                            continue;
                        }
                        if (property0.NameEquals("unrestorableFiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedDatabaseRestoreDetailUnrestorableFileProperties> array = new List<ManagedDatabaseRestoreDetailUnrestorableFileProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedDatabaseRestoreDetailUnrestorableFileProperties.DeserializeManagedDatabaseRestoreDetailUnrestorableFileProperties(item));
                            }
                            unrestorableFiles = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedDatabaseRestoreDetailData(id, name, type, systemData.Value, type0.Value, status.Value, blockReason.Value, lastUploadedFileName.Value, Optional.ToNullable(lastUploadedFileTime), lastRestoredFileName.Value, Optional.ToNullable(lastRestoredFileTime), Optional.ToNullable(percentCompleted), Optional.ToNullable(currentRestoredSizeMB), Optional.ToNullable(currentRestorePlanSizeMB), currentBackupType.Value, currentRestoringFileName.Value, Optional.ToNullable(numberOfFilesDetected), Optional.ToNullable(numberOfFilesQueued), Optional.ToNullable(numberOfFilesSkipped), Optional.ToNullable(numberOfFilesRestoring), Optional.ToNullable(numberOfFilesRestored), Optional.ToNullable(numberOfFilesUnrestorable), Optional.ToList(fullBackupSets), Optional.ToList(diffBackupSets), Optional.ToList(logBackupSets), Optional.ToList(unrestorableFiles), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedDatabaseRestoreDetailData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseRestoreDetailData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedDatabaseRestoreDetailData)} does not support '{options.Format}' format.");
            }
        }

        ManagedDatabaseRestoreDetailData IPersistableModel<ManagedDatabaseRestoreDetailData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseRestoreDetailData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedDatabaseRestoreDetailData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedDatabaseRestoreDetailData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedDatabaseRestoreDetailData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
