// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IdpsQueryOrderBy : IUtf8JsonSerializable, IJsonModel<IdpsQueryOrderBy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IdpsQueryOrderBy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IdpsQueryOrderBy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsQueryOrderBy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Field != null)
            {
                writer.WritePropertyName("field"u8);
                writer.WriteStringValue(Field);
            }
            if (Order.HasValue)
            {
                writer.WritePropertyName("order"u8);
                writer.WriteStringValue(Order.Value.ToString());
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

        IdpsQueryOrderBy IJsonModel<IdpsQueryOrderBy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsQueryOrderBy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIdpsQueryOrderBy(document.RootElement, options);
        }

        internal static IdpsQueryOrderBy DeserializeIdpsQueryOrderBy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string field = default;
            FirewallPolicyIdpsQuerySortOrder? order = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = new FirewallPolicyIdpsQuerySortOrder(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IdpsQueryOrderBy(field, order, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IdpsQueryOrderBy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IdpsQueryOrderBy)} does not support '{options.Format}' format.");
            }
        }

        IdpsQueryOrderBy IPersistableModel<IdpsQueryOrderBy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIdpsQueryOrderBy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IdpsQueryOrderBy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IdpsQueryOrderBy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
