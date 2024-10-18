// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class SharedGalleryImageVersionData : IUtf8JsonSerializable, IJsonModel<SharedGalleryImageVersionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharedGalleryImageVersionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SharedGalleryImageVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
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
                writer.WriteObjectValue(StorageProfile, options);
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
        }

        SharedGalleryImageVersionData IJsonModel<SharedGalleryImageVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedGalleryImageVersionData(document.RootElement, options);
        }

        internal static SharedGalleryImageVersionData DeserializeSharedGalleryImageVersionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            AzureLocation? location = default;
            DateTimeOffset? publishedDate = default;
            DateTimeOffset? endOfLifeDate = default;
            bool? excludeFromLatest = default;
            SharedGalleryImageVersionStorageProfile storageProfile = default;
            IReadOnlyDictionary<string, string> artifactTags = default;
            string uniqueId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                            storageProfile = SharedGalleryImageVersionStorageProfile.DeserializeSharedGalleryImageVersionStorageProfile(property0.Value, options);
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
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SharedGalleryImageVersionData(
                name,
                location,
                serializedAdditionalRawData,
                uniqueId,
                publishedDate,
                endOfLifeDate,
                excludeFromLatest,
                storageProfile,
                artifactTags ?? new ChangeTrackingDictionary<string, string>());
        }

        BinaryData IPersistableModel<SharedGalleryImageVersionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support writing '{options.Format}' format.");
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
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryImageVersionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharedGalleryImageVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
