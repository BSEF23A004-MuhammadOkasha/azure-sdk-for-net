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
    public partial class CassandraConnectionError : IUtf8JsonSerializable, IJsonModel<CassandraConnectionError>, IPersistableModel<CassandraConnectionError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraConnectionError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraConnectionError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraConnectionError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraConnectionError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteStringValue(ConnectionState.Value.ToString());
            }
            if (Optional.IsDefined(IPFrom))
            {
                writer.WritePropertyName("iPFrom"u8);
                writer.WriteStringValue(IPFrom);
            }
            if (Optional.IsDefined(IPTo))
            {
                writer.WritePropertyName("iPTo"u8);
                writer.WriteStringValue(IPTo);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Exception))
            {
                writer.WritePropertyName("exception"u8);
                writer.WriteStringValue(Exception);
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

        CassandraConnectionError IJsonModel<CassandraConnectionError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraConnectionError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraConnectionError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraConnectionError(document.RootElement, options);
        }

        internal static CassandraConnectionError DeserializeCassandraConnectionError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CassandraConnectionState> connectionState = default;
            Optional<string> ipFrom = default;
            Optional<string> ipTo = default;
            Optional<int> port = default;
            Optional<string> exception = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new CassandraConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("iPFrom"u8))
                {
                    ipFrom = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iPTo"u8))
                {
                    ipTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exception"u8))
                {
                    exception = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraConnectionError(Optional.ToNullable(connectionState), ipFrom.Value, ipTo.Value, Optional.ToNullable(port), exception.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ConnectionState))
            {
                builder.Append("  connectionState:");
                builder.AppendLine($" '{ConnectionState.ToString()}'");
            }

            if (Optional.IsDefined(IPFrom))
            {
                builder.Append("  iPFrom:");
                builder.AppendLine($" '{IPFrom}'");
            }

            if (Optional.IsDefined(IPTo))
            {
                builder.Append("  iPTo:");
                builder.AppendLine($" '{IPTo}'");
            }

            if (Optional.IsDefined(Port))
            {
                builder.Append("  port:");
                builder.AppendLine($" '{Port.Value.ToString()}'");
            }

            if (Optional.IsDefined(Exception))
            {
                builder.Append("  exception:");
                builder.AppendLine($" '{Exception}'");
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

        BinaryData IPersistableModel<CassandraConnectionError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraConnectionError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CassandraConnectionError)} does not support '{options.Format}' format.");
            }
        }

        CassandraConnectionError IPersistableModel<CassandraConnectionError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraConnectionError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraConnectionError(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CassandraConnectionError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraConnectionError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
