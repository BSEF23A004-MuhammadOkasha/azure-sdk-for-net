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
    public partial class ContainerAppScale : IUtf8JsonSerializable, IJsonModel<ContainerAppScale>, IPersistableModel<ContainerAppScale>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppScale>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppScale>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScale>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScale)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinReplicas))
            {
                writer.WritePropertyName("minReplicas"u8);
                writer.WriteNumberValue(MinReplicas.Value);
            }
            if (Optional.IsDefined(MaxReplicas))
            {
                writer.WritePropertyName("maxReplicas"u8);
                writer.WriteNumberValue(MaxReplicas.Value);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
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

        ContainerAppScale IJsonModel<ContainerAppScale>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScale>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScale)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppScale(document.RootElement, options);
        }

        internal static ContainerAppScale DeserializeContainerAppScale(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minReplicas = default;
            Optional<int> maxReplicas = default;
            Optional<IList<ContainerAppScaleRule>> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppScaleRule> array = new List<ContainerAppScaleRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppScaleRule.DeserializeContainerAppScaleRule(item));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppScale(Optional.ToNullable(minReplicas), Optional.ToNullable(maxReplicas), Optional.ToList(rules), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(MinReplicas))
            {
                builder.Append("  minReplicas:");
                builder.AppendLine($" '{MinReplicas.Value.ToString()}'");
            }

            if (Optional.IsDefined(MaxReplicas))
            {
                builder.Append("  maxReplicas:");
                builder.AppendLine($" '{MaxReplicas.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Rules))
            {
                builder.Append("  rules:");
                builder.AppendLine(" [");
                foreach (var item in Rules)
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

        BinaryData IPersistableModel<ContainerAppScale>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScale>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScale)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppScale IPersistableModel<ContainerAppScale>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScale>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppScale(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScale)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppScale>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
