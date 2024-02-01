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

namespace Azure.ResourceManager.Consumption.Models
{
    internal partial class UsageDetailsListResult : IUtf8JsonSerializable, IJsonModel<UsageDetailsListResult>, IPersistableModel<UsageDetailsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UsageDetailsListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UsageDetailsListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UsageDetailsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UsageDetailsListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        UsageDetailsListResult IJsonModel<UsageDetailsListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UsageDetailsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UsageDetailsListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUsageDetailsListResult(document.RootElement, options);
        }

        internal static UsageDetailsListResult DeserializeUsageDetailsListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ConsumptionUsageDetail>> value = default;
            Optional<string> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConsumptionUsageDetail> array = new List<ConsumptionUsageDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConsumptionUsageDetail.DeserializeConsumptionUsageDetail(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UsageDetailsListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Value))
            {
                builder.Append("  value:");
                builder.AppendLine(" [");
                foreach (var item in Value)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(NextLink))
            {
                builder.Append("  nextLink:");
                builder.AppendLine($" '{NextLink}'");
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

        BinaryData IPersistableModel<UsageDetailsListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UsageDetailsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UsageDetailsListResult)} does not support '{options.Format}' format.");
            }
        }

        UsageDetailsListResult IPersistableModel<UsageDetailsListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UsageDetailsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUsageDetailsListResult(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(UsageDetailsListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UsageDetailsListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
