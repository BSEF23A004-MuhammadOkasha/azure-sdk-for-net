// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class VmPlacementRequestResult : IUtf8JsonSerializable, IJsonModel<VmPlacementRequestResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmPlacementRequestResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmPlacementRequestResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementRequestResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmPlacementRequestResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(VmSize is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStartArray();
                foreach (var item in VmSize)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsFeasible.HasValue)
            {
                writer.WritePropertyName("isFeasible"u8);
                writer.WriteBooleanValue(IsFeasible.Value);
            }
            if (MessageCode != null)
            {
                writer.WritePropertyName("messageCode"u8);
                writer.WriteStringValue(MessageCode);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        VmPlacementRequestResult IJsonModel<VmPlacementRequestResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementRequestResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmPlacementRequestResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmPlacementRequestResult(document.RootElement, options);
        }

        internal static VmPlacementRequestResult DeserializeVmPlacementRequestResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> vmSize = default;
            bool? isFeasible = default;
            string messageCode = default;
            string message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
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
                    vmSize = array;
                    continue;
                }
                if (property.NameEquals("isFeasible"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isFeasible = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("messageCode"u8))
                {
                    messageCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmPlacementRequestResult(vmSize ?? new ChangeTrackingList<string>(), isFeasible, messageCode, message, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmPlacementRequestResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementRequestResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmPlacementRequestResult)} does not support '{options.Format}' format.");
            }
        }

        VmPlacementRequestResult IPersistableModel<VmPlacementRequestResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementRequestResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmPlacementRequestResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmPlacementRequestResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmPlacementRequestResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
