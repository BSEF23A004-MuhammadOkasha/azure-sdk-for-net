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
    public partial class RollbackStatusInfo : IUtf8JsonSerializable, IJsonModel<RollbackStatusInfo>, IPersistableModel<RollbackStatusInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RollbackStatusInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RollbackStatusInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollbackStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollbackStatusInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SuccessfullyRolledbackInstanceCount))
            {
                writer.WritePropertyName("successfullyRolledbackInstanceCount"u8);
                writer.WriteNumberValue(SuccessfullyRolledbackInstanceCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FailedRolledbackInstanceCount))
            {
                writer.WritePropertyName("failedRolledbackInstanceCount"u8);
                writer.WriteNumberValue(FailedRolledbackInstanceCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RollbackError))
            {
                writer.WritePropertyName("rollbackError"u8);
                writer.WriteObjectValue(RollbackError);
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

        RollbackStatusInfo IJsonModel<RollbackStatusInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollbackStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollbackStatusInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRollbackStatusInfo(document.RootElement, options);
        }

        internal static RollbackStatusInfo DeserializeRollbackStatusInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> successfullyRolledbackInstanceCount = default;
            Optional<int> failedRolledbackInstanceCount = default;
            Optional<ComputeApiError> rollbackError = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("successfullyRolledbackInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successfullyRolledbackInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedRolledbackInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedRolledbackInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rollbackError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollbackError = ComputeApiError.DeserializeComputeApiError(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RollbackStatusInfo(Optional.ToNullable(successfullyRolledbackInstanceCount), Optional.ToNullable(failedRolledbackInstanceCount), rollbackError.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SuccessfullyRolledbackInstanceCount))
            {
                builder.Append("  successfullyRolledbackInstanceCount:");
                builder.AppendLine($" '{SuccessfullyRolledbackInstanceCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(FailedRolledbackInstanceCount))
            {
                builder.Append("  failedRolledbackInstanceCount:");
                builder.AppendLine($" '{FailedRolledbackInstanceCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(RollbackError))
            {
                builder.Append("  rollbackError:");
                AppendChildObject(builder, RollbackError, options, 2);
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

        BinaryData IPersistableModel<RollbackStatusInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollbackStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RollbackStatusInfo)} does not support '{options.Format}' format.");
            }
        }

        RollbackStatusInfo IPersistableModel<RollbackStatusInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollbackStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRollbackStatusInfo(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(RollbackStatusInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RollbackStatusInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
