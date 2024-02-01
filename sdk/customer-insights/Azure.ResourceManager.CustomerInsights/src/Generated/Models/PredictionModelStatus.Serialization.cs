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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionModelStatus : IUtf8JsonSerializable, IJsonModel<PredictionModelStatus>, IPersistableModel<PredictionModelStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictionModelStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PredictionModelStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionModelStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionModelStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PredictionName))
            {
                writer.WritePropertyName("predictionName"u8);
                writer.WriteStringValue(PredictionName);
            }
            if (options.Format != "W" && Optional.IsDefined(PredictionGuidId))
            {
                writer.WritePropertyName("predictionGuidId"u8);
                writer.WriteStringValue(PredictionGuidId);
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(TrainingSetCount))
            {
                writer.WritePropertyName("trainingSetCount"u8);
                writer.WriteNumberValue(TrainingSetCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TestSetCount))
            {
                writer.WritePropertyName("testSetCount"u8);
                writer.WriteNumberValue(TestSetCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ValidationSetCount))
            {
                writer.WritePropertyName("validationSetCount"u8);
                writer.WriteNumberValue(ValidationSetCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TrainingAccuracy))
            {
                writer.WritePropertyName("trainingAccuracy"u8);
                writer.WriteNumberValue(TrainingAccuracy.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SignalsUsed))
            {
                writer.WritePropertyName("signalsUsed"u8);
                writer.WriteNumberValue(SignalsUsed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
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

        PredictionModelStatus IJsonModel<PredictionModelStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionModelStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionModelStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionModelStatus(document.RootElement, options);
        }

        internal static PredictionModelStatus DeserializePredictionModelStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> tenantId = default;
            Optional<string> predictionName = default;
            Optional<string> predictionGuidId = default;
            PredictionModelLifeCycle status = default;
            Optional<string> message = default;
            Optional<int> trainingSetCount = default;
            Optional<int> testSetCount = default;
            Optional<int> validationSetCount = default;
            Optional<decimal> trainingAccuracy = default;
            Optional<int> signalsUsed = default;
            Optional<string> modelVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("predictionName"u8))
                {
                    predictionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("predictionGuidId"u8))
                {
                    predictionGuidId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new PredictionModelLifeCycle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trainingSetCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainingSetCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("testSetCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testSetCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationSetCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationSetCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trainingAccuracy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainingAccuracy = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("signalsUsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signalsUsed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PredictionModelStatus(Optional.ToNullable(tenantId), predictionName.Value, predictionGuidId.Value, status, message.Value, Optional.ToNullable(trainingSetCount), Optional.ToNullable(testSetCount), Optional.ToNullable(validationSetCount), Optional.ToNullable(trainingAccuracy), Optional.ToNullable(signalsUsed), modelVersion.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TenantId))
            {
                builder.Append("  tenantId:");
                builder.AppendLine($" '{TenantId.Value.ToString()}'");
            }

            if (Optional.IsDefined(PredictionName))
            {
                builder.Append("  predictionName:");
                builder.AppendLine($" '{PredictionName}'");
            }

            if (Optional.IsDefined(PredictionGuidId))
            {
                builder.Append("  predictionGuidId:");
                builder.AppendLine($" '{PredictionGuidId}'");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsDefined(Message))
            {
                builder.Append("  message:");
                builder.AppendLine($" '{Message}'");
            }

            if (Optional.IsDefined(TrainingSetCount))
            {
                builder.Append("  trainingSetCount:");
                builder.AppendLine($" '{TrainingSetCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(TestSetCount))
            {
                builder.Append("  testSetCount:");
                builder.AppendLine($" '{TestSetCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(ValidationSetCount))
            {
                builder.Append("  validationSetCount:");
                builder.AppendLine($" '{ValidationSetCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(TrainingAccuracy))
            {
                builder.Append("  trainingAccuracy:");
                builder.AppendLine($" '{TrainingAccuracy.Value.ToString()}'");
            }

            if (Optional.IsDefined(SignalsUsed))
            {
                builder.Append("  signalsUsed:");
                builder.AppendLine($" '{SignalsUsed.Value.ToString()}'");
            }

            if (Optional.IsDefined(ModelVersion))
            {
                builder.Append("  modelVersion:");
                builder.AppendLine($" '{ModelVersion}'");
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

        BinaryData IPersistableModel<PredictionModelStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionModelStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PredictionModelStatus)} does not support '{options.Format}' format.");
            }
        }

        PredictionModelStatus IPersistableModel<PredictionModelStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionModelStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictionModelStatus(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PredictionModelStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictionModelStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
