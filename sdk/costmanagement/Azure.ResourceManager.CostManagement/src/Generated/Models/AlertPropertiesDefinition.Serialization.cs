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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class AlertPropertiesDefinition : IUtf8JsonSerializable, IJsonModel<AlertPropertiesDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertPropertiesDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AlertPropertiesDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertPropertiesDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AlertType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AlertType.Value.ToString());
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Criteria))
            {
                writer.WritePropertyName("criteria"u8);
                writer.WriteStringValue(Criteria.Value.ToString());
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

        AlertPropertiesDefinition IJsonModel<AlertPropertiesDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertPropertiesDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertPropertiesDefinition(document.RootElement, options);
        }

        internal static AlertPropertiesDefinition DeserializeAlertPropertiesDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CostManagementAlertType> type = default;
            Optional<CostManagementAlertCategory> category = default;
            Optional<AlertCriterion> criteria = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new CostManagementAlertType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new CostManagementAlertCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("criteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    criteria = new AlertCriterion(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AlertPropertiesDefinition(Optional.ToNullable(type), Optional.ToNullable(category), Optional.ToNullable(criteria), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AlertType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{AlertType.ToString()}'");
            }

            if (Optional.IsDefined(Category))
            {
                builder.Append("  category:");
                builder.AppendLine($" '{Category.ToString()}'");
            }

            if (Optional.IsDefined(Criteria))
            {
                builder.Append("  criteria:");
                builder.AppendLine($" '{Criteria.ToString()}'");
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

        BinaryData IPersistableModel<AlertPropertiesDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AlertPropertiesDefinition)} does not support '{options.Format}' format.");
            }
        }

        AlertPropertiesDefinition IPersistableModel<AlertPropertiesDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertPropertiesDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertPropertiesDefinition(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AlertPropertiesDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertPropertiesDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
