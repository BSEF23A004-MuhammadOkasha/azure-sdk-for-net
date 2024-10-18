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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningNodeStateCounts : IUtf8JsonSerializable, IJsonModel<MachineLearningNodeStateCounts>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningNodeStateCounts>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningNodeStateCounts>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningNodeStateCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningNodeStateCounts)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(IdleNodeCount))
            {
                writer.WritePropertyName("idleNodeCount"u8);
                writer.WriteNumberValue(IdleNodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RunningNodeCount))
            {
                writer.WritePropertyName("runningNodeCount"u8);
                writer.WriteNumberValue(RunningNodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PreparingNodeCount))
            {
                writer.WritePropertyName("preparingNodeCount"u8);
                writer.WriteNumberValue(PreparingNodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UnusableNodeCount))
            {
                writer.WritePropertyName("unusableNodeCount"u8);
                writer.WriteNumberValue(UnusableNodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LeavingNodeCount))
            {
                writer.WritePropertyName("leavingNodeCount"u8);
                writer.WriteNumberValue(LeavingNodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PreemptedNodeCount))
            {
                writer.WritePropertyName("preemptedNodeCount"u8);
                writer.WriteNumberValue(PreemptedNodeCount.Value);
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

        MachineLearningNodeStateCounts IJsonModel<MachineLearningNodeStateCounts>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningNodeStateCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningNodeStateCounts)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningNodeStateCounts(document.RootElement, options);
        }

        internal static MachineLearningNodeStateCounts DeserializeMachineLearningNodeStateCounts(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? idleNodeCount = default;
            int? runningNodeCount = default;
            int? preparingNodeCount = default;
            int? unusableNodeCount = default;
            int? leavingNodeCount = default;
            int? preemptedNodeCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("idleNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    idleNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runningNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runningNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preparingNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preparingNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unusableNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unusableNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("leavingNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    leavingNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preemptedNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptedNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningNodeStateCounts(
                idleNodeCount,
                runningNodeCount,
                preparingNodeCount,
                unusableNodeCount,
                leavingNodeCount,
                preemptedNodeCount,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdleNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  idleNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IdleNodeCount))
                {
                    builder.Append("  idleNodeCount: ");
                    builder.AppendLine($"{IdleNodeCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunningNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  runningNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunningNodeCount))
                {
                    builder.Append("  runningNodeCount: ");
                    builder.AppendLine($"{RunningNodeCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PreparingNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  preparingNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PreparingNodeCount))
                {
                    builder.Append("  preparingNodeCount: ");
                    builder.AppendLine($"{PreparingNodeCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UnusableNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  unusableNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UnusableNodeCount))
                {
                    builder.Append("  unusableNodeCount: ");
                    builder.AppendLine($"{UnusableNodeCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LeavingNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  leavingNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LeavingNodeCount))
                {
                    builder.Append("  leavingNodeCount: ");
                    builder.AppendLine($"{LeavingNodeCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PreemptedNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  preemptedNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PreemptedNodeCount))
                {
                    builder.Append("  preemptedNodeCount: ");
                    builder.AppendLine($"{PreemptedNodeCount.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningNodeStateCounts>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningNodeStateCounts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningNodeStateCounts)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningNodeStateCounts IPersistableModel<MachineLearningNodeStateCounts>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningNodeStateCounts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningNodeStateCounts(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningNodeStateCounts)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningNodeStateCounts>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
