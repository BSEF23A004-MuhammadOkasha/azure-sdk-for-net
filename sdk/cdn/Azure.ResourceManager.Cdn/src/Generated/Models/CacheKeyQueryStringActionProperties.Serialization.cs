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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CacheKeyQueryStringActionProperties : IUtf8JsonSerializable, IJsonModel<CacheKeyQueryStringActionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CacheKeyQueryStringActionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CacheKeyQueryStringActionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CacheKeyQueryStringActionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("queryStringBehavior"u8);
            writer.WriteStringValue(QueryStringBehavior.ToString());
            if (Optional.IsDefined(QueryParameters))
            {
                if (QueryParameters != null)
                {
                    writer.WritePropertyName("queryParameters"u8);
                    writer.WriteStringValue(QueryParameters);
                }
                else
                {
                    writer.WriteNull("queryParameters");
                }
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

        CacheKeyQueryStringActionProperties IJsonModel<CacheKeyQueryStringActionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CacheKeyQueryStringActionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCacheKeyQueryStringActionProperties(document.RootElement, options);
        }

        internal static CacheKeyQueryStringActionProperties DeserializeCacheKeyQueryStringActionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CacheKeyQueryStringActionType typeName = default;
            QueryStringBehavior queryStringBehavior = default;
            Optional<string> queryParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new CacheKeyQueryStringActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryStringBehavior"u8))
                {
                    queryStringBehavior = new QueryStringBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        queryParameters = null;
                        continue;
                    }
                    queryParameters = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CacheKeyQueryStringActionProperties(typeName, queryStringBehavior, queryParameters.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CacheKeyQueryStringActionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CacheKeyQueryStringActionProperties)} does not support '{options.Format}' format.");
            }
        }

        CacheKeyQueryStringActionProperties IPersistableModel<CacheKeyQueryStringActionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheKeyQueryStringActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCacheKeyQueryStringActionProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CacheKeyQueryStringActionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CacheKeyQueryStringActionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
