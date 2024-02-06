// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class AttachDetachDataDisksRequest : IUtf8JsonSerializable, IJsonModel<AttachDetachDataDisksRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AttachDetachDataDisksRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AttachDetachDataDisksRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttachDetachDataDisksRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AttachDetachDataDisksRequest)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DataDisksToAttach))
            {
                writer.WritePropertyName("dataDisksToAttach"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisksToAttach)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataDisksToDetach))
            {
                writer.WritePropertyName("dataDisksToDetach"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisksToDetach)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
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

        AttachDetachDataDisksRequest IJsonModel<AttachDetachDataDisksRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttachDetachDataDisksRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AttachDetachDataDisksRequest)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAttachDetachDataDisksRequest(document.RootElement, options);
        }

        internal static AttachDetachDataDisksRequest DeserializeAttachDetachDataDisksRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DataDisksToAttach>> dataDisksToAttach = default;
            Optional<IList<DataDisksToDetach>> dataDisksToDetach = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDisksToAttach"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataDisksToAttach> array = new List<DataDisksToAttach>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataDisksToAttach.DeserializeDataDisksToAttach(item));
                    }
                    dataDisksToAttach = array;
                    continue;
                }
                if (property.NameEquals("dataDisksToDetach"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataDisksToDetach> array = new List<DataDisksToDetach>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataDisksToDetach.DeserializeDataDisksToDetach(item));
                    }
                    dataDisksToDetach = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AttachDetachDataDisksRequest(Optional.ToList(dataDisksToAttach), Optional.ToList(dataDisksToDetach), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AttachDetachDataDisksRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttachDetachDataDisksRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AttachDetachDataDisksRequest)} does not support '{options.Format}' format.");
            }
        }

        AttachDetachDataDisksRequest IPersistableModel<AttachDetachDataDisksRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttachDetachDataDisksRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAttachDetachDataDisksRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AttachDetachDataDisksRequest)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AttachDetachDataDisksRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
