// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownAutoMLVertical))]
    public partial class AutoMLVertical : IUtf8JsonSerializable, IJsonModel<AutoMLVertical>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoMLVertical>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoMLVertical>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVertical>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoMLVertical)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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

        AutoMLVertical IJsonModel<AutoMLVertical>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVertical>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoMLVertical)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoMLVertical(document.RootElement, options);
        }

        internal static AutoMLVertical DeserializeAutoMLVertical(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("taskType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Classification": return ClassificationTask.DeserializeClassificationTask(element, options);
                    case "Forecasting": return MachineLearningForecasting.DeserializeMachineLearningForecasting(element, options);
                    case "ImageClassification": return ImageClassification.DeserializeImageClassification(element, options);
                    case "ImageClassificationMultilabel": return ImageClassificationMultilabel.DeserializeImageClassificationMultilabel(element, options);
                    case "ImageInstanceSegmentation": return ImageInstanceSegmentation.DeserializeImageInstanceSegmentation(element, options);
                    case "ImageObjectDetection": return ImageObjectDetection.DeserializeImageObjectDetection(element, options);
                    case "Regression": return AutoMLVerticalRegression.DeserializeAutoMLVerticalRegression(element, options);
                    case "TextClassification": return TextClassification.DeserializeTextClassification(element, options);
                    case "TextClassificationMultilabel": return TextClassificationMultilabel.DeserializeTextClassificationMultilabel(element, options);
                    case "TextNER": return TextNer.DeserializeTextNer(element, options);
                }
            }
            return UnknownAutoMLVertical.DeserializeUnknownAutoMLVertical(element, options);
        }

        BinaryData IPersistableModel<AutoMLVertical>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVertical>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoMLVertical)} does not support '{options.Format}' format.");
            }
        }

        AutoMLVertical IPersistableModel<AutoMLVertical>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVertical>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoMLVertical(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoMLVertical)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoMLVertical>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
