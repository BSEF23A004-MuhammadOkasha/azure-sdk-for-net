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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedRestorableGremlinGraphResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedRestorableGremlinGraphResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedRestorableGremlinGraphResourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtendedRestorableGremlinGraphResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableGremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableGremlinGraphResourceInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CanUndelete))
            {
                writer.WritePropertyName("canUndelete"u8);
                writer.WriteStringValue(CanUndelete);
            }
            if (options.Format != "W" && Optional.IsDefined(CanUndeleteReason))
            {
                writer.WritePropertyName("canUndeleteReason"u8);
                writer.WriteStringValue(CanUndeleteReason);
            }
            if (options.Format != "W" && Optional.IsDefined(EventTimestamp))
            {
                writer.WritePropertyName("eventTimestamp"u8);
                writer.WriteStringValue(EventTimestamp);
            }
            if (options.Format != "W" && Optional.IsDefined(GraphName))
            {
                writer.WritePropertyName("ownerId"u8);
                writer.WriteStringValue(GraphName);
            }
            if (options.Format != "W" && Optional.IsDefined(GraphId))
            {
                writer.WritePropertyName("ownerResourceId"u8);
                writer.WriteStringValue(GraphId);
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
        }

        ExtendedRestorableGremlinGraphResourceInfo IJsonModel<ExtendedRestorableGremlinGraphResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableGremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableGremlinGraphResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedRestorableGremlinGraphResourceInfo(document.RootElement, options);
        }

        internal static ExtendedRestorableGremlinGraphResourceInfo DeserializeExtendedRestorableGremlinGraphResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rid = default;
            CosmosDBOperationType? operationType = default;
            string canUndelete = default;
            string canUndeleteReason = default;
            string eventTimestamp = default;
            string ownerId = default;
            string ownerResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("canUndelete"u8))
                {
                    canUndelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("canUndeleteReason"u8))
                {
                    canUndeleteReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExtendedRestorableGremlinGraphResourceInfo(
                rid,
                operationType,
                canUndelete,
                canUndeleteReason,
                eventTimestamp,
                ownerId,
                ownerResourceId,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _rid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Rid))
                {
                    builder.Append("  _rid: ");
                    if (Rid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Rid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Rid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OperationType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  operationType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OperationType))
                {
                    builder.Append("  operationType: ");
                    builder.AppendLine($"'{OperationType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CanUndelete), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  canUndelete: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CanUndelete))
                {
                    builder.Append("  canUndelete: ");
                    if (CanUndelete.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CanUndelete}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CanUndelete}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CanUndeleteReason), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  canUndeleteReason: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CanUndeleteReason))
                {
                    builder.Append("  canUndeleteReason: ");
                    if (CanUndeleteReason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CanUndeleteReason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CanUndeleteReason}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  eventTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EventTimestamp))
                {
                    builder.Append("  eventTimestamp: ");
                    if (EventTimestamp.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EventTimestamp}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EventTimestamp}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GraphName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ownerId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GraphName))
                {
                    builder.Append("  ownerId: ");
                    if (GraphName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GraphName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GraphName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GraphId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ownerResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GraphId))
                {
                    builder.Append("  ownerResourceId: ");
                    if (GraphId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GraphId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GraphId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ExtendedRestorableGremlinGraphResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableGremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableGremlinGraphResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ExtendedRestorableGremlinGraphResourceInfo IPersistableModel<ExtendedRestorableGremlinGraphResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableGremlinGraphResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedRestorableGremlinGraphResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableGremlinGraphResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedRestorableGremlinGraphResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
