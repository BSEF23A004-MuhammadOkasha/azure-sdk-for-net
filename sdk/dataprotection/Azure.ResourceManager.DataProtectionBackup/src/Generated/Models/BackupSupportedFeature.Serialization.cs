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
    public partial class BackupSupportedFeature : IUtf8JsonSerializable, IJsonModel<BackupSupportedFeature>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupSupportedFeature>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupSupportedFeature>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSupportedFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupSupportedFeature)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FeatureName != null)
            {
                writer.WritePropertyName("featureName"u8);
                writer.WriteStringValue(FeatureName);
            }
            if (SupportStatus.HasValue)
            {
                writer.WritePropertyName("supportStatus"u8);
                writer.WriteStringValue(SupportStatus.Value.ToString());
            }
            if (!(ExposureControlledFeatures is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("exposureControlledFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in ExposureControlledFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        BackupSupportedFeature IJsonModel<BackupSupportedFeature>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSupportedFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupSupportedFeature)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupSupportedFeature(document.RootElement, options);
        }

        internal static BackupSupportedFeature DeserializeBackupSupportedFeature(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> featureName = default;
            Optional<FeatureSupportStatus> supportStatus = default;
            IReadOnlyList<string> exposureControlledFeatures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureName"u8))
                {
                    featureName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportStatus = new FeatureSupportStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exposureControlledFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    exposureControlledFeatures = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupSupportedFeature(featureName.Value, Optional.ToNullable(supportStatus), exposureControlledFeatures ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupSupportedFeature>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSupportedFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupSupportedFeature)} does not support '{options.Format}' format.");
            }
        }

        BackupSupportedFeature IPersistableModel<BackupSupportedFeature>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSupportedFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupSupportedFeature(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupSupportedFeature)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupSupportedFeature>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
