// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CommunityGalleryInfo : IUtf8JsonSerializable, IJsonModel<CommunityGalleryInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunityGalleryInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommunityGalleryInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublisherUriString))
            {
                writer.WritePropertyName("publisherUri"u8);
                writer.WriteStringValue(PublisherUriString);
            }
            if (Optional.IsDefined(PublisherContact))
            {
                writer.WritePropertyName("publisherContact"u8);
                writer.WriteStringValue(PublisherContact);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula"u8);
                writer.WriteStringValue(Eula);
            }
            if (Optional.IsDefined(PublicNamePrefix))
            {
                writer.WritePropertyName("publicNamePrefix"u8);
                writer.WriteStringValue(PublicNamePrefix);
            }
            if (options.Format != "W" && Optional.IsDefined(CommunityGalleryEnabled))
            {
                writer.WritePropertyName("communityGalleryEnabled"u8);
                writer.WriteBooleanValue(CommunityGalleryEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PublicNames))
            {
                writer.WritePropertyName("publicNames"u8);
                writer.WriteStartArray();
                foreach (var item in PublicNames)
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

        CommunityGalleryInfo IJsonModel<CommunityGalleryInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunityGalleryInfo(document.RootElement, options);
        }

        internal static CommunityGalleryInfo DeserializeCommunityGalleryInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> publisherUri = default;
            Optional<string> publisherContact = default;
            Optional<string> eula = default;
            Optional<string> publicNamePrefix = default;
            Optional<bool> communityGalleryEnabled = default;
            Optional<IReadOnlyList<string>> publicNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherUri"u8))
                {
                    publisherUri = property.Value.GetString();
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
                if (property.NameEquals("publicNamePrefix"u8))
                {
                    publicNamePrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityGalleryEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communityGalleryEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publicNames"u8))
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
                    publicNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommunityGalleryInfo(publisherUri.Value, publisherContact.Value, eula.Value, publicNamePrefix.Value, Optional.ToNullable(communityGalleryEnabled), Optional.ToList(publicNames), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PublisherUriString))
            {
                builder.Append("  publisherUri:");
                builder.AppendLine($" '{PublisherUriString}'");
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

            if (Optional.IsDefined(PublicNamePrefix))
            {
                builder.Append("  publicNamePrefix:");
                builder.AppendLine($" '{PublicNamePrefix}'");
            }

            if (Optional.IsDefined(CommunityGalleryEnabled))
            {
                builder.Append("  communityGalleryEnabled:");
                var boolValue = CommunityGalleryEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(PublicNames))
            {
                if (PublicNames.Any())
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
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<CommunityGalleryInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support '{options.Format}' format.");
            }
        }

        CommunityGalleryInfo IPersistableModel<CommunityGalleryInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommunityGalleryInfo(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunityGalleryInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
