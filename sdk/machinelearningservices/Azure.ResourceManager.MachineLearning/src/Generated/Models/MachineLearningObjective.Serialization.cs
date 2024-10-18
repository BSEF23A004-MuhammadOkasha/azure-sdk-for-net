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
    public partial class MachineLearningObjective : IUtf8JsonSerializable, IJsonModel<MachineLearningObjective>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningObjective>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningObjective>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningObjective>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningObjective)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("primaryMetric"u8);
            writer.WriteStringValue(PrimaryMetric);
            writer.WritePropertyName("goal"u8);
            writer.WriteStringValue(Goal.ToString());
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

        MachineLearningObjective IJsonModel<MachineLearningObjective>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningObjective>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningObjective)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningObjective(document.RootElement, options);
        }

        internal static MachineLearningObjective DeserializeMachineLearningObjective(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryMetric = default;
            MachineLearningGoal goal = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    primaryMetric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("goal"u8))
                {
                    goal = new MachineLearningGoal(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningObjective(primaryMetric, goal, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryMetric), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryMetric: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryMetric))
                {
                    builder.Append("  primaryMetric: ");
                    if (PrimaryMetric.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrimaryMetric}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrimaryMetric}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Goal), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  goal: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  goal: ");
                builder.AppendLine($"'{Goal.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningObjective>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningObjective>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningObjective)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningObjective IPersistableModel<MachineLearningObjective>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningObjective>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningObjective(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningObjective)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningObjective>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
