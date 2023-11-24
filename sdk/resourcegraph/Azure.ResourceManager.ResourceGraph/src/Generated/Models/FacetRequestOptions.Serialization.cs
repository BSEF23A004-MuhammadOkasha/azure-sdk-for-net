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

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class FacetRequestOptions : IUtf8JsonSerializable, IJsonModel<FacetRequestOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FacetRequestOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FacetRequestOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetRequestOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FacetRequestOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SortBy))
            {
                writer.WritePropertyName("sortBy"u8);
                writer.WriteStringValue(SortBy);
            }
            if (Optional.IsDefined(SortOrder))
            {
                writer.WritePropertyName("sortOrder"u8);
                writer.WriteStringValue(SortOrder.Value.ToSerialString());
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("$top"u8);
                writer.WriteNumberValue(Top.Value);
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

        FacetRequestOptions IJsonModel<FacetRequestOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetRequestOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FacetRequestOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFacetRequestOptions(document.RootElement, options);
        }

        internal static FacetRequestOptions DeserializeFacetRequestOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sortBy = default;
            Optional<FacetSortOrder> sortOrder = default;
            Optional<string> filter = default;
            Optional<int> top = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sortBy"u8))
                {
                    sortBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sortOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sortOrder = property.Value.GetString().ToFacetSortOrder();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("$top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FacetRequestOptions(sortBy.Value, Optional.ToNullable(sortOrder), filter.Value, Optional.ToNullable(top), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FacetRequestOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetRequestOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(FacetRequestOptions)} does not support '{options.Format}' format.");
            }
        }

        FacetRequestOptions IPersistableModel<FacetRequestOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacetRequestOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFacetRequestOptions(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(FacetRequestOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FacetRequestOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
