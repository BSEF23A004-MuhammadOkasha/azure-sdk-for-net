// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupFindRestorableTimeRangeResultProperties : IUtf8JsonSerializable, IJsonModel<BackupFindRestorableTimeRangeResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupFindRestorableTimeRangeResultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupFindRestorableTimeRangeResultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFindRestorableTimeRangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupFindRestorableTimeRangeResultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RestorableTimeRanges))
            {
                writer.WritePropertyName("restorableTimeRanges"u8);
                writer.WriteStartArray();
                foreach (var item in RestorableTimeRanges)
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
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType);
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

        BackupFindRestorableTimeRangeResultProperties IJsonModel<BackupFindRestorableTimeRangeResultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFindRestorableTimeRangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupFindRestorableTimeRangeResultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupFindRestorableTimeRangeResultProperties(document.RootElement, options);
        }

        internal static BackupFindRestorableTimeRangeResultProperties DeserializeBackupFindRestorableTimeRangeResultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<RestorableTimeRange>> restorableTimeRanges = default;
            Optional<string> objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restorableTimeRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorableTimeRange> array = new List<RestorableTimeRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableTimeRange.DeserializeRestorableTimeRange(item));
                    }
                    restorableTimeRanges = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupFindRestorableTimeRangeResultProperties(Optional.ToList(restorableTimeRanges), objectType.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupFindRestorableTimeRangeResultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFindRestorableTimeRangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupFindRestorableTimeRangeResultProperties)} does not support '{options.Format}' format.");
            }
        }

        BackupFindRestorableTimeRangeResultProperties IPersistableModel<BackupFindRestorableTimeRangeResultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFindRestorableTimeRangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupFindRestorableTimeRangeResultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupFindRestorableTimeRangeResultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupFindRestorableTimeRangeResultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
