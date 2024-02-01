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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class SharedGalleryImageVersionData : IUtf8JsonSerializable, IJsonModel<SharedGalleryImageVersionData>, IPersistableModel<SharedGalleryImageVersionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharedGalleryImageVersionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SharedGalleryImageVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PublishedOn))
            {
                writer.WritePropertyName("publishedDate"u8);
                writer.WriteStringValue(PublishedOn.Value, "O");
            }
            if (Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (Optional.IsDefined(IsExcludedFromLatest))
            {
                writer.WritePropertyName("excludeFromLatest"u8);
                writer.WriteBooleanValue(IsExcludedFromLatest.Value);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsCollectionDefined(ArtifactTags))
            {
                writer.WritePropertyName("artifactTags"u8);
                writer.WriteStartObject();
                foreach (var item in ArtifactTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WritePropertyName("identifier"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UniqueId))
            {
                writer.WritePropertyName("uniqueId"u8);
                writer.WriteStringValue(UniqueId);
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

        SharedGalleryImageVersionData IJsonModel<SharedGalleryImageVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedGalleryImageVersionData(document.RootElement, options);
        }

        internal static SharedGalleryImageVersionData DeserializeSharedGalleryImageVersionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<DateTimeOffset> publishedDate = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<bool> excludeFromLatest = default;
            Optional<SharedGalleryImageVersionStorageProfile> storageProfile = default;
            Optional<IReadOnlyDictionary<string, string>> artifactTags = default;
            Optional<string> uniqueId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("publishedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publishedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endOfLifeDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endOfLifeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("excludeFromLatest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            excludeFromLatest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = SharedGalleryImageVersionStorageProfile.DeserializeSharedGalleryImageVersionStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("artifactTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            artifactTags = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
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
            return new SharedGalleryImageVersionData(name.Value, Optional.ToNullable(location), serializedAdditionalRawData, uniqueId.Value, Optional.ToNullable(publishedDate), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(excludeFromLatest), storageProfile.Value, Optional.ToDictionary(artifactTags));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

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

            if (Optional.IsDefined(IsExcludedFromLatest))
            {
                builder.Append("  excludeFromLatest:");
                var boolValue = IsExcludedFromLatest.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(StorageProfile))
            {
                builder.Append("  storageProfile:");
                AppendChildObject(builder, StorageProfile, options, 2);
            }

            if (Optional.IsCollectionDefined(ArtifactTags))
            {
                builder.Append("  artifactTags:");
                builder.AppendLine(" {");
                foreach (var item in ArtifactTags)
                {
                    builder.Append($"    {item.Key}: ");
                    if (item.Value == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($" '{item.Value}'");
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsDefined(UniqueId))
            {
                builder.Append("  uniqueId:");
                builder.AppendLine($" '{UniqueId}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.Value.ToString()}'");
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

        BinaryData IPersistableModel<SharedGalleryImageVersionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support '{options.Format}' format.");
            }
        }

        SharedGalleryImageVersionData IPersistableModel<SharedGalleryImageVersionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSharedGalleryImageVersionData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharedGalleryImageVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
