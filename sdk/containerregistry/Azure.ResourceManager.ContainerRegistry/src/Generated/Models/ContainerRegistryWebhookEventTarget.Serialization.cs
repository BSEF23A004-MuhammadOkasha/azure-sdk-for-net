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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryWebhookEventTarget : IUtf8JsonSerializable, IJsonModel<ContainerRegistryWebhookEventTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryWebhookEventTarget>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryWebhookEventTarget>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventTarget)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType"u8);
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteNumberValue(Size.Value);
            }
            if (Optional.IsDefined(Digest))
            {
                writer.WritePropertyName("digest"u8);
                writer.WriteStringValue(Digest);
            }
            if (Optional.IsDefined(Length))
            {
                writer.WritePropertyName("length"u8);
                writer.WriteNumberValue(Length.Value);
            }
            if (Optional.IsDefined(Repository))
            {
                writer.WritePropertyName("repository"u8);
                writer.WriteStringValue(Repository);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag"u8);
                writer.WriteStringValue(Tag);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        ContainerRegistryWebhookEventTarget IJsonModel<ContainerRegistryWebhookEventTarget>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventTarget)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryWebhookEventTarget(document.RootElement, options);
        }

        internal static ContainerRegistryWebhookEventTarget DeserializeContainerRegistryWebhookEventTarget(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mediaType = default;
            Optional<long> size = default;
            Optional<string> digest = default;
            Optional<long> length = default;
            Optional<string> repository = default;
            Optional<Uri> url = default;
            Optional<string> tag = default;
            Optional<string> name = default;
            Optional<string> version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    length = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("repository"u8))
                {
                    repository = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryWebhookEventTarget(mediaType.Value, Optional.ToNullable(size), digest.Value, Optional.ToNullable(length), repository.Value, url.Value, tag.Value, name.Value, version.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(MediaType))
            {
                builder.Append("  mediaType:");
                builder.AppendLine($" '{MediaType}'");
            }

            if (Optional.IsDefined(Size))
            {
                builder.Append("  size:");
                builder.AppendLine($" '{Size.Value.ToString()}'");
            }

            if (Optional.IsDefined(Digest))
            {
                builder.Append("  digest:");
                builder.AppendLine($" '{Digest}'");
            }

            if (Optional.IsDefined(Length))
            {
                builder.Append("  length:");
                builder.AppendLine($" '{Length.Value.ToString()}'");
            }

            if (Optional.IsDefined(Repository))
            {
                builder.Append("  repository:");
                builder.AppendLine($" '{Repository}'");
            }

            if (Optional.IsDefined(Uri))
            {
                builder.Append("  url:");
                builder.AppendLine($" '{Uri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Tag))
            {
                builder.Append("  tag:");
                builder.AppendLine($" '{Tag}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(Version))
            {
                builder.Append("  version:");
                builder.AppendLine($" '{Version}'");
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

        BinaryData IPersistableModel<ContainerRegistryWebhookEventTarget>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventTarget)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryWebhookEventTarget IPersistableModel<ContainerRegistryWebhookEventTarget>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryWebhookEventTarget(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventTarget)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryWebhookEventTarget>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
