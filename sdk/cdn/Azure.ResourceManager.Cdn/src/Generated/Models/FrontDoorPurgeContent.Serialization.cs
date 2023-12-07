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
    public partial class FrontDoorPurgeContent : IUtf8JsonSerializable, IJsonModel<FrontDoorPurgeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorPurgeContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorPurgeContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorPurgeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FrontDoorPurgeContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("contentPaths"u8);
            writer.WriteStartArray();
            foreach (var item in ContentPaths)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Domains))
            {
                writer.WritePropertyName("domains"u8);
                writer.WriteStartArray();
                foreach (var item in Domains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        FrontDoorPurgeContent IJsonModel<FrontDoorPurgeContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorPurgeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FrontDoorPurgeContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorPurgeContent(document.RootElement, options);
        }

        internal static FrontDoorPurgeContent DeserializeFrontDoorPurgeContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> contentPaths = default;
            Optional<IList<string>> domains = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentPaths"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contentPaths = array;
                    continue;
                }
                if (property.NameEquals("domains"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    domains = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FrontDoorPurgeContent(contentPaths, Optional.ToList(domains), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorPurgeContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorPurgeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(FrontDoorPurgeContent)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorPurgeContent IPersistableModel<FrontDoorPurgeContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorPurgeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorPurgeContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(FrontDoorPurgeContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorPurgeContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
