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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppDefaultAuthorizationPolicy : IUtf8JsonSerializable, IJsonModel<ContainerAppDefaultAuthorizationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppDefaultAuthorizationPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppDefaultAuthorizationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AllowedPrincipals))
            {
                writer.WritePropertyName("allowedPrincipals"u8);
                writer.WriteObjectValue(AllowedPrincipals);
            }
            if (Optional.IsCollectionDefined(AllowedApplications))
            {
                writer.WritePropertyName("allowedApplications"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedApplications)
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

        ContainerAppDefaultAuthorizationPolicy IJsonModel<ContainerAppDefaultAuthorizationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDefaultAuthorizationPolicy(document.RootElement, options);
        }

        internal static ContainerAppDefaultAuthorizationPolicy DeserializeContainerAppDefaultAuthorizationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppAllowedPrincipals> allowedPrincipals = default;
            Optional<IList<string>> allowedApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedPrincipals = ContainerAppAllowedPrincipals.DeserializeContainerAppAllowedPrincipals(property.Value);
                    continue;
                }
                if (property.NameEquals("allowedApplications"u8))
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
                    allowedApplications = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppDefaultAuthorizationPolicy(allowedPrincipals.Value, Optional.ToList(allowedApplications), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AllowedPrincipals))
            {
                builder.Append("  allowedPrincipals:");
                AppendChildObject(builder, AllowedPrincipals, options, 2, false);
            }

            if (Optional.IsCollectionDefined(AllowedApplications))
            {
                if (AllowedApplications.Any())
                {
                    builder.Append("  allowedApplications:");
                    builder.AppendLine(" [");
                    foreach (var item in AllowedApplications)
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

        BinaryData IPersistableModel<ContainerAppDefaultAuthorizationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppDefaultAuthorizationPolicy IPersistableModel<ContainerAppDefaultAuthorizationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppDefaultAuthorizationPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppDefaultAuthorizationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
