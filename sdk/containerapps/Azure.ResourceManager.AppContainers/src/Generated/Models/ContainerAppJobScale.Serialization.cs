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
    public partial class ContainerAppJobScale : IUtf8JsonSerializable, IJsonModel<ContainerAppJobScale>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobScale>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppJobScale>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScale>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobScale)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PollingIntervalInSeconds))
            {
                writer.WritePropertyName("pollingInterval"u8);
                writer.WriteNumberValue(PollingIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(MinExecutions))
            {
                writer.WritePropertyName("minExecutions"u8);
                writer.WriteNumberValue(MinExecutions.Value);
            }
            if (Optional.IsDefined(MaxExecutions))
            {
                writer.WritePropertyName("maxExecutions"u8);
                writer.WriteNumberValue(MaxExecutions.Value);
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

        ContainerAppJobScale IJsonModel<ContainerAppJobScale>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScale>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobScale)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobScale(document.RootElement, options);
        }

        internal static ContainerAppJobScale DeserializeContainerAppJobScale(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> pollingInterval = default;
            Optional<int> minExecutions = default;
            Optional<int> maxExecutions = default;
            Optional<IList<ContainerAppJobScaleRule>> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pollingInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pollingInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minExecutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minExecutions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxExecutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxExecutions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppJobScaleRule> array = new List<ContainerAppJobScaleRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppJobScaleRule.DeserializeContainerAppJobScaleRule(item));
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
            return new ContainerAppJobScale(Optional.ToNullable(pollingInterval), Optional.ToNullable(minExecutions), Optional.ToNullable(maxExecutions), Optional.ToList(rules), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PollingIntervalInSeconds))
            {
                builder.Append("  pollingInterval:");
                builder.AppendLine($" {PollingIntervalInSeconds.Value}");
            }

            if (Optional.IsDefined(MinExecutions))
            {
                builder.Append("  minExecutions:");
                builder.AppendLine($" {MinExecutions.Value}");
            }

            if (Optional.IsDefined(MaxExecutions))
            {
                builder.Append("  maxExecutions:");
                builder.AppendLine($" {MaxExecutions.Value}");
            }

            if (Optional.IsCollectionDefined(Rules))
            {
                if (Rules.Any())
                {
                    builder.Append("  rules:");
                    builder.AppendLine(" [");
                    foreach (var item in Rules)
                    {
                        AppendChildObject(builder, item, options, 4, true);
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

        BinaryData IPersistableModel<ContainerAppJobScale>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScale>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobScale)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppJobScale IPersistableModel<ContainerAppJobScale>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScale>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobScale(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobScale)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobScale>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
