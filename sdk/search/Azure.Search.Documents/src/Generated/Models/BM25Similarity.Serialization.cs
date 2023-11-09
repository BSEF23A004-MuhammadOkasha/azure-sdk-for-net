// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class BM25Similarity : IUtf8JsonSerializable, IJsonModel<BM25Similarity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BM25Similarity>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BM25Similarity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(K1))
            {
                if (K1 != null)
                {
                    writer.WritePropertyName("k1"u8);
                    writer.WriteNumberValue(K1.Value);
                }
                else
                {
                    writer.WriteNull("k1");
                }
            }
            if (Optional.IsDefined(B))
            {
                if (B != null)
                {
                    writer.WritePropertyName("b"u8);
                    writer.WriteNumberValue(B.Value);
                }
                else
                {
                    writer.WriteNull("b");
                }
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        BM25Similarity IJsonModel<BM25Similarity>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BM25Similarity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBM25Similarity(document.RootElement, options);
        }

        internal static BM25Similarity DeserializeBM25Similarity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double?> k1 = default;
            Optional<double?> b = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("k1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        k1 = null;
                        continue;
                    }
                    k1 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("b"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        b = null;
                        continue;
                    }
                    b = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BM25Similarity(odataType, serializedAdditionalRawData, Optional.ToNullable(k1), Optional.ToNullable(b));
        }

        BinaryData IModel<BM25Similarity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BM25Similarity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BM25Similarity IModel<BM25Similarity>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BM25Similarity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBM25Similarity(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BM25Similarity>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
