// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Gallery.Models
{
    public partial class GalleryImageVersionUefiSettings : IUtf8JsonSerializable, IJsonModel<GalleryImageVersionUefiSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersionUefiSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GalleryImageVersionUefiSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionUefiSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionUefiSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SignatureTemplateNames))
            {
                writer.WritePropertyName("signatureTemplateNames"u8);
                writer.WriteStartArray();
                foreach (var item in SignatureTemplateNames)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AdditionalSignatures))
            {
                writer.WritePropertyName("additionalSignatures"u8);
                writer.WriteObjectValue(AdditionalSignatures, options);
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

        GalleryImageVersionUefiSettings IJsonModel<GalleryImageVersionUefiSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionUefiSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionUefiSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersionUefiSettings(document.RootElement, options);
        }

        internal static GalleryImageVersionUefiSettings DeserializeGalleryImageVersionUefiSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<UefiSignatureTemplateName> signatureTemplateNames = default;
            UefiKeySignatures additionalSignatures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signatureTemplateNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiSignatureTemplateName> array = new List<UefiSignatureTemplateName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new UefiSignatureTemplateName(item.GetString()));
                    }
                    signatureTemplateNames = array;
                    continue;
                }
                if (property.NameEquals("additionalSignatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalSignatures = UefiKeySignatures.DeserializeUefiKeySignatures(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GalleryImageVersionUefiSettings(signatureTemplateNames ?? new ChangeTrackingList<UefiSignatureTemplateName>(), additionalSignatures, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryImageVersionUefiSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionUefiSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionUefiSettings)} does not support writing '{options.Format}' format.");
            }
        }

        GalleryImageVersionUefiSettings IPersistableModel<GalleryImageVersionUefiSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionUefiSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryImageVersionUefiSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionUefiSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryImageVersionUefiSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
