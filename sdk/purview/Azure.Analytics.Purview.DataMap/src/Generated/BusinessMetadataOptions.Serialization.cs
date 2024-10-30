// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class BusinessMetadataOptions : IUtf8JsonSerializable, IJsonModel<BusinessMetadataOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BusinessMetadataOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BusinessMetadataOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BusinessMetadataOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BusinessMetadataOptions)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("file"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(global::System.BinaryData.FromStream(File));
#else
            using (JsonDocument document = JsonDocument.Parse(BinaryData.FromStream(File)))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
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
        }

        BusinessMetadataOptions IJsonModel<BusinessMetadataOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BusinessMetadataOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BusinessMetadataOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBusinessMetadataOptions(document.RootElement, options);
        }

        internal static BusinessMetadataOptions DeserializeBusinessMetadataOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Stream file = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file"u8))
                {
                    file = BinaryData.FromString(property.Value.GetRawText()).ToStream();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BusinessMetadataOptions(file, serializedAdditionalRawData);
        }

        private BinaryData SerializeMultipart(ModelReaderWriterOptions options)
        {
            using MultipartFormDataRequestContent content = ToMultipartRequestContent();
            using MemoryStream stream = new MemoryStream();
            content.WriteTo(stream);
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        internal virtual MultipartFormDataRequestContent ToMultipartRequestContent()
        {
            MultipartFormDataRequestContent content = new MultipartFormDataRequestContent();
            content.Add(File, "file", "file", "application/octet-stream");
            return content;
        }

        BinaryData IPersistableModel<BusinessMetadataOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BusinessMetadataOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "MFD":
                    return SerializeMultipart(options);
                default:
                    throw new FormatException($"The model {nameof(BusinessMetadataOptions)} does not support writing '{options.Format}' format.");
            }
        }

        BusinessMetadataOptions IPersistableModel<BusinessMetadataOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BusinessMetadataOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBusinessMetadataOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BusinessMetadataOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BusinessMetadataOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "MFD";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BusinessMetadataOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBusinessMetadataOptions(document.RootElement);
        }
    }
}
