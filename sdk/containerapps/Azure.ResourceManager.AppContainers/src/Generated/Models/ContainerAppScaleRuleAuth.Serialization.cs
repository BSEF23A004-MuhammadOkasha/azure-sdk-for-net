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
    public partial class ContainerAppScaleRuleAuth : IUtf8JsonSerializable, IJsonModel<ContainerAppScaleRuleAuth>, IPersistableModel<ContainerAppScaleRuleAuth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppScaleRuleAuth>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppScaleRuleAuth>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRuleAuth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRuleAuth)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SecretRef))
            {
                writer.WritePropertyName("secretRef"u8);
                writer.WriteStringValue(SecretRef);
            }
            if (Optional.IsDefined(TriggerParameter))
            {
                writer.WritePropertyName("triggerParameter"u8);
                writer.WriteStringValue(TriggerParameter);
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

        ContainerAppScaleRuleAuth IJsonModel<ContainerAppScaleRuleAuth>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRuleAuth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRuleAuth)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppScaleRuleAuth(document.RootElement, options);
        }

        internal static ContainerAppScaleRuleAuth DeserializeContainerAppScaleRuleAuth(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> secretRef = default;
            Optional<string> triggerParameter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretRef"u8))
                {
                    secretRef = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerParameter"u8))
                {
                    triggerParameter = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppScaleRuleAuth(secretRef.Value, triggerParameter.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SecretRef))
            {
                builder.Append("  secretRef:");
                builder.AppendLine($" '{SecretRef}'");
            }

            if (Optional.IsDefined(TriggerParameter))
            {
                builder.Append("  triggerParameter:");
                builder.AppendLine($" '{TriggerParameter}'");
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

        BinaryData IPersistableModel<ContainerAppScaleRuleAuth>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRuleAuth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRuleAuth)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppScaleRuleAuth IPersistableModel<ContainerAppScaleRuleAuth>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRuleAuth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppScaleRuleAuth(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRuleAuth)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppScaleRuleAuth>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
