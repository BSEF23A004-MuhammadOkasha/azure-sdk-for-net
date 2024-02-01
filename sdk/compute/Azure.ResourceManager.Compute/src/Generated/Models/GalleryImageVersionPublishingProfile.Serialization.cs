// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionPublishingProfile : IUtf8JsonSerializable, IJsonModel<GalleryImageVersionPublishingProfile>, IPersistableModel<GalleryImageVersionPublishingProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersionPublishingProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryImageVersionPublishingProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TargetRegions))
            {
                writer.WritePropertyName("targetRegions"u8);
                writer.WriteStartArray();
                foreach (var item in TargetRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount"u8);
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsDefined(IsExcludedFromLatest))
            {
                writer.WritePropertyName("excludeFromLatest"u8);
                writer.WriteBooleanValue(IsExcludedFromLatest.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PublishedOn))
            {
                writer.WritePropertyName("publishedDate"u8);
                writer.WriteStringValue(PublishedOn.Value, "O");
            }
            if (Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType"u8);
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationMode))
            {
                writer.WritePropertyName("replicationMode"u8);
                writer.WriteStringValue(ReplicationMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TargetExtendedLocations))
            {
                writer.WritePropertyName("targetExtendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in TargetExtendedLocations)
                {
                    writer.WriteObjectValue(item);
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

        GalleryImageVersionPublishingProfile IJsonModel<GalleryImageVersionPublishingProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersionPublishingProfile(document.RootElement, options);
        }

        internal static GalleryImageVersionPublishingProfile DeserializeGalleryImageVersionPublishingProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TargetRegion>> targetRegions = default;
            Optional<int> replicaCount = default;
            Optional<bool> excludeFromLatest = default;
            Optional<DateTimeOffset> publishedDate = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<ImageStorageAccountType> storageAccountType = default;
            Optional<GalleryReplicationMode> replicationMode = default;
            Optional<IList<GalleryTargetExtendedLocation>> targetExtendedLocations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetRegion> array = new List<TargetRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetRegion.DeserializeTargetRegion(item));
                    }
                    targetRegions = array;
                    continue;
                }
                if (property.NameEquals("replicaCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromLatest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeFromLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new ImageStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationMode = new GalleryReplicationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetExtendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryTargetExtendedLocation> array = new List<GalleryTargetExtendedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryTargetExtendedLocation.DeserializeGalleryTargetExtendedLocation(item));
                    }
                    targetExtendedLocations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryImageVersionPublishingProfile(Optional.ToList(targetRegions), Optional.ToNullable(replicaCount), Optional.ToNullable(excludeFromLatest), Optional.ToNullable(publishedDate), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(storageAccountType), Optional.ToNullable(replicationMode), Optional.ToList(targetExtendedLocations), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(TargetRegions))
            {
                builder.Append("  targetRegions:");
                builder.AppendLine(" [");
                foreach (var item in TargetRegions)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(ReplicaCount))
            {
                builder.Append("  replicaCount:");
                builder.AppendLine($" '{ReplicaCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(IsExcludedFromLatest))
            {
                builder.Append("  excludeFromLatest:");
                var boolValue = IsExcludedFromLatest.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(PublishedOn))
            {
                builder.Append("  publishedDate:");
                builder.AppendLine($" '{PublishedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(EndOfLifeOn))
            {
                builder.Append("  endOfLifeDate:");
                builder.AppendLine($" '{EndOfLifeOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(StorageAccountType))
            {
                builder.Append("  storageAccountType:");
                builder.AppendLine($" '{StorageAccountType.ToString()}'");
            }

            if (Optional.IsDefined(ReplicationMode))
            {
                builder.Append("  replicationMode:");
                builder.AppendLine($" '{ReplicationMode.ToString()}'");
            }

            if (Optional.IsCollectionDefined(TargetExtendedLocations))
            {
                builder.Append("  targetExtendedLocations:");
                builder.AppendLine(" [");
                foreach (var item in TargetExtendedLocations)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<GalleryImageVersionPublishingProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support '{options.Format}' format.");
            }
        }

        GalleryImageVersionPublishingProfile IPersistableModel<GalleryImageVersionPublishingProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryImageVersionPublishingProfile(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryImageVersionPublishingProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
