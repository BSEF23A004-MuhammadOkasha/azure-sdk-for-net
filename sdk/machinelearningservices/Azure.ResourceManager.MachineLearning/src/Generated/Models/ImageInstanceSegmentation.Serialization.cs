// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageInstanceSegmentation : IUtf8JsonSerializable, IJsonModel<ImageInstanceSegmentation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageInstanceSegmentation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageInstanceSegmentation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageInstanceSegmentation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageInstanceSegmentation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(ModelSettings))
            {
                if (ModelSettings != null)
                {
                    writer.WritePropertyName("modelSettings"u8);
                    writer.WriteObjectValue(ModelSettings);
                }
                else
                {
                    writer.WriteNull("modelSettings");
                }
            }
            if (Optional.IsCollectionDefined(SearchSpace))
            {
                if (SearchSpace != null)
                {
                    writer.WritePropertyName("searchSpace"u8);
                    writer.WriteStartArray();
                    foreach (var item in SearchSpace)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("searchSpace");
                }
            }
            writer.WritePropertyName("limitSettings"u8);
            writer.WriteObjectValue(LimitSettings);
            if (Optional.IsDefined(SweepSettings))
            {
                if (SweepSettings != null)
                {
                    writer.WritePropertyName("sweepSettings"u8);
                    writer.WriteObjectValue(SweepSettings);
                }
                else
                {
                    writer.WriteNull("sweepSettings");
                }
            }
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (Optional.IsDefined(ValidationDataSize))
            {
                if (ValidationDataSize != null)
                {
                    writer.WritePropertyName("validationDataSize"u8);
                    writer.WriteNumberValue(ValidationDataSize.Value);
                }
                else
                {
                    writer.WriteNull("validationDataSize");
                }
            }
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            if (Optional.IsDefined(TargetColumnName))
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData);
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

        ImageInstanceSegmentation IJsonModel<ImageInstanceSegmentation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageInstanceSegmentation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageInstanceSegmentation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageInstanceSegmentation(document.RootElement, options);
        }

        internal static ImageInstanceSegmentation DeserializeImageInstanceSegmentation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<InstanceSegmentationPrimaryMetric> primaryMetric = default;
            Optional<ImageModelSettingsObjectDetection> modelSettings = default;
            Optional<IList<ImageModelDistributionSettingsObjectDetection>> searchSpace = default;
            ImageLimitSettings limitSettings = default;
            Optional<ImageSweepSettings> sweepSettings = default;
            Optional<MachineLearningTableJobInput> validationData = default;
            Optional<double?> validationDataSize = default;
            Optional<MachineLearningLogVerbosity> logVerbosity = default;
            Optional<string> targetColumnName = default;
            TaskType taskType = default;
            MachineLearningTableJobInput trainingData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new InstanceSegmentationPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelSettings = null;
                        continue;
                    }
                    modelSettings = ImageModelSettingsObjectDetection.DeserializeImageModelSettingsObjectDetection(property.Value, options);
                    continue;
                }
                if (property.NameEquals("searchSpace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchSpace = null;
                        continue;
                    }
                    List<ImageModelDistributionSettingsObjectDetection> array = new List<ImageModelDistributionSettingsObjectDetection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageModelDistributionSettingsObjectDetection.DeserializeImageModelDistributionSettingsObjectDetection(item, options));
                    }
                    searchSpace = array;
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    limitSettings = ImageLimitSettings.DeserializeImageLimitSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sweepSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sweepSettings = null;
                        continue;
                    }
                    sweepSettings = ImageSweepSettings.DeserializeImageSweepSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationDataSize = null;
                        continue;
                    }
                    validationDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageInstanceSegmentation(Optional.ToNullable(logVerbosity), targetColumnName.Value, taskType, trainingData, serializedAdditionalRawData, Optional.ToNullable(primaryMetric), modelSettings.Value, Optional.ToList(searchSpace), limitSettings, sweepSettings.Value, validationData.Value, Optional.ToNullable(validationDataSize));
        }

        BinaryData IPersistableModel<ImageInstanceSegmentation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageInstanceSegmentation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageInstanceSegmentation)} does not support '{options.Format}' format.");
            }
        }

        ImageInstanceSegmentation IPersistableModel<ImageInstanceSegmentation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageInstanceSegmentation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageInstanceSegmentation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageInstanceSegmentation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageInstanceSegmentation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
