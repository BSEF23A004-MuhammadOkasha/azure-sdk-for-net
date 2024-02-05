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
    public partial class ConflictResolutionPolicy : IUtf8JsonSerializable, IJsonModel<ConflictResolutionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConflictResolutionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConflictResolutionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConflictResolutionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConflictResolutionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(ConflictResolutionPath))
            {
                writer.WritePropertyName("conflictResolutionPath"u8);
                writer.WriteStringValue(ConflictResolutionPath);
            }
            if (Optional.IsDefined(ConflictResolutionProcedure))
            {
                writer.WritePropertyName("conflictResolutionProcedure"u8);
                writer.WriteStringValue(ConflictResolutionProcedure);
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

        ConflictResolutionPolicy IJsonModel<ConflictResolutionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConflictResolutionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConflictResolutionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConflictResolutionPolicy(document.RootElement, options);
        }

        internal static ConflictResolutionPolicy DeserializeConflictResolutionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ConflictResolutionMode> mode = default;
            Optional<string> conflictResolutionPath = default;
            Optional<string> conflictResolutionProcedure = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new ConflictResolutionMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("conflictResolutionPath"u8))
                {
                    conflictResolutionPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conflictResolutionProcedure"u8))
                {
                    conflictResolutionProcedure = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConflictResolutionPolicy(Optional.ToNullable(mode), conflictResolutionPath.Value, conflictResolutionProcedure.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Mode))
            {
                builder.Append("  mode:");
                builder.AppendLine($" '{Mode.ToString()}'");
            }

            if (Optional.IsDefined(ConflictResolutionPath))
            {
                builder.Append("  conflictResolutionPath:");
                builder.AppendLine($" '{ConflictResolutionPath}'");
            }

            if (Optional.IsDefined(ConflictResolutionProcedure))
            {
                builder.Append("  conflictResolutionProcedure:");
                builder.AppendLine($" '{ConflictResolutionProcedure}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ConflictResolutionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConflictResolutionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConflictResolutionPolicy)} does not support '{options.Format}' format.");
            }
        }

        ConflictResolutionPolicy IPersistableModel<ConflictResolutionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConflictResolutionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConflictResolutionPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConflictResolutionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConflictResolutionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
