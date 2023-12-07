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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class IPPool : IUtf8JsonSerializable, IJsonModel<IPPool>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPPool>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IPPool>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IPPool)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IPPoolType))
            {
                writer.WritePropertyName("ipPoolType"u8);
                writer.WriteStringValue(IPPoolType.Value.ToSerialString());
            }
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteStringValue(Start);
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteStringValue(End);
            }
            if (Optional.IsDefined(Info))
            {
                writer.WritePropertyName("info"u8);
                writer.WriteObjectValue(Info);
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

        IPPool IJsonModel<IPPool>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IPPool)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPPool(document.RootElement, options);
        }

        internal static IPPool DeserializeIPPool(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IPPoolTypeEnum> ipPoolType = default;
            Optional<string> start = default;
            Optional<string> end = default;
            Optional<IPPoolInfo> info = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipPoolType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipPoolType = property.Value.GetString().ToIPPoolTypeEnum();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    info = IPPoolInfo.DeserializeIPPoolInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IPPool(name.Value, Optional.ToNullable(ipPoolType), start.Value, end.Value, info.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IPPool>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPool>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(IPPool)} does not support '{options.Format}' format.");
            }
        }

        IPPool IPersistableModel<IPPool>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPool>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIPPool(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(IPPool)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPPool>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
