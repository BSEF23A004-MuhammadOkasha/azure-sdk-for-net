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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppRegistryInfo : IUtf8JsonSerializable, IJsonModel<ContainerAppRegistryInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppRegistryInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppRegistryInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RegistryServer))
            {
                writer.WritePropertyName("registryUrl"u8);
                writer.WriteStringValue(RegistryServer);
            }
            if (Optional.IsDefined(RegistryUserName))
            {
                writer.WritePropertyName("registryUserName"u8);
                writer.WriteStringValue(RegistryUserName);
            }
            if (Optional.IsDefined(RegistryPassword))
            {
                writer.WritePropertyName("registryPassword"u8);
                writer.WriteStringValue(RegistryPassword);
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

        ContainerAppRegistryInfo IJsonModel<ContainerAppRegistryInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppRegistryInfo(document.RootElement, options);
        }

        internal static ContainerAppRegistryInfo DeserializeContainerAppRegistryInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> registryUrl = default;
            Optional<string> registryUserName = default;
            Optional<string> registryPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registryUrl"u8))
                {
                    registryUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryUserName"u8))
                {
                    registryUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryPassword"u8))
                {
                    registryPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppRegistryInfo(registryUrl.Value, registryUserName.Value, registryPassword.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RegistryServer))
            {
                builder.Append("  registryUrl:");
                builder.AppendLine($" '{RegistryServer}'");
            }

            if (Optional.IsDefined(RegistryUserName))
            {
                builder.Append("  registryUserName:");
                builder.AppendLine($" '{RegistryUserName}'");
            }

            if (Optional.IsDefined(RegistryPassword))
            {
                builder.Append("  registryPassword:");
                builder.AppendLine($" '{RegistryPassword}'");
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

        BinaryData IPersistableModel<ContainerAppRegistryInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppRegistryInfo IPersistableModel<ContainerAppRegistryInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppRegistryInfo(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppRegistryInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
