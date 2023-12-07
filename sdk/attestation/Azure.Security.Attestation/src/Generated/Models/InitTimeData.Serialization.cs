// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.Attestation
{
    internal partial class InitTimeData : IUtf8JsonSerializable, IJsonModel<InitTimeData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InitTimeData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InitTimeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitTimeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InitTimeData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteBase64StringValue(Data, "U");
            }
            if (Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType.Value.ToString());
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

        InitTimeData IJsonModel<InitTimeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitTimeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InitTimeData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInitTimeData(document.RootElement, options);
        }

        internal static InitTimeData DeserializeInitTimeData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<byte[]> data = default;
            Optional<DataType> dataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    data = property.Value.GetBytesFromBase64("U");
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataType = new DataType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InitTimeData(data.Value, Optional.ToNullable(dataType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InitTimeData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitTimeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(InitTimeData)} does not support '{options.Format}' format.");
            }
        }

        InitTimeData IPersistableModel<InitTimeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitTimeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInitTimeData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(InitTimeData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InitTimeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
