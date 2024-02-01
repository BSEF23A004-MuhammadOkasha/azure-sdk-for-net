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
    public partial class CommunityGalleryMetadata : IUtf8JsonSerializable, IJsonModel<CommunityGalleryMetadata>, IPersistableModel<CommunityGalleryMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunityGalleryMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommunityGalleryMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublisherUri))
            {
                writer.WritePropertyName("publisherUri"u8);
                writer.WriteStringValue(PublisherUri.AbsoluteUri);
            }
            writer.WritePropertyName("publisherContact"u8);
            writer.WriteStringValue(PublisherContact);
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula"u8);
                writer.WriteStringValue(Eula);
            }
            writer.WritePropertyName("publicNames"u8);
            writer.WriteStartArray();
            foreach (var item in PublicNames)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(PrivacyStatementUri))
            {
                writer.WritePropertyName("privacyStatementUri"u8);
                writer.WriteStringValue(PrivacyStatementUri.AbsoluteUri);
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

        CommunityGalleryMetadata IJsonModel<CommunityGalleryMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunityGalleryMetadata(document.RootElement, options);
        }

        internal static CommunityGalleryMetadata DeserializeCommunityGalleryMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> publisherUri = default;
            string publisherContact = default;
            Optional<string> eula = default;
            IReadOnlyList<string> publicNames = default;
            Optional<Uri> privacyStatementUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherContact"u8))
                {
                    publisherContact = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eula"u8))
                {
                    eula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicNames"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    publicNames = array;
                    continue;
                }
                if (property.NameEquals("privacyStatementUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privacyStatementUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommunityGalleryMetadata(publisherUri.Value, publisherContact, eula.Value, publicNames, privacyStatementUri.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PublisherUri))
            {
                builder.Append("  publisherUri:");
                builder.AppendLine($" '{PublisherUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(PublisherContact))
            {
                builder.Append("  publisherContact:");
                builder.AppendLine($" '{PublisherContact}'");
            }

            if (Optional.IsDefined(Eula))
            {
                builder.Append("  eula:");
                builder.AppendLine($" '{Eula}'");
            }

            if (Optional.IsCollectionDefined(PublicNames))
            {
                builder.Append("  publicNames:");
                builder.AppendLine(" [");
                foreach (var item in PublicNames)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(PrivacyStatementUri))
            {
                builder.Append("  privacyStatementUri:");
                builder.AppendLine($" '{PrivacyStatementUri.AbsoluteUri}'");
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

        BinaryData IPersistableModel<CommunityGalleryMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support '{options.Format}' format.");
            }
        }

        CommunityGalleryMetadata IPersistableModel<CommunityGalleryMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommunityGalleryMetadata(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunityGalleryMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
