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
    public partial class ParticipantPropertyReference : IUtf8JsonSerializable, IJsonModel<ParticipantPropertyReference>, IPersistableModel<ParticipantPropertyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ParticipantPropertyReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ParticipantPropertyReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParticipantPropertyReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParticipantPropertyReference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourcePropertyName"u8);
            writer.WriteStringValue(SourcePropertyName);
            writer.WritePropertyName("targetPropertyName"u8);
            writer.WriteStringValue(TargetPropertyName);
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

        ParticipantPropertyReference IJsonModel<ParticipantPropertyReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParticipantPropertyReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParticipantPropertyReference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeParticipantPropertyReference(document.RootElement, options);
        }

        internal static ParticipantPropertyReference DeserializeParticipantPropertyReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourcePropertyName = default;
            string targetPropertyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourcePropertyName"u8))
                {
                    sourcePropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPropertyName"u8))
                {
                    targetPropertyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ParticipantPropertyReference(sourcePropertyName, targetPropertyName, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SourcePropertyName))
            {
                builder.Append("  sourcePropertyName:");
                builder.AppendLine($" '{SourcePropertyName}'");
            }

            if (Optional.IsDefined(TargetPropertyName))
            {
                builder.Append("  targetPropertyName:");
                builder.AppendLine($" '{TargetPropertyName}'");
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

        BinaryData IPersistableModel<ParticipantPropertyReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParticipantPropertyReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ParticipantPropertyReference)} does not support '{options.Format}' format.");
            }
        }

        ParticipantPropertyReference IPersistableModel<ParticipantPropertyReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParticipantPropertyReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeParticipantPropertyReference(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ParticipantPropertyReference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ParticipantPropertyReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
