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
    public partial class ComputeResourceSkuRestrictions : IUtf8JsonSerializable, IJsonModel<ComputeResourceSkuRestrictions>, IPersistableModel<ComputeResourceSkuRestrictions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeResourceSkuRestrictions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputeResourceSkuRestrictions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeResourceSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeResourceSkuRestrictions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RestrictionsType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RestrictionsType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(RestrictionInfo))
            {
                writer.WritePropertyName("restrictionInfo"u8);
                writer.WriteObjectValue(RestrictionInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(ReasonCode))
            {
                writer.WritePropertyName("reasonCode"u8);
                writer.WriteStringValue(ReasonCode.Value.ToSerialString());
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

        ComputeResourceSkuRestrictions IJsonModel<ComputeResourceSkuRestrictions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeResourceSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeResourceSkuRestrictions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeResourceSkuRestrictions(document.RootElement, options);
        }

        internal static ComputeResourceSkuRestrictions DeserializeComputeResourceSkuRestrictions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ComputeResourceSkuRestrictionsType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<ComputeResourceSkuRestrictionInfo> restrictionInfo = default;
            Optional<ComputeResourceSkuRestrictionsReasonCode> reasonCode = default;
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
                    type = property.Value.GetString().ToComputeResourceSkuRestrictionsType();
                    continue;
                }
                if (property.NameEquals("values"u8))
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
                    values = array;
                    continue;
                }
                if (property.NameEquals("restrictionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictionInfo = ComputeResourceSkuRestrictionInfo.DeserializeComputeResourceSkuRestrictionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = property.Value.GetString().ToComputeResourceSkuRestrictionsReasonCode();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputeResourceSkuRestrictions(Optional.ToNullable(type), Optional.ToList(values), restrictionInfo.Value, Optional.ToNullable(reasonCode), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RestrictionsType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{RestrictionsType.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Values))
            {
                builder.Append("  values:");
                builder.AppendLine(" [");
                foreach (var item in Values)
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

            if (Optional.IsDefined(RestrictionInfo))
            {
                builder.Append("  restrictionInfo:");
                AppendChildObject(builder, RestrictionInfo, options, 2);
            }

            if (Optional.IsDefined(ReasonCode))
            {
                builder.Append("  reasonCode:");
                builder.AppendLine($" '{ReasonCode.ToString()}'");
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

        BinaryData IPersistableModel<ComputeResourceSkuRestrictions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeResourceSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ComputeResourceSkuRestrictions)} does not support '{options.Format}' format.");
            }
        }

        ComputeResourceSkuRestrictions IPersistableModel<ComputeResourceSkuRestrictions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeResourceSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeResourceSkuRestrictions(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ComputeResourceSkuRestrictions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeResourceSkuRestrictions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
