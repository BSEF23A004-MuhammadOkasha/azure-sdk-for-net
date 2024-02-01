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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class TransferConfiguration : IUtf8JsonSerializable, IJsonModel<TransferConfiguration>, IPersistableModel<TransferConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransferConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("transferConfigurationType"u8);
            writer.WriteStringValue(TransferConfigurationType.ToSerialString());
            if (Optional.IsDefined(TransferFilterDetails))
            {
                writer.WritePropertyName("transferFilterDetails"u8);
                writer.WriteObjectValue(TransferFilterDetails);
            }
            if (Optional.IsDefined(TransferAllDetails))
            {
                writer.WritePropertyName("transferAllDetails"u8);
                writer.WriteObjectValue(TransferAllDetails);
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

        TransferConfiguration IJsonModel<TransferConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferConfiguration(document.RootElement, options);
        }

        internal static TransferConfiguration DeserializeTransferConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransferConfigurationType transferConfigurationType = default;
            Optional<TransferConfigurationTransferFilterDetails> transferFilterDetails = default;
            Optional<TransferConfigurationTransferAllDetails> transferAllDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transferConfigurationType"u8))
                {
                    transferConfigurationType = property.Value.GetString().ToTransferConfigurationType();
                    continue;
                }
                if (property.NameEquals("transferFilterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferFilterDetails = TransferConfigurationTransferFilterDetails.DeserializeTransferConfigurationTransferFilterDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("transferAllDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferAllDetails = TransferConfigurationTransferAllDetails.DeserializeTransferConfigurationTransferAllDetails(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransferConfiguration(transferConfigurationType, transferFilterDetails.Value, transferAllDetails.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TransferConfigurationType))
            {
                builder.Append("  transferConfigurationType:");
                builder.AppendLine($" '{TransferConfigurationType.ToString()}'");
            }

            if (Optional.IsDefined(TransferFilterDetails))
            {
                builder.Append("  transferFilterDetails:");
                AppendChildObject(builder, TransferFilterDetails, options, 2);
            }

            if (Optional.IsDefined(TransferAllDetails))
            {
                builder.Append("  transferAllDetails:");
                AppendChildObject(builder, TransferAllDetails, options, 2);
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

        BinaryData IPersistableModel<TransferConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TransferConfiguration)} does not support '{options.Format}' format.");
            }
        }

        TransferConfiguration IPersistableModel<TransferConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransferConfiguration(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(TransferConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransferConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
