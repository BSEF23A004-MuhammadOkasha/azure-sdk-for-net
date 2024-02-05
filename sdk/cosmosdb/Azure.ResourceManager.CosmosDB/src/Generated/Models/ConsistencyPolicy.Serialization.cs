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
    public partial class ConsistencyPolicy : IUtf8JsonSerializable, IJsonModel<ConsistencyPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsistencyPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsistencyPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsistencyPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("defaultConsistencyLevel"u8);
            writer.WriteStringValue(DefaultConsistencyLevel.ToSerialString());
            if (Optional.IsDefined(MaxStalenessPrefix))
            {
                writer.WritePropertyName("maxStalenessPrefix"u8);
                writer.WriteNumberValue(MaxStalenessPrefix.Value);
            }
            if (Optional.IsDefined(MaxIntervalInSeconds))
            {
                writer.WritePropertyName("maxIntervalInSeconds"u8);
                writer.WriteNumberValue(MaxIntervalInSeconds.Value);
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

        ConsistencyPolicy IJsonModel<ConsistencyPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsistencyPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsistencyPolicy(document.RootElement, options);
        }

        internal static ConsistencyPolicy DeserializeConsistencyPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefaultConsistencyLevel defaultConsistencyLevel = default;
            Optional<long> maxStalenessPrefix = default;
            Optional<int> maxIntervalInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultConsistencyLevel"u8))
                {
                    defaultConsistencyLevel = property.Value.GetString().ToDefaultConsistencyLevel();
                    continue;
                }
                if (property.NameEquals("maxStalenessPrefix"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStalenessPrefix = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxIntervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsistencyPolicy(defaultConsistencyLevel, Optional.ToNullable(maxStalenessPrefix), Optional.ToNullable(maxIntervalInSeconds), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(DefaultConsistencyLevel))
            {
                builder.Append("  defaultConsistencyLevel:");
                builder.AppendLine($" '{DefaultConsistencyLevel.ToString()}'");
            }

            if (Optional.IsDefined(MaxStalenessPrefix))
            {
                builder.Append("  maxStalenessPrefix:");
                builder.AppendLine($" '{MaxStalenessPrefix.Value.ToString()}'");
            }

            if (Optional.IsDefined(MaxIntervalInSeconds))
            {
                builder.Append("  maxIntervalInSeconds:");
                builder.AppendLine($" {MaxIntervalInSeconds.Value}");
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

        BinaryData IPersistableModel<ConsistencyPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConsistencyPolicy)} does not support '{options.Format}' format.");
            }
        }

        ConsistencyPolicy IPersistableModel<ConsistencyPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsistencyPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConsistencyPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsistencyPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
